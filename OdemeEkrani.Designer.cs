namespace Siparis_Otomasyon
{
    partial class OdemeEkrani
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpKredi = new System.Windows.Forms.TabPage();
            this.pnlOdemeBilgisi = new System.Windows.Forms.Panel();
            this.btnOdemeYapCard = new System.Windows.Forms.Button();
            this.mtbCvv = new System.Windows.Forms.MaskedTextBox();
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.cbAy = new System.Windows.Forms.ComboBox();
            this.mtbKartNo = new System.Windows.Forms.MaskedTextBox();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelKart = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lCVV = new System.Windows.Forms.Label();
            this.lKartNo = new System.Windows.Forms.Label();
            this.lSKT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lAdSoyad = new System.Windows.Forms.Label();
            this.tpCheck = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBanka = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBanka = new System.Windows.Forms.TextBox();
            this.btnOdemeYapCheck = new System.Windows.Forms.Button();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lSiparisTutari = new System.Windows.Forms.Label();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.lBankId = new System.Windows.Forms.Label();
            this.lAd = new System.Windows.Forms.Label();
            this.tpNakit = new System.Windows.Forms.TabPage();
            this.chckbxElden = new System.Windows.Forms.CheckBox();
            this.btnEldenOdeme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpKredi.SuspendLayout();
            this.pnlOdemeBilgisi.SuspendLayout();
            this.panelKart.SuspendLayout();
            this.tpCheck.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.tpNakit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIptal.Location = new System.Drawing.Point(821, 548);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(124, 59);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpKredi);
            this.tabControl1.Controls.Add(this.tpCheck);
            this.tabControl1.Controls.Add(this.tpNakit);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 534);
            this.tabControl1.TabIndex = 2;
            // 
            // tpKredi
            // 
            this.tpKredi.Controls.Add(this.pnlOdemeBilgisi);
            this.tpKredi.Controls.Add(this.panelKart);
            this.tpKredi.Location = new System.Drawing.Point(4, 25);
            this.tpKredi.Name = "tpKredi";
            this.tpKredi.Padding = new System.Windows.Forms.Padding(3);
            this.tpKredi.Size = new System.Drawing.Size(988, 505);
            this.tpKredi.TabIndex = 0;
            this.tpKredi.Text = "Kredi Kartı İle Ödeme Yap";
            this.tpKredi.UseVisualStyleBackColor = true;
            // 
            // pnlOdemeBilgisi
            // 
            this.pnlOdemeBilgisi.Controls.Add(this.btnOdemeYapCard);
            this.pnlOdemeBilgisi.Controls.Add(this.mtbCvv);
            this.pnlOdemeBilgisi.Controls.Add(this.cbYil);
            this.pnlOdemeBilgisi.Controls.Add(this.cbAy);
            this.pnlOdemeBilgisi.Controls.Add(this.mtbKartNo);
            this.pnlOdemeBilgisi.Controls.Add(this.tbAdSoyad);
            this.pnlOdemeBilgisi.Controls.Add(this.label2);
            this.pnlOdemeBilgisi.Controls.Add(this.label5);
            this.pnlOdemeBilgisi.Controls.Add(this.label4);
            this.pnlOdemeBilgisi.Controls.Add(this.label3);
            this.pnlOdemeBilgisi.Location = new System.Drawing.Point(6, 6);
            this.pnlOdemeBilgisi.Name = "pnlOdemeBilgisi";
            this.pnlOdemeBilgisi.Size = new System.Drawing.Size(497, 294);
            this.pnlOdemeBilgisi.TabIndex = 6;
            // 
            // btnOdemeYapCard
            // 
            this.btnOdemeYapCard.BackColor = System.Drawing.Color.LawnGreen;
            this.btnOdemeYapCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOdemeYapCard.Location = new System.Drawing.Point(305, 219);
            this.btnOdemeYapCard.Name = "btnOdemeYapCard";
            this.btnOdemeYapCard.Size = new System.Drawing.Size(189, 72);
            this.btnOdemeYapCard.TabIndex = 11;
            this.btnOdemeYapCard.Text = "Ödeme Yap";
            this.btnOdemeYapCard.UseVisualStyleBackColor = false;
            this.btnOdemeYapCard.Click += new System.EventHandler(this.btnOdemeYapCard_Click);
            // 
            // mtbCvv
            // 
            this.mtbCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbCvv.Location = new System.Drawing.Point(222, 126);
            this.mtbCvv.Mask = "000";
            this.mtbCvv.Name = "mtbCvv";
            this.mtbCvv.Size = new System.Drawing.Size(46, 30);
            this.mtbCvv.TabIndex = 10;
            this.mtbCvv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbCvv_KeyUp);
            // 
            // cbYil
            // 
            this.cbYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Items.AddRange(new object[] {
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.cbYil.Location = new System.Drawing.Point(329, 84);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(82, 33);
            this.cbYil.TabIndex = 9;
            this.cbYil.SelectedIndexChanged += new System.EventHandler(this.cbYil_SelectedIndexChanged);
            // 
            // cbAy
            // 
            this.cbAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbAy.FormattingEnabled = true;
            this.cbAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbAy.Location = new System.Drawing.Point(222, 84);
            this.cbAy.Name = "cbAy";
            this.cbAy.Size = new System.Drawing.Size(82, 33);
            this.cbAy.TabIndex = 8;
            this.cbAy.SelectedIndexChanged += new System.EventHandler(this.cbAy_SelectedIndexChanged);
            // 
            // mtbKartNo
            // 
            this.mtbKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtbKartNo.Location = new System.Drawing.Point(222, 49);
            this.mtbKartNo.Mask = "0000 0000 0000 0000";
            this.mtbKartNo.Name = "mtbKartNo";
            this.mtbKartNo.Size = new System.Drawing.Size(272, 30);
            this.mtbKartNo.TabIndex = 7;
            this.mtbKartNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbKartNo_KeyUp);
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdSoyad.Location = new System.Drawing.Point(222, 11);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(272, 30);
            this.tbAdSoyad.TabIndex = 6;
            this.tbAdSoyad.TextChanged += new System.EventHandler(this.tbAdSoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(20, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD SOYAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(94, 125);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(34, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "KART NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(2, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "S.K.T AY/YIL";
            // 
            // panelKart
            // 
            this.panelKart.BackgroundImage = global::Siparis_Otomasyon.Properties.Resources.credit23;
            this.panelKart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelKart.Controls.Add(this.label8);
            this.panelKart.Controls.Add(this.lCVV);
            this.panelKart.Controls.Add(this.lKartNo);
            this.panelKart.Controls.Add(this.lSKT);
            this.panelKart.Controls.Add(this.label9);
            this.panelKart.Controls.Add(this.lAdSoyad);
            this.panelKart.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelKart.Location = new System.Drawing.Point(511, 3);
            this.panelKart.Name = "panelKart";
            this.panelKart.Size = new System.Drawing.Size(474, 499);
            this.panelKart.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 373);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 360, 20);
            this.label8.Size = new System.Drawing.Size(360, 56);
            this.label8.TabIndex = 6;
            // 
            // lCVV
            // 
            this.lCVV.AutoSize = true;
            this.lCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.lCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lCVV.ForeColor = System.Drawing.Color.White;
            this.lCVV.Location = new System.Drawing.Point(370, 338);
            this.lCVV.Margin = new System.Windows.Forms.Padding(0);
            this.lCVV.Name = "lCVV";
            this.lCVV.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lCVV.Size = new System.Drawing.Size(0, 35);
            this.lCVV.TabIndex = 5;
            // 
            // lKartNo
            // 
            this.lKartNo.AutoSize = true;
            this.lKartNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.lKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lKartNo.ForeColor = System.Drawing.Color.White;
            this.lKartNo.Location = new System.Drawing.Point(54, 128);
            this.lKartNo.Margin = new System.Windows.Forms.Padding(0);
            this.lKartNo.Name = "lKartNo";
            this.lKartNo.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.lKartNo.Size = new System.Drawing.Size(50, 36);
            this.lKartNo.TabIndex = 0;
            // 
            // lSKT
            // 
            this.lSKT.AutoSize = true;
            this.lSKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.lSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSKT.ForeColor = System.Drawing.Color.White;
            this.lSKT.Location = new System.Drawing.Point(277, 164);
            this.lSKT.Margin = new System.Windows.Forms.Padding(0);
            this.lSKT.Name = "lSKT";
            this.lSKT.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.lSKT.Size = new System.Drawing.Size(50, 25);
            this.lSKT.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(167, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.label9.Size = new System.Drawing.Size(89, 36);
            this.label9.TabIndex = 3;
            this.label9.Text = "   ";
            // 
            // lAdSoyad
            // 
            this.lAdSoyad.AutoSize = true;
            this.lAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.lAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lAdSoyad.Location = new System.Drawing.Point(54, 192);
            this.lAdSoyad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lAdSoyad.Name = "lAdSoyad";
            this.lAdSoyad.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.lAdSoyad.Size = new System.Drawing.Size(40, 36);
            this.lAdSoyad.TabIndex = 1;
            // 
            // tpCheck
            // 
            this.tpCheck.Controls.Add(this.panel1);
            this.tpCheck.Controls.Add(this.lBankId);
            this.tpCheck.Controls.Add(this.lAd);
            this.tpCheck.Location = new System.Drawing.Point(4, 25);
            this.tpCheck.Name = "tpCheck";
            this.tpCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheck.Size = new System.Drawing.Size(988, 505);
            this.tpCheck.TabIndex = 1;
            this.tpCheck.Text = "Çek İle Ödeme Yap";
            this.tpCheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBanka);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lSiparisTutari);
            this.panel1.Controls.Add(this.pbCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 499);
            this.panel1.TabIndex = 17;
            // 
            // lblBanka
            // 
            this.lblBanka.AutoSize = true;
            this.lblBanka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.lblBanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBanka.Location = new System.Drawing.Point(238, 338);
            this.lblBanka.Name = "lblBanka";
            this.lblBanka.Size = new System.Drawing.Size(15, 20);
            this.lblBanka.TabIndex = 17;
            this.lblBanka.Tag = "";
            this.lblBanka.Text = "-";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAd.Location = new System.Drawing.Point(161, 309);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(15, 20);
            this.lblAd.TabIndex = 16;
            this.lblAd.Tag = "";
            this.lblAd.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbBanka);
            this.panel2.Controls.Add(this.btnOdemeYapCheck);
            this.panel2.Controls.Add(this.tbAd);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 220);
            this.panel2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(25, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "AD SOYAD:";
            // 
            // tbBanka
            // 
            this.tbBanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbBanka.Location = new System.Drawing.Point(148, 64);
            this.tbBanka.Name = "tbBanka";
            this.tbBanka.Size = new System.Drawing.Size(371, 34);
            this.tbBanka.TabIndex = 14;
            this.tbBanka.TextChanged += new System.EventHandler(this.tbBanka_TextChanged);
            // 
            // btnOdemeYapCheck
            // 
            this.btnOdemeYapCheck.BackColor = System.Drawing.Color.Lime;
            this.btnOdemeYapCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOdemeYapCheck.Location = new System.Drawing.Point(471, 156);
            this.btnOdemeYapCheck.Name = "btnOdemeYapCheck";
            this.btnOdemeYapCheck.Size = new System.Drawing.Size(213, 61);
            this.btnOdemeYapCheck.TabIndex = 5;
            this.btnOdemeYapCheck.Text = "Ödeme Yap";
            this.btnOdemeYapCheck.UseVisualStyleBackColor = false;
            this.btnOdemeYapCheck.Click += new System.EventHandler(this.btnOdemeYapCheck_Click);
            // 
            // tbAd
            // 
            this.tbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbAd.Location = new System.Drawing.Point(148, 13);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(371, 34);
            this.tbAd.TabIndex = 13;
            this.tbAd.TextChanged += new System.EventHandler(this.tbAd_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(55, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "BANKA:";
            // 
            // lSiparisTutari
            // 
            this.lSiparisTutari.AutoSize = true;
            this.lSiparisTutari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.lSiparisTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lSiparisTutari.Location = new System.Drawing.Point(642, 366);
            this.lSiparisTutari.Name = "lSiparisTutari";
            this.lSiparisTutari.Size = new System.Drawing.Size(15, 20);
            this.lSiparisTutari.TabIndex = 10;
            this.lSiparisTutari.Tag = "";
            this.lSiparisTutari.Text = "-";
            // 
            // pbCheck
            // 
            this.pbCheck.Image = global::Siparis_Otomasyon.Properties.Resources.check2;
            this.pbCheck.Location = new System.Drawing.Point(3, 239);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(817, 254);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheck.TabIndex = 6;
            this.pbCheck.TabStop = false;
            // 
            // lBankId
            // 
            this.lBankId.AutoSize = true;
            this.lBankId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.lBankId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lBankId.Location = new System.Drawing.Point(331, 341);
            this.lBankId.Name = "lBankId";
            this.lBankId.Size = new System.Drawing.Size(0, 20);
            this.lBankId.TabIndex = 9;
            this.lBankId.Tag = "";
            // 
            // lAd
            // 
            this.lAd.AutoSize = true;
            this.lAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(124)))));
            this.lAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lAd.Location = new System.Drawing.Point(232, 312);
            this.lAd.Name = "lAd";
            this.lAd.Size = new System.Drawing.Size(0, 20);
            this.lAd.TabIndex = 8;
            this.lAd.Tag = "";
            // 
            // tpNakit
            // 
            this.tpNakit.Controls.Add(this.chckbxElden);
            this.tpNakit.Controls.Add(this.btnEldenOdeme);
            this.tpNakit.Location = new System.Drawing.Point(4, 25);
            this.tpNakit.Name = "tpNakit";
            this.tpNakit.Size = new System.Drawing.Size(988, 505);
            this.tpNakit.TabIndex = 2;
            this.tpNakit.Text = "Nakit Ödeme";
            this.tpNakit.UseVisualStyleBackColor = true;
            // 
            // chckbxElden
            // 
            this.chckbxElden.AutoSize = true;
            this.chckbxElden.Location = new System.Drawing.Point(409, 208);
            this.chckbxElden.Name = "chckbxElden";
            this.chckbxElden.Size = new System.Drawing.Size(230, 20);
            this.chckbxElden.TabIndex = 5;
            this.chckbxElden.Text = "Nakit (Elden) Ödeme Yapacağım.";
            this.chckbxElden.UseVisualStyleBackColor = true;
            // 
            // btnEldenOdeme
            // 
            this.btnEldenOdeme.BackColor = System.Drawing.Color.Lime;
            this.btnEldenOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEldenOdeme.Location = new System.Drawing.Point(409, 234);
            this.btnEldenOdeme.Name = "btnEldenOdeme";
            this.btnEldenOdeme.Size = new System.Drawing.Size(213, 61);
            this.btnEldenOdeme.TabIndex = 6;
            this.btnEldenOdeme.Text = "Elden Ödeme";
            this.btnEldenOdeme.UseVisualStyleBackColor = false;
            this.btnEldenOdeme.Click += new System.EventHandler(this.btnEldenOdeme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // OdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1009, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnIptal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OdemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeme Ekranı";
            this.Load += new System.EventHandler(this.OdemeEkrani_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpKredi.ResumeLayout(false);
            this.pnlOdemeBilgisi.ResumeLayout(false);
            this.pnlOdemeBilgisi.PerformLayout();
            this.panelKart.ResumeLayout(false);
            this.panelKart.PerformLayout();
            this.tpCheck.ResumeLayout(false);
            this.tpCheck.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.tpNakit.ResumeLayout(false);
            this.tpNakit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpKredi;
        private System.Windows.Forms.TabPage tpCheck;
        private System.Windows.Forms.Button btnOdemeYapCheck;
        private System.Windows.Forms.Panel panelKart;
        private System.Windows.Forms.Panel pnlOdemeBilgisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpNakit;
        private System.Windows.Forms.CheckBox chckbxElden;
        private System.Windows.Forms.Button btnEldenOdeme;
        private System.Windows.Forms.MaskedTextBox mtbCvv;
        private System.Windows.Forms.ComboBox cbYil;
        private System.Windows.Forms.ComboBox cbAy;
        private System.Windows.Forms.MaskedTextBox mtbKartNo;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label lKartNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lCVV;
        private System.Windows.Forms.Label lSKT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lAdSoyad;
        private System.Windows.Forms.Button btnOdemeYapCard;
        private System.Windows.Forms.TextBox tbBanka;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lSiparisTutari;
        private System.Windows.Forms.Label lBankId;
        private System.Windows.Forms.Label lAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBanka;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}