﻿namespace ModbusRTUSlave
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
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.lb_test_write = new System.Windows.Forms.Label();
            this.lbisland = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_reduce_f = new System.Windows.Forms.Button();
            this.bt_reduce_v = new System.Windows.Forms.Button();
            this.bt_fine_f = new System.Windows.Forms.Button();
            this.bt_fine_v = new System.Windows.Forms.Button();
            this.textBox_fine = new System.Windows.Forms.TextBox();
            this.lb_q = new System.Windows.Forms.Label();
            this.lb_p = new System.Windows.Forms.Label();
            this.lb_f = new System.Windows.Forms.Label();
            this.lb_v = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlCOMStatus.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 587);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox11);
            this.tabPage1.Controls.Add(this.checkBox10);
            this.tabPage1.Controls.Add(this.checkBox9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lv);
            this.tabPage1.Controls.Add(this.lb_test_write);
            this.tabPage1.Controls.Add(this.lbisland);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.checkBox7);
            this.tabPage1.Controls.Add(this.checkBox8);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.bt_reduce_f);
            this.tabPage1.Controls.Add(this.bt_reduce_v);
            this.tabPage1.Controls.Add(this.bt_fine_f);
            this.tabPage1.Controls.Add(this.bt_fine_v);
            this.tabPage1.Controls.Add(this.textBox_fine);
            this.tabPage1.Controls.Add(this.lb_q);
            this.tabPage1.Controls.Add(this.lb_p);
            this.tabPage1.Controls.Add(this.lb_f);
            this.tabPage1.Controls.Add(this.lb_v);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
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
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(637, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(524, 373);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(62, 19);
            this.checkBox11.TabIndex = 104;
            this.checkBox11.Text = "3-b14";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(515, 350);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(62, 19);
            this.checkBox10.TabIndex = 103;
            this.checkBox10.Text = "3-b10";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(480, 327);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(62, 19);
            this.checkBox9.TabIndex = 102;
            this.checkBox9.Text = "2-b12";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 14F);
            this.label3.Location = new System.Drawing.Point(400, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 101;
            this.label3.Text = "告警";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8F);
            this.button1.Location = new System.Drawing.Point(404, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 100;
            this.button1.Text = "清除螢幕";
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lv
            // 
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(7, 393);
            this.lv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(604, 154);
            this.lv.TabIndex = 99;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // lb_test_write
            // 
            this.lb_test_write.Font = new System.Drawing.Font("新細明體", 14F);
            this.lb_test_write.Location = new System.Drawing.Point(510, 294);
            this.lb_test_write.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_test_write.Name = "lb_test_write";
            this.lb_test_write.Size = new System.Drawing.Size(124, 22);
            this.lb_test_write.TabIndex = 98;
            this.lb_test_write.Text = "測試寫入";
            // 
            // lbisland
            // 
            this.lbisland.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbisland.Location = new System.Drawing.Point(274, 223);
            this.lbisland.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbisland.Name = "lbisland";
            this.lbisland.Size = new System.Drawing.Size(124, 22);
            this.lbisland.TabIndex = 97;
            this.lbisland.Text = "孤島模式 ";
            this.lbisland.Click += new System.EventHandler(this.lbisland_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(457, 298);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(43, 19);
            this.checkBox5.TabIndex = 96;
            this.checkBox5.Text = "b7";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(457, 273);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(43, 19);
            this.checkBox6.TabIndex = 95;
            this.checkBox6.Text = "b6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(457, 248);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(43, 19);
            this.checkBox7.TabIndex = 94;
            this.checkBox7.Text = "b5";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(457, 223);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(43, 19);
            this.checkBox8.TabIndex = 93;
            this.checkBox8.Text = "b4";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(408, 298);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(43, 19);
            this.checkBox4.TabIndex = 92;
            this.checkBox4.Text = "b3";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(408, 273);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(43, 19);
            this.checkBox3.TabIndex = 91;
            this.checkBox3.Text = "b2";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(408, 248);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(43, 19);
            this.checkBox2.TabIndex = 90;
            this.checkBox2.Text = "b1";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(408, 223);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(43, 19);
            this.checkBox1.TabIndex = 89;
            this.checkBox1.Text = "b0";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bt_reduce_f
            // 
            this.bt_reduce_f.Font = new System.Drawing.Font("Arial", 8F);
            this.bt_reduce_f.Location = new System.Drawing.Point(325, 357);
            this.bt_reduce_f.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_reduce_f.Name = "bt_reduce_f";
            this.bt_reduce_f.Size = new System.Drawing.Size(72, 28);
            this.bt_reduce_f.TabIndex = 88;
            this.bt_reduce_f.Text = "調整f-";
            this.bt_reduce_f.Click += new System.EventHandler(this.bt_reduce_f_Click);
            // 
            // bt_reduce_v
            // 
            this.bt_reduce_v.Font = new System.Drawing.Font("Arial", 8F);
            this.bt_reduce_v.Location = new System.Drawing.Point(165, 357);
            this.bt_reduce_v.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_reduce_v.Name = "bt_reduce_v";
            this.bt_reduce_v.Size = new System.Drawing.Size(72, 28);
            this.bt_reduce_v.TabIndex = 87;
            this.bt_reduce_v.Text = "調整v-";
            this.bt_reduce_v.Click += new System.EventHandler(this.bt_reduce_v_Click);
            // 
            // bt_fine_f
            // 
            this.bt_fine_f.Font = new System.Drawing.Font("Arial", 8F);
            this.bt_fine_f.Location = new System.Drawing.Point(245, 357);
            this.bt_fine_f.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_fine_f.Name = "bt_fine_f";
            this.bt_fine_f.Size = new System.Drawing.Size(72, 28);
            this.bt_fine_f.TabIndex = 85;
            this.bt_fine_f.Text = "調整f+";
            this.bt_fine_f.Click += new System.EventHandler(this.bt_fine_f_Click);
            // 
            // bt_fine_v
            // 
            this.bt_fine_v.Font = new System.Drawing.Font("Arial", 8F);
            this.bt_fine_v.Location = new System.Drawing.Point(91, 357);
            this.bt_fine_v.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_fine_v.Name = "bt_fine_v";
            this.bt_fine_v.Size = new System.Drawing.Size(72, 28);
            this.bt_fine_v.TabIndex = 84;
            this.bt_fine_v.Text = "調整v+";
            this.bt_fine_v.Click += new System.EventHandler(this.bt_fine_v_Click);
            // 
            // textBox_fine
            // 
            this.textBox_fine.Location = new System.Drawing.Point(16, 357);
            this.textBox_fine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_fine.Name = "textBox_fine";
            this.textBox_fine.Size = new System.Drawing.Size(65, 25);
            this.textBox_fine.TabIndex = 83;
            this.textBox_fine.Text = "改變值";
            // 
            // lb_q
            // 
            this.lb_q.Font = new System.Drawing.Font("新細明體", 14F);
            this.lb_q.Location = new System.Drawing.Point(94, 315);
            this.lb_q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_q.Name = "lb_q";
            this.lb_q.Size = new System.Drawing.Size(96, 22);
            this.lb_q.TabIndex = 82;
            this.lb_q.Text = "var";
            // 
            // lb_p
            // 
            this.lb_p.Font = new System.Drawing.Font("新細明體", 14F);
            this.lb_p.Location = new System.Drawing.Point(94, 267);
            this.lb_p.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_p.Name = "lb_p";
            this.lb_p.Size = new System.Drawing.Size(96, 22);
            this.lb_p.TabIndex = 81;
            this.lb_p.Text = "p";
            // 
            // lb_f
            // 
            this.lb_f.Font = new System.Drawing.Font("新細明體", 14F);
            this.lb_f.Location = new System.Drawing.Point(99, 223);
            this.lb_f.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_f.Name = "lb_f";
            this.lb_f.Size = new System.Drawing.Size(67, 22);
            this.lb_f.TabIndex = 80;
            this.lb_f.Text = "f";
            // 
            // lb_v
            // 
            this.lb_v.Font = new System.Drawing.Font("新細明體", 14F);
            this.lb_v.Location = new System.Drawing.Point(99, 192);
            this.lb_v.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_v.Name = "lb_v";
            this.lb_v.Size = new System.Drawing.Size(67, 22);
            this.lb_v.TabIndex = 79;
            this.lb_v.Text = "v";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("新細明體", 14F);
            this.label9.Location = new System.Drawing.Point(23, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 27);
            this.label9.TabIndex = 78;
            this.label9.Text = "q";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("新細明體", 14F);
            this.label8.Location = new System.Drawing.Point(23, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 27);
            this.label8.TabIndex = 77;
            this.label8.Text = "p";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("新細明體", 14F);
            this.label6.Location = new System.Drawing.Point(23, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 76;
            this.label6.Text = "頻率";
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
            this.pnlCOMStatus.Location = new System.Drawing.Point(16, 62);
            this.pnlCOMStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCOMStatus.Name = "pnlCOMStatus";
            this.pnlCOMStatus.Size = new System.Drawing.Size(541, 108);
            this.pnlCOMStatus.TabIndex = 56;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbStopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBit.Location = new System.Drawing.Point(452, 43);
            this.cmbStopBit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(73, 24);
            this.cmbStopBit.TabIndex = 32;
            // 
            // btCloseCOM
            // 
            this.btCloseCOM.Enabled = false;
            this.btCloseCOM.Font = new System.Drawing.Font("Arial", 8F);
            this.btCloseCOM.Location = new System.Drawing.Point(423, 77);
            this.btCloseCOM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCloseCOM.Name = "btCloseCOM";
            this.btCloseCOM.Size = new System.Drawing.Size(104, 28);
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
            this.cmbParity.Location = new System.Drawing.Point(301, 43);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(132, 24);
            this.cmbParity.TabIndex = 31;
            // 
            // btOpenCOM
            // 
            this.btOpenCOM.Font = new System.Drawing.Font("Arial", 8F);
            this.btOpenCOM.Location = new System.Drawing.Point(301, 77);
            this.btOpenCOM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btOpenCOM.Name = "btOpenCOM";
            this.btOpenCOM.Size = new System.Drawing.Size(104, 28);
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
            this.cmbDataBit.Location = new System.Drawing.Point(227, 43);
            this.cmbDataBit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDataBit.Name = "cmbDataBit";
            this.cmbDataBit.Size = new System.Drawing.Size(63, 24);
            this.cmbDataBit.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Connection Status";
            // 
            // labStopBit
            // 
            this.labStopBit.Font = new System.Drawing.Font("Arial", 8F);
            this.labStopBit.Location = new System.Drawing.Point(452, 25);
            this.labStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStopBit.Name = "labStopBit";
            this.labStopBit.Size = new System.Drawing.Size(75, 18);
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
            this.labParity.Size = new System.Drawing.Size(131, 18);
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
            this.labBaud.Size = new System.Drawing.Size(100, 18);
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
            this.labDataBit.Size = new System.Drawing.Size(64, 18);
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
            this.labPort.Size = new System.Drawing.Size(100, 18);
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
            this.cmbBaud.Location = new System.Drawing.Point(114, 43);
            this.cmbBaud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(100, 24);
            this.cmbBaud.TabIndex = 29;
            // 
            // cmbPort
            // 
            this.cmbPort.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbPort.Location = new System.Drawing.Point(8, 43);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(98, 24);
            this.cmbPort.TabIndex = 28;
            this.cmbPort.Text = "COM3";
            // 
            // txtAI4
            // 
            this.txtAI4.Location = new System.Drawing.Point(292, 173);
            this.txtAI4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAI4.Name = "txtAI4";
            this.txtAI4.Size = new System.Drawing.Size(129, 25);
            this.txtAI4.TabIndex = 72;
            this.txtAI4.Text = "444";
            // 
            // txtAI3
            // 
            this.txtAI3.Location = new System.Drawing.Point(317, 178);
            this.txtAI3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAI3.Name = "txtAI3";
            this.txtAI3.Size = new System.Drawing.Size(129, 25);
            this.txtAI3.TabIndex = 71;
            this.txtAI3.Text = "333";
            // 
            // txtAI2
            // 
            this.txtAI2.Location = new System.Drawing.Point(306, 187);
            this.txtAI2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAI2.Name = "txtAI2";
            this.txtAI2.Size = new System.Drawing.Size(129, 25);
            this.txtAI2.TabIndex = 70;
            this.txtAI2.Text = "222";
            // 
            // txtAI1
            // 
            this.txtAI1.Location = new System.Drawing.Point(302, 177);
            this.txtAI1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAI1.Name = "txtAI1";
            this.txtAI1.Size = new System.Drawing.Size(129, 25);
            this.txtAI1.TabIndex = 69;
            this.txtAI1.Text = "111";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label5.Location = new System.Drawing.Point(8, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 53);
            this.label5.TabIndex = 73;
            this.label5.Text = "pcs rtu slave模擬";
            // 
            // txtAO4
            // 
            this.txtAO4.Location = new System.Drawing.Point(440, 180);
            this.txtAO4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAO4.Name = "txtAO4";
            this.txtAO4.Size = new System.Drawing.Size(129, 25);
            this.txtAO4.TabIndex = 68;
            this.txtAO4.Text = "0";
            this.txtAO4.TextChanged += new System.EventHandler(this.txtAO4_TextChanged);
            // 
            // txtAO3
            // 
            this.txtAO3.Location = new System.Drawing.Point(450, 187);
            this.txtAO3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAO3.Name = "txtAO3";
            this.txtAO3.Size = new System.Drawing.Size(129, 25);
            this.txtAO3.TabIndex = 67;
            this.txtAO3.Text = "0";
            this.txtAO3.TextChanged += new System.EventHandler(this.txtAO3_TextChanged);
            // 
            // txtAO2
            // 
            this.txtAO2.Location = new System.Drawing.Point(459, 187);
            this.txtAO2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAO2.Name = "txtAO2";
            this.txtAO2.Size = new System.Drawing.Size(129, 25);
            this.txtAO2.TabIndex = 66;
            this.txtAO2.Text = "0";
            this.txtAO2.TextChanged += new System.EventHandler(this.txtAO2_TextChanged);
            // 
            // txtAO1
            // 
            this.txtAO1.Location = new System.Drawing.Point(439, 180);
            this.txtAO1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAO1.Name = "txtAO1";
            this.txtAO1.Size = new System.Drawing.Size(129, 25);
            this.txtAO1.TabIndex = 65;
            this.txtAO1.Text = "0";
            this.txtAO1.TextChanged += new System.EventHandler(this.txtAO1_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 14F);
            this.label4.Location = new System.Drawing.Point(24, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "電壓";
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(637, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(349, 7);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 542);
            this.listView1.TabIndex = 88;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // chkDI4
            // 
            this.chkDI4.Location = new System.Drawing.Point(141, 392);
            this.chkDI4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDI4.Name = "chkDI4";
            this.chkDI4.Size = new System.Drawing.Size(109, 20);
            this.chkDI4.TabIndex = 85;
            this.chkDI4.Text = "100004";
            // 
            // chkDI3
            // 
            this.chkDI3.Location = new System.Drawing.Point(141, 342);
            this.chkDI3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDI3.Name = "chkDI3";
            this.chkDI3.Size = new System.Drawing.Size(109, 20);
            this.chkDI3.TabIndex = 84;
            this.chkDI3.Text = "100003";
            // 
            // chkDI2
            // 
            this.chkDI2.Location = new System.Drawing.Point(141, 290);
            this.chkDI2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDI2.Name = "chkDI2";
            this.chkDI2.Size = new System.Drawing.Size(109, 20);
            this.chkDI2.TabIndex = 83;
            this.chkDI2.Text = "100002";
            // 
            // chkDI1
            // 
            this.chkDI1.Location = new System.Drawing.Point(139, 238);
            this.chkDI1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDI1.Name = "chkDI1";
            this.chkDI1.Size = new System.Drawing.Size(109, 20);
            this.chkDI1.TabIndex = 82;
            this.chkDI1.Text = "100001";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "DI Value";
            // 
            // chkDO4
            // 
            this.chkDO4.Location = new System.Drawing.Point(24, 392);
            this.chkDO4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDO4.Name = "chkDO4";
            this.chkDO4.Size = new System.Drawing.Size(109, 20);
            this.chkDO4.TabIndex = 81;
            this.chkDO4.Text = "000004";
            // 
            // chkDO3
            // 
            this.chkDO3.Location = new System.Drawing.Point(24, 342);
            this.chkDO3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDO3.Name = "chkDO3";
            this.chkDO3.Size = new System.Drawing.Size(109, 20);
            this.chkDO3.TabIndex = 80;
            this.chkDO3.Text = "000003";
            // 
            // chkDO2
            // 
            this.chkDO2.Location = new System.Drawing.Point(24, 290);
            this.chkDO2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDO2.Name = "chkDO2";
            this.chkDO2.Size = new System.Drawing.Size(109, 20);
            this.chkDO2.TabIndex = 79;
            this.chkDO2.Text = "000002";
            // 
            // chkDO1
            // 
            this.chkDO1.Location = new System.Drawing.Point(21, 238);
            this.chkDO1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDO1.Name = "chkDO1";
            this.chkDO1.Size = new System.Drawing.Size(109, 20);
            this.chkDO1.TabIndex = 78;
            this.chkDO1.Text = "000001";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "DO Value";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 612);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Modbus_Slave_RTU_Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlCOMStatus.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_q;
        private System.Windows.Forms.Label lb_p;
        private System.Windows.Forms.Label lb_f;
        private System.Windows.Forms.Label lb_v;
        private System.Windows.Forms.TextBox textBox_fine;
        private System.Windows.Forms.Button bt_fine_v;
        private System.Windows.Forms.Button bt_fine_f;
        private System.Windows.Forms.Button bt_reduce_f;
        private System.Windows.Forms.Button bt_reduce_v;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbisland;
        private System.Windows.Forms.Label lb_test_write;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
    }
}

