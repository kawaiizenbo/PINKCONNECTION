using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace PINKCONNECTION_TestApp
{
    public partial class MainForm : Form
    {
        SerialPort port = null;
        private System.Timers.Timer sequenceTimer;
        private static List<byte> movementQueue;
        static byte[] bytesClear = { 27, 91, 48, 72, 27, 91, 48, 74, };
        static string clear = Encoding.UTF8.GetString(bytesClear);
        public MainForm()
        {
            InitializeComponent();
            movementQueue = new List<byte>();
            sequenceTimer = new System.Timers.Timer
            {
                Interval = 1000.0/12.0
            };
            sequenceTimer.Elapsed += Event_sequenceTimer_Tick;
            findSerialPorts();
        }

        private void Event_sequenceTimer_Tick(object sender, EventArgs e)
        {
            if (movementQueue.Count == 0)
            {
                sequenceTimer.Stop();
                return;
            }
            byte movement = movementQueue[0];
            if (movement == 0)
            {
                movementQueue.RemoveAt(0);
                return;
            }
            port.Write(movement.ToString());
            movementQueue.RemoveAt(0);
        }

        private void playSequenceButton_Click(object sender, EventArgs e)
        {
            if (port == null)
            {
                MessageBox.Show("Please select a serial port!");
                return;
            }
            if (fileBrowser.ShowDialog() == DialogResult.Cancel) return;
            if (!File.Exists(fileBrowser.FileName)) return;
            movementQueue = new List<byte>(File.ReadAllBytes(fileBrowser.FileName));
            sequenceTimer.Start();
        }

        private void findSerialPorts()
        {
            serialPortList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                serialPortList.Items.Add(s);
            }
        }

        private void updateSerialPortListButton_Click(object sender, EventArgs e)
        {
            findSerialPorts();
        }

        private void serialPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (port != null) port.Close();
            port = new SerialPort(serialPortList.Text, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            logTextBox.Clear();
        }

        public void WriteToLog(string text)
        {
            logTextBox.AppendText(text.Replace(clear, ""));
        }

        public delegate void WriteToLogDelegate(string text);

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new WriteToLogDelegate(WriteToLog), new object[]{port.ReadExisting()});
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
        }

        private void movementsPerSecondSelector_ValueChanged(object sender, EventArgs e)
        {
            sequenceTimer = new System.Timers.Timer
            {
                Interval = 1000.0/(double)movementsPerSecondSelector.Value
            };
            sequenceTimer.Elapsed += Event_sequenceTimer_Tick;
        }

        private void channelButton_Click(object sender, EventArgs e)
        {
            if (port == null)
            {
                MessageBox.Show("Please select a serial port!");
                return;
            }
            port.Write(((Button)sender).Text.Split(' ')[1]);
        }
    }
}
