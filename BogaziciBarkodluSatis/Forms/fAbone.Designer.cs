namespace BogaziciBarkodluSatis.Forms
{
    partial class fAbone
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_bitis = new BogaziciBarkodluSatis.Controls.CntrlDatePicker();
            this.date_baslangic = new BogaziciBarkodluSatis.Controls.CntrlDatePicker();
            this.lbl_bitis = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_baslangıc = new BogaziciBarkodluSatis.lblStandart();
            this.maskedTxt_telNo = new System.Windows.Forms.MaskedTextBox();
            this.cmb_abonelikTuru = new System.Windows.Forms.ComboBox();
            this.txt_tcNo = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.lbl_abone = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_tcNo = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_telNo = new BogaziciBarkodluSatis.lblStandart();
            this.txt_adSoyad = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_adSoyad = new BogaziciBarkodluSatis.lblStandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_aboneEkle = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_iptal = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_kaydet = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_aboneAra = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_aboneAra = new BogaziciBarkodluSatis.lblStandart();
            this.grd_abonelik = new BogaziciBarkodluSatis.grdOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_abonelik)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 270;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1278, 816);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_bitis);
            this.panel1.Controls.Add(this.date_baslangic);
            this.panel1.Controls.Add(this.lbl_bitis);
            this.panel1.Controls.Add(this.lbl_baslangıc);
            this.panel1.Controls.Add(this.maskedTxt_telNo);
            this.panel1.Controls.Add(this.cmb_abonelikTuru);
            this.panel1.Controls.Add(this.txt_tcNo);
            this.panel1.Controls.Add(this.lbl_abone);
            this.panel1.Controls.Add(this.lbl_tcNo);
            this.panel1.Controls.Add(this.lbl_telNo);
            this.panel1.Controls.Add(this.txt_adSoyad);
            this.panel1.Controls.Add(this.lbl_adSoyad);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 764);
            this.panel1.TabIndex = 0;
            // 
            // date_bitis
            // 
            this.date_bitis.BorderColor = System.Drawing.Color.SteelBlue;
            this.date_bitis.BorderSize = 2;
            this.date_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_bitis.Location = new System.Drawing.Point(17, 473);
            this.date_bitis.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_bitis.Name = "date_bitis";
            this.date_bitis.Size = new System.Drawing.Size(246, 35);
            this.date_bitis.SkinColor = System.Drawing.Color.Silver;
            this.date_bitis.TabIndex = 9;
            this.date_bitis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // date_baslangic
            // 
            this.date_baslangic.BorderColor = System.Drawing.Color.SteelBlue;
            this.date_baslangic.BorderSize = 2;
            this.date_baslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_baslangic.Location = new System.Drawing.Point(17, 392);
            this.date_baslangic.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_baslangic.Name = "date_baslangic";
            this.date_baslangic.Size = new System.Drawing.Size(246, 35);
            this.date_baslangic.SkinColor = System.Drawing.Color.Silver;
            this.date_baslangic.TabIndex = 8;
            this.date_baslangic.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bitis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_bitis.Location = new System.Drawing.Point(12, 445);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(102, 25);
            this.lbl_bitis.TabIndex = 7;
            this.lbl_bitis.Text = "Bitiş Tarihi";
            // 
            // lbl_baslangıc
            // 
            this.lbl_baslangıc.AutoSize = true;
            this.lbl_baslangıc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslangıc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_baslangıc.Location = new System.Drawing.Point(12, 364);
            this.lbl_baslangıc.Name = "lbl_baslangıc";
            this.lbl_baslangıc.Size = new System.Drawing.Size(151, 25);
            this.lbl_baslangıc.TabIndex = 6;
            this.lbl_baslangıc.Text = "Başlangıc Tarihi";
            // 
            // maskedTxt_telNo
            // 
            this.maskedTxt_telNo.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTxt_telNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTxt_telNo.Location = new System.Drawing.Point(18, 138);
            this.maskedTxt_telNo.Mask = "(999) 000-0000";
            this.maskedTxt_telNo.Name = "maskedTxt_telNo";
            this.maskedTxt_telNo.Size = new System.Drawing.Size(245, 33);
            this.maskedTxt_telNo.TabIndex = 4;
            // 
            // cmb_abonelikTuru
            // 
            this.cmb_abonelikTuru.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_abonelikTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_abonelikTuru.FormattingEnabled = true;
            this.cmb_abonelikTuru.Location = new System.Drawing.Point(17, 306);
            this.cmb_abonelikTuru.Name = "cmb_abonelikTuru";
            this.cmb_abonelikTuru.Size = new System.Drawing.Size(246, 32);
            this.cmb_abonelikTuru.TabIndex = 3;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_tcNo.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_tcNo.BorderSize = 2;
            this.txt_tcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcNo.Location = new System.Drawing.Point(17, 219);
            this.txt_tcNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tcNo.Multiline = false;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tcNo.PasswordChar = false;
            this.txt_tcNo.ReadOnly = false;
            this.txt_tcNo.Size = new System.Drawing.Size(246, 39);
            this.txt_tcNo.TabIndex = 2;
            this.txt_tcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tcNo.Texts = "";
            this.txt_tcNo.UnderlinedStyle = false;
            // 
            // lbl_abone
            // 
            this.lbl_abone.AutoSize = true;
            this.lbl_abone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_abone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_abone.Location = new System.Drawing.Point(13, 282);
            this.lbl_abone.Name = "lbl_abone";
            this.lbl_abone.Size = new System.Drawing.Size(134, 25);
            this.lbl_abone.TabIndex = 2;
            this.lbl_abone.Text = "Abonelik Türü";
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_tcNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_tcNo.Location = new System.Drawing.Point(13, 195);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(70, 25);
            this.lbl_tcNo.TabIndex = 2;
            this.lbl_tcNo.Text = "TC No";
            // 
            // lbl_telNo
            // 
            this.lbl_telNo.AutoSize = true;
            this.lbl_telNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_telNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telNo.Location = new System.Drawing.Point(13, 109);
            this.lbl_telNo.Name = "lbl_telNo";
            this.lbl_telNo.Size = new System.Drawing.Size(166, 25);
            this.lbl_telNo.TabIndex = 2;
            this.lbl_telNo.Text = "Telefon Numarası";
            // 
            // txt_adSoyad
            // 
            this.txt_adSoyad.BackColor = System.Drawing.SystemColors.Control;
            this.txt_adSoyad.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_adSoyad.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_adSoyad.BorderSize = 2;
            this.txt_adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adSoyad.ForeColor = System.Drawing.Color.Black;
            this.txt_adSoyad.Location = new System.Drawing.Point(17, 51);
            this.txt_adSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adSoyad.Multiline = false;
            this.txt_adSoyad.Name = "txt_adSoyad";
            this.txt_adSoyad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_adSoyad.PasswordChar = false;
            this.txt_adSoyad.ReadOnly = false;
            this.txt_adSoyad.Size = new System.Drawing.Size(246, 39);
            this.txt_adSoyad.TabIndex = 0;
            this.txt_adSoyad.Texts = "";
            this.txt_adSoyad.UnderlinedStyle = false;
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_adSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_adSoyad.Location = new System.Drawing.Point(13, 27);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(99, 25);
            this.lbl_adSoyad.TabIndex = 2;
            this.lbl_adSoyad.Text = "Ad Soyad";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_aboneEkle);
            this.panel2.Controls.Add(this.btn_iptal);
            this.panel2.Controls.Add(this.btn_kaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 243);
            this.panel2.TabIndex = 1;
            // 
            // btn_aboneEkle
            // 
            this.btn_aboneEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_aboneEkle.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btn_aboneEkle.BorderColor = System.Drawing.Color.Black;
            this.btn_aboneEkle.BorderRadius = 25;
            this.btn_aboneEkle.BorderSize = 0;
            this.btn_aboneEkle.FlatAppearance.BorderSize = 0;
            this.btn_aboneEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aboneEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aboneEkle.ForeColor = System.Drawing.Color.White;
            this.btn_aboneEkle.Image = global::BogaziciBarkodluSatis.Properties.Resources.sub;
            this.btn_aboneEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aboneEkle.Location = new System.Drawing.Point(17, 122);
            this.btn_aboneEkle.Name = "btn_aboneEkle";
            this.btn_aboneEkle.Size = new System.Drawing.Size(246, 93);
            this.btn_aboneEkle.TabIndex = 15;
            this.btn_aboneEkle.Text = "Abonelik Ekle";
            this.btn_aboneEkle.TextColor = System.Drawing.Color.White;
            this.btn_aboneEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aboneEkle.UseVisualStyleBackColor = false;
            this.btn_aboneEkle.Click += new System.EventHandler(this.btn_aboneEkle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Firebrick;
            this.btn_iptal.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btn_iptal.BorderColor = System.Drawing.Color.Black;
            this.btn_iptal.BorderRadius = 15;
            this.btn_iptal.BorderSize = 0;
            this.btn_iptal.FlatAppearance.BorderSize = 0;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.Image = global::BogaziciBarkodluSatis.Properties.Resources.cancel24;
            this.btn_iptal.Location = new System.Drawing.Point(143, 16);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(120, 100);
            this.btn_iptal.TabIndex = 14;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_iptal.TextColor = System.Drawing.Color.White;
            this.btn_iptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_iptal.UseVisualStyleBackColor = false;
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
            this.btn_kaydet.Location = new System.Drawing.Point(17, 16);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(120, 100);
            this.btn_kaydet.TabIndex = 13;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.TextColor = System.Drawing.Color.White;
            this.btn_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_kaydet.UseVisualStyleBackColor = false;
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
            this.splitContainer2.Panel1.Controls.Add(this.txt_aboneAra);
            this.splitContainer2.Panel1.Controls.Add(this.lbl_aboneAra);
            this.splitContainer2.Panel1MinSize = 80;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grd_abonelik);
            this.splitContainer2.Size = new System.Drawing.Size(998, 816);
            this.splitContainer2.SplitterDistance = 85;
            this.splitContainer2.TabIndex = 0;
            // 
            // txt_aboneAra
            // 
            this.txt_aboneAra.BackColor = System.Drawing.SystemColors.Control;
            this.txt_aboneAra.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_aboneAra.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txt_aboneAra.BorderSize = 2;
            this.txt_aboneAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aboneAra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_aboneAra.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_aboneAra.Location = new System.Drawing.Point(4, 37);
            this.txt_aboneAra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aboneAra.Multiline = false;
            this.txt_aboneAra.Name = "txt_aboneAra";
            this.txt_aboneAra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_aboneAra.PasswordChar = false;
            this.txt_aboneAra.ReadOnly = false;
            this.txt_aboneAra.Size = new System.Drawing.Size(483, 39);
            this.txt_aboneAra.TabIndex = 10;
            this.txt_aboneAra.Texts = "";
            this.txt_aboneAra.UnderlinedStyle = true;
            // 
            // lbl_aboneAra
            // 
            this.lbl_aboneAra.AutoSize = true;
            this.lbl_aboneAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_aboneAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_aboneAra.Location = new System.Drawing.Point(3, 12);
            this.lbl_aboneAra.Name = "lbl_aboneAra";
            this.lbl_aboneAra.Size = new System.Drawing.Size(106, 25);
            this.lbl_aboneAra.TabIndex = 9;
            this.lbl_aboneAra.Text = "Abone Ara";
            // 
            // grd_abonelik
            // 
            this.grd_abonelik.AllowUserToAddRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGreen;
            this.grd_abonelik.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grd_abonelik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_abonelik.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.grd_abonelik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_abonelik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grd_abonelik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_abonelik.DefaultCellStyle = dataGridViewCellStyle6;
            this.grd_abonelik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_abonelik.EnableHeadersVisualStyles = false;
            this.grd_abonelik.Location = new System.Drawing.Point(0, 0);
            this.grd_abonelik.Name = "grd_abonelik";
            this.grd_abonelik.RowHeadersVisible = false;
            this.grd_abonelik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_abonelik.Size = new System.Drawing.Size(998, 727);
            this.grd_abonelik.TabIndex = 0;
            // 
            // fAbone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 816);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1294, 855);
            this.Name = "fAbone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABONE İŞLEMLERİ SAYFASI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_abonelik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_abonelikTuru;
        private Controls.CntrlNumericTextBox txt_tcNo;
        private lblStandart lbl_abone;
        private lblStandart lbl_tcNo;
        private lblStandart lbl_telNo;
        private Controls.CntrlTextBox txt_adSoyad;
        private lblStandart lbl_adSoyad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private grdOzel grd_abonelik;
        private Controls.CntrlButton btn_aboneEkle;
        private Controls.CntrlButton btn_iptal;
        private Controls.CntrlButton btn_kaydet;
        private Controls.CntrlTextBox txt_aboneAra;
        private lblStandart lbl_aboneAra;
        private System.Windows.Forms.MaskedTextBox maskedTxt_telNo;
        private Controls.CntrlDatePicker date_bitis;
        private Controls.CntrlDatePicker date_baslangic;
        private lblStandart lbl_bitis;
        private lblStandart lbl_baslangıc;
    }
}