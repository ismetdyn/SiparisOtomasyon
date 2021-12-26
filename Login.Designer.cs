namespace Siparis_Otomasyon
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lAd = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lnkLblYeniKullanici = new System.Windows.Forms.LinkLabel();
            this.lSifre = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.cbBeniHatirla = new System.Windows.Forms.CheckBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(142, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesabınıza Giriş Yapınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lAd
            // 
            this.lAd.AutoSize = true;
            this.lAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lAd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lAd.Location = new System.Drawing.Point(249, 109);
            this.lAd.Name = "lAd";
            this.lAd.Size = new System.Drawing.Size(37, 25);
            this.lAd.TabIndex = 0;
            this.lAd.Text = "Ad";
            // 
            // tbAd
            // 
            this.tbAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbAd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAd.Location = new System.Drawing.Point(96, 145);
            this.tbAd.MaxLength = 20;
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(346, 36);
            this.tbAd.TabIndex = 1;
            this.tbAd.WordWrap = false;
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(96, 324);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(179, 57);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lnkLblYeniKullanici
            // 
            this.lnkLblYeniKullanici.AutoSize = true;
            this.lnkLblYeniKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnkLblYeniKullanici.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLblYeniKullanici.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkLblYeniKullanici.Location = new System.Drawing.Point(207, 507);
            this.lnkLblYeniKullanici.Name = "lnkLblYeniKullanici";
            this.lnkLblYeniKullanici.Size = new System.Drawing.Size(94, 25);
            this.lnkLblYeniKullanici.TabIndex = 4;
            this.lnkLblYeniKullanici.TabStop = true;
            this.lnkLblYeniKullanici.Text = "KAYDOL";
            this.lnkLblYeniKullanici.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblYeniKullanici_LinkClicked);
            // 
            // lSifre
            // 
            this.lSifre.AutoSize = true;
            this.lSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSifre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lSifre.Location = new System.Drawing.Point(249, 221);
            this.lSifre.Name = "lSifre";
            this.lSifre.Size = new System.Drawing.Size(52, 25);
            this.lSifre.TabIndex = 7;
            this.lSifre.Text = "Şifre";
            // 
            // tbSifre
            // 
            this.tbSifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSifre.BackColor = System.Drawing.SystemColors.Window;
            this.tbSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSifre.Location = new System.Drawing.Point(96, 261);
            this.tbSifre.MaxLength = 20;
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.ShortcutsEnabled = false;
            this.tbSifre.Size = new System.Drawing.Size(346, 36);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // cbBeniHatirla
            // 
            this.cbBeniHatirla.AutoSize = true;
            this.cbBeniHatirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBeniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBeniHatirla.Location = new System.Drawing.Point(297, 361);
            this.cbBeniHatirla.Name = "cbBeniHatirla";
            this.cbBeniHatirla.Size = new System.Drawing.Size(98, 20);
            this.cbBeniHatirla.TabIndex = 8;
            this.cbBeniHatirla.Text = "Beni Hatırla";
            this.cbBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCikis.Location = new System.Drawing.Point(96, 397);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(179, 57);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(520, 605);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.cbBeniHatirla);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.lSifre);
            this.Controls.Add(this.lnkLblYeniKullanici);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.lAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(520, 605);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 605);
            this.Name = "Login";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Girişi";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lAd;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel lnkLblYeniKullanici;
        private System.Windows.Forms.Label lSifre;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.CheckBox cbBeniHatirla;
        private System.Windows.Forms.Button btnCikis;
    }
}

