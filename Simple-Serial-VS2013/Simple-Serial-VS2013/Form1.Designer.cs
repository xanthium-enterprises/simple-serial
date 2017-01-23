namespace Simple_Serial_VS2013
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBox_Serial_Settings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Standard_Baudrates = new System.Windows.Forms.ComboBox();
            this.ComboBox_Available_SerialPorts = new System.Windows.Forms.ComboBox();
            this.GroupBox_Serial_Transmit = new System.Windows.Forms.GroupBox();
            this.Button_Transmit_Data = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Data_Transmitted = new System.Windows.Forms.TextBox();
            this.GroupBox_Serial_Receive = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_received_Data = new System.Windows.Forms.TextBox();
            this.Button_Receive_Data = new System.Windows.Forms.Button();
            this.GroupBox_Log = new System.Windows.Forms.GroupBox();
            this.TextBox_System_Log = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PictureBox_Facebook = new System.Windows.Forms.PictureBox();
            this.PictureBox_Twitter = new System.Windows.Forms.PictureBox();
            this.LinkLabel_Tutorial = new System.Windows.Forms.LinkLabel();
            this.GroupBox_Serial_Settings.SuspendLayout();
            this.GroupBox_Serial_Transmit.SuspendLayout();
            this.GroupBox_Serial_Receive.SuspendLayout();
            this.GroupBox_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Twitter)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Serial_Settings
            // 
            this.GroupBox_Serial_Settings.Controls.Add(this.label3);
            this.GroupBox_Serial_Settings.Controls.Add(this.label2);
            this.GroupBox_Serial_Settings.Controls.Add(this.ComboBox_Standard_Baudrates);
            this.GroupBox_Serial_Settings.Controls.Add(this.ComboBox_Available_SerialPorts);
            this.GroupBox_Serial_Settings.Location = new System.Drawing.Point(12, 40);
            this.GroupBox_Serial_Settings.Name = "GroupBox_Serial_Settings";
            this.GroupBox_Serial_Settings.Size = new System.Drawing.Size(446, 82);
            this.GroupBox_Serial_Settings.TabIndex = 0;
            this.GroupBox_Serial_Settings.TabStop = false;
            this.GroupBox_Serial_Settings.Text = "Serial Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Ports";
            // 
            // ComboBox_Standard_Baudrates
            // 
            this.ComboBox_Standard_Baudrates.FormattingEnabled = true;
            this.ComboBox_Standard_Baudrates.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.ComboBox_Standard_Baudrates.Location = new System.Drawing.Point(301, 39);
            this.ComboBox_Standard_Baudrates.Name = "ComboBox_Standard_Baudrates";
            this.ComboBox_Standard_Baudrates.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Standard_Baudrates.TabIndex = 1;
            this.ComboBox_Standard_Baudrates.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Standard_Baudrates_SelectionChangeCommitted);
            // 
            // ComboBox_Available_SerialPorts
            // 
            this.ComboBox_Available_SerialPorts.FormattingEnabled = true;
            this.ComboBox_Available_SerialPorts.Location = new System.Drawing.Point(89, 39);
            this.ComboBox_Available_SerialPorts.Name = "ComboBox_Available_SerialPorts";
            this.ComboBox_Available_SerialPorts.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Available_SerialPorts.Sorted = true;
            this.ComboBox_Available_SerialPorts.TabIndex = 0;
            this.ComboBox_Available_SerialPorts.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Available_SerialPorts_SelectionChangeCommitted);
            // 
            // GroupBox_Serial_Transmit
            // 
            this.GroupBox_Serial_Transmit.Controls.Add(this.Button_Transmit_Data);
            this.GroupBox_Serial_Transmit.Controls.Add(this.label1);
            this.GroupBox_Serial_Transmit.Controls.Add(this.TextBox_Data_Transmitted);
            this.GroupBox_Serial_Transmit.Location = new System.Drawing.Point(12, 138);
            this.GroupBox_Serial_Transmit.Name = "GroupBox_Serial_Transmit";
            this.GroupBox_Serial_Transmit.Size = new System.Drawing.Size(200, 154);
            this.GroupBox_Serial_Transmit.TabIndex = 1;
            this.GroupBox_Serial_Transmit.TabStop = false;
            this.GroupBox_Serial_Transmit.Text = "Serial Transmit";
            // 
            // Button_Transmit_Data
            // 
            this.Button_Transmit_Data.Location = new System.Drawing.Point(22, 69);
            this.Button_Transmit_Data.Name = "Button_Transmit_Data";
            this.Button_Transmit_Data.Size = new System.Drawing.Size(161, 37);
            this.Button_Transmit_Data.TabIndex = 2;
            this.Button_Transmit_Data.Text = "Transmit";
            this.Button_Transmit_Data.UseVisualStyleBackColor = true;
            this.Button_Transmit_Data.Click += new System.EventHandler(this.Button_Transmit_Data_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // TextBox_Data_Transmitted
            // 
            this.TextBox_Data_Transmitted.Location = new System.Drawing.Point(55, 31);
            this.TextBox_Data_Transmitted.Name = "TextBox_Data_Transmitted";
            this.TextBox_Data_Transmitted.Size = new System.Drawing.Size(128, 20);
            this.TextBox_Data_Transmitted.TabIndex = 0;
            this.TextBox_Data_Transmitted.Click += new System.EventHandler(this.TextBox_Data_Transmitted_Click);
            this.TextBox_Data_Transmitted.Validated += new System.EventHandler(this.TextBox_Data_Transmitted_Validated);
            // 
            // GroupBox_Serial_Receive
            // 
            this.GroupBox_Serial_Receive.Controls.Add(this.label4);
            this.GroupBox_Serial_Receive.Controls.Add(this.TextBox_received_Data);
            this.GroupBox_Serial_Receive.Controls.Add(this.Button_Receive_Data);
            this.GroupBox_Serial_Receive.Location = new System.Drawing.Point(251, 138);
            this.GroupBox_Serial_Receive.Name = "GroupBox_Serial_Receive";
            this.GroupBox_Serial_Receive.Size = new System.Drawing.Size(200, 154);
            this.GroupBox_Serial_Receive.TabIndex = 2;
            this.GroupBox_Serial_Receive.TabStop = false;
            this.GroupBox_Serial_Receive.Text = "Serial Receive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Received Data";
            // 
            // TextBox_received_Data
            // 
            this.TextBox_received_Data.Location = new System.Drawing.Point(22, 97);
            this.TextBox_received_Data.Multiline = true;
            this.TextBox_received_Data.Name = "TextBox_received_Data";
            this.TextBox_received_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_received_Data.Size = new System.Drawing.Size(161, 40);
            this.TextBox_received_Data.TabIndex = 1;
            // 
            // Button_Receive_Data
            // 
            this.Button_Receive_Data.Location = new System.Drawing.Point(22, 26);
            this.Button_Receive_Data.Name = "Button_Receive_Data";
            this.Button_Receive_Data.Size = new System.Drawing.Size(161, 37);
            this.Button_Receive_Data.TabIndex = 0;
            this.Button_Receive_Data.Text = "Receive Data";
            this.Button_Receive_Data.UseVisualStyleBackColor = true;
            this.Button_Receive_Data.Click += new System.EventHandler(this.Button_Receive_Data_Click);
            // 
            // GroupBox_Log
            // 
            this.GroupBox_Log.Controls.Add(this.TextBox_System_Log);
            this.GroupBox_Log.Location = new System.Drawing.Point(12, 304);
            this.GroupBox_Log.Name = "GroupBox_Log";
            this.GroupBox_Log.Size = new System.Drawing.Size(439, 169);
            this.GroupBox_Log.TabIndex = 3;
            this.GroupBox_Log.TabStop = false;
            this.GroupBox_Log.Text = "Log";
            // 
            // TextBox_System_Log
            // 
            this.TextBox_System_Log.Location = new System.Drawing.Point(9, 23);
            this.TextBox_System_Log.Multiline = true;
            this.TextBox_System_Log.Name = "TextBox_System_Log";
            this.TextBox_System_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_System_Log.Size = new System.Drawing.Size(413, 129);
            this.TextBox_System_Log.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.xanthium.in ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PictureBox_Facebook
            // 
            this.PictureBox_Facebook.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Facebook.Image")));
            this.PictureBox_Facebook.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Facebook.InitialImage")));
            this.PictureBox_Facebook.Location = new System.Drawing.Point(372, 7);
            this.PictureBox_Facebook.Name = "PictureBox_Facebook";
            this.PictureBox_Facebook.Size = new System.Drawing.Size(42, 38);
            this.PictureBox_Facebook.TabIndex = 5;
            this.PictureBox_Facebook.TabStop = false;
            this.PictureBox_Facebook.Click += new System.EventHandler(this.PictureBox_Facebook_Click);
            // 
            // PictureBox_Twitter
            // 
            this.PictureBox_Twitter.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Twitter.Image")));
            this.PictureBox_Twitter.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Twitter.InitialImage")));
            this.PictureBox_Twitter.Location = new System.Drawing.Point(416, 7);
            this.PictureBox_Twitter.Name = "PictureBox_Twitter";
            this.PictureBox_Twitter.Size = new System.Drawing.Size(42, 38);
            this.PictureBox_Twitter.TabIndex = 6;
            this.PictureBox_Twitter.TabStop = false;
            this.PictureBox_Twitter.Click += new System.EventHandler(this.PictureBox_Twitter_Click);
            // 
            // LinkLabel_Tutorial
            // 
            this.LinkLabel_Tutorial.AutoSize = true;
            this.LinkLabel_Tutorial.Location = new System.Drawing.Point(114, 9);
            this.LinkLabel_Tutorial.Name = "LinkLabel_Tutorial";
            this.LinkLabel_Tutorial.Size = new System.Drawing.Size(42, 13);
            this.LinkLabel_Tutorial.TabIndex = 7;
            this.LinkLabel_Tutorial.TabStop = true;
            this.LinkLabel_Tutorial.Text = "Tutorial";
            this.LinkLabel_Tutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Tutorial_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 485);
            this.Controls.Add(this.LinkLabel_Tutorial);
            this.Controls.Add(this.PictureBox_Twitter);
            this.Controls.Add(this.PictureBox_Facebook);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.GroupBox_Log);
            this.Controls.Add(this.GroupBox_Serial_Receive);
            this.Controls.Add(this.GroupBox_Serial_Transmit);
            this.Controls.Add(this.GroupBox_Serial_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Serial [C#]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Serial_Settings.ResumeLayout(false);
            this.GroupBox_Serial_Settings.PerformLayout();
            this.GroupBox_Serial_Transmit.ResumeLayout(false);
            this.GroupBox_Serial_Transmit.PerformLayout();
            this.GroupBox_Serial_Receive.ResumeLayout(false);
            this.GroupBox_Serial_Receive.PerformLayout();
            this.GroupBox_Log.ResumeLayout(false);
            this.GroupBox_Log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Twitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Serial_Settings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Standard_Baudrates;
        private System.Windows.Forms.ComboBox ComboBox_Available_SerialPorts;
        private System.Windows.Forms.GroupBox GroupBox_Serial_Transmit;
        private System.Windows.Forms.Button Button_Transmit_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Data_Transmitted;
        private System.Windows.Forms.GroupBox GroupBox_Serial_Receive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_received_Data;
        private System.Windows.Forms.Button Button_Receive_Data;
        private System.Windows.Forms.GroupBox GroupBox_Log;
        private System.Windows.Forms.TextBox TextBox_System_Log;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox PictureBox_Facebook;
        private System.Windows.Forms.PictureBox PictureBox_Twitter;
        private System.Windows.Forms.LinkLabel LinkLabel_Tutorial;
    }
}

