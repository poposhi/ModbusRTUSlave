namespace ModbusRTUSlave
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlCOMStatus = new System.Windows.Forms.Panel();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.btCloseCOM = new System.Windows.Forms.Button();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.btOpenCOM = new System.Windows.Forms.Button();
            this.cmbDataBit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labStopBit = new System.Windows.Forms.Label();
            this.labParity = new System.Windows.Forms.Label();
            this.labBaud = new System.Windows.Forms.Label();
            this.labDataBit = new System.Windows.Forms.Label();
            this.labPort = new System.Windows.Forms.Label();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.txtAI4 = new System.Windows.Forms.TextBox();
            this.txtAI3 = new System.Windows.Forms.TextBox();
            this.txtAI2 = new System.Windows.Forms.TextBox();
            this.txtAI1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAO4 = new System.Windows.Forms.TextBox();
            this.txtAO3 = new System.Windows.Forms.TextBox();
            this.txtAO2 = new System.Windows.Forms.TextBox();
            this.txtAO1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDI4 = new System.Windows.Forms.CheckBox();
            this.chkDI3 = new System.Windows.Forms.CheckBox();
            this.chkDI2 = new System.Windows.Forms.CheckBox();
            this.chkDI1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDO4 = new System.Windows.Forms.CheckBox();
            this.chkDO3 = new System.Windows.Forms.CheckBox();
            this.chkDO2 = new System.Windows.Forms.CheckBox();
            this.chkDO1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlCOMStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 522);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlCOMStatus);
            this.tabPage1.Controls.Add(this.txtAI4);
            this.tabPage1.Controls.Add(this.txtAI3);
            this.tabPage1.Controls.Add(this.txtAI2);
            this.tabPage1.Controls.Add(this.txtAI1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtAO4);
            this.tabPage1.Controls.Add(this.txtAO3);
            this.tabPage1.Controls.Add(this.txtAO2);
            this.tabPage1.Controls.Add(this.txtAO1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.chkDI4);
            this.tabPage2.Controls.Add(this.chkDI3);
            this.tabPage2.Controls.Add(this.chkDI2);
            this.tabPage2.Controls.Add(this.chkDI1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chkDO4);
            this.tabPage2.Controls.Add(this.chkDO3);
            this.tabPage2.Controls.Add(this.chkDO2);
            this.tabPage2.Controls.Add(this.chkDO1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlCOMStatus
            // 
            this.pnlCOMStatus.Controls.Add(this.cmbStopBit);
            this.pnlCOMStatus.Controls.Add(this.btCloseCOM);
            this.pnlCOMStatus.Controls.Add(this.cmbParity);
            this.pnlCOMStatus.Controls.Add(this.btOpenCOM);
            this.pnlCOMStatus.Controls.Add(this.cmbDataBit);
            this.pnlCOMStatus.Controls.Add(this.label7);
            this.pnlCOMStatus.Controls.Add(this.labStopBit);
            this.pnlCOMStatus.Controls.Add(this.labParity);
            this.pnlCOMStatus.Controls.Add(this.labBaud);
            this.pnlCOMStatus.Controls.Add(this.labDataBit);
            this.pnlCOMStatus.Controls.Add(this.labPort);
            this.pnlCOMStatus.Controls.Add(this.cmbBaud);
            this.pnlCOMStatus.Controls.Add(this.cmbPort);
            this.pnlCOMStatus.Location = new System.Drawing.Point(27, 78);
            this.pnlCOMStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCOMStatus.Name = "pnlCOMStatus";
            this.pnlCOMStatus.Size = new System.Drawing.Size(541, 109);
            this.pnlCOMStatus.TabIndex = 56;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbStopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBit.Location = new System.Drawing.Point(452, 44);
            this.cmbStopBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(73, 24);
            this.cmbStopBit.TabIndex = 32;
            // 
            // btCloseCOM
            // 
            this.btCloseCOM.Enabled = false;
            this.btCloseCOM.Font = new System.Drawing.Font("Arial", 8F);
            this.btCloseCOM.Location = new System.Drawing.Point(423, 76);
            this.btCloseCOM.Margin = new System.Windows.Forms.Padding(4);
            this.btCloseCOM.Name = "btCloseCOM";
            this.btCloseCOM.Size = new System.Drawing.Size(104, 29);
            this.btCloseCOM.TabIndex = 45;
            this.btCloseCOM.Text = "Close";
            this.btCloseCOM.Click += new System.EventHandler(this.btCloseCOM_Click_1);
            // 
            // cmbParity
            // 
            this.cmbParity.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbParity.Items.AddRange(new object[] {
            "0-None Parity",
            "1-Odd Parity",
            "2-Even Parity"});
            this.cmbParity.Location = new System.Drawing.Point(301, 44);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(132, 24);
            this.cmbParity.TabIndex = 31;
            // 
            // btOpenCOM
            // 
            this.btOpenCOM.Font = new System.Drawing.Font("Arial", 8F);
            this.btOpenCOM.Location = new System.Drawing.Point(301, 76);
            this.btOpenCOM.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenCOM.Name = "btOpenCOM";
            this.btOpenCOM.Size = new System.Drawing.Size(104, 29);
            this.btOpenCOM.TabIndex = 38;
            this.btOpenCOM.Text = "Open";
            this.btOpenCOM.Click += new System.EventHandler(this.btOpenCOM_Click_1);
            // 
            // cmbDataBit
            // 
            this.cmbDataBit.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBit.Location = new System.Drawing.Point(227, 44);
            this.cmbDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDataBit.Name = "cmbDataBit";
            this.cmbDataBit.Size = new System.Drawing.Size(63, 24);
            this.cmbDataBit.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Connection Status";
            // 
            // labStopBit
            // 
            this.labStopBit.Font = new System.Drawing.Font("Arial", 8F);
            this.labStopBit.Location = new System.Drawing.Point(452, 25);
            this.labStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStopBit.Name = "labStopBit";
            this.labStopBit.Size = new System.Drawing.Size(75, 19);
            this.labStopBit.TabIndex = 47;
            this.labStopBit.Text = "Stop Bit";
            this.labStopBit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labParity
            // 
            this.labParity.Font = new System.Drawing.Font("Arial", 8F);
            this.labParity.Location = new System.Drawing.Point(304, 25);
            this.labParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labParity.Name = "labParity";
            this.labParity.Size = new System.Drawing.Size(131, 19);
            this.labParity.TabIndex = 48;
            this.labParity.Text = "Parity";
            this.labParity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labBaud
            // 
            this.labBaud.Font = new System.Drawing.Font("Arial", 8F);
            this.labBaud.Location = new System.Drawing.Point(115, 25);
            this.labBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBaud.Name = "labBaud";
            this.labBaud.Size = new System.Drawing.Size(100, 19);
            this.labBaud.TabIndex = 49;
            this.labBaud.Text = "Baudrate";
            this.labBaud.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labDataBit
            // 
            this.labDataBit.Font = new System.Drawing.Font("Arial", 8F);
            this.labDataBit.Location = new System.Drawing.Point(227, 25);
            this.labDataBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDataBit.Name = "labDataBit";
            this.labDataBit.Size = new System.Drawing.Size(64, 19);
            this.labDataBit.TabIndex = 50;
            this.labDataBit.Text = "Data Bit";
            this.labDataBit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPort
            // 
            this.labPort.Font = new System.Drawing.Font("Arial", 8F);
            this.labPort.Location = new System.Drawing.Point(8, 25);
            this.labPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(100, 19);
            this.labPort.TabIndex = 51;
            this.labPort.Text = "COM Port";
            this.labPort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbBaud
            // 
            this.cmbBaud.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "115200",
            "19200",
            "38400",
            "57600",
            "9600"});
            this.cmbBaud.Location = new System.Drawing.Point(113, 44);
            this.cmbBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(100, 24);
            this.cmbBaud.TabIndex = 29;
            // 
            // cmbPort
            // 
            this.cmbPort.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbPort.Location = new System.Drawing.Point(8, 44);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(99, 24);
            this.cmbPort.TabIndex = 28;
            this.cmbPort.Text = "COM4";
            // 
            // txtAI4
            // 
            this.txtAI4.Location = new System.Drawing.Point(281, 395);
            this.txtAI4.Margin = new System.Windows.Forms.Padding(4);
            this.txtAI4.Name = "txtAI4";
            this.txtAI4.Size = new System.Drawing.Size(129, 25);
            this.txtAI4.TabIndex = 72;
            this.txtAI4.Text = "444";
            // 
            // txtAI3
            // 
            this.txtAI3.Location = new System.Drawing.Point(281, 344);
            this.txtAI3.Margin = new System.Windows.Forms.Padding(4);
            this.txtAI3.Name = "txtAI3";
            this.txtAI3.Size = new System.Drawing.Size(129, 25);
            this.txtAI3.TabIndex = 71;
            this.txtAI3.Text = "333";
            // 
            // txtAI2
            // 
            this.txtAI2.Location = new System.Drawing.Point(281, 293);
            this.txtAI2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAI2.Name = "txtAI2";
            this.txtAI2.Size = new System.Drawing.Size(129, 25);
            this.txtAI2.TabIndex = 70;
            this.txtAI2.Text = "222";
            // 
            // txtAI1
            // 
            this.txtAI1.Location = new System.Drawing.Point(281, 243);
            this.txtAI1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAI1.Name = "txtAI1";
            this.txtAI1.Size = new System.Drawing.Size(129, 25);
            this.txtAI1.TabIndex = 69;
            this.txtAI1.Text = "111";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label5.Location = new System.Drawing.Point(39, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 47);
            this.label5.TabIndex = 73;
            this.label5.Text = "IO Simulation";
            // 
            // txtAO4
            // 
            this.txtAO4.Location = new System.Drawing.Point(437, 395);
            this.txtAO4.Margin = new System.Windows.Forms.Padding(4);
            this.txtAO4.Name = "txtAO4";
            this.txtAO4.Size = new System.Drawing.Size(129, 25);
            this.txtAO4.TabIndex = 68;
            this.txtAO4.Text = "0";
            // 
            // txtAO3
            // 
            this.txtAO3.Location = new System.Drawing.Point(437, 344);
            this.txtAO3.Margin = new System.Windows.Forms.Padding(4);
            this.txtAO3.Name = "txtAO3";
            this.txtAO3.Size = new System.Drawing.Size(129, 25);
            this.txtAO3.TabIndex = 67;
            this.txtAO3.Text = "0";
            // 
            // txtAO2
            // 
            this.txtAO2.Location = new System.Drawing.Point(437, 293);
            this.txtAO2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAO2.Name = "txtAO2";
            this.txtAO2.Size = new System.Drawing.Size(129, 25);
            this.txtAO2.TabIndex = 66;
            this.txtAO2.Text = "0";
            // 
            // txtAO1
            // 
            this.txtAO1.Location = new System.Drawing.Point(437, 243);
            this.txtAO1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAO1.Name = "txtAO1";
            this.txtAO1.Size = new System.Drawing.Size(129, 25);
            this.txtAO1.TabIndex = 65;
            this.txtAO1.Text = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(435, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 74;
            this.label3.Text = "AO Value";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 75;
            this.label4.Text = "AI Value";
            // 
            // chkDI4
            // 
            this.chkDI4.Location = new System.Drawing.Point(141, 392);
            this.chkDI4.Margin = new System.Windows.Forms.Padding(4);
            this.chkDI4.Name = "chkDI4";
            this.chkDI4.Size = new System.Drawing.Size(109, 20);
            this.chkDI4.TabIndex = 85;
            this.chkDI4.Text = "100004";
            // 
            // chkDI3
            // 
            this.chkDI3.Location = new System.Drawing.Point(141, 341);
            this.chkDI3.Margin = new System.Windows.Forms.Padding(4);
            this.chkDI3.Name = "chkDI3";
            this.chkDI3.Size = new System.Drawing.Size(109, 20);
            this.chkDI3.TabIndex = 84;
            this.chkDI3.Text = "100003";
            // 
            // chkDI2
            // 
            this.chkDI2.Location = new System.Drawing.Point(141, 290);
            this.chkDI2.Margin = new System.Windows.Forms.Padding(4);
            this.chkDI2.Name = "chkDI2";
            this.chkDI2.Size = new System.Drawing.Size(109, 20);
            this.chkDI2.TabIndex = 83;
            this.chkDI2.Text = "100002";
            // 
            // chkDI1
            // 
            this.chkDI1.Location = new System.Drawing.Point(138, 239);
            this.chkDI1.Margin = new System.Windows.Forms.Padding(4);
            this.chkDI1.Name = "chkDI1";
            this.chkDI1.Size = new System.Drawing.Size(109, 20);
            this.chkDI1.TabIndex = 82;
            this.chkDI1.Text = "100001";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "DI Value";
            // 
            // chkDO4
            // 
            this.chkDO4.Location = new System.Drawing.Point(24, 392);
            this.chkDO4.Margin = new System.Windows.Forms.Padding(4);
            this.chkDO4.Name = "chkDO4";
            this.chkDO4.Size = new System.Drawing.Size(109, 20);
            this.chkDO4.TabIndex = 81;
            this.chkDO4.Text = "000004";
            // 
            // chkDO3
            // 
            this.chkDO3.Location = new System.Drawing.Point(24, 341);
            this.chkDO3.Margin = new System.Windows.Forms.Padding(4);
            this.chkDO3.Name = "chkDO3";
            this.chkDO3.Size = new System.Drawing.Size(109, 20);
            this.chkDO3.TabIndex = 80;
            this.chkDO3.Text = "000003";
            // 
            // chkDO2
            // 
            this.chkDO2.Location = new System.Drawing.Point(24, 290);
            this.chkDO2.Margin = new System.Windows.Forms.Padding(4);
            this.chkDO2.Name = "chkDO2";
            this.chkDO2.Size = new System.Drawing.Size(109, 20);
            this.chkDO2.TabIndex = 79;
            this.chkDO2.Text = "000002";
            // 
            // chkDO1
            // 
            this.chkDO1.Location = new System.Drawing.Point(21, 239);
            this.chkDO1.Margin = new System.Windows.Forms.Padding(4);
            this.chkDO1.Name = "chkDO1";
            this.chkDO1.Size = new System.Drawing.Size(109, 20);
            this.chkDO1.TabIndex = 78;
            this.chkDO1.Text = "000001";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "DO Value";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(349, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 481);
            this.listView1.TabIndex = 88;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 612);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Modbus_Slave_RTU_Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlCOMStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlCOMStatus;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.Button btCloseCOM;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Button btOpenCOM;
        private System.Windows.Forms.ComboBox cmbDataBit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labStopBit;
        private System.Windows.Forms.Label labParity;
        private System.Windows.Forms.Label labBaud;
        private System.Windows.Forms.Label labDataBit;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TextBox txtAI4;
        private System.Windows.Forms.TextBox txtAI3;
        private System.Windows.Forms.TextBox txtAI2;
        private System.Windows.Forms.TextBox txtAI1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAO4;
        private System.Windows.Forms.TextBox txtAO3;
        private System.Windows.Forms.TextBox txtAO2;
        private System.Windows.Forms.TextBox txtAO1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkDI4;
        private System.Windows.Forms.CheckBox chkDI3;
        private System.Windows.Forms.CheckBox chkDI2;
        private System.Windows.Forms.CheckBox chkDI1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDO4;
        private System.Windows.Forms.CheckBox chkDO3;
        private System.Windows.Forms.CheckBox chkDO2;
        private System.Windows.Forms.CheckBox chkDO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer2;
    }
}

