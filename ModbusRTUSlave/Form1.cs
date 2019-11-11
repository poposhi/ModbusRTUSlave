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
        #region listview
        private void InitialListView()//��l��ListView���榡�j�p 
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("address",50);
            listView1.Columns.Add("value", 50);
            //���w��
            listView1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance
   | System.Reflection.BindingFlags.NonPublic).SetValue(listView1, true, null);
        }
        public delegate void Listview_Print(ListView list, string time, string message);//time type �S��
        public static void lv_Print(ListView list, string time, string message)// ��Jlistview ,���str
        {
            //�P�_�o��TextBox������O�_�b�P�@�Ӱ�����W
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
        public static void lv_Print(ListView list, string message)// ��Jlistview ,���str
        {
            String time = DateTime.Now.ToString();
            //�P�_�o��TextBox������O�_�b�P�@�Ӱ�����W
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
                        iAddress++;//�a�}�|��1 41207>41041
                        try
                        {
                            if (iAddress == 6003)
                            {
                                reg30[25] = e.Data.B[i]; //iAddress 1000�O41001
                            }
                            if (iAddress == 6006) //��ڤW�O6006
                            {
                                reg30[24] = e.Data.B[i]; //iAddress 1000�O41001
                            }
                        }
                        catch 
                        {
                            tb1.Text = "�g�Jpq�ഫ�Ȧs�����~ ";
                        }


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
            }
            else if (cmbParity.Text.Substring(0, 1) == "2")
            {
                comPort.Parity = Parity.Even;
            }
            if (cmbStopBit.Text == "0")
            {
                comPort.StopBits = StopBits.None;
            }
            else if (cmbStopBit.Text == "1")
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
            reg30[6] = reg30[7] = reg30[8] = 380;
            reg30[16] = 60;
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
                slave.DataStore.InputRegisters[5000 + i] = reg30[i];
                int addr = 3500 + i;
                lv_Print(listView1, addr.ToString(), reg30[i].ToString());
            }
            pcs1.REG = reg30;
            pcs1.putData();
            lb_v.Text =pcs1.getV.ToString();
            lb_f.Text= pcs1.getF.ToString();
            lb_p.Text = pcs1.getP.ToString();
            lb_q.Text = pcs1.getQ.ToString();
        }

        private void bt_fine_v_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 6; i < 9; i++)
                {
                    reg30[i] += Convert.ToUInt16(textBox_fine.Text);
                }

            }
            catch
            {
                tb1.Text += "bt_fine_v+ error";
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
                tb1.Text += "bt_fine_f+ error";
            }
        }

        private void bt_reduce_v_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 6; i < 9; i++)
                {
                    reg30[i] -= Convert.ToUInt16(textBox_fine.Text);
                }

            }
            catch
            {
                tb1.Text += "bt_fine_v- error";
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
                tb1.Text += "bt_fine_f- error";
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
    }
}