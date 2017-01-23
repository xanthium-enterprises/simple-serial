//+---------------------------------------------------------------------------------------------------+
//| Simple Serial V1.0                                                                                |
//+---------------------------------------------------------------------------------------------------+ 
//| A simple C# program for communicating between your PC and a Microcontroller board like Arduino.   |
//| The Software can be used as a starting point for building your own software/Control program that  | 
//| uses SerialPort.                                                                                  |
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
//|                              USB to Serial Converter  			     Microcontroller              |
//+---------------------------------------------------------------------------------------------------+
//|                                                                                                   |
//| Compiler/IDE     : Visual Studio Community Edition 2015                                           |
//| Libraries        : Dotnet Framework 4.5 (System.IO.Ports)                                         |
//| Operating System : Windows 7,8,10                                                                 |
//| Programmer       : Rahul.Sreedharan                                                               |
//| Date             : 21 January 2017                                                                |
//| Website          : www.xanthium.in                                                                |
//|                                                                                                   |
//+---------------------------------------------------------------------------------------------------+


using System;
using System.Windows.Forms;

using System.IO.Ports;       // used to access the SerialPort Class

namespace Simple_Serial_VS2013
{
    public partial class Form1 : Form
    {
        string Selected_Port_Baudrate;    //used for storing selected Baudrate and COMport,for displaying purposes 
        
        public Form1()
        {
            InitializeComponent();

            //Populate the Combobox with SerialPorts on the System
            ComboBox_Available_SerialPorts.Items.AddRange(SerialPort.GetPortNames());

            //Disable both Transmit and receive functions 
            GroupBox_Serial_Transmit.Enabled = false;
            GroupBox_Serial_Receive.Enabled  = false;

            // Disable Baudrate Selection also
            ComboBox_Standard_Baudrates.Enabled = false; 

            // Displaying System Information 

            string SystemInformation;//Used for Storing System Information 

            SystemInformation  = " Machine Name = " + System.Environment.MachineName;                                         // Get the Machine Name 
            SystemInformation  = SystemInformation + Environment.NewLine + " OS Version = " + System.Environment.OSVersion;    // Get the OS version
            SystemInformation  = SystemInformation + Environment.NewLine + " Processor Cores = " + Environment.ProcessorCount; // Get the Number of Processors on the System

            TextBox_System_Log.Text = SystemInformation; //Display into the Log Text Box
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Will run, when user selects a serialport using Drop Down Menu
        private void ComboBox_Available_SerialPorts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Selected_Port_Baudrate = ComboBox_Available_SerialPorts.SelectedItem.ToString() + " Selected"; // Store the Selected COM port

            TextBox_System_Log.Text = Selected_Port_Baudrate;  // Display the Selected COM port in the Log Text Box                                  

            ComboBox_Standard_Baudrates.Enabled = true;       // Enable Baudrate Selection after COM port is Selected
             
        }

        // Will run, when user selects a baudrate using Drop Down Menu after Serialport is selected
        private void ComboBox_Standard_Baudrates_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Selected_Port_Baudrate = Selected_Port_Baudrate + Environment.NewLine;             
            Selected_Port_Baudrate = Selected_Port_Baudrate + ComboBox_Standard_Baudrates.SelectedItem.ToString() + " bps selected";
            TextBox_System_Log.Text = Selected_Port_Baudrate;  // Display the Selected Baudrate in the Log Text Box 

            //Enable both Transmit and Receive Groupboxes
            GroupBox_Serial_Transmit.Enabled = true;
            GroupBox_Serial_Receive.Enabled  = true;
        }

        private void TextBox_Data_Transmitted_Validated(object sender, EventArgs e)
        {
            //Not used
        }

        private void TextBox_Data_Transmitted_Click(object sender, EventArgs e)
        {
            //Not used
        }

