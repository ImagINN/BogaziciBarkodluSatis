namespace BogaziciBarkodluSatis.Forms
{
    partial class fRapor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRapor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_gosterim = new System.Windows.Forms.Panel();
            this.txt_giderNakit = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_ekGelirNakit = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_giderKart = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_satisNakit = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_ekGelirKart = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_satisKart = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_aboneSayisi = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_kayip = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.lbl_satısGelirToplam = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_abonelik = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_iade = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_ekGelir = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_gider = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_satısGelirNakit = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_kayıp = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_ekGelirNakit = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_giderNakit = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_satısGelirKart = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_ekGelirKart = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_abonelikSayısı = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_giderKart = new BogaziciBarkodluSatis.lblStandart();
            this.pnl_raporAl = new System.Windows.Forms.Panel();
            this.btn_raporAl = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.pnl_date = new System.Windows.Forms.Panel();
            this.lbl_baslangıc = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_bitis = new BogaziciBarkodluSatis.lblStandart();
            this.date_baslangic = new BogaziciBarkodluSatis.Controls.CntrlDatePicker();
            this.date_bitis = new BogaziciBarkodluSatis.Controls.CntrlDatePicker();
            this.btn_listele = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.pnl_filtreleme = new System.Windows.Forms.Panel();
            this.lbl_giderTuru = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_abonelikTuru = new BogaziciBarkodluSatis.lblStandart();
            this.rb_abonelikler = new System.Windows.Forms.RadioButton();
            this.rb_gider = new System.Windows.Forms.RadioButton();
            this.cmb_giderTuru = new System.Windows.Forms.ComboBox();
            this.cmb_abonelikTuru = new System.Windows.Forms.ComboBox();
            this.rb_ekGelir = new System.Windows.Forms.RadioButton();
            this.lbl_odemeTürü = new BogaziciBarkodluSatis.lblStandart();
            this.rb_iade = new System.Windows.Forms.RadioButton();
            this.cmb_odemeTuru = new System.Windows.Forms.ComboBox();
            this.rb_satıslar = new System.Windows.Forms.RadioButton();
            this.rb_tumu = new System.Windows.Forms.RadioButton();
            this.lbl_filtrelemeTuru = new BogaziciBarkodluSatis.lblStandart();
            this.grd_list = new BogaziciBarkodluSatis.grdOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_gosterim.SuspendLayout();
            this.pnl_raporAl.SuspendLayout();
            this.pnl_date.SuspendLayout();
            this.pnl_filtreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_list)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl_gosterim);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_raporAl);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_date);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_filtreleme);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grd_list);
            this.splitContainer1.Size = new System.Drawing.Size(1524, 821);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnl_gosterim
            // 
            this.pnl_gosterim.Controls.Add(this.txt_giderNakit);
            this.pnl_gosterim.Controls.Add(this.txt_ekGelirNakit);
            this.pnl_gosterim.Controls.Add(this.txt_giderKart);
            this.pnl_gosterim.Controls.Add(this.txt_satisNakit);
            this.pnl_gosterim.Controls.Add(this.txt_ekGelirKart);
            this.pnl_gosterim.Controls.Add(this.txt_satisKart);
            this.pnl_gosterim.Controls.Add(this.txt_aboneSayisi);
            this.pnl_gosterim.Controls.Add(this.txt_kayip);
            this.pnl_gosterim.Controls.Add(this.lbl_satısGelirToplam);
            this.pnl_gosterim.Controls.Add(this.lbl_abonelik);
            this.pnl_gosterim.Controls.Add(this.lbl_iade);
            this.pnl_gosterim.Controls.Add(this.lbl_ekGelir);
            this.pnl_gosterim.Controls.Add(this.lbl_gider);
            this.pnl_gosterim.Controls.Add(this.lbl_satısGelirNakit);
            this.pnl_gosterim.Controls.Add(this.lbl_kayıp);
            this.pnl_gosterim.Controls.Add(this.lbl_ekGelirNakit);
            this.pnl_gosterim.Controls.Add(this.lbl_giderNakit);
            this.pnl_gosterim.Controls.Add(this.lbl_satısGelirKart);
            this.pnl_gosterim.Controls.Add(this.lbl_ekGelirKart);
            this.pnl_gosterim.Controls.Add(this.lbl_abonelikSayısı);
            this.pnl_gosterim.Controls.Add(this.lbl_giderKart);
            this.pnl_gosterim.Location = new System.Drawing.Point(656, 0);
            this.pnl_gosterim.Name = "pnl_gosterim";
            this.pnl_gosterim.Size = new System.Drawing.Size(660, 302);
            this.pnl_gosterim.TabIndex = 27;
            // 
            // txt_giderNakit
            // 
            this.txt_giderNakit.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_giderNakit.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_giderNakit.BorderSize = 2;
            this.txt_giderNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_giderNakit.Location = new System.Drawing.Point(306, 144);
            this.txt_giderNakit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giderNakit.Multiline = false;
            this.txt_giderNakit.Name = "txt_giderNakit";
            this.txt_giderNakit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_giderNakit.PasswordChar = false;
            this.txt_giderNakit.ReadOnly = true;
            this.txt_giderNakit.Size = new System.Drawing.Size(118, 33);
            this.txt_giderNakit.TabIndex = 26;
            this.txt_giderNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_giderNakit.Texts = "";
            this.txt_giderNakit.UnderlinedStyle = false;
            // 
            // txt_ekGelirNakit
            // 
            this.txt_ekGelirNakit.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_ekGelirNakit.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_ekGelirNakit.BorderSize = 2;
            this.txt_ekGelirNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ekGelirNakit.Location = new System.Drawing.Point(306, 40);
            this.txt_ekGelirNakit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ekGelirNakit.Multiline = false;
            this.txt_ekGelirNakit.Name = "txt_ekGelirNakit";
            this.txt_ekGelirNakit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ekGelirNakit.PasswordChar = false;
            this.txt_ekGelirNakit.ReadOnly = true;
            this.txt_ekGelirNakit.Size = new System.Drawing.Size(118, 33);
            this.txt_ekGelirNakit.TabIndex = 26;
            this.txt_ekGelirNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ekGelirNakit.Texts = "";
            this.txt_ekGelirNakit.UnderlinedStyle = false;
            // 
            // txt_giderKart
            // 
            this.txt_giderKart.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_giderKart.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_giderKart.BorderSize = 2;
            this.txt_giderKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_giderKart.Location = new System.Drawing.Point(306, 181);
            this.txt_giderKart.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giderKart.Multiline = false;
            this.txt_giderKart.Name = "txt_giderKart";
            this.txt_giderKart.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_giderKart.PasswordChar = false;
            this.txt_giderKart.ReadOnly = true;
            this.txt_giderKart.Size = new System.Drawing.Size(118, 33);
            this.txt_giderKart.TabIndex = 26;
            this.txt_giderKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_giderKart.Texts = "";
            this.txt_giderKart.UnderlinedStyle = false;
            // 
            // txt_satisNakit
            // 
            this.txt_satisNakit.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_satisNakit.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_satisNakit.BorderSize = 2;
            this.txt_satisNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_satisNakit.Location = new System.Drawing.Point(119, 40);
            this.txt_satisNakit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_satisNakit.Multiline = false;
            this.txt_satisNakit.Name = "txt_satisNakit";
            this.txt_satisNakit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_satisNakit.PasswordChar = false;
            this.txt_satisNakit.ReadOnly = true;
            this.txt_satisNakit.Size = new System.Drawing.Size(118, 33);
            this.txt_satisNakit.TabIndex = 26;
            this.txt_satisNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_satisNakit.Texts = "";
            this.txt_satisNakit.UnderlinedStyle = false;
            // 
            // txt_ekGelirKart
            // 
            this.txt_ekGelirKart.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_ekGelirKart.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_ekGelirKart.BorderSize = 2;
            this.txt_ekGelirKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ekGelirKart.Location = new System.Drawing.Point(306, 77);
            this.txt_ekGelirKart.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ekGelirKart.Multiline = false;
            this.txt_ekGelirKart.Name = "txt_ekGelirKart";
            this.txt_ekGelirKart.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ekGelirKart.PasswordChar = false;
            this.txt_ekGelirKart.ReadOnly = true;
            this.txt_ekGelirKart.Size = new System.Drawing.Size(118, 33);
            this.txt_ekGelirKart.TabIndex = 26;
            this.txt_ekGelirKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ekGelirKart.Texts = "";
            this.txt_ekGelirKart.UnderlinedStyle = false;
            // 
            // txt_satisKart
            // 
            this.txt_satisKart.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_satisKart.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_satisKart.BorderSize = 2;
            this.txt_satisKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_satisKart.Location = new System.Drawing.Point(119, 77);
            this.txt_satisKart.Margin = new System.Windows.Forms.Padding(4);
            this.txt_satisKart.Multiline = false;
            this.txt_satisKart.Name = "txt_satisKart";
            this.txt_satisKart.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_satisKart.PasswordChar = false;
            this.txt_satisKart.ReadOnly = true;
            this.txt_satisKart.Size = new System.Drawing.Size(118, 33);
            this.txt_satisKart.TabIndex = 26;
            this.txt_satisKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_satisKart.Texts = "";
            this.txt_satisKart.UnderlinedStyle = false;
            // 
            // txt_aboneSayisi
            // 
            this.txt_aboneSayisi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_aboneSayisi.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_aboneSayisi.BorderSize = 2;
            this.txt_aboneSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aboneSayisi.Location = new System.Drawing.Point(119, 138);
            this.txt_aboneSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aboneSayisi.Multiline = false;
            this.txt_aboneSayisi.Name = "txt_aboneSayisi";
            this.txt_aboneSayisi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_aboneSayisi.PasswordChar = false;
            this.txt_aboneSayisi.ReadOnly = true;
            this.txt_aboneSayisi.Size = new System.Drawing.Size(118, 33);
            this.txt_aboneSayisi.TabIndex = 26;
            this.txt_aboneSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_aboneSayisi.Texts = "";
            this.txt_aboneSayisi.UnderlinedStyle = false;
            // 
            // txt_kayip
            // 
            this.txt_kayip.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_kayip.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_kayip.BorderSize = 2;
            this.txt_kayip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayip.Location = new System.Drawing.Point(119, 196);
            this.txt_kayip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kayip.Multiline = false;
            this.txt_kayip.Name = "txt_kayip";
            this.txt_kayip.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_kayip.PasswordChar = false;
            this.txt_kayip.ReadOnly = true;
            this.txt_kayip.Size = new System.Drawing.Size(118, 33);
            this.txt_kayip.TabIndex = 13;
            this.txt_kayip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kayip.Texts = "";
            this.txt_kayip.UnderlinedStyle = false;
            // 
            // lbl_satısGelirToplam
            // 
            this.lbl_satısGelirToplam.AutoSize = true;
            this.lbl_satısGelirToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_satısGelirToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_satısGelirToplam.Location = new System.Drawing.Point(104, 8);
            this.lbl_satısGelirToplam.Name = "lbl_satısGelirToplam";
            this.lbl_satısGelirToplam.Size = new System.Drawing.Size(141, 20);
            this.lbl_satısGelirToplam.TabIndex = 13;
            this.lbl_satısGelirToplam.Text = "Satış Gelir Toplamı";
            // 
            // lbl_abonelik
            // 
            this.lbl_abonelik.AutoSize = true;
            this.lbl_abonelik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_abonelik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_abonelik.Location = new System.Drawing.Point(143, 114);
            this.lbl_abonelik.Name = "lbl_abonelik";
            this.lbl_abonelik.Size = new System.Drawing.Size(70, 20);
            this.lbl_abonelik.TabIndex = 25;
            this.lbl_abonelik.Text = "Abonelik";
            // 
            // lbl_iade
            // 
            this.lbl_iade.AutoSize = true;
            this.lbl_iade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_iade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_iade.Location = new System.Drawing.Point(156, 175);
            this.lbl_iade.Name = "lbl_iade";
            this.lbl_iade.Size = new System.Drawing.Size(41, 20);
            this.lbl_iade.TabIndex = 13;
            this.lbl_iade.Text = "İade";
            // 
            // lbl_ekGelir
            // 
            this.lbl_ekGelir.AutoSize = true;
            this.lbl_ekGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ekGelir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ekGelir.Location = new System.Drawing.Point(339, 12);
            this.lbl_ekGelir.Name = "lbl_ekGelir";
            this.lbl_ekGelir.Size = new System.Drawing.Size(65, 20);
            this.lbl_ekGelir.TabIndex = 13;
            this.lbl_ekGelir.Text = "Ek Gelir";
            // 
            // lbl_gider
            // 
            this.lbl_gider.AutoSize = true;
            this.lbl_gider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_gider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_gider.Location = new System.Drawing.Point(339, 114);
            this.lbl_gider.Name = "lbl_gider";
            this.lbl_gider.Size = new System.Drawing.Size(48, 20);
            this.lbl_gider.TabIndex = 13;
            this.lbl_gider.Text = "Gider";
            // 
            // lbl_satısGelirNakit
            // 
            this.lbl_satısGelirNakit.AutoSize = true;
            this.lbl_satısGelirNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_satısGelirNakit.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_satısGelirNakit.Location = new System.Drawing.Point(67, 45);
            this.lbl_satısGelirNakit.Name = "lbl_satısGelirNakit";
            this.lbl_satısGelirNakit.Size = new System.Drawing.Size(49, 20);
            this.lbl_satısGelirNakit.TabIndex = 14;
            this.lbl_satısGelirNakit.Text = "Nakit:";
            this.lbl_satısGelirNakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_kayıp
            // 
            this.lbl_kayıp.AutoSize = true;
            this.lbl_kayıp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_kayıp.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_kayıp.Location = new System.Drawing.Point(61, 201);
            this.lbl_kayıp.Name = "lbl_kayıp";
            this.lbl_kayıp.Size = new System.Drawing.Size(51, 20);
            this.lbl_kayıp.TabIndex = 14;
            this.lbl_kayıp.Text = "Kayıp:";
            this.lbl_kayıp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ekGelirNakit
            // 
            this.lbl_ekGelirNakit.AutoSize = true;
            this.lbl_ekGelirNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ekGelirNakit.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_ekGelirNakit.Location = new System.Drawing.Point(260, 44);
            this.lbl_ekGelirNakit.Name = "lbl_ekGelirNakit";
            this.lbl_ekGelirNakit.Size = new System.Drawing.Size(49, 20);
            this.lbl_ekGelirNakit.TabIndex = 14;
            this.lbl_ekGelirNakit.Text = "Nakit:";
            // 
            // lbl_giderNakit
            // 
            this.lbl_giderNakit.AutoSize = true;
            this.lbl_giderNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_giderNakit.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_giderNakit.Location = new System.Drawing.Point(260, 144);
            this.lbl_giderNakit.Name = "lbl_giderNakit";
            this.lbl_giderNakit.Size = new System.Drawing.Size(49, 20);
            this.lbl_giderNakit.TabIndex = 14;
            this.lbl_giderNakit.Text = "Nakit:";
            this.lbl_giderNakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_satısGelirKart
            // 
            this.lbl_satısGelirKart.AutoSize = true;
            this.lbl_satısGelirKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_satısGelirKart.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_satısGelirKart.Location = new System.Drawing.Point(74, 83);
            this.lbl_satısGelirKart.Name = "lbl_satısGelirKart";
            this.lbl_satısGelirKart.Size = new System.Drawing.Size(42, 20);
            this.lbl_satısGelirKart.TabIndex = 15;
            this.lbl_satısGelirKart.Text = "Kart:";
            this.lbl_satısGelirKart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ekGelirKart
            // 
            this.lbl_ekGelirKart.AutoSize = true;
            this.lbl_ekGelirKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ekGelirKart.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_ekGelirKart.Location = new System.Drawing.Point(267, 83);
            this.lbl_ekGelirKart.Name = "lbl_ekGelirKart";
            this.lbl_ekGelirKart.Size = new System.Drawing.Size(42, 20);
            this.lbl_ekGelirKart.TabIndex = 15;
            this.lbl_ekGelirKart.Text = "Kart:";
            // 
            // lbl_abonelikSayısı
            // 
            this.lbl_abonelikSayısı.AutoSize = true;
            this.lbl_abonelikSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_abonelikSayısı.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_abonelikSayısı.Location = new System.Drawing.Point(7, 145);
            this.lbl_abonelikSayısı.Name = "lbl_abonelikSayısı";
            this.lbl_abonelikSayısı.Size = new System.Drawing.Size(105, 20);
            this.lbl_abonelikSayısı.TabIndex = 22;
            this.lbl_abonelikSayısı.Text = "Abone Sayısı:";
            this.lbl_abonelikSayısı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_giderKart
            // 
            this.lbl_giderKart.AutoSize = true;
            this.lbl_giderKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_giderKart.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_giderKart.Location = new System.Drawing.Point(264, 183);
            this.lbl_giderKart.Name = "lbl_giderKart";
            this.lbl_giderKart.Size = new System.Drawing.Size(42, 20);
            this.lbl_giderKart.TabIndex = 15;
            this.lbl_giderKart.Text = "Kart:";
            this.lbl_giderKart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_raporAl
            // 
            this.pnl_raporAl.Controls.Add(this.btn_raporAl);
            this.pnl_raporAl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_raporAl.Location = new System.Drawing.Point(1324, 0);
            this.pnl_raporAl.Name = "pnl_raporAl";
            this.pnl_raporAl.Size = new System.Drawing.Size(200, 302);
            this.pnl_raporAl.TabIndex = 26;
            // 
            // btn_raporAl
            // 
            this.btn_raporAl.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_raporAl.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_raporAl.BorderColor = System.Drawing.Color.Black;
            this.btn_raporAl.BorderRadius = 40;
            this.btn_raporAl.BorderSize = 0;
            this.btn_raporAl.FlatAppearance.BorderSize = 0;
            this.btn_raporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporAl.ForeColor = System.Drawing.Color.White;
            this.btn_raporAl.Image = global::BogaziciBarkodluSatis.Properties.Resources.export__2_;
            this.btn_raporAl.Location = new System.Drawing.Point(3, 178);
            this.btn_raporAl.Name = "btn_raporAl";
            this.btn_raporAl.Size = new System.Drawing.Size(170, 120);
            this.btn_raporAl.TabIndex = 34;
            this.btn_raporAl.Text = "Rapor Al";
            this.btn_raporAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raporAl.TextColor = System.Drawing.Color.White;
            this.btn_raporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_raporAl.UseVisualStyleBackColor = false;
            // 
            // pnl_date
            // 
            this.pnl_date.Controls.Add(this.lbl_baslangıc);
            this.pnl_date.Controls.Add(this.lbl_bitis);
            this.pnl_date.Controls.Add(this.date_baslangic);
            this.pnl_date.Controls.Add(this.date_bitis);
            this.pnl_date.Controls.Add(this.btn_listele);
            this.pnl_date.Location = new System.Drawing.Point(242, 3);
            this.pnl_date.Name = "pnl_date";
            this.pnl_date.Size = new System.Drawing.Size(408, 299);
            this.pnl_date.TabIndex = 21;
            // 
            // lbl_baslangıc
            // 
            this.lbl_baslangıc.AutoSize = true;
            this.lbl_baslangıc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslangıc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_baslangıc.Location = new System.Drawing.Point(9, 9);
            this.lbl_baslangıc.Name = "lbl_baslangıc";
            this.lbl_baslangıc.Size = new System.Drawing.Size(143, 24);
            this.lbl_baslangıc.TabIndex = 8;
            this.lbl_baslangıc.Text = "Başlangıc Tarihi";
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_bitis.Location = new System.Drawing.Point(9, 80);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(95, 24);
            this.lbl_bitis.TabIndex = 9;
            this.lbl_bitis.Text = "Bitiş Tarihi";
            // 
            // date_baslangic
            // 
            this.date_baslangic.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.date_baslangic.BorderSize = 2;
            this.date_baslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_baslangic.Location = new System.Drawing.Point(14, 37);
            this.date_baslangic.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_baslangic.Name = "date_baslangic";
            this.date_baslangic.Size = new System.Drawing.Size(252, 35);
            this.date_baslangic.SkinColor = System.Drawing.Color.Silver;
            this.date_baslangic.TabIndex = 9;
            this.date_baslangic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // date_bitis
            // 
            this.date_bitis.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.date_bitis.BorderSize = 2;
            this.date_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_bitis.Location = new System.Drawing.Point(14, 108);
            this.date_bitis.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_bitis.Name = "date_bitis";
            this.date_bitis.Size = new System.Drawing.Size(252, 35);
            this.date_bitis.SkinColor = System.Drawing.Color.Silver;
            this.date_bitis.TabIndex = 10;
            this.date_bitis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_listele.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_listele.BorderColor = System.Drawing.Color.Black;
            this.btn_listele.BorderRadius = 40;
            this.btn_listele.BorderSize = 0;
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.Image = global::BogaziciBarkodluSatis.Properties.Resources.list32;
            this.btn_listele.Location = new System.Drawing.Point(272, 37);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(122, 106);
            this.btn_listele.TabIndex = 11;
            this.btn_listele.Text = "Listele";
            this.btn_listele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_listele.TextColor = System.Drawing.Color.White;
            this.btn_listele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_listele.UseVisualStyleBackColor = false;
            // 
            // pnl_filtreleme
            // 
            this.pnl_filtreleme.Controls.Add(this.lbl_giderTuru);
            this.pnl_filtreleme.Controls.Add(this.lbl_abonelikTuru);
            this.pnl_filtreleme.Controls.Add(this.rb_abonelikler);
            this.pnl_filtreleme.Controls.Add(this.rb_gider);
            this.pnl_filtreleme.Controls.Add(this.cmb_giderTuru);
            this.pnl_filtreleme.Controls.Add(this.cmb_abonelikTuru);
            this.pnl_filtreleme.Controls.Add(this.rb_ekGelir);
            this.pnl_filtreleme.Controls.Add(this.lbl_odemeTürü);
            this.pnl_filtreleme.Controls.Add(this.rb_iade);
            this.pnl_filtreleme.Controls.Add(this.cmb_odemeTuru);
            this.pnl_filtreleme.Controls.Add(this.rb_satıslar);
            this.pnl_filtreleme.Controls.Add(this.rb_tumu);
            this.pnl_filtreleme.Controls.Add(this.lbl_filtrelemeTuru);
            this.pnl_filtreleme.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_filtreleme.Location = new System.Drawing.Point(0, 0);
            this.pnl_filtreleme.Name = "pnl_filtreleme";
            this.pnl_filtreleme.Size = new System.Drawing.Size(236, 302);
            this.pnl_filtreleme.TabIndex = 20;
            // 
            // lbl_giderTuru
            // 
            this.lbl_giderTuru.AutoSize = true;
            this.lbl_giderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_giderTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_giderTuru.Location = new System.Drawing.Point(12, 241);
            this.lbl_giderTuru.Name = "lbl_giderTuru";
            this.lbl_giderTuru.Size = new System.Drawing.Size(84, 20);
            this.lbl_giderTuru.TabIndex = 7;
            this.lbl_giderTuru.Text = "Gider Türü";
            // 
            // lbl_abonelikTuru
            // 
            this.lbl_abonelikTuru.AutoSize = true;
            this.lbl_abonelikTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_abonelikTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_abonelikTuru.Location = new System.Drawing.Point(12, 191);
            this.lbl_abonelikTuru.Name = "lbl_abonelikTuru";
            this.lbl_abonelikTuru.Size = new System.Drawing.Size(106, 20);
            this.lbl_abonelikTuru.TabIndex = 7;
            this.lbl_abonelikTuru.Text = "Abonelik Türü";
            // 
            // rb_abonelikler
            // 
            this.rb_abonelikler.AutoSize = true;
            this.rb_abonelikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_abonelikler.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_abonelikler.Location = new System.Drawing.Point(121, 103);
            this.rb_abonelikler.Name = "rb_abonelikler";
            this.rb_abonelikler.Size = new System.Drawing.Size(105, 24);
            this.rb_abonelikler.TabIndex = 5;
            this.rb_abonelikler.Text = "Abonelikler";
            this.rb_abonelikler.UseVisualStyleBackColor = true;
            // 
            // rb_gider
            // 
            this.rb_gider.AutoSize = true;
            this.rb_gider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_gider.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_gider.Location = new System.Drawing.Point(121, 73);
            this.rb_gider.Name = "rb_gider";
            this.rb_gider.Size = new System.Drawing.Size(83, 24);
            this.rb_gider.TabIndex = 4;
            this.rb_gider.Text = "Giderler";
            this.rb_gider.UseVisualStyleBackColor = true;
            // 
            // cmb_giderTuru
            // 
            this.cmb_giderTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_giderTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_giderTuru.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_giderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_giderTuru.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmb_giderTuru.FormattingEnabled = true;
            this.cmb_giderTuru.Items.AddRange(new object[] {
            "Tümü"});
            this.cmb_giderTuru.Location = new System.Drawing.Point(16, 264);
            this.cmb_giderTuru.Name = "cmb_giderTuru";
            this.cmb_giderTuru.Size = new System.Drawing.Size(134, 24);
            this.cmb_giderTuru.TabIndex = 8;
            this.cmb_giderTuru.Text = "Tümü";
            // 
            // cmb_abonelikTuru
            // 
            this.cmb_abonelikTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_abonelikTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_abonelikTuru.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_abonelikTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_abonelikTuru.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmb_abonelikTuru.FormattingEnabled = true;
            this.cmb_abonelikTuru.Items.AddRange(new object[] {
            "Tümü"});
            this.cmb_abonelikTuru.Location = new System.Drawing.Point(16, 214);
            this.cmb_abonelikTuru.Name = "cmb_abonelikTuru";
            this.cmb_abonelikTuru.Size = new System.Drawing.Size(134, 24);
            this.cmb_abonelikTuru.TabIndex = 7;
            this.cmb_abonelikTuru.Text = "Tümü";
            // 
            // rb_ekGelir
            // 
            this.rb_ekGelir.AutoSize = true;
            this.rb_ekGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_ekGelir.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_ekGelir.Location = new System.Drawing.Point(121, 43);
            this.rb_ekGelir.Name = "rb_ekGelir";
            this.rb_ekGelir.Size = new System.Drawing.Size(83, 24);
            this.rb_ekGelir.TabIndex = 3;
            this.rb_ekGelir.Text = "Ek Gelir";
            this.rb_ekGelir.UseVisualStyleBackColor = true;
            // 
            // lbl_odemeTürü
            // 
            this.lbl_odemeTürü.AutoSize = true;
            this.lbl_odemeTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_odemeTürü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_odemeTürü.Location = new System.Drawing.Point(12, 141);
            this.lbl_odemeTürü.Name = "lbl_odemeTürü";
            this.lbl_odemeTürü.Size = new System.Drawing.Size(97, 20);
            this.lbl_odemeTürü.TabIndex = 7;
            this.lbl_odemeTürü.Text = "Ödeme Türü";
            // 
            // rb_iade
            // 
            this.rb_iade.AutoSize = true;
            this.rb_iade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_iade.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_iade.Location = new System.Drawing.Point(16, 103);
            this.rb_iade.Name = "rb_iade";
            this.rb_iade.Size = new System.Drawing.Size(59, 24);
            this.rb_iade.TabIndex = 2;
            this.rb_iade.Text = "İade";
            this.rb_iade.UseVisualStyleBackColor = true;
            // 
            // cmb_odemeTuru
            // 
            this.cmb_odemeTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_odemeTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_odemeTuru.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_odemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_odemeTuru.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmb_odemeTuru.FormattingEnabled = true;
            this.cmb_odemeTuru.Items.AddRange(new object[] {
            "Tümü",
            "Nakit",
            "Kart",
            "Nakit-Kart"});
            this.cmb_odemeTuru.Location = new System.Drawing.Point(16, 164);
            this.cmb_odemeTuru.Name = "cmb_odemeTuru";
            this.cmb_odemeTuru.Size = new System.Drawing.Size(134, 24);
            this.cmb_odemeTuru.TabIndex = 6;
            this.cmb_odemeTuru.Text = "Tümü";
            // 
            // rb_satıslar
            // 
            this.rb_satıslar.AutoSize = true;
            this.rb_satıslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_satıslar.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_satıslar.Location = new System.Drawing.Point(16, 73);
            this.rb_satıslar.Name = "rb_satıslar";
            this.rb_satıslar.Size = new System.Drawing.Size(80, 24);
            this.rb_satıslar.TabIndex = 1;
            this.rb_satıslar.Text = "Satışlar";
            this.rb_satıslar.UseVisualStyleBackColor = true;
            // 
            // rb_tumu
            // 
            this.rb_tumu.AutoSize = true;
            this.rb_tumu.Checked = true;
            this.rb_tumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_tumu.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_tumu.Location = new System.Drawing.Point(16, 43);
            this.rb_tumu.Name = "rb_tumu";
            this.rb_tumu.Size = new System.Drawing.Size(67, 24);
            this.rb_tumu.TabIndex = 0;
            this.rb_tumu.TabStop = true;
            this.rb_tumu.Text = "Tümü";
            this.rb_tumu.UseVisualStyleBackColor = true;
            // 
            // lbl_filtrelemeTuru
            // 
            this.lbl_filtrelemeTuru.AutoSize = true;
            this.lbl_filtrelemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_filtrelemeTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_filtrelemeTuru.Location = new System.Drawing.Point(12, 10);
            this.lbl_filtrelemeTuru.Name = "lbl_filtrelemeTuru";
            this.lbl_filtrelemeTuru.Size = new System.Drawing.Size(138, 24);
            this.lbl_filtrelemeTuru.TabIndex = 0;
            this.lbl_filtrelemeTuru.Text = "Filtreleme Türü";
            // 
            // grd_list
            // 
            this.grd_list.AllowUserToAddRows = false;
            this.grd_list.AllowUserToDeleteRows = false;
            this.grd_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_list.BackgroundColor = System.Drawing.Color.White;
            this.grd_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_list.DefaultCellStyle = dataGridViewCellStyle1;
            this.grd_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_list.EnableHeadersVisualStyles = false;
            this.grd_list.Location = new System.Drawing.Point(0, 0);
            this.grd_list.Name = "grd_list";
            this.grd_list.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_list.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.grd_list.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_list.Size = new System.Drawing.Size(1524, 515);
            this.grd_list.TabIndex = 2;
            // 
            // fRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 821);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1540, 860);
            this.Name = "fRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPOR SAYFASI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_gosterim.ResumeLayout(false);
            this.pnl_gosterim.PerformLayout();
            this.pnl_raporAl.ResumeLayout(false);
            this.pnl_date.ResumeLayout(false);
            this.pnl_date.PerformLayout();
            this.pnl_filtreleme.ResumeLayout(false);
            this.pnl_filtreleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.CntrlButton btn_listele;
        private Controls.CntrlDatePicker date_bitis;
        private Controls.CntrlDatePicker date_baslangic;
        private lblStandart lbl_bitis;
        private lblStandart lbl_baslangıc;
        private lblStandart lbl_filtrelemeTuru;
        private lblStandart lbl_satısGelirKart;
        private lblStandart lbl_satısGelirNakit;
        private lblStandart lbl_satısGelirToplam;
        private lblStandart lbl_giderKart;
        private lblStandart lbl_ekGelirKart;
        private lblStandart lbl_giderNakit;
        private lblStandart lbl_ekGelirNakit;
        private lblStandart lbl_kayıp;
        private lblStandart lbl_gider;
        private lblStandart lbl_ekGelir;
        private lblStandart lbl_iade;
        private grdOzel grd_list;
        private System.Windows.Forms.Panel pnl_filtreleme;
        private lblStandart lbl_odemeTürü;
        private System.Windows.Forms.ComboBox cmb_odemeTuru;
        private System.Windows.Forms.RadioButton rb_gider;
        private System.Windows.Forms.RadioButton rb_ekGelir;
        private System.Windows.Forms.RadioButton rb_iade;
        private System.Windows.Forms.RadioButton rb_satıslar;
        private System.Windows.Forms.RadioButton rb_tumu;
        private System.Windows.Forms.Panel pnl_date;
        private lblStandart lbl_abonelikTuru;
        private System.Windows.Forms.RadioButton rb_abonelikler;
        private System.Windows.Forms.ComboBox cmb_abonelikTuru;
        private lblStandart lbl_abonelikSayısı;
        private lblStandart lbl_abonelik;
        private System.Windows.Forms.Panel pnl_raporAl;
        private Controls.CntrlButton btn_raporAl;
        private System.Windows.Forms.Panel pnl_gosterim;
        private lblStandart lbl_giderTuru;
        private System.Windows.Forms.ComboBox cmb_giderTuru;
        private Controls.CntrlNumericTextBox txt_giderNakit;
        private Controls.CntrlNumericTextBox txt_ekGelirNakit;
        private Controls.CntrlNumericTextBox txt_giderKart;
        private Controls.CntrlNumericTextBox txt_satisNakit;
        private Controls.CntrlNumericTextBox txt_ekGelirKart;
        private Controls.CntrlNumericTextBox txt_satisKart;
        private Controls.CntrlNumericTextBox txt_aboneSayisi;
        private Controls.CntrlNumericTextBox txt_kayip;
    }
}