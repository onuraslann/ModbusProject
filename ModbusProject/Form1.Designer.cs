
namespace ModbusProject
{
    partial class txtForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIPAdress = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnBaglantıAc = new System.Windows.Forms.Button();
            this.btnBaglantıKapat = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.Label();
            this.lblBaglantıDurumu = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.tmrModbusTcpIP = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ModbusServerIP :";
            // 
            // txtServerIPAdress
            // 
            this.txtServerIPAdress.Location = new System.Drawing.Point(138, 82);
            this.txtServerIPAdress.Name = "txtServerIPAdress";
            this.txtServerIPAdress.Size = new System.Drawing.Size(177, 22);
            this.txtServerIPAdress.TabIndex = 64;
            this.txtServerIPAdress.Text = "127.0.0.1";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(12, 138);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(46, 17);
            this.label111.TabIndex = 65;
            this.label111.Text = "Port : ";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(145, 133);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(170, 22);
            this.txtPort.TabIndex = 66;
            this.txtPort.Text = "502";
            // 
            // btnBaglantıAc
            // 
            this.btnBaglantıAc.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBaglantıAc.Location = new System.Drawing.Point(138, 173);
            this.btnBaglantıAc.Name = "btnBaglantıAc";
            this.btnBaglantıAc.Size = new System.Drawing.Size(187, 36);
            this.btnBaglantıAc.TabIndex = 67;
            this.btnBaglantıAc.Text = "Connect";
            this.btnBaglantıAc.UseVisualStyleBackColor = false;
            this.btnBaglantıAc.Click += new System.EventHandler(this.btnBaglantıAc_Click);
            // 
            // btnBaglantıKapat
            // 
            this.btnBaglantıKapat.BackColor = System.Drawing.Color.Yellow;
            this.btnBaglantıKapat.Location = new System.Drawing.Point(138, 230);
            this.btnBaglantıKapat.Name = "btnBaglantıKapat";
            this.btnBaglantıKapat.Size = new System.Drawing.Size(187, 36);
            this.btnBaglantıKapat.TabIndex = 68;
            this.btnBaglantıKapat.Text = "Disconnect";
            this.btnBaglantıKapat.UseVisualStyleBackColor = false;
            this.btnBaglantıKapat.Click += new System.EventHandler(this.btnBaglantıKapat_Click_1);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(15, 256);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(75, 23);
            this.txtSave.TabIndex = 69;
            this.txtSave.Text = "Save";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Status : ";
            // 
            // txtMesaj
            // 
            this.txtMesaj.AutoSize = true;
            this.txtMesaj.BackColor = System.Drawing.Color.Gray;
            this.txtMesaj.Location = new System.Drawing.Point(12, 315);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(120, 17);
            this.txtMesaj.TabIndex = 72;
            this.txtMesaj.Text = "Error Messages  :";
            // 
            // lblBaglantıDurumu
            // 
            this.lblBaglantıDurumu.AutoSize = true;
            this.lblBaglantıDurumu.Location = new System.Drawing.Point(438, 11);
            this.lblBaglantıDurumu.Name = "lblBaglantıDurumu";
            this.lblBaglantıDurumu.Size = new System.Drawing.Size(102, 17);
            this.lblBaglantıDurumu.TabIndex = 73;
            this.lblBaglantıDurumu.Text = "Baglantı Kapalı";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(360, 68);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 17);
            this.label25.TabIndex = 53;
            this.label25.Text = "Slave ID : ";
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSlaveId.Location = new System.Drawing.Point(438, 68);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(121, 22);
            this.txtSlaveId.TabIndex = 74;
            this.txtSlaveId.Text = "1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(358, 116);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 17);
            this.label26.TabIndex = 75;
            this.label26.Text = "Function : ";
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
            this.cboState.Location = new System.Drawing.Point(438, 116);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 24);
            this.cboState.TabIndex = 76;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(360, 173);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 77;
            this.label23.Text = "Address";
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAdress.Location = new System.Drawing.Point(438, 173);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(121, 22);
            this.txtAdress.TabIndex = 78;
            this.txtAdress.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(358, 240);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 79;
            this.label24.Text = "Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtquantity.Location = new System.Drawing.Point(438, 237);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(121, 22);
            this.txtquantity.TabIndex = 80;
            this.txtquantity.Text = "10";
            // 
            // tmrModbusTcpIP
            // 
            this.tmrModbusTcpIP.Tick += new System.EventHandler(this.tmrModbusTcpIP_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(598, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 349);
            this.panel1.TabIndex = 81;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip1.TabIndex = 82;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveASToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveASToolStripMenuItem
            // 
            this.saveASToolStripMenuItem.Name = "saveASToolStripMenuItem";
            this.saveASToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveASToolStripMenuItem.Text = "SaveAS";
            // 
            // txtForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtSlaveId);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblBaglantıDurumu);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.btnBaglantıKapat);
            this.Controls.Add(this.btnBaglantıAc);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.txtServerIPAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "txtForms";
            this.ShowIcon = false;
            this.Text = "Modbus";
            this.Load += new System.EventHandler(this.txtForms_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIPAdress;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnBaglantıAc;
        private System.Windows.Forms.Button btnBaglantıKapat;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMesaj;
        private System.Windows.Forms.Label lblBaglantıDurumu;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Timer tmrModbusTcpIP;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveASToolStripMenuItem;
    }
}

