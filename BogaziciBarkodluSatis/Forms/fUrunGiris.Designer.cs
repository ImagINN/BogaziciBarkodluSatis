namespace BogaziciBarkodluSatis
{
    partial class fUrunGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUrunGiris));
            this.splcntr_main = new System.Windows.Forms.SplitContainer();
            this.btn_iptal = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_barkodOlustur = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_kaydet = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_bedenEkle = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_urunGrubuEkle = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.pnl_raporAl = new System.Windows.Forms.Panel();
            this.btn_raporAl = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_alisFiyati = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_satisFiyati = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_miktar = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_kdvOrani = new BogaziciBarkodluSatis.lblStandart();
            this.txt_alisFiyati = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_satisFiyati = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_miktar = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_kdvOrani = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.tableLayoutPanel_yazı = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_beden = new BogaziciBarkodluSatis.lblStandart();
            this.txt_aciklama = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.txt_urunAdi = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_barkod = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_urunAdi = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_aciklama = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_urunGrubu = new BogaziciBarkodluSatis.lblStandart();
            this.cmb_urunGrubu = new System.Windows.Forms.ComboBox();
            this.cmb_beden = new System.Windows.Forms.ComboBox();
            this.txt_barkod = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.pnl_urunAraUrunSayisi = new System.Windows.Forms.Panel();
            this.txt_urunSayisi = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_urunAra = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_urunAra = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_urunSayisi = new BogaziciBarkodluSatis.lblStandart();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.grdOzel1 = new BogaziciBarkodluSatis.grdOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splcntr_main)).BeginInit();
            this.splcntr_main.Panel1.SuspendLayout();
            this.splcntr_main.Panel2.SuspendLayout();
            this.splcntr_main.SuspendLayout();
            this.pnl_raporAl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_yazı.SuspendLayout();
            this.pnl_urunAraUrunSayisi.SuspendLayout();
            this.pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOzel1)).BeginInit();
            this.SuspendLayout();
            // 
            // splcntr_main
            // 
            this.splcntr_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcntr_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splcntr_main.Location = new System.Drawing.Point(0, 0);
            this.splcntr_main.Name = "splcntr_main";
            this.splcntr_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcntr_main.Panel1
            // 
            this.splcntr_main.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splcntr_main.Panel1.Controls.Add(this.btn_iptal);
            this.splcntr_main.Panel1.Controls.Add(this.btn_barkodOlustur);
            this.splcntr_main.Panel1.Controls.Add(this.btn_kaydet);
            this.splcntr_main.Panel1.Controls.Add(this.btn_bedenEkle);
            this.splcntr_main.Panel1.Controls.Add(this.btn_urunGrubuEkle);
            this.splcntr_main.Panel1.Controls.Add(this.pnl_raporAl);
            this.splcntr_main.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splcntr_main.Panel1.Controls.Add(this.tableLayoutPanel_yazı);
            // 
            // splcntr_main.Panel2
            // 
            this.splcntr_main.Panel2.Controls.Add(this.pnl_urunAraUrunSayisi);
            this.splcntr_main.Panel2.Controls.Add(this.pnl_grid);
            this.splcntr_main.Size = new System.Drawing.Size(1274, 821);
            this.splcntr_main.SplitterDistance = 383;
            this.splcntr_main.TabIndex = 0;
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
            this.btn_iptal.Location = new System.Drawing.Point(877, 209);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(109, 90);
            this.btn_iptal.TabIndex = 12;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_iptal.TextColor = System.Drawing.Color.White;
            this.btn_iptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_iptal.UseVisualStyleBackColor = false;
            // 
            // btn_barkodOlustur
            // 
            this.btn_barkodOlustur.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_barkodOlustur.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.btn_barkodOlustur.BorderColor = System.Drawing.Color.Black;
            this.btn_barkodOlustur.BorderRadius = 15;
            this.btn_barkodOlustur.BorderSize = 0;
            this.btn_barkodOlustur.FlatAppearance.BorderSize = 0;
            this.btn_barkodOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barkodOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_barkodOlustur.ForeColor = System.Drawing.Color.White;
            this.btn_barkodOlustur.Image = global::BogaziciBarkodluSatis.Properties.Resources.barcode4832;
            this.btn_barkodOlustur.Location = new System.Drawing.Point(428, 263);
            this.btn_barkodOlustur.Margin = new System.Windows.Forms.Padding(1);
            this.btn_barkodOlustur.Name = "btn_barkodOlustur";
            this.btn_barkodOlustur.Size = new System.Drawing.Size(150, 106);
            this.btn_barkodOlustur.TabIndex = 6;
            this.btn_barkodOlustur.Text = "Barkod Oluştur";
            this.btn_barkodOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_barkodOlustur.TextColor = System.Drawing.Color.White;
            this.btn_barkodOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_barkodOlustur.UseVisualStyleBackColor = false;
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
            this.btn_kaydet.Location = new System.Drawing.Point(767, 209);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(109, 90);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.TextColor = System.Drawing.Color.White;
            this.btn_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // btn_bedenEkle
            // 
            this.btn_bedenEkle.BackColor = System.Drawing.Color.Tan;
            this.btn_bedenEkle.BackgroundColor = System.Drawing.Color.Tan;
            this.btn_bedenEkle.BorderColor = System.Drawing.Color.Black;
            this.btn_bedenEkle.BorderRadius = 15;
            this.btn_bedenEkle.BorderSize = 0;
            this.btn_bedenEkle.FlatAppearance.BorderSize = 0;
            this.btn_bedenEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bedenEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bedenEkle.ForeColor = System.Drawing.Color.White;
            this.btn_bedenEkle.Image = global::BogaziciBarkodluSatis.Properties.Resources.Ekle24;
            this.btn_bedenEkle.Location = new System.Drawing.Point(124, 263);
            this.btn_bedenEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_bedenEkle.Name = "btn_bedenEkle";
            this.btn_bedenEkle.Size = new System.Drawing.Size(150, 106);
            this.btn_bedenEkle.TabIndex = 5;
            this.btn_bedenEkle.Text = "Beden Ekle";
            this.btn_bedenEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bedenEkle.TextColor = System.Drawing.Color.White;
            this.btn_bedenEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_bedenEkle.UseVisualStyleBackColor = false;
            this.btn_bedenEkle.Click += new System.EventHandler(this.btn_bedenEkle_Click);
            // 
            // btn_urunGrubuEkle
            // 
            this.btn_urunGrubuEkle.BackColor = System.Drawing.Color.Peru;
            this.btn_urunGrubuEkle.BackgroundColor = System.Drawing.Color.Peru;
            this.btn_urunGrubuEkle.BorderColor = System.Drawing.Color.Black;
            this.btn_urunGrubuEkle.BorderRadius = 15;
            this.btn_urunGrubuEkle.BorderSize = 0;
            this.btn_urunGrubuEkle.FlatAppearance.BorderSize = 0;
            this.btn_urunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urunGrubuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunGrubuEkle.ForeColor = System.Drawing.Color.White;
            this.btn_urunGrubuEkle.Image = global::BogaziciBarkodluSatis.Properties.Resources.Ekle24;
            this.btn_urunGrubuEkle.Location = new System.Drawing.Point(276, 263);
            this.btn_urunGrubuEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_urunGrubuEkle.Name = "btn_urunGrubuEkle";
            this.btn_urunGrubuEkle.Size = new System.Drawing.Size(150, 106);
            this.btn_urunGrubuEkle.TabIndex = 5;
            this.btn_urunGrubuEkle.Text = "Ürün Grubu Ekle";
            this.btn_urunGrubuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_urunGrubuEkle.TextColor = System.Drawing.Color.White;
            this.btn_urunGrubuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_urunGrubuEkle.UseVisualStyleBackColor = false;
            this.btn_urunGrubuEkle.Click += new System.EventHandler(this.btn_urunGrubuEkle_Click);
            // 
            // pnl_raporAl
            // 
            this.pnl_raporAl.Controls.Add(this.btn_raporAl);
            this.pnl_raporAl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_raporAl.Location = new System.Drawing.Point(1096, 0);
            this.pnl_raporAl.Name = "pnl_raporAl";
            this.pnl_raporAl.Size = new System.Drawing.Size(178, 383);
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
            this.btn_raporAl.Location = new System.Drawing.Point(1, 179);
            this.btn_raporAl.Name = "btn_raporAl";
            this.btn_raporAl.Size = new System.Drawing.Size(170, 120);
            this.btn_raporAl.TabIndex = 15;
            this.btn_raporAl.Text = "Rapor Al";
            this.btn_raporAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raporAl.TextColor = System.Drawing.Color.White;
            this.btn_raporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_raporAl.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21834F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_alisFiyati, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_satisFiyati, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_miktar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_kdvOrani, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_alisFiyati, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_satisFiyati, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_miktar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_kdvOrani, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(760, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.3886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.35233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 193);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // lbl_alisFiyati
            // 
            this.lbl_alisFiyati.AutoSize = true;
            this.lbl_alisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_alisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_alisFiyati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_alisFiyati.Location = new System.Drawing.Point(3, 0);
            this.lbl_alisFiyati.Name = "lbl_alisFiyati";
            this.lbl_alisFiyati.Size = new System.Drawing.Size(108, 48);
            this.lbl_alisFiyati.TabIndex = 8;
            this.lbl_alisFiyati.Text = "Alış Fiyatı:";
            this.lbl_alisFiyati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_satisFiyati
            // 
            this.lbl_satisFiyati.AutoSize = true;
            this.lbl_satisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_satisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_satisFiyati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_satisFiyati.Location = new System.Drawing.Point(3, 48);
            this.lbl_satisFiyati.Name = "lbl_satisFiyati";
            this.lbl_satisFiyati.Size = new System.Drawing.Size(108, 49);
            this.lbl_satisFiyati.TabIndex = 9;
            this.lbl_satisFiyati.Text = "Satış Fiyatı:";
            this.lbl_satisFiyati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_miktar
            // 
            this.lbl_miktar.AutoSize = true;
            this.lbl_miktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_miktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_miktar.Location = new System.Drawing.Point(3, 97);
            this.lbl_miktar.Name = "lbl_miktar";
            this.lbl_miktar.Size = new System.Drawing.Size(108, 47);
            this.lbl_miktar.TabIndex = 10;
            this.lbl_miktar.Text = "Miktar:";
            this.lbl_miktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_kdvOrani
            // 
            this.lbl_kdvOrani.AutoSize = true;
            this.lbl_kdvOrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_kdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_kdvOrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_kdvOrani.Location = new System.Drawing.Point(3, 144);
            this.lbl_kdvOrani.Name = "lbl_kdvOrani";
            this.lbl_kdvOrani.Size = new System.Drawing.Size(108, 49);
            this.lbl_kdvOrani.TabIndex = 11;
            this.lbl_kdvOrani.Text = "KDV Oranı:";
            this.lbl_kdvOrani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_alisFiyati
            // 
            this.txt_alisFiyati.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_alisFiyati.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_alisFiyati.BorderSize = 2;
            this.txt_alisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_alisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alisFiyati.Location = new System.Drawing.Point(118, 7);
            this.txt_alisFiyati.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.txt_alisFiyati.Multiline = false;
            this.txt_alisFiyati.Name = "txt_alisFiyati";
            this.txt_alisFiyati.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_alisFiyati.PasswordChar = false;
            this.txt_alisFiyati.ReadOnly = false;
            this.txt_alisFiyati.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_alisFiyati.Size = new System.Drawing.Size(107, 35);
            this.txt_alisFiyati.TabIndex = 7;
            this.txt_alisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_alisFiyati.Texts = "";
            this.txt_alisFiyati.UnderlinedStyle = false;
            // 
            // txt_satisFiyati
            // 
            this.txt_satisFiyati.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_satisFiyati.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_satisFiyati.BorderSize = 2;
            this.txt_satisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_satisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_satisFiyati.Location = new System.Drawing.Point(118, 55);
            this.txt_satisFiyati.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.txt_satisFiyati.Multiline = false;
            this.txt_satisFiyati.Name = "txt_satisFiyati";
            this.txt_satisFiyati.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_satisFiyati.PasswordChar = false;
            this.txt_satisFiyati.ReadOnly = false;
            this.txt_satisFiyati.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_satisFiyati.Size = new System.Drawing.Size(107, 35);
            this.txt_satisFiyati.TabIndex = 8;
            this.txt_satisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_satisFiyati.Texts = "";
            this.txt_satisFiyati.UnderlinedStyle = false;
            // 
            // txt_miktar
            // 
            this.txt_miktar.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_miktar.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_miktar.BorderSize = 2;
            this.txt_miktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_miktar.Location = new System.Drawing.Point(118, 104);
            this.txt_miktar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.txt_miktar.Multiline = false;
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_miktar.PasswordChar = false;
            this.txt_miktar.ReadOnly = false;
            this.txt_miktar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_miktar.Size = new System.Drawing.Size(107, 35);
            this.txt_miktar.TabIndex = 9;
            this.txt_miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_miktar.Texts = "";
            this.txt_miktar.UnderlinedStyle = false;
            // 
            // txt_kdvOrani
            // 
            this.txt_kdvOrani.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_kdvOrani.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_kdvOrani.BorderSize = 2;
            this.txt_kdvOrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_kdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kdvOrani.Location = new System.Drawing.Point(118, 151);
            this.txt_kdvOrani.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.txt_kdvOrani.Multiline = false;
            this.txt_kdvOrani.Name = "txt_kdvOrani";
            this.txt_kdvOrani.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_kdvOrani.PasswordChar = false;
            this.txt_kdvOrani.ReadOnly = false;
            this.txt_kdvOrani.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_kdvOrani.Size = new System.Drawing.Size(107, 35);
            this.txt_kdvOrani.TabIndex = 10;
            this.txt_kdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kdvOrani.Texts = "";
            this.txt_kdvOrani.UnderlinedStyle = false;
            // 
            // tableLayoutPanel_yazı
            // 
            this.tableLayoutPanel_yazı.ColumnCount = 2;
            this.tableLayoutPanel_yazı.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4947F));
            this.tableLayoutPanel_yazı.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.5053F));
            this.tableLayoutPanel_yazı.Controls.Add(this.lbl_beden, 0, 4);
            this.tableLayoutPanel_yazı.Controls.Add(this.txt_aciklama, 1, 2);
            this.tableLayoutPanel_yazı.Controls.Add(this.txt_urunAdi, 1, 1);
            this.tableLayoutPanel_yazı.Controls.Add(this.lbl_barkod, 0, 0);
            this.tableLayoutPanel_yazı.Controls.Add(this.lbl_urunAdi, 0, 1);
            this.tableLayoutPanel_yazı.Controls.Add(this.lbl_aciklama, 0, 2);
            this.tableLayoutPanel_yazı.Controls.Add(this.lbl_urunGrubu, 0, 3);
            this.tableLayoutPanel_yazı.Controls.Add(this.cmb_urunGrubu, 1, 3);
            this.tableLayoutPanel_yazı.Controls.Add(this.cmb_beden, 1, 4);
            this.tableLayoutPanel_yazı.Controls.Add(this.txt_barkod, 1, 0);
            this.tableLayoutPanel_yazı.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_yazı.Name = "tableLayoutPanel_yazı";
            this.tableLayoutPanel_yazı.RowCount = 5;
            this.tableLayoutPanel_yazı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_yazı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_yazı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_yazı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_yazı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_yazı.Size = new System.Drawing.Size(566, 245);
            this.tableLayoutPanel_yazı.TabIndex = 24;
            // 
            // lbl_beden
            // 
            this.lbl_beden.AutoSize = true;
            this.lbl_beden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_beden.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_beden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_beden.Location = new System.Drawing.Point(3, 196);
            this.lbl_beden.Name = "lbl_beden";
            this.lbl_beden.Size = new System.Drawing.Size(110, 49);
            this.lbl_beden.TabIndex = 9;
            this.lbl_beden.Text = "Beden:";
            this.lbl_beden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.BackColor = System.Drawing.SystemColors.Control;
            this.txt_aciklama.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_aciklama.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_aciklama.BorderSize = 2;
            this.txt_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aciklama.ForeColor = System.Drawing.Color.DimGray;
            this.txt_aciklama.Location = new System.Drawing.Point(120, 105);
            this.txt_aciklama.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.txt_aciklama.Multiline = false;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Padding = new System.Windows.Forms.Padding(7);
            this.txt_aciklama.PasswordChar = false;
            this.txt_aciklama.ReadOnly = false;
            this.txt_aciklama.Size = new System.Drawing.Size(442, 35);
            this.txt_aciklama.TabIndex = 2;
            this.txt_aciklama.Texts = "";
            this.txt_aciklama.UnderlinedStyle = false;
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_urunAdi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_urunAdi.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_urunAdi.BorderSize = 2;
            this.txt_urunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_urunAdi.Location = new System.Drawing.Point(120, 56);
            this.txt_urunAdi.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.txt_urunAdi.Multiline = false;
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Padding = new System.Windows.Forms.Padding(7);
            this.txt_urunAdi.PasswordChar = false;
            this.txt_urunAdi.ReadOnly = false;
            this.txt_urunAdi.Size = new System.Drawing.Size(442, 35);
            this.txt_urunAdi.TabIndex = 1;
            this.txt_urunAdi.Texts = "";
            this.txt_urunAdi.UnderlinedStyle = false;
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_barkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_barkod.Location = new System.Drawing.Point(3, 0);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(110, 49);
            this.lbl_barkod.TabIndex = 0;
            this.lbl_barkod.Text = "Barkod:";
            this.lbl_barkod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_urunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunAdi.Location = new System.Drawing.Point(3, 49);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(110, 49);
            this.lbl_urunAdi.TabIndex = 1;
            this.lbl_urunAdi.Text = "Ürün Adı:";
            this.lbl_urunAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.AutoSize = true;
            this.lbl_aciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_aciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_aciklama.Location = new System.Drawing.Point(3, 98);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(110, 49);
            this.lbl_aciklama.TabIndex = 2;
            this.lbl_aciklama.Text = "Açıklama:";
            this.lbl_aciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_urunGrubu
            // 
            this.lbl_urunGrubu.AutoSize = true;
            this.lbl_urunGrubu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_urunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_urunGrubu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunGrubu.Location = new System.Drawing.Point(3, 147);
            this.lbl_urunGrubu.Name = "lbl_urunGrubu";
            this.lbl_urunGrubu.Size = new System.Drawing.Size(110, 49);
            this.lbl_urunGrubu.TabIndex = 4;
            this.lbl_urunGrubu.Text = "Ürün Grubu:";
            this.lbl_urunGrubu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_urunGrubu
            // 
            this.cmb_urunGrubu.BackColor = System.Drawing.Color.BurlyWood;
            this.cmb_urunGrubu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_urunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_urunGrubu.FormattingEnabled = true;
            this.cmb_urunGrubu.Location = new System.Drawing.Point(119, 153);
            this.cmb_urunGrubu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cmb_urunGrubu.Name = "cmb_urunGrubu";
            this.cmb_urunGrubu.Size = new System.Drawing.Size(444, 37);
            this.cmb_urunGrubu.TabIndex = 3;
            // 
            // cmb_beden
            // 
            this.cmb_beden.BackColor = System.Drawing.Color.BurlyWood;
            this.cmb_beden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_beden.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_beden.FormattingEnabled = true;
            this.cmb_beden.Location = new System.Drawing.Point(119, 202);
            this.cmb_beden.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cmb_beden.Name = "cmb_beden";
            this.cmb_beden.Size = new System.Drawing.Size(444, 37);
            this.cmb_beden.TabIndex = 4;
            // 
            // txt_barkod
            // 
            this.txt_barkod.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_barkod.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_barkod.BorderSize = 2;
            this.txt_barkod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barkod.Location = new System.Drawing.Point(120, 7);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.txt_barkod.Multiline = false;
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_barkod.PasswordChar = false;
            this.txt_barkod.ReadOnly = false;
            this.txt_barkod.Size = new System.Drawing.Size(442, 35);
            this.txt_barkod.TabIndex = 0;
            this.txt_barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_barkod.Texts = "";
            this.txt_barkod.UnderlinedStyle = false;
            // 
            // pnl_urunAraUrunSayisi
            // 
            this.pnl_urunAraUrunSayisi.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_urunAraUrunSayisi.Controls.Add(this.txt_urunSayisi);
            this.pnl_urunAraUrunSayisi.Controls.Add(this.txt_urunAra);
            this.pnl_urunAraUrunSayisi.Controls.Add(this.lbl_urunAra);
            this.pnl_urunAraUrunSayisi.Controls.Add(this.lbl_urunSayisi);
            this.pnl_urunAraUrunSayisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_urunAraUrunSayisi.Location = new System.Drawing.Point(0, 0);
            this.pnl_urunAraUrunSayisi.Name = "pnl_urunAraUrunSayisi";
            this.pnl_urunAraUrunSayisi.Size = new System.Drawing.Size(1274, 58);
            this.pnl_urunAraUrunSayisi.TabIndex = 1;
            // 
            // txt_urunSayisi
            // 
            this.txt_urunSayisi.BorderColor = System.Drawing.Color.Black;
            this.txt_urunSayisi.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_urunSayisi.BorderSize = 2;
            this.txt_urunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunSayisi.Location = new System.Drawing.Point(604, 7);
            this.txt_urunSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urunSayisi.Multiline = false;
            this.txt_urunSayisi.Name = "txt_urunSayisi";
            this.txt_urunSayisi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_urunSayisi.PasswordChar = false;
            this.txt_urunSayisi.ReadOnly = false;
            this.txt_urunSayisi.Size = new System.Drawing.Size(86, 37);
            this.txt_urunSayisi.TabIndex = 14;
            this.txt_urunSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_urunSayisi.Texts = "";
            this.txt_urunSayisi.UnderlinedStyle = true;
            // 
            // txt_urunAra
            // 
            this.txt_urunAra.BackColor = System.Drawing.SystemColors.Control;
            this.txt_urunAra.BorderColor = System.Drawing.Color.Black;
            this.txt_urunAra.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_urunAra.BorderSize = 2;
            this.txt_urunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunAra.ForeColor = System.Drawing.Color.Black;
            this.txt_urunAra.Location = new System.Drawing.Point(119, 7);
            this.txt_urunAra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urunAra.Multiline = false;
            this.txt_urunAra.Name = "txt_urunAra";
            this.txt_urunAra.Padding = new System.Windows.Forms.Padding(7);
            this.txt_urunAra.PasswordChar = false;
            this.txt_urunAra.ReadOnly = false;
            this.txt_urunAra.Size = new System.Drawing.Size(318, 37);
            this.txt_urunAra.TabIndex = 13;
            this.txt_urunAra.Texts = "";
            this.txt_urunAra.UnderlinedStyle = true;
            // 
            // lbl_urunAra
            // 
            this.lbl_urunAra.AutoSize = true;
            this.lbl_urunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_urunAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunAra.Location = new System.Drawing.Point(14, 12);
            this.lbl_urunAra.Name = "lbl_urunAra";
            this.lbl_urunAra.Size = new System.Drawing.Size(112, 29);
            this.lbl_urunAra.TabIndex = 20;
            this.lbl_urunAra.Text = "Ürün Ara:";
            // 
            // lbl_urunSayisi
            // 
            this.lbl_urunSayisi.AutoSize = true;
            this.lbl_urunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_urunSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunSayisi.Location = new System.Drawing.Point(470, 15);
            this.lbl_urunSayisi.Name = "lbl_urunSayisi";
            this.lbl_urunSayisi.Size = new System.Drawing.Size(140, 29);
            this.lbl_urunSayisi.TabIndex = 22;
            this.lbl_urunSayisi.Text = "Ürün Sayısı:";
            // 
            // pnl_grid
            // 
            this.pnl_grid.Controls.Add(this.grdOzel1);
            this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Location = new System.Drawing.Point(0, 0);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(1274, 434);
            this.pnl_grid.TabIndex = 0;
            // 
            // grdOzel1
            // 
            this.grdOzel1.AllowUserToAddRows = false;
            this.grdOzel1.AllowUserToDeleteRows = false;
            this.grdOzel1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOzel1.BackgroundColor = System.Drawing.Color.White;
            this.grdOzel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOzel1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOzel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOzel1.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdOzel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOzel1.EnableHeadersVisualStyles = false;
            this.grdOzel1.Location = new System.Drawing.Point(0, 0);
            this.grdOzel1.Name = "grdOzel1";
            this.grdOzel1.ReadOnly = true;
            this.grdOzel1.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.grdOzel1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdOzel1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOzel1.Size = new System.Drawing.Size(1274, 434);
            this.grdOzel1.TabIndex = 0;
            // 
            // fUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1274, 821);
            this.Controls.Add(this.splcntr_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1290, 860);
            this.Name = "fUrunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN GİRİŞ SAYFASI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splcntr_main.Panel1.ResumeLayout(false);
            this.splcntr_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcntr_main)).EndInit();
            this.splcntr_main.ResumeLayout(false);
            this.pnl_raporAl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_yazı.ResumeLayout(false);
            this.tableLayoutPanel_yazı.PerformLayout();
            this.pnl_urunAraUrunSayisi.ResumeLayout(false);
            this.pnl_urunAraUrunSayisi.PerformLayout();
            this.pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOzel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splcntr_main;
        private lblStandart lbl_urunSayisi;
        private lblStandart lbl_urunAra;
        private lblStandart lbl_kdvOrani;
        private lblStandart lbl_miktar;
        private lblStandart lbl_satisFiyati;
        private lblStandart lbl_alisFiyati;
        private lblStandart lbl_urunGrubu;
        private lblStandart lbl_aciklama;
        private lblStandart lbl_urunAdi;
        private lblStandart lbl_barkod;
        private grdOzel grdOzel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_yazı;
        private System.Windows.Forms.Panel pnl_urunAraUrunSayisi;
        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.Panel pnl_raporAl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox cmb_urunGrubu;
        private Controls.CntrlTextBox txt_urunAra;
        private Controls.CntrlTextBox txt_aciklama;
        private Controls.CntrlTextBox txt_urunAdi;
        private Controls.CntrlNumericTextBox txt_alisFiyati;
        private Controls.CntrlNumericTextBox txt_satisFiyati;
        private Controls.CntrlNumericTextBox txt_miktar;
        private Controls.CntrlNumericTextBox txt_kdvOrani;
        private Controls.CntrlNumericTextBox txt_urunSayisi;
        private Controls.CntrlButton btn_urunGrubuEkle;
        private Controls.CntrlButton btn_iptal;
        private Controls.CntrlButton btn_kaydet;
        private Controls.CntrlButton btn_barkodOlustur;
        private Controls.CntrlButton btn_raporAl;
        private lblStandart lbl_beden;
        public System.Windows.Forms.ComboBox cmb_beden;
        private Controls.CntrlNumericTextBox txt_barkod;
        private Controls.CntrlButton btn_bedenEkle;
    }
}