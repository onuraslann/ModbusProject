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


namespace ModbusProject
{
    public partial class txtForms : Form
    {
        ModbusClient modbusClient;

        private TextBox[] register;
        private TextBox[] register2;
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
       


                for (int i = 0; i < Convert.ToInt32(txtquantity.Text); i++)
                {
                    register2[i] = new TextBox();


                    register2[i].Location = new Point(0, i * 20);
                    //register2[i].Location = new Point(450, i * 20);
                    register2[i].Size = new Size(50, 22);
                    //this.Controls.Add(register2[i]);
                    panel1.Controls.Add(register2[i]);
                    //register3[i] = new TextBox();

                    //register3[i].Location = new Point(500, i * 20);
                    //register3[i].Size = new Size(50, 22);
                    //this.Controls.Add(register3[i]);

                    register[i] = new TextBox();
                    //register[i].Location = new Point(500, (i) * 20);
                    register[i].Location = new Point(0, (i) * 20);
                    register[i].Size = new Size(150, 45);

                    //this.Controls.Add(register[i]);
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
                    int[] inputRegister = modbusClient.ReadInputRegisters(startingAddress: Convert.ToInt32(txtAdress.Text), quantity: Convert.ToInt32(txtquantity));


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
                    this.Controls.Remove(register2[i]);
                    this.Controls.Remove(register[i]);



                }
            }
            catch (Exception ex)
            {
                lblBaglantıDurumu.Text = ex.Message;
            }
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

     

      
      

   

        private void txtSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "*";
                saveFileDialog1.Filter = "YazıDosyaları(*txt)|*.text)";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.ShowDialog();
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);

                writer.WriteLine("IP" + txtServerIPAdress);
                writer.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Kaydetme işlemi başarısız");
            }

        }
    }
}
