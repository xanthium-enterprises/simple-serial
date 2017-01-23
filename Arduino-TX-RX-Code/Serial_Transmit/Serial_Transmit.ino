//+---------------------------------------------------------------------------------------------------+ 
//| Arduino Serial Transmission to PC                                                                 |
//+---------------------------------------------------------------------------------------------------+     
//| Continously transmit the String "Hello from Arduino" @9600bps every 2 Seconds.                    |
//| To be used with Simple Serial Program(C#).                                                        |
//+---------------------------------------------------------------------------------------------------+
//|Hardware Connections(Arduino)                                                                      |
//|                                                                                                   |
//|   +-----------+                                                                                   |
//|   |   PC      |                      +-------------+                                              |
//|   |           |      USB             |             |                                              |
//|   +-----------+ ====================>|   +-------+  \                                             |
//|   \ [] [] [] []\                     |   |       |   |                                            |
//|    \ [] [] [] []\                    |   +-------+   |                                            |
//|     +------------+                   +--------------/                                             |
//|       Windows OS                         Arduino Uno                                              |
//|                                                                                                   |
//|                                                                                                   |
//+---------------------------------------------------------------------------------------------------+
//|Hardware Connections(any other Microcontroller)                                                    |
//|                                                                                                   |
//|  |------------|                                                                                   |
//|  |            |                USB2SERIAL V2.0                     +---------------+              |    
//|  |            |            +--------------------+                  |               |              |
//|  |------------|            |                 RX |<---------------- |(TXD)          |              |
//|   \ [][][][][] \===========|(USB -> Serial)  TX |----------------->|(RXD)          |              |
//|    \------------\   USB    |                GND |------------------| GND           |              |
//|        Laptop              +--------------------+     TTL link     |               |              |
//|                                                                    +---------------+              |                                                                    
//|                              USB to Serial Converter             Microcontroller                  |
//+---------------------------------------------------------------------------------------------------+
//|                                                                                                   |
//| Compiler/IDE     : Arduino IDE                                                                    |
//| Libraries        : Serial                                                                         |
//|                                                                                                   |
//| Programmer       : (c)Rahul.Sreedharan                                                            |
//| Date             : 21 January 2017                                                                |
//| Website          : www.xanthium.in                                                                |
//|                                                                                                   |
//+---------------------------------------------------------------------------------------------------+


int LED_Pin = 13;                 // LED connected to digital pin 13

void setup()
{
 Serial.begin(9600,SERIAL_8N1);  // Configure the baudrate and data format for serial transmission
 pinMode(LED_Pin,OUTPUT);        // Pin13 as Output
 digitalWrite(LED_Pin,LOW);      // Pin13 LED OFF
}

void loop() 
{
  Serial.println("Hello from Arduino"); // Send the String,Use Serial.println() because we have used SerialPort.ReadLine() on C# side
                                        // SerialPort.ReadLine() on C# side will return only after receiving '/n' character
  Blink_LED();                          // Blink LED to indicate transmission
}

//Function to Blink LED 13 
void Blink_LED()
{
  digitalWrite(LED_Pin,HIGH);
  delay(1000);
  digitalWrite(LED_Pin,LOW);
  delay(1000);
}