        //Used for sending data to SerialPort
        private void Button_Transmit_Data_Click(object sender, EventArgs e)
        {
            GroupBox_Serial_Receive.Enabled = false; // Disable the Receive Groupbox

            //Local Variables
            string Port_Name = ComboBox_Available_SerialPorts.SelectedItem.ToString();    // Store the selected COM port name to "Port_Name" varaiable
            int    Baud_Rate = Convert.ToInt32(ComboBox_Standard_Baudrates.SelectedItem); // Convert the string "9600" to int32 9600
            string Data      = TextBox_Data_Transmitted.Text;                             //Store the string in Textbox to variable "Data"


            // MessageBox.Show(Port_Name);           // Debugging Purpose
            // MessageBox.Show(Baud_Rate.ToString());

            SerialPort COMport = new SerialPort(Port_Name, Baud_Rate); //Create a new  SerialPort Object (defaullt setting -> 8N1)

            //try to Open SerialPort
            
       
            try
            {
                COMport.Open();
            }
            #region  
            catch (UnauthorizedAccessException SerialException) //exception that is thrown when the operating system denies access 
            {
                MessageBox.Show(SerialException.ToString());
                TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }

            catch (System.IO.IOException SerialException)     // An attempt to set the state of the underlying port failed
            {
                MessageBox.Show(SerialException.ToString());
                TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }

            catch (InvalidOperationException SerialException) // The specified port on the current instance of the SerialPort is already open
            {
                   MessageBox.Show(SerialException.ToString());
                   TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                   TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                   COMport.Close();
            }

            catch //Any other ERROR
            {
                MessageBox.Show("ERROR in Opening Serial PORT -- UnKnown ERROR");
                COMport.Close();
            }
            #endregion

            //If we are able to open the port 
            if (COMport.IsOpen == true)
            {
                //MessageBox.Show("Port Opened");
                COMport.WriteLine(Data);                // Send Data
                COMport.Close();                        // Close the Port
                GroupBox_Serial_Receive.Enabled = true; // Enable the Receive Groupbox

                TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + Data + "  Written to Port";
            }
            else
            {
                GroupBox_Serial_Receive.Enabled = true; // Enable the Receive Groupbox
                MessageBox.Show("Unable to Write to COM port ");
                COMport.Close();
            }
        }

        //Used for Receiving Data from Serial Port
        private void Button_Receive_Data_Click(object sender, EventArgs e)
        {
            GroupBox_Serial_Transmit.Enabled = false; // Disable the Transmit Groupbox
            #region
            //Local Variables
            string Port_Name = ComboBox_Available_SerialPorts.SelectedItem.ToString();      // PortName
            int Baud_Rate = Convert.ToInt32(ComboBox_Standard_Baudrates.SelectedItem);   // BaudRate
            string ReceivedData = ""; //                                                    // String Containing Received Data
           

            SerialPort COMport = new SerialPort(Port_Name, Baud_Rate);
            #endregion
            COMport.ReadTimeout = 3500; //Setting ReadTimeout =3500 ms or 3.5 seconds

            //Open the Serial Port 
            #region
            try
            {
                COMport.Open();
            }
            catch (UnauthorizedAccessException SerialException) //exception that is thrown when the operating system denies access 
            {
                MessageBox.Show(SerialException.ToString());
                TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();                                  // Close the Port
            }

            catch (System.IO.IOException SerialException)     // An attempt to set the state of the underlying port failed
            {
                MessageBox.Show(SerialException.ToString());
                TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();                                  // Close the Port
            }

            catch (InvalidOperationException SerialException) // The specified port on the current instance of the SerialPort is already open
            {
                MessageBox.Show(SerialException.ToString());
                TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();                                  // Close the Port
            }


            catch //Any other ERROR
            {
                MessageBox.Show("ERROR in Opening Serial PORT -- UnKnown ERROR");
                COMport.Close();                                  // Close the Port
            }
            #endregion

            try
            {
                //If we are able to open the port 
                if (COMport.IsOpen == true)
                {
                    //MessageBox.Show("Port Opened");
                    TextBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;

                    ReceivedData = COMport.ReadLine();                // Wait for data reception
                    #region
                    TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + Environment.NewLine + "Waiting for Data";

                    TextBox_received_Data.Text = ReceivedData;

                    COMport.Close();                                  // Close the Port

                    TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + ReceivedData + "  Received from Port";
                    #endregion
                    GroupBox_Serial_Transmit.Enabled = true; // Enable the Transmit Groupbox
                }
                else
                {
                    GroupBox_Serial_Transmit.Enabled = true; // Enable the Transmit Groupbox
                    MessageBox.Show("Unable to Write to COM port ");
                    GroupBox_Serial_Transmit.Enabled = true; // Enable the Transmit Groupbox
                    COMport.Close();                                  // Close the Port
                }
            }

            // Only catch timeout exceptions.
            catch (TimeoutException SerialTimeOutException)
            {
                #region
                // Show in a Message Box 
                MessageBox.Show(COMport.ReadTimeout.ToString() + " milliSeconds Passed" + Environment.NewLine + "Operation Timed Out");
                MessageBox.Show(SerialTimeOutException.ToString());

                //Show in Log TextBox
                TextBox_System_Log.Text = COMport.ReadTimeout.ToString() + " milliSeconds Passed" + Environment.NewLine + "Operation Timed Out";
                TextBox_System_Log.Text = TextBox_System_Log.Text + Environment.NewLine + SerialTimeOutException.ToString();
                #endregion
                COMport.Close();                                  // Close the Port

                GroupBox_Serial_Transmit.Enabled = true; // Enable the Transmit Groupbox
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xanthium.in/");

        }

        private void PictureBox_Facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/xanthium.enterprises");
        }

        private void PictureBox_Twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/InXanthium");
        }

        private void LinkLabel_Tutorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xanthium.in/building-opensource-gui-based-serial-port-communication-program-dot-net-framework-and-arduino");
        }
    } //end of Partial Class Form1
}//end of namespace Simple_Serial_VS2013
