// PINKCONNECTION Client Program for Cyberamics

#include <String.h>

#define CHANNEL_1 2
#define CHANNEL_2 3
#define CHANNEL_3 4
#define CHANNEL_4 5
#define CHANNEL_5 6
#define CHANNEL_6 7
#define CHANNEL_7 8
#define CHANNEL_8 9

int incomingByte = 0;
int pinOffset = 47;

void setup() 
{
  pinMode(CHANNEL_1, OUTPUT);
  pinMode(CHANNEL_2, OUTPUT);
  pinMode(CHANNEL_3, OUTPUT);
  pinMode(CHANNEL_4, OUTPUT);
  pinMode(CHANNEL_5, OUTPUT);
  pinMode(CHANNEL_6, OUTPUT);
  pinMode(CHANNEL_7, OUTPUT);
  pinMode(CHANNEL_8, OUTPUT);
  Serial.begin(9600);
  Serial.write("\033[0H\033[0J");
  Serial.println("PINKCONNECTION Client Init.");
  Serial.println("8 output Cyberamic Controller");
}

void loop() 
{
  if (Serial.available() > 0) 
  {
    incomingByte = Serial.read();

    int pin = incomingByte - pinOffset;
    if (pin < 2 || pin > 9)
    {
      Serial.println("Unknown Input!");
      return;
    }
    digitalWrite(pin, !digitalRead(pin));
    Serial.println("Movement Channel " + String(pin-1) + " " + (digitalRead(pin) ? "On" : "Off"));
  }
}
