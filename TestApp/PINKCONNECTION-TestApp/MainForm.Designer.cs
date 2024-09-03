namespace PINKCONNECTION_TestApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playSequenceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.channel8Button = new System.Windows.Forms.Button();
            this.channel7Button = new System.Windows.Forms.Button();
            this.channel6Button = new System.Windows.Forms.Button();
            this.channel5Button = new System.Windows.Forms.Button();
            this.channel4Button = new System.Windows.Forms.Button();
            this.channel3Button = new System.Windows.Forms.Button();
            this.channel2Button = new System.Windows.Forms.Button();
            this.channel1Button = new System.Windows.Forms.Button();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.movementsPerSecondSelector = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serialPortList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateSerialPortListButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movementsPerSecondSelector)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // playSequenceButton
            // 
            this.playSequenceButton.Location = new System.Drawing.Point(6, 19);
            this.playSequenceButton.Name = "playSequenceButton";
            this.playSequenceButton.Size = new System.Drawing.Size(225, 25);
            this.playSequenceButton.TabIndex = 0;
            this.playSequenceButton.Text = "Play Sequence File";
            this.playSequenceButton.UseVisualStyleBackColor = true;
            this.playSequenceButton.Click += new System.EventHandler(this.playSequenceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.channel8Button);
            this.groupBox1.Controls.Add(this.channel7Button);
            this.groupBox1.Controls.Add(this.channel6Button);
            this.groupBox1.Controls.Add(this.channel5Button);
            this.groupBox1.Controls.Add(this.channel4Button);
            this.groupBox1.Controls.Add(this.channel3Button);
            this.groupBox1.Controls.Add(this.channel2Button);
            this.groupBox1.Controls.Add(this.channel1Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual Control";
            // 
            // channel8Button
            // 
            this.channel8Button.Location = new System.Drawing.Point(344, 48);
            this.channel8Button.Name = "channel8Button";
            this.channel8Button.Size = new System.Drawing.Size(106, 23);
            this.channel8Button.TabIndex = 7;
            this.channel8Button.Text = "Channel 8";
            this.channel8Button.UseVisualStyleBackColor = true;
            this.channel8Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // channel7Button
            // 
            this.channel7Button.Location = new System.Drawing.Point(231, 48);
            this.channel7Button.Name = "channel7Button";
            this.channel7Button.Size = new System.Drawing.Size(107, 23);
            this.channel7Button.TabIndex = 6;
            this.channel7Button.Text = "Channel 7";
            this.channel7Button.UseVisualStyleBackColor = true;
            this.channel7Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // channel6Button
            // 
            this.channel6Button.Location = new System.Drawing.Point(118, 48);
            this.channel6Button.Name = "channel6Button";
            this.channel6Button.Size = new System.Drawing.Size(107, 23);
            this.channel6Button.TabIndex = 5;
            this.channel6Button.Text = "Channel 6";
            this.channel6Button.UseVisualStyleBackColor = true;
            this.channel6Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // channel5Button
            // 
            this.channel5Button.Location = new System.Drawing.Point(6, 48);
            this.channel5Button.Name = "channel5Button";
            this.channel5Button.Size = new System.Drawing.Size(106, 23);
            this.channel5Button.TabIndex = 4;
            this.channel5Button.Text = "Channel 5";
            this.channel5Button.UseVisualStyleBackColor = true;
            this.channel5Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // channel4Button
            // 
            this.channel4Button.Location = new System.Drawing.Point(344, 19);
            this.channel4Button.Name = "channel4Button";
            this.channel4Button.Size = new System.Drawing.Size(106, 23);
            this.channel4Button.TabIndex = 3;
            this.channel4Button.Text = "Channel 4";
            this.channel4Button.UseVisualStyleBackColor = true;
            this.channel4Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // channel3Button
            // 
            this.channel3Button.Location = new System.Drawing.Point(231, 19);
            this.channel3Button.Name = "channel3Button";
            this.channel3Button.Size = new System.Drawing.Size(107, 23);
            this.channel3Button.TabIndex = 2;
            this.channel3Button.Text = "Channel 3";
            this.channel3Button.UseVisualStyleBackColor = true;
            this.channel3Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // channel2Button
            // 
            this.channel2Button.Location = new System.Drawing.Point(118, 19);
            this.channel2Button.Name = "channel2Button";
            this.channel2Button.Size = new System.Drawing.Size(107, 23);
            this.channel2Button.TabIndex = 1;
            this.channel2Button.Text = "Channel 2";
            this.channel2Button.UseVisualStyleBackColor = true;
            this.channel2Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // channel1Button
            // 
            this.channel1Button.Location = new System.Drawing.Point(6, 19);
            this.channel1Button.Name = "channel1Button";
            this.channel1Button.Size = new System.Drawing.Size(106, 23);
            this.channel1Button.TabIndex = 0;
            this.channel1Button.Text = "Channel 1";
            this.channel1Button.UseVisualStyleBackColor = true;
            this.channel1Button.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Filter = "PINKCONNECT Sequences|*.pcs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.Black;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.Lime;
            this.logTextBox.Location = new System.Drawing.Point(6, 19);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(444, 265);
            this.logTextBox.TabIndex = 0;
            // 
            // movementsPerSecondSelector
            // 
            this.movementsPerSecondSelector.Location = new System.Drawing.Point(237, 21);
            this.movementsPerSecondSelector.Name = "movementsPerSecondSelector";
            this.movementsPerSecondSelector.Size = new System.Drawing.Size(87, 20);
            this.movementsPerSecondSelector.TabIndex = 4;
            this.movementsPerSecondSelector.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.movementsPerSecondSelector.ValueChanged += new System.EventHandler(this.movementsPerSecondSelector_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movements per Second";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.playSequenceButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.movementsPerSecondSelector);
            this.groupBox3.Location = new System.Drawing.Point(12, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 50);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automatic Control";
            // 
            // serialPortList
            // 
            this.serialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortList.FormattingEnabled = true;
            this.serialPortList.Location = new System.Drawing.Point(12, 12);
            this.serialPortList.Name = "serialPortList";
            this.serialPortList.Size = new System.Drawing.Size(100, 21);
            this.serialPortList.TabIndex = 7;
            this.serialPortList.SelectedIndexChanged += new System.EventHandler(this.serialPortList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serial Port";
            // 
            // updateSerialPortListButton
            // 
            this.updateSerialPortListButton.Location = new System.Drawing.Point(262, 12);
            this.updateSerialPortListButton.Name = "updateSerialPortListButton";
            this.updateSerialPortListButton.Size = new System.Drawing.Size(100, 21);
            this.updateSerialPortListButton.TabIndex = 9;
            this.updateSerialPortListButton.Text = "Update List";
            this.updateSerialPortListButton.UseVisualStyleBackColor = true;
            this.updateSerialPortListButton.Click += new System.EventHandler(this.updateSerialPortListButton_Click);
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(368, 12);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(100, 21);
            this.clearLogButton.TabIndex = 10;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.updateSerialPortListButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serialPortList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "PINKCONNECTION Test Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movementsPerSecondSelector)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playSequenceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.Button channel1Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown movementsPerSecondSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button channel8Button;
        private System.Windows.Forms.Button channel7Button;
        private System.Windows.Forms.Button channel6Button;
        private System.Windows.Forms.Button channel5Button;
        private System.Windows.Forms.Button channel4Button;
        private System.Windows.Forms.Button channel3Button;
        private System.Windows.Forms.Button channel2Button;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.ComboBox serialPortList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateSerialPortListButton;
        private System.Windows.Forms.Button clearLogButton;
    }
}

