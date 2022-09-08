namespace BogaziciBarkodluSatis.Forms
{
    partial class fFiyatGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFiyatGuncelle));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_kaydet = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.txt_yeniFiyat = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.lbl_yeniFiyat = new BogaziciBarkodluSatis.lblStandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_urunGrubu = new System.Windows.Forms.ComboBox();
            this.txt_fiyat = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_urunAdi = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_urunBilgi = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_barkod = new BogaziciBarkodluSatis.lblStandart();
            this.txt_barkod = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.lbl_urunGrubu = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_urunAdi = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_fiyat = new BogaziciBarkodluSatis.lblStandart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_barkodOkut = new BogaziciBarkodluSatis.lblStandart();
            this.txt_barkodOkut = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_urunAra = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_urunAra = new BogaziciBarkodluSatis.lblStandart();
            this.grd_urunler = new BogaziciBarkodluSatis.grdOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1293, 796);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_kaydet);
            this.panel3.Controls.Add(this.txt_yeniFiyat);
            this.panel3.Controls.Add(this.lbl_yeniFiyat);
            this.panel3.Location = new System.Drawing.Point(0, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 103);
            this.panel3.TabIndex = 8;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_kaydet.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.btn_kaydet.BorderColor = System.Drawing.Color.Black;
            this.btn_kaydet.BorderRadius = 15;
            this.btn_kaydet.BorderSize = 0;
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.Image = global::BogaziciBarkodluSatis.Properties.Resources.save24;
            this.btn_kaydet.Location = new System.Drawing.Point(251, 8);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(143, 59);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.TextColor = System.Drawing.Color.White;
            this.btn_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // txt_yeniFiyat
            // 
            this.txt_yeniFiyat.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_yeniFiyat.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_yeniFiyat.BorderSize = 2;
            this.txt_yeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yeniFiyat.Location = new System.Drawing.Point(104, 22);
            this.txt_yeniFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yeniFiyat.Multiline = false;
            this.txt_yeniFiyat.Name = "txt_yeniFiyat";
            this.txt_yeniFiyat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_yeniFiyat.PasswordChar = false;
            this.txt_yeniFiyat.ReadOnly = false;
            this.txt_yeniFiyat.Size = new System.Drawing.Size(140, 33);
            this.txt_yeniFiyat.TabIndex = 5;
            this.txt_yeniFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_yeniFiyat.Texts = "";
            this.txt_yeniFiyat.UnderlinedStyle = false;
            // 
            // lbl_yeniFiyat
            // 
            this.lbl_yeniFiyat.AutoSize = true;
            this.lbl_yeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_yeniFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_yeniFiyat.Location = new System.Drawing.Point(14, 28);
            this.lbl_yeniFiyat.Name = "lbl_yeniFiyat";
            this.lbl_yeniFiyat.Size = new System.Drawing.Size(82, 20);
            this.lbl_yeniFiyat.TabIndex = 4;
            this.lbl_yeniFiyat.Text = "Yeni Fiyatı";
            this.lbl_yeniFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmb_urunGrubu);
            this.panel2.Controls.Add(this.txt_fiyat);
            this.panel2.Controls.Add(this.txt_urunAdi);
            this.panel2.Controls.Add(this.lbl_urunBilgi);
            this.panel2.Controls.Add(this.lbl_barkod);
            this.panel2.Controls.Add(this.txt_barkod);
            this.panel2.Controls.Add(this.lbl_urunGrubu);
            this.panel2.Controls.Add(this.lbl_urunAdi);
            this.panel2.Controls.Add(this.lbl_fiyat);
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 217);
            this.panel2.TabIndex = 7;
            // 
            // cmb_urunGrubu
            // 
            this.cmb_urunGrubu.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_urunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_urunGrubu.FormattingEnabled = true;
            this.cmb_urunGrubu.Location = new System.Drawing.Point(104, 132);
            this.cmb_urunGrubu.Name = "cmb_urunGrubu";
            this.cmb_urunGrubu.Size = new System.Drawing.Size(280, 32);
            this.cmb_urunGrubu.TabIndex = 3;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_fiyat.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_fiyat.BorderSize = 2;
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyat.Location = new System.Drawing.Point(104, 171);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fiyat.Multiline = false;
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_fiyat.PasswordChar = false;
            this.txt_fiyat.ReadOnly = false;
            this.txt_fiyat.Size = new System.Drawing.Size(140, 33);
            this.txt_fiyat.TabIndex = 4;
            this.txt_fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fiyat.Texts = "";
            this.txt_fiyat.UnderlinedStyle = false;
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_urunAdi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_urunAdi.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_urunAdi.BorderSize = 2;
            this.txt_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunAdi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_urunAdi.Location = new System.Drawing.Point(104, 92);
            this.txt_urunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urunAdi.Multiline = false;
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_urunAdi.PasswordChar = false;
            this.txt_urunAdi.ReadOnly = false;
            this.txt_urunAdi.Size = new System.Drawing.Size(280, 33);
            this.txt_urunAdi.TabIndex = 2;
            this.txt_urunAdi.Texts = "";
            this.txt_urunAdi.UnderlinedStyle = false;
            // 
            // lbl_urunBilgi
            // 
            this.lbl_urunBilgi.AutoSize = true;
            this.lbl_urunBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_urunBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunBilgi.Location = new System.Drawing.Point(124, 22);
            this.lbl_urunBilgi.Name = "lbl_urunBilgi";
            this.lbl_urunBilgi.Size = new System.Drawing.Size(172, 25);
            this.lbl_urunBilgi.TabIndex = 2;
            this.lbl_urunBilgi.Text = "Seçili Ürün Bilgileri";
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_barkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_barkod.Location = new System.Drawing.Point(36, 57);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(60, 20);
            this.lbl_barkod.TabIndex = 4;
            this.lbl_barkod.Text = "Barkod";
            // 
            // txt_barkod
            // 
            this.txt_barkod.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_barkod.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_barkod.BorderSize = 2;
            this.txt_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barkod.Location = new System.Drawing.Point(104, 51);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkod.Multiline = false;
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_barkod.PasswordChar = false;
            this.txt_barkod.ReadOnly = false;
            this.txt_barkod.Size = new System.Drawing.Size(280, 33);
            this.txt_barkod.TabIndex = 1;
            this.txt_barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_barkod.Texts = "";
            this.txt_barkod.UnderlinedStyle = false;
            // 
            // lbl_urunGrubu
            // 
            this.lbl_urunGrubu.AutoSize = true;
            this.lbl_urunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_urunGrubu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunGrubu.Location = new System.Drawing.Point(3, 138);
            this.lbl_urunGrubu.Name = "lbl_urunGrubu";
            this.lbl_urunGrubu.Size = new System.Drawing.Size(93, 20);
            this.lbl_urunGrubu.TabIndex = 4;
            this.lbl_urunGrubu.Text = "Ürün Grubu";
            this.lbl_urunGrubu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_urunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunAdi.Location = new System.Drawing.Point(25, 98);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(71, 20);
            this.lbl_urunAdi.TabIndex = 4;
            this.lbl_urunAdi.Text = "Ürün Adı";
            this.lbl_urunAdi.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_fiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_fiyat.Location = new System.Drawing.Point(50, 177);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(46, 20);
            this.lbl_fiyat.TabIndex = 4;
            this.lbl_fiyat.Text = "Fiyatı";
            this.lbl_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_barkodOkut);
            this.panel1.Controls.Add(this.txt_barkodOkut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 98);
            this.panel1.TabIndex = 3;
            // 
            // lbl_barkodOkut
            // 
            this.lbl_barkodOkut.AutoSize = true;
            this.lbl_barkodOkut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_barkodOkut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_barkodOkut.Location = new System.Drawing.Point(8, 9);
            this.lbl_barkodOkut.Name = "lbl_barkodOkut";
            this.lbl_barkodOkut.Size = new System.Drawing.Size(164, 25);
            this.lbl_barkodOkut.TabIndex = 0;
            this.lbl_barkodOkut.Text = "Barkod Okutunuz";
            // 
            // txt_barkodOkut
            // 
            this.txt_barkodOkut.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_barkodOkut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_barkodOkut.BorderFocusColor = System.Drawing.Color.White;
            this.txt_barkodOkut.BorderSize = 2;
            this.txt_barkodOkut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barkodOkut.ForeColor = System.Drawing.Color.White;
            this.txt_barkodOkut.Location = new System.Drawing.Point(13, 38);
            this.txt_barkodOkut.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkodOkut.Multiline = false;
            this.txt_barkodOkut.Name = "txt_barkodOkut";
            this.txt_barkodOkut.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_barkodOkut.PasswordChar = false;
            this.txt_barkodOkut.ReadOnly = false;
            this.txt_barkodOkut.Size = new System.Drawing.Size(336, 39);
            this.txt_barkodOkut.TabIndex = 0;
            this.txt_barkodOkut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_barkodOkut.Texts = "";
            this.txt_barkodOkut.UnderlinedStyle = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txt_urunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lbl_urunAra);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grd_urunler);
            this.splitContainer2.Size = new System.Drawing.Size(879, 796);
            this.splitContainer2.SplitterDistance = 78;
            this.splitContainer2.TabIndex = 0;
            // 
            // txt_urunAra
            // 
            this.txt_urunAra.BackColor = System.Drawing.SystemColors.Control;
            this.txt_urunAra.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_urunAra.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txt_urunAra.BorderSize = 2;
            this.txt_urunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunAra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_urunAra.Location = new System.Drawing.Point(-1, 38);
            this.txt_urunAra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urunAra.Multiline = false;
            this.txt_urunAra.Name = "txt_urunAra";
            this.txt_urunAra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_urunAra.PasswordChar = false;
            this.txt_urunAra.ReadOnly = false;
            this.txt_urunAra.Size = new System.Drawing.Size(483, 39);
            this.txt_urunAra.TabIndex = 7;
            this.txt_urunAra.Texts = "";
            this.txt_urunAra.UnderlinedStyle = true;
            // 
            // lbl_urunAra
            // 
            this.lbl_urunAra.AutoSize = true;
            this.lbl_urunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_urunAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunAra.Location = new System.Drawing.Point(3, 9);
            this.lbl_urunAra.Name = "lbl_urunAra";
            this.lbl_urunAra.Size = new System.Drawing.Size(90, 25);
            this.lbl_urunAra.TabIndex = 4;
            this.lbl_urunAra.Text = "Ürün Ara";
            // 
            // grd_urunler
            // 
            this.grd_urunler.AllowUserToAddRows = false;
            this.grd_urunler.AllowUserToDeleteRows = false;
            this.grd_urunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_urunler.BackgroundColor = System.Drawing.Color.White;
            this.grd_urunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_urunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_urunler.DefaultCellStyle = dataGridViewCellStyle1;
            this.grd_urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_urunler.EnableHeadersVisualStyles = false;
            this.grd_urunler.Location = new System.Drawing.Point(0, 0);
            this.grd_urunler.Name = "grd_urunler";
            this.grd_urunler.ReadOnly = true;
            this.grd_urunler.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.grd_urunler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grd_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_urunler.Size = new System.Drawing.Size(879, 714);
            this.grd_urunler.TabIndex = 2;
            // 
            // fFiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 796);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1309, 835);
            this.Name = "fFiyatGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİYAT GÜNCELLEME SAYFASI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_urunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.CntrlTextBox txt_urunAra;
        private lblStandart lbl_urunAra;
        private grdOzel grd_urunler;
        private Controls.CntrlNumericTextBox txt_barkodOkut;
        private lblStandart lbl_barkodOkut;
        private System.Windows.Forms.Panel panel1;
        private lblStandart lbl_urunBilgi;
        private lblStandart lbl_barkod;
        private Controls.CntrlNumericTextBox txt_fiyat;
        private Controls.CntrlNumericTextBox txt_barkod;
        private lblStandart lbl_fiyat;
        private lblStandart lbl_urunAdi;
        private Controls.CntrlTextBox txt_urunAdi;
        private System.Windows.Forms.Panel panel3;
        private Controls.CntrlNumericTextBox txt_yeniFiyat;
        private lblStandart lbl_yeniFiyat;
        private System.Windows.Forms.Panel panel2;
        private Controls.CntrlButton btn_kaydet;
        private System.Windows.Forms.ComboBox cmb_urunGrubu;
        private lblStandart lbl_urunGrubu;
    }
}