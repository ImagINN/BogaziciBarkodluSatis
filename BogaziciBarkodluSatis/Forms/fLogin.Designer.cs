namespace BogaziciBarkodluSatis.Forms
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_girisYap = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.txt_sifre = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.txt_kullaniciAdi = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_sifre = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_kullaniciAdi = new BogaziciBarkodluSatis.lblStandart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BogaziciBarkodluSatis.Properties.Resources.bogaziciLogo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_girisYap);
            this.panel1.Controls.Add(this.txt_sifre);
            this.panel1.Controls.Add(this.txt_kullaniciAdi);
            this.panel1.Controls.Add(this.lbl_sifre);
            this.panel1.Controls.Add(this.lbl_kullaniciAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 160);
            this.panel1.TabIndex = 1;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_girisYap.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_girisYap.BorderColor = System.Drawing.Color.Black;
            this.btn_girisYap.BorderRadius = 15;
            this.btn_girisYap.BorderSize = 1;
            this.btn_girisYap.FlatAppearance.BorderSize = 0;
            this.btn_girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_girisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisYap.ForeColor = System.Drawing.Color.White;
            this.btn_girisYap.Location = new System.Drawing.Point(242, 42);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(117, 110);
            this.btn_girisYap.TabIndex = 2;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.TextColor = System.Drawing.Color.White;
            this.btn_girisYap.UseVisualStyleBackColor = false;
            this.btn_girisYap.Click += new System.EventHandler(this.cntrlButton1_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.White;
            this.txt_sifre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sifre.BorderFocusColor = System.Drawing.Color.Black;
            this.txt_sifre.BorderSize = 2;
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sifre.Location = new System.Drawing.Point(13, 119);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre.Multiline = false;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_sifre.PasswordChar = true;
            this.txt_sifre.ReadOnly = false;
            this.txt_sifre.Size = new System.Drawing.Size(220, 33);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.Texts = "";
            this.txt_sifre.UnderlinedStyle = false;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txt_kullaniciAdi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_kullaniciAdi.BorderFocusColor = System.Drawing.Color.Black;
            this.txt_kullaniciAdi.BorderSize = 2;
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(15, 42);
            this.txt_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullaniciAdi.Multiline = false;
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_kullaniciAdi.PasswordChar = false;
            this.txt_kullaniciAdi.ReadOnly = false;
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(220, 33);
            this.txt_kullaniciAdi.TabIndex = 0;
            this.txt_kullaniciAdi.Texts = "";
            this.txt_kullaniciAdi.UnderlinedStyle = false;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_sifre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_sifre.Location = new System.Drawing.Point(10, 90);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(52, 25);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre";
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_kullaniciAdi.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(10, 13);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(119, 25);
            this.lbl_kullaniciAdi.TabIndex = 0;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(372, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI GİRİŞ SAYFASI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private lblStandart lbl_kullaniciAdi;
        private Controls.CntrlTextBox txt_sifre;
        private Controls.CntrlTextBox txt_kullaniciAdi;
        private lblStandart lbl_sifre;
        private Controls.CntrlButton btn_girisYap;
    }
}