namespace BogaziciBarkodluSatis.Forms
{
    partial class fStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStok));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_urunGrubunaEkle = new System.Windows.Forms.RadioButton();
            this.rdb_tumu = new System.Windows.Forms.RadioButton();
            this.lbl_filtrelemeTuru = new BogaziciBarkodluSatis.lblStandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_urunGrubu = new BogaziciBarkodluSatis.lblStandart();
            this.cmb_urunGrubu = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_raporAl = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_ara = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.date_bitis = new BogaziciBarkodluSatis.Controls.CntrlDatePicker();
            this.date_baslangic = new BogaziciBarkodluSatis.Controls.CntrlDatePicker();
            this.lbl_bitis = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_baslangıc = new BogaziciBarkodluSatis.lblStandart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStandart1 = new BogaziciBarkodluSatis.lblStandart();
            this.cmb_islemTuru = new System.Windows.Forms.ComboBox();
            this.lbl_islemTuru = new BogaziciBarkodluSatis.lblStandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_urunAra = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_urunAra = new BogaziciBarkodluSatis.lblStandart();
            this.grd_urunler = new BogaziciBarkodluSatis.grdOzel();
            this.lblStandart2 = new BogaziciBarkodluSatis.lblStandart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1274, 821);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.rdb_urunGrubunaEkle);
            this.panel1.Controls.Add(this.rdb_tumu);
            this.panel1.Controls.Add(this.lbl_filtrelemeTuru);
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 113);
            this.panel1.TabIndex = 3;
            // 
            // rdb_urunGrubunaEkle
            // 
            this.rdb_urunGrubunaEkle.AutoSize = true;
            this.rdb_urunGrubunaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_urunGrubunaEkle.ForeColor = System.Drawing.Color.SteelBlue;
            this.rdb_urunGrubunaEkle.Location = new System.Drawing.Point(25, 72);
            this.rdb_urunGrubunaEkle.Name = "rdb_urunGrubunaEkle";
            this.rdb_urunGrubunaEkle.Size = new System.Drawing.Size(201, 29);
            this.rdb_urunGrubunaEkle.TabIndex = 2;
            this.rdb_urunGrubunaEkle.Text = "Ürün Grubuna Göre";
            this.rdb_urunGrubunaEkle.UseVisualStyleBackColor = true;
            // 
            // rdb_tumu
            // 
            this.rdb_tumu.AutoSize = true;
            this.rdb_tumu.Checked = true;
            this.rdb_tumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_tumu.ForeColor = System.Drawing.Color.SteelBlue;
            this.rdb_tumu.Location = new System.Drawing.Point(25, 37);
            this.rdb_tumu.Name = "rdb_tumu";
            this.rdb_tumu.Size = new System.Drawing.Size(81, 29);
            this.rdb_tumu.TabIndex = 1;
            this.rdb_tumu.TabStop = true;
            this.rdb_tumu.Text = "Tümü";
            this.rdb_tumu.UseVisualStyleBackColor = true;
            // 
            // lbl_filtrelemeTuru
            // 
            this.lbl_filtrelemeTuru.AutoSize = true;
            this.lbl_filtrelemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_filtrelemeTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_filtrelemeTuru.Location = new System.Drawing.Point(20, 9);
            this.lbl_filtrelemeTuru.Name = "lbl_filtrelemeTuru";
            this.lbl_filtrelemeTuru.Size = new System.Drawing.Size(142, 25);
            this.lbl_filtrelemeTuru.TabIndex = 2;
            this.lbl_filtrelemeTuru.Text = "Filtreleme Türü";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblStandart2);
            this.panel2.Controls.Add(this.lbl_urunGrubu);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.cmb_urunGrubu);
            this.panel2.Location = new System.Drawing.Point(0, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 174);
            this.panel2.TabIndex = 4;
            // 
            // lbl_urunGrubu
            // 
            this.lbl_urunGrubu.AutoSize = true;
            this.lbl_urunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_urunGrubu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunGrubu.Location = new System.Drawing.Point(20, 15);
            this.lbl_urunGrubu.Name = "lbl_urunGrubu";
            this.lbl_urunGrubu.Size = new System.Drawing.Size(113, 25);
            this.lbl_urunGrubu.TabIndex = 1;
            this.lbl_urunGrubu.Text = "Ürün Grubu";
            // 
            // cmb_urunGrubu
            // 
            this.cmb_urunGrubu.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_urunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_urunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_urunGrubu.FormattingEnabled = true;
            this.cmb_urunGrubu.Location = new System.Drawing.Point(25, 52);
            this.cmb_urunGrubu.Name = "cmb_urunGrubu";
            this.cmb_urunGrubu.Size = new System.Drawing.Size(294, 28);
            this.cmb_urunGrubu.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.btn_raporAl);
            this.panel5.Controls.Add(this.btn_ara);
            this.panel5.Location = new System.Drawing.Point(1, 588);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 110);
            this.panel5.TabIndex = 4;
            // 
            // btn_raporAl
            // 
            this.btn_raporAl.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_raporAl.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_raporAl.BorderColor = System.Drawing.Color.Black;
            this.btn_raporAl.BorderRadius = 20;
            this.btn_raporAl.BorderSize = 0;
            this.btn_raporAl.FlatAppearance.BorderSize = 0;
            this.btn_raporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporAl.ForeColor = System.Drawing.Color.White;
            this.btn_raporAl.Image = global::BogaziciBarkodluSatis.Properties.Resources.export__2_;
            this.btn_raporAl.Location = new System.Drawing.Point(25, 0);
            this.btn_raporAl.Name = "btn_raporAl";
            this.btn_raporAl.Size = new System.Drawing.Size(156, 110);
            this.btn_raporAl.TabIndex = 6;
            this.btn_raporAl.Text = "Rapor Al";
            this.btn_raporAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raporAl.TextColor = System.Drawing.Color.White;
            this.btn_raporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_raporAl.UseVisualStyleBackColor = false;
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_ara.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.btn_ara.BorderColor = System.Drawing.Color.Black;
            this.btn_ara.BorderRadius = 20;
            this.btn_ara.BorderSize = 0;
            this.btn_ara.FlatAppearance.BorderSize = 0;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Image = global::BogaziciBarkodluSatis.Properties.Resources.ara3232;
            this.btn_ara.Location = new System.Drawing.Point(187, 0);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(153, 110);
            this.btn_ara.TabIndex = 7;
            this.btn_ara.Text = "Ara";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.TextColor = System.Drawing.Color.White;
            this.btn_ara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ara.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.date_bitis);
            this.panel3.Controls.Add(this.date_baslangic);
            this.panel3.Controls.Add(this.lbl_bitis);
            this.panel3.Controls.Add(this.lbl_baslangıc);
            this.panel3.Location = new System.Drawing.Point(1, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 165);
            this.panel3.TabIndex = 5;
            // 
            // date_bitis
            // 
            this.date_bitis.BorderColor = System.Drawing.Color.SteelBlue;
            this.date_bitis.BorderSize = 2;
            this.date_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_bitis.Location = new System.Drawing.Point(25, 119);
            this.date_bitis.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_bitis.Name = "date_bitis";
            this.date_bitis.Size = new System.Drawing.Size(294, 35);
            this.date_bitis.SkinColor = System.Drawing.Color.Silver;
            this.date_bitis.TabIndex = 5;
            this.date_bitis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // date_baslangic
            // 
            this.date_baslangic.BorderColor = System.Drawing.Color.SteelBlue;
            this.date_baslangic.BorderSize = 2;
            this.date_baslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_baslangic.Location = new System.Drawing.Point(25, 38);
            this.date_baslangic.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_baslangic.Name = "date_baslangic";
            this.date_baslangic.Size = new System.Drawing.Size(294, 35);
            this.date_baslangic.SkinColor = System.Drawing.Color.Silver;
            this.date_baslangic.TabIndex = 4;
            this.date_baslangic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_bitis.Location = new System.Drawing.Point(20, 91);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(102, 25);
            this.lbl_bitis.TabIndex = 2;
            this.lbl_bitis.Text = "Bitiş Tarihi";
            // 
            // lbl_baslangıc
            // 
            this.lbl_baslangıc.AutoSize = true;
            this.lbl_baslangıc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslangıc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_baslangıc.Location = new System.Drawing.Point(20, 10);
            this.lbl_baslangıc.Name = "lbl_baslangıc";
            this.lbl_baslangıc.Size = new System.Drawing.Size(151, 25);
            this.lbl_baslangıc.TabIndex = 0;
            this.lbl_baslangıc.Text = "Başlangıc Tarihi";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblStandart1);
            this.panel4.Controls.Add(this.cmb_islemTuru);
            this.panel4.Controls.Add(this.lbl_islemTuru);
            this.panel4.Location = new System.Drawing.Point(0, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 103);
            this.panel4.TabIndex = 2;
            // 
            // lblStandart1
            // 
            this.lblStandart1.AutoSize = true;
            this.lblStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStandart1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStandart1.Location = new System.Drawing.Point(22, 77);
            this.lblStandart1.Name = "lblStandart1";
            this.lblStandart1.Size = new System.Drawing.Size(228, 18);
            this.lblStandart1.TabIndex = 2;
            this.lblStandart1.Text = "*İşlem türünü seçmeyi unutmayın.";
            // 
            // cmb_islemTuru
            // 
            this.cmb_islemTuru.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_islemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_islemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_islemTuru.FormattingEnabled = true;
            this.cmb_islemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme",
            "Kayıp Ürünler"});
            this.cmb_islemTuru.Location = new System.Drawing.Point(25, 46);
            this.cmb_islemTuru.Name = "cmb_islemTuru";
            this.cmb_islemTuru.Size = new System.Drawing.Size(294, 28);
            this.cmb_islemTuru.TabIndex = 0;
            // 
            // lbl_islemTuru
            // 
            this.lbl_islemTuru.AutoSize = true;
            this.lbl_islemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_islemTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_islemTuru.Location = new System.Drawing.Point(20, 9);
            this.lbl_islemTuru.Name = "lbl_islemTuru";
            this.lbl_islemTuru.Size = new System.Drawing.Size(104, 25);
            this.lbl_islemTuru.TabIndex = 0;
            this.lbl_islemTuru.Text = "İşlem Türü";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.txt_urunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lbl_urunAra);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.grd_urunler);
            this.splitContainer2.Size = new System.Drawing.Size(910, 821);
            this.splitContainer2.SplitterDistance = 94;
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
            this.txt_urunAra.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_urunAra.Location = new System.Drawing.Point(8, 47);
            this.txt_urunAra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urunAra.Multiline = false;
            this.txt_urunAra.Name = "txt_urunAra";
            this.txt_urunAra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_urunAra.PasswordChar = false;
            this.txt_urunAra.ReadOnly = false;
            this.txt_urunAra.Size = new System.Drawing.Size(483, 39);
            this.txt_urunAra.TabIndex = 8;
            this.txt_urunAra.Texts = "";
            this.txt_urunAra.UnderlinedStyle = true;
            // 
            // lbl_urunAra
            // 
            this.lbl_urunAra.AutoSize = true;
            this.lbl_urunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_urunAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunAra.Location = new System.Drawing.Point(12, 18);
            this.lbl_urunAra.Name = "lbl_urunAra";
            this.lbl_urunAra.Size = new System.Drawing.Size(90, 25);
            this.lbl_urunAra.TabIndex = 2;
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
            this.grd_urunler.Size = new System.Drawing.Size(910, 723);
            this.grd_urunler.TabIndex = 1;
            // 
            // lblStandart2
            // 
            this.lblStandart2.AutoSize = true;
            this.lblStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblStandart2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStandart2.Location = new System.Drawing.Point(20, 99);
            this.lblStandart2.Name = "lblStandart2";
            this.lblStandart2.Size = new System.Drawing.Size(74, 25);
            this.lblStandart2.TabIndex = 1;
            this.lblStandart2.Text = "Beden ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1274, 821);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1290, 860);
            this.Name = "fStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK SAYFASI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private lblStandart lbl_bitis;
        private lblStandart lbl_baslangıc;
        private System.Windows.Forms.Panel panel2;
        private lblStandart lbl_urunGrubu;
        private System.Windows.Forms.ComboBox cmb_urunGrubu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_urunGrubunaEkle;
        private System.Windows.Forms.RadioButton rdb_tumu;
        private lblStandart lbl_filtrelemeTuru;
        private System.Windows.Forms.ComboBox cmb_islemTuru;
        private lblStandart lbl_islemTuru;
        private System.Windows.Forms.Panel panel4;
        private Controls.CntrlButton btn_ara;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.CntrlTextBox txt_urunAra;
        private lblStandart lbl_urunAra;
        private grdOzel grd_urunler;
        private Controls.CntrlButton btn_raporAl;
        private Controls.CntrlDatePicker date_baslangic;
        private Controls.CntrlDatePicker date_bitis;
        private lblStandart lblStandart1;
        private lblStandart lblStandart2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}