using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus;
using Modbus.Device;
using Modbus.Data;
using System.Threading;

namespace ModbusRTUSlave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialListView();
        }
        #region 委派
        #region listview
        private void InitialListView()//初始化ListView的格式大小 
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("address", 50);
            listView1.Columns.Add("value", 50);
            lv.View = View.Details;
            lv.GridLines = true;
            lv.LabelEdit = false;
            lv.FullRowSelect = true;
            lv.Columns.Add("meeeage1", 100);
            lv.Columns.Add("meeeage2", 200);
            //雙緩衝
            listView1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance
   | System.Reflection.BindingFlags.NonPublic).SetValue(listView1, true, null);
            lv.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance
| System.Reflection.BindingFlags.NonPublic).SetValue(lv, true, null);
        }
        public delegate void Listview_Print(ListView list, string time, string message);//time type 沒改
        public delegate void lPrintHandler(Label label, string text);
        public static void lv_Print(ListView list, string time, string message)// 輸入listview ,兩個str
        {
            //判斷這個TextBox的物件是否在同一個執行緒上
            if (list.InvokeRequired)
            {
                Listview_Print ph = new Listview_Print(lv_Print);
                list.Invoke(ph, list, time, message);
            }
            else
            {
                String[] row = { time, message };
                ListViewItem item = new ListViewItem(row);
                //ADD ITEMS
                list.Items.Add(item);
                if (list.Items.Count > 1000)
                {
                    list.Items.RemoveAt(1);
                }
            }
        }
        public static void lv_Print(ListView list, string message)// 輸入listview ,兩個str
        {
            String time = DateTime.Now.ToString();
            //判斷這個TextBox的物件是否在同一個執行緒上
            if (list.InvokeRequired)
            {
                Listview_Print ph = new Listview_Print(lv_Print);
                list.Invoke(ph, list, time, message);
            }
            else
            {
                String[] row = { time, message };
                ListViewItem item = new ListViewItem(row);
                //ADD ITEMS
                list.Items.Add(item);
                if (list.Items.Count > 1000)
                {
                    list.Items.RemoveAt(1);
                }
            }
        }
        #endregion

        public static void l_Print(Label tb, string text)
        {
            //判斷這個TextBox的物件是否在同一個執行緒上
            if (tb.InvokeRequired)
            {
                lPrintHandler ph = new lPrintHandler(l_Print);
                tb.Invoke(ph, tb, text);
            }
            else
            {
                tb.Text = text;
            }
        }
        public delegate void txbox_PrintPrintHandler(TextBox textBox, string text);
        public static void txbox_Print(TextBox textBox, string text)
        {
            //判斷這個TextBox的物件是否在同一個執行緒上
            if (textBox.InvokeRequired)
            {
                txbox_PrintPrintHandler ph = new txbox_PrintPrintHandler(txbox_Print);
                textBox.Invoke(ph, textBox, text);
            }
            else
            {
                textBox.Text = text;
            }
        }
        #endregion
        ModbusSlave slave;
        private byte slaveID = 1;
        private SerialPort comPort = new SerialPort();
        ushort[] reg30 = new ushort[60];

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBaud.SelectedIndex = 7;
            cmbDataBit.SelectedIndex = 1;
            cmbParity.SelectedIndex = 0;
            cmbStopBit.SelectedIndex = 0;
            // foreach (string s in SerialPort.GetPortNames())
            //    cmbPort.Items.Add(s);
            //cmbPort.SelectedIndex = 0;
        }
        private void Modbus_Request_Event(object sender, Modbus.Device.ModbusSlaveRequestEventArgs e)
        {
            //request from master
            byte fc = e.Message.FunctionCode;
            byte[] data = e.Message.MessageFrame;
            byte[] byteStartAddress = new byte[] { data[3], data[2] };
            byte[] byteNum = new byte[] { data[5], data[4] };
            Int16 StartAddress = BitConverter.ToInt16(byteStartAddress, 0);
            Int16 NumOfPoint = BitConverter.ToInt16(byteNum, 0);

            Console.WriteLine(fc.ToString() + "," + StartAddress.ToString() + "," + NumOfPoint.ToString());

        }

        private void Modbus_DataStoreWriteTo(object sender, Modbus.Data.DataStoreEventArgs e)
        {
            //this.Text = "DataType=" + e.ModbusDataType.ToString() + "  StartAdress=" + e.StartAddress;
            int iAddress = e.StartAddress;//e.StartAddress;
            switch (e.ModbusDataType)
            {
                case ModbusDataType.HoldingRegister:
                    for (int i = 0; i < e.Data.B.Count; i++)
                    {
                        //Set AO                 

                        //e.Data.B[i] already write to slave.DataStore.HoldingRegisters[e.StartAddress + i + 1]
                        //e.StartAddress starts from 0
                        //You can set AO value to hardware here

                        DoAOUpdate(iAddress, e.Data.B[i].ToString());
                        lv_Print(lv, iAddress.ToString(), e.Data.B[i].ToString());
                        try
                        {
                            //這邊的地址要減1
                            if (iAddress == 6003)  //q
                            {
                                reg30[25] = e.Data.B[i]; //iAddress 1000是41001
                                pcs1.getQ = reg30[25];
                                //lv_Print(lv, e.Data.B[i].ToString());
                            }
                            if (iAddress == 6006) //p
                            {
                                reg30[24] = e.Data.B[i]; //iAddress 1000是41001
                                //lv_Print(lv, e.Data.B[i].ToString());
                                pcs1.getP = reg30[24];
                            }
                            if (iAddress == 6007) //孤島   slave 地址是正常的 
                            {
                                if (e.Data.B[i] == 1)
                                {
                                    lbisland.BackColor = Color.Red;
                                    lbisland.Text = "孤島啟動";
                                }
                                if (e.Data.B[i] == 0)
                                {
                                    lbisland.BackColor = Color.White;
                                    lbisland.Text = "孤島關閉";
                                }
                            }
                            if (iAddress == 6007)
                            {
                                l_Print(lb_test_write, "寫入成功 ");
                            }
                        }
                        catch (Exception ee)
                        {
                            lv_Print(lv, "寫入pq轉換暫存器錯誤 ", ee.Message);

                        }

                        iAddress++;//地址會減1 41207>41041
                    }
                    break;

                case ModbusDataType.Coil:
                    for (int i = 0; i < e.Data.A.Count; i++)
                    {
                        //Set DO
                        //e.Data.A[i] already write to slave.DataStore.CoilDiscretes[e.StartAddress + i + 1]
                        //e.StartAddress starts from 0
                        //You can set DO value to hardware here

                        DoDOUpdate(iAddress, e.Data.A[i]);
                        iAddress++;
                        if (e.Data.A.Count == 1)
                        {
                            break;
                        }
                    }
                    break;
            }

        }
        #region "Set AO"
        private delegate void UpdateAOStatusDelegate(int index, String message);
        private void DoAOUpdate(int index, String message)
        {
            if (this.InvokeRequired)
            {
                // we were called on a worker thread
                // marshal the call to the user interface thread
                this.Invoke(new UpdateAOStatusDelegate(DoAOUpdate),
                            new object[] { index, message });
                return;
            }

            // this code can only be reached
            // by the user interface thread
            switch (index)
            {
                case 0:
                    this.txtAO1.Text = message;
                    break;
                case 1:
                    this.txtAO2.Text = message;
                    break;
                case 2:
                    this.txtAO3.Text = message;
                    break;
                case 3:
                    this.txtAO4.Text = message;
                    break;
            }

        }
        #endregion

        #region "Set DO"
        private delegate void UpdateDOStatusDelegate(int index, bool value);
        private void DoDOUpdate(int index, bool value)
        {
            if (this.InvokeRequired)
            {
                // we were called on a worker thread
                // marshal the call to the user interface thread
                this.Invoke(new UpdateDOStatusDelegate(DoDOUpdate),
                            new object[] { index, value });
                return;
            }

            // this code can only be reached
            // by the user interface thread
            switch (index)
            {
                case 0:
                    this.chkDO1.Checked = value;
                    break;
                case 1:
                    this.chkDO2.Checked = value;
                    break;
                case 2:
                    this.chkDO3.Checked = value;
                    break;
                case 3:
                    this.chkDO4.Checked = value;
                    break;
            }

        }
        #endregion



        private void timer1_Tick(object sender, EventArgs e)
        {
            //update input values to datastore
            //DI
            slave.DataStore.InputDiscretes[1] = chkDI1.Checked;
            slave.DataStore.InputDiscretes[2] = chkDI2.Checked;
            slave.DataStore.InputDiscretes[3] = chkDI3.Checked;
            slave.DataStore.InputDiscretes[4] = chkDI4.Checked;
            //AI
            slave.DataStore.InputRegisters[1] = Convert.ToUInt16(txtAI1.Text);
            slave.DataStore.InputRegisters[2] = Convert.ToUInt16(txtAI2.Text);
            slave.DataStore.InputRegisters[3] = Convert.ToUInt16(txtAI3.Text);
            slave.DataStore.InputRegisters[4] = Convert.ToUInt16(txtAI4.Text);
            //AO
            slave.DataStore.HoldingRegisters[1] = Convert.ToUInt16(txtAO1.Text);
            slave.DataStore.HoldingRegisters[2] = Convert.ToUInt16(txtAO2.Text);
            slave.DataStore.HoldingRegisters[3] = Convert.ToUInt16(txtAO3.Text);
            slave.DataStore.HoldingRegisters[4] = Convert.ToUInt16(txtAO4.Text);
            //DO
            slave.DataStore.CoilDiscretes[1] = chkDO1.Checked;
            slave.DataStore.CoilDiscretes[2] = chkDO2.Checked;
            slave.DataStore.CoilDiscretes[3] = chkDO3.Checked;
            slave.DataStore.CoilDiscretes[4] = chkDO4.Checked;

        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOpenCOM_Click_1(object sender, EventArgs e)
        {
            #region comPort
            comPort.PortName = cmbPort.Text;
            comPort.BaudRate = int.Parse(cmbBaud.Text);
            comPort.DataBits = int.Parse(cmbDataBit.Text);
            if (cmbParity.Text.Substring(0, 1) == "0")
            {
                comPort.Parity = Parity.None;
            }
            else if (cmbParity.Text.Substring(0, 1) == "1")
            {
                comPort.Parity = Parity.Odd;
                comPort.Parity = Parity.Odd;
                comPort.Parity = Parity.Odd;
                comPort.Parity = Parity.Odd;
                comPort.Parity = Parity.Odd;
            }
            else if (cmbParity.Text.Substring(0, 1) == "2")
            {
                comPort.Parity = Parity.Even;
            }
            if (cmbStopBit.Text == "0")
            {
                comPort.StopBits = StopBits.None;
            }
            //else if (cmbStopBit.Text == "1")
            {
                comPort.StopBits = StopBits.One;
            }
            comPort.Open();
            #endregion
            slave = ModbusSerialSlave.CreateRtu(slaveID, comPort);
            slave.ModbusSlaveRequestReceived += new EventHandler<ModbusSlaveRequestEventArgs>(Modbus_Request_Event);
            slave.DataStore = Modbus.Data.DataStoreFactory.CreateDefaultDataStore();
            slave.DataStore.DataStoreWrittenTo += new EventHandler<DataStoreEventArgs>(Modbus_DataStoreWriteTo);
            btOpenCOM.Enabled = false;
            btCloseCOM.Enabled = true;
            slave.Listen();

            timer1.Enabled = true;
            timer2.Enabled = true;

            for (int i = 0; i < 60; i++)
            {
                reg30[i] = (ushort)i;
            }
            reg_init();

        }
        private void reg_init()
        {
            reg30[2] = 0; //初始化故障代碼
            reg30[3] = 0; //初始化故障代碼
            reg30[4] = 0; //初始化故障代碼
            reg30[5] = 0; //初始化故障代碼
            reg30[6] = reg30[7] = reg30[8] = 3800; //初始化電壓 
            reg30[16] = 6000; //f
            reg30[20] = 2500; //vdc
            reg30[21] = 173;//idc
            reg30[22] = (ushort)(reg30[20] * reg30[21] / 100);
            reg30[24] = 0;
            reg30[25] = 0;

        }
        private void btCloseCOM_Click_1(object sender, EventArgs e)
        {
            //Close comport first,then stop and dispose slave.
            comPort.Close();
            slave.Stop();
            slave.Dispose();
            btOpenCOM.Enabled = true;
            btCloseCOM.Enabled = false;
            timer1.Enabled = false;
        }
        private void btOpenCOM_Click(object sender, EventArgs e)
        {

        }

        private void btCloseCOM_Click(object sender, EventArgs e)
        {

        }
        pcs pcs1 = new pcs();
        private void timer2_Tick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int i = 0; i < 60; i++)
            {
                slave.DataStore.InputRegisters[5001 + i] = reg30[i];
                int addr = 35000 + i;
                lv_Print(listView1, addr.ToString(), reg30[i].ToString());
            }
            pcs1.REG = reg30;
            pcs1.putData();
            lb_v.Text = (pcs1.getV / 10).ToString("#0.0");
            lb_f.Text = (pcs1.getF / 100).ToString("#0.00");
            lb_p.Text = pcs1.getP.ToString();
            lb_q.Text = pcs1.getQ.ToString();
        }

        private void bt_fine_v_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int ii = 0; ii < 10; ii++)
                    {
                        reg30[i] += Convert.ToUInt16(textBox_fine.Text);
                    }

                }

            }
            catch
            {

                lv_Print(lv, "bt_fine_v+ error ");
            }
        }

        private void bt_fine_f_Click(object sender, EventArgs e)
        {
            try
            {

                reg30[16] += Convert.ToUInt16(textBox_fine.Text);


            }
            catch
            {
                lv_Print(lv, "bt_fine_f+ error");
            }
        }

        private void bt_reduce_v_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int ii = 0; ii < 10; ii++)
                    {
                        reg30[i] -= Convert.ToUInt16(textBox_fine.Text);
                    }
                }

            }
            catch
            {
                lv_Print(lv, "bt_fine_v- error");
            }
        }

        private void bt_reduce_f_Click(object sender, EventArgs e)
        {
            try
            {

                reg30[16] -= Convert.ToUInt16(textBox_fine.Text);


            }
            catch
            {
                lv_Print(lv, "bt_fine_f- error");
            }
        }
        private void ref_writeBit(ref ushort value, int bit_number, char bit_value) //輸入數值 要更改的第幾個bit  要更改的數值 回傳整個暫存器 更改好的數值  
        {
            try
            {
                string flag;
                int Substring_bit = 15 - bit_number;
                flag = Convert.ToString(value, 2).PadLeft(16, '0');
                var c = flag.ToCharArray();//分開成 char array
                c[Substring_bit] = bit_value; //修改
                string str = new string(c); //合併 char array to string 
                value = Convert.ToUInt16(str, 2);
            }
            catch
            {
                lv_Print(lv, "ref_writeBit error");
            }
        }

        private void txtAO4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAO3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAO2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAO1_TextChanged(object sender, EventArgs e)
        {

        }
        #region checkBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox1.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 0, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 0, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");

                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox2.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 1, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 1, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");
                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox3.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 2, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 2, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");
                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox4.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 3, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 3, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");
                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox8.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 4, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 4, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");
                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox7.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 5, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 5, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");
                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox6.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 6, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 6, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");
                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox5.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[2], 7, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[2], 7, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");
                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }

        #endregion

        private void lbisland_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lv.Clear();
            InitialListView();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox9.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[3], 12, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[3], 12, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");

                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox10.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[4], 10, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[4], 10, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");

                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (checkBox11.CheckState)
                {
                    case CheckState.Checked:
                        ref_writeBit(ref reg30[4], 14, '1');
                        break;
                    case CheckState.Unchecked:
                        ref_writeBit(ref reg30[4], 14, '0');
                        break;
                    case CheckState.Indeterminate:
                        lv_Print(lv, "進入CheckBox的三種狀態");

                        break;
                }
            }
            catch (Exception ee) { lv_Print(lv, "CheckBox error", ee.Message); }
        }
    }
}