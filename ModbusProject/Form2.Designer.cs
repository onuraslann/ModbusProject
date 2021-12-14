
namespace ModbusProject
{
    partial class txtForms2
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
            this.label111 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaglantıKapat = new System.Windows.Forms.Button();
            this.btnBaglantıAc = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServerIPAdress = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBaglantıDurumu = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrModbus2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(12, 66);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(46, 17);
            this.label111.TabIndex = 67;
            this.label111.Text = "Port : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "ModbusServerIP :";
            // 
            // btnBaglantıKapat
            // 
            this.btnBaglantıKapat.BackColor = System.Drawing.Color.Yellow;
            this.btnBaglantıKapat.Location = new System.Drawing.Point(138, 165);
            this.btnBaglantıKapat.Name = "btnBaglantıKapat";
            this.btnBaglantıKapat.Size = new System.Drawing.Size(187, 36);
            this.btnBaglantıKapat.TabIndex = 72;
            this.btnBaglantıKapat.Text = "Disconnect";
            this.btnBaglantıKapat.UseVisualStyleBackColor = false;
            this.btnBaglantıKapat.Click += new System.EventHandler(this.btnBaglantıKapat_Click);
            // 
            // btnBaglantıAc
            // 
            this.btnBaglantıAc.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBaglantıAc.Location = new System.Drawing.Point(138, 108);
            this.btnBaglantıAc.Name = "btnBaglantıAc";
            this.btnBaglantıAc.Size = new System.Drawing.Size(187, 36);
            this.btnBaglantıAc.TabIndex = 71;
            this.btnBaglantıAc.Text = "Connect";
            this.btnBaglantıAc.UseVisualStyleBackColor = false;
            this.btnBaglantıAc.Click += new System.EventHandler(this.btnBaglantıAc_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(138, 66);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(187, 22);
            this.txtPort.TabIndex = 70;
            this.txtPort.Text = "502";
            // 
            // txtServerIPAdress
            // 
            this.txtServerIPAdress.Location = new System.Drawing.Point(138, 18);
            this.txtServerIPAdress.Name = "txtServerIPAdress";
            this.txtServerIPAdress.Size = new System.Drawing.Size(187, 22);
            this.txtServerIPAdress.TabIndex = 69;
            this.txtServerIPAdress.Text = "127.0.0.1";
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtquantity.Location = new System.Drawing.Point(466, 205);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(121, 22);
            this.txtquantity.TabIndex = 88;
            this.txtquantity.Text = "10";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(341, 193);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 87;
            this.label24.Text = "Quantity";
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAdress.Location = new System.Drawing.Point(466, 151);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(121, 22);
            this.txtAdress.TabIndex = 86;
            this.txtAdress.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(341, 156);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 85;
            this.label23.Text = "Address";
            // 
            // cboState
            // 
            this.cboState.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "01 Read Coils(0x)",
            "02 Input Status(1x)",
            "03 Read Holding Register(4x)",
            "04 Input Register(3x)"});
            this.cboState.Location = new System.Drawing.Point(466, 105);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 24);
            this.cboState.TabIndex = 84;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(339, 108);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 17);
            this.label26.TabIndex = 83;
            this.label26.Text = "Function : ";
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSlaveId.Location = new System.Drawing.Point(466, 61);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(121, 22);
            this.txtSlaveId.TabIndex = 82;
            this.txtSlaveId.Text = "1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(341, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 17);
            this.label25.TabIndex = 81;
            this.label25.Text = "Slave ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Status : ";
            // 
            // lblBaglantıDurumu
            // 
            this.lblBaglantıDurumu.AutoSize = true;
            this.lblBaglantıDurumu.Location = new System.Drawing.Point(463, 18);
            this.lblBaglantıDurumu.Name = "lblBaglantıDurumu";
            this.lblBaglantıDurumu.Size = new System.Drawing.Size(102, 17);
            this.lblBaglantıDurumu.TabIndex = 90;
            this.lblBaglantıDurumu.Text = "Baglantı Kapalı";
            // 
            // txtMesaj
            // 
            this.txtMesaj.AutoSize = true;
            this.txtMesaj.BackColor = System.Drawing.Color.Gray;
            this.txtMesaj.Location = new System.Drawing.Point(12, 412);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(120, 17);
            this.txtMesaj.TabIndex = 91;
            this.txtMesaj.Text = "Error Messages  :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(598, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 349);
            this.panel1.TabIndex = 81;
            // 
            // tmrModbus2
            // 
            this.tmrModbus2.Tick += new System.EventHandler(this.tmrModbus2_Tick);
            // 
            // txtForms2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lblBaglantıDurumu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtSlaveId);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnBaglantıKapat);
            this.Controls.Add(this.btnBaglantıAc);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServerIPAdress);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "txtForms2";
            this.Text = "ModbusNew";
            this.Load += new System.EventHandler(this.txtForms2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaglantıKapat;
        private System.Windows.Forms.Button btnBaglantıAc;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServerIPAdress;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBaglantıDurumu;
        private System.Windows.Forms.Label txtMesaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrModbus2;
    }
}