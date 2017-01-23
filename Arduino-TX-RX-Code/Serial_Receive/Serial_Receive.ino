//+---------------------------------------------------------------------------------------------------+ 
//| Arduino Serial Reception from PC                                                                  |
//+---------------------------------------------------------------------------------------------------+     
//| Receive Characters from PC @9600bps 8N1 data format.                                              |      
//|   *Blink LED on Pin 13 once  if character 'q' is received.                                        |
//|   *Blink LED on Pin 13 Twice if character 'w' is received.                                        |
//|                                                                                                   |
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
  char Data_Received; //used for storing received character
  
  if(Serial.available() > 0) //If there is any data in Serial Buffer of ATmega 
  {
    Data_Received = Serial.read();   // Read the Data

    switch(Data_Received)            // Use a switch to select number of Blinks 
    {
      case 'q': Blink_Pin13_LED(1);  // Blink LED on Pin 13 once  if character 'q' is received
                break;
      case 'w': Blink_Pin13_LED(2);  // Blink LED on Pin 13 Twice if character 'w' is received
                break;
      default:  Blink_Pin13_LED(0);  // No Blinking,LED Off
                break;
    }//end of switch()
   }//end of if
} //end of loop() 

// routine for blinking the LED n times,where n = no of times 

void Blink_Pin13_LED(int Times)
{
  while(Times > 0)
  {
    digitalWrite(LED_Pin,HIGH);
    delay(1000);
    digitalWrite(LED_Pin,LOW);
    delay(1000);
    Times--;
  }
}

