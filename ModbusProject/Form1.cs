using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using EasyModbus.Exceptions;
using System.IO;
using Newtonsoft.Json;



namespace ModbusProject
{
    public partial class txtForms : Form
    {
        ModbusClient modbusClient;

        private TextBox[] register;
        private TextBox[] register2;
        private TextBox[] register3;
        public txtForms()
        {
            InitializeComponent();
        }

        private void txtForms_Load(object sender, EventArgs e)
        {
            cboState.Text = "03 Read Holding Register(4x)";
        }

        private void btnBaglantıAc_Click(object sender, EventArgs e)
        {

            try
            {
                txtSlaveId.ReadOnly = true;
                txtAdress.ReadOnly = true;
                txtPort.ReadOnly = true;
                txtServerIPAdress.ReadOnly = true;
                txtquantity.ReadOnly = true;
                modbusClient = new ModbusClient(txtServerIPAdress.Text, Convert.ToInt16(txtPort.Text));
                modbusClient.Connect();
                register = new TextBox[Convert.ToInt16(txtquantity.Text)];
                register2 = new TextBox[Convert.ToInt16(txtquantity.Text)];
                register3 = new TextBox[Convert.ToInt16(txtquantity.Text)];
                for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                {
                    register2[i] = new TextBox();
                    register2[i].Location = new Point(0, i * 20);
                    register2[i].Size = new Size(40, 22);
                    panel1.Controls.Add(register2[i]);

                    register3[i] = new TextBox();
                    register3[i].Location = new Point(40, (i) * 20);
                    register3[i].Size = new Size(80, 45);
                    panel1.Controls.Add(register3[i]);
                   
                    register[i] = new TextBox();
                    register[i].Location = new Point(120, (i) * 20);
                    register[i].Size = new Size(100, 45);
                    panel1.Controls.Add(register[i]);
      

                }
                lblBaglantıDurumu.Text = "Connection Open";
                tmrModbusTcpIP.Enabled = true;

            }
            catch (Exception ex)
            {

                lblBaglantıDurumu.Text = ex.Message;
            }
        }
        private void tmrModbusTcpIP_Tick_1(object sender, EventArgs e)
        {
            tmrModbusTcpIP.Enabled = false;
            try
            {
                if (cboState.Text == "03 Read Holding Register(4x)")
                {

                    modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);
                    int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(startingAddress: Convert.ToInt16(txtAdress.Text), quantity: Convert.ToInt16(txtquantity.Text));


                    for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                    {
                        register2[i].Text = (Convert.ToInt16(txtAdress.Text) + (i)).ToString();

                        register[i].Text = readHoldingRegisters[i].ToString();
                    }
                }
                else if (cboState.Text == "Read Coils(0x)")
                {
                    modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);
                    bool[] readCoils = modbusClient.ReadCoils(startingAddress: Convert.ToInt32(txtAdress.Text), quantity: Convert.ToInt32(txtquantity.Text));

                    for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                    {
                        register2[i].Text = (Convert.ToInt16(txtAdress.Text) + (i)).ToString();
                        register[i].Text = readCoils[i].ToString();

                    }
                }

                else if (cboState.Text == "04 Input Register(3x)")
                {
                    modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);
                    int[] inputRegister = modbusClient.ReadInputRegisters(startingAddress: Convert.ToInt32(txtAdress.Text), quantity: Convert.ToInt32(txtquantity.Text));

                    for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                    {
                        register2[i].Text = (Convert.ToInt16(txtAdress.Text) + (i)).ToString();

                        register[i].Text = inputRegister[i].ToString();

                    }

                }
                else if (cboState.Text == "02 Input Status(1x)")
                {

                    modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);

                    bool[] inputStatus = modbusClient.ReadDiscreteInputs(startingAddress: Convert.ToInt32(txtAdress.Text), quantity: Convert.ToInt32(txtquantity.Text));

                    for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                    {
                        register2[i].Text = (Convert.ToInt16(txtAdress.Text) + (i)).ToString();
                        register[i].Text = inputStatus[i].ToString();
                    }
                }

            }

            catch (Exception ex)
            {
                txtMesaj.Text = ex.Message;

            }
            tmrModbusTcpIP.Enabled = true;
        }
       
        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Buraya Sadece Sayı giriniz");
            }
        }
        private void txtSlaveId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Buraya Sadece Sayı giriniz");
            }
        }
      

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtForms2 to = new txtForms2();
            to.Show();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "*";
                saveFileDialog1.Filter = "YazıDosyaları(*json)|*.json)";
                saveFileDialog1.DefaultExt = "json";
                saveFileDialog1.ShowDialog();
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
            
                ModbusSetup setup = new ModbusSetup()
                {
                    ServerIP = txtServerIPAdress.Text,
                    Port = Convert.ToInt32(txtPort.Text),
                    SlaveId = Convert.ToInt32(txtSlaveId.Text),
                    Function = cboState.Text,
                    Address = Convert.ToInt32(txtAdress.Text),
                    Quantity = Convert.ToInt32(txtquantity.Text)
                };              
      
                for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                {
                    ModbusRegister temp = new ModbusRegister();
                    temp.RegisterNr = Convert.ToInt32(register2[i].Text);
                    temp.Description = register3[i].Text;
                    temp.RegisterValue = register[i].Text;
                    setup.Registers[i] = temp;
                }
                writer.WriteLine(JsonConvert.SerializeObject(setup));

                /*for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                {
                    writer.WriteLine(i + JsonConvert.SerializeObject(register3[i].Text));
                }*/

                writer.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kaydetme işlemi başarısız");
            }


        }
        private void txtSlaveId_TextChanged(object sender, EventArgs e)
        {
        }
        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "*";
                saveFileDialog1.Filter = "YazıDosyaları(*json)|*.json)";
                saveFileDialog1.DefaultExt = "json";
                saveFileDialog1.ShowDialog();
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                ModbusSetup setup = new ModbusSetup();
                setup.ServerIP = txtServerIPAdress.Text;
                setup.Port = Convert.ToInt32(txtPort.Text);
                setup.SlaveId = Convert.ToInt32(txtSlaveId.Text);
                setup.Function = cboState.Text;
                setup.Address = Convert.ToInt32(txtAdress.Text);
                setup.Quantity = Convert.ToInt32(txtquantity.Text);

                writer.WriteLine(JsonConvert.SerializeObject(setup));
                for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                {
                    writer.Write(JsonConvert.SerializeObject(i +   " : "  +register3[i].Text));      

                 }
                    writer.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kaydetme işlemi başarısız");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBaglantıKapat_Click_1(object sender, EventArgs e)
        {
            try
            {
                modbusClient.Disconnect();
                lblBaglantıDurumu.Text = "Disconnection ";
                tmrModbusTcpIP.Enabled = false;
                txtSlaveId.ReadOnly = false;
                txtAdress.ReadOnly = false;
                txtPort.ReadOnly = false;
                txtServerIPAdress.ReadOnly = false;
                txtquantity.ReadOnly = false;
                for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                {
                    panel1.Controls.Remove(register[i]);
                    panel1.Controls.Remove(register2[i]);
                    panel1.Controls.Remove(register3[i]);
                }
            }
            catch (Exception ex)
            {
                lblBaglantıDurumu.Text = ex.Message;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((st = openFileDialog.OpenFile()) != null)
                {
                    string file = openFileDialog.FileName;
                    string str = File.ReadAllText(file);
                    openfolder.Text = str;
                }              
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }
    }
    }

