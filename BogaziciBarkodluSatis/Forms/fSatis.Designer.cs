namespace BogaziciBarkodluSatis
{
    partial class fSatis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSatis));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tblLytPnl_satısEkranı = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_onay = new BogaziciBarkodluSatis.lblStandart();
            this.txt_barkod = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_miktar = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.lbl_nakit = new System.Windows.Forms.Label();
            this.lbl_kart = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_barkod = new System.Windows.Forms.Label();
            this.lbl_miktar = new System.Windows.Forms.Label();
            this.grd_urunler = new System.Windows.Forms.DataGridView();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblLytPnl_odemeYontemi = new System.Windows.Forms.TableLayoutPanel();
            this.btn_nakitKart = new System.Windows.Forms.Button();
            this.btn_kart = new System.Windows.Forms.Button();
            this.btn_nakit = new System.Windows.Forms.Button();
            this.tblLytPnl_toplamTutar = new System.Windows.Forms.TableLayoutPanel();
            this.txt_toplamTutar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_paraUstuGoster = new BogaziciBarkodluSatis.lblStandart();
            this.lbl_paraUstu = new BogaziciBarkodluSatis.lblStandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tblLytPnl_uyeBilgi = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytPnl_uyeBtn = new System.Windows.Forms.TableLayoutPanel();
            this.txt_tcNo = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.txt_soyisim = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.lbl_telNo = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_isim = new BogaziciBarkodluSatis.Controls.CntrlTextBox();
            this.txt_telNo = new BogaziciBarkodluSatis.Controls.CntrlNumericTextBox();
            this.grd_uyeBilgi = new System.Windows.Forms.DataGridView();
            this.UyeUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeFıyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeMıktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLytPnl_islemler = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sorgula = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_aboneIslemi = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_temizle = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_iade = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblLytPnl_satısEkranı.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_urunler)).BeginInit();
            this.tblLytPnl_odemeYontemi.SuspendLayout();
            this.tblLytPnl_toplamTutar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tblLytPnl_uyeBilgi.SuspendLayout();
            this.tblLytPnl_uyeBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_uyeBilgi)).BeginInit();
            this.tblLytPnl_islemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tblLytPnl_satısEkranı);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1684, 961);
            this.splitContainer1.SplitterDistance = 847;
            this.splitContainer1.TabIndex = 0;
            // 
            // tblLytPnl_satısEkranı
            // 
            this.tblLytPnl_satısEkranı.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tblLytPnl_satısEkranı.ColumnCount = 1;
            this.tblLytPnl_satısEkranı.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnl_satısEkranı.Controls.Add(this.panel1, 0, 0);
            this.tblLytPnl_satısEkranı.Controls.Add(this.grd_urunler, 0, 1);
            this.tblLytPnl_satısEkranı.Controls.Add(this.tblLytPnl_odemeYontemi, 0, 2);
            this.tblLytPnl_satısEkranı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPnl_satısEkranı.Location = new System.Drawing.Point(0, 0);
            this.tblLytPnl_satısEkranı.Name = "tblLytPnl_satısEkranı";
            this.tblLytPnl_satısEkranı.RowCount = 3;
            this.tblLytPnl_satısEkranı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLytPnl_satısEkranı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblLytPnl_satısEkranı.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLytPnl_satısEkranı.Size = new System.Drawing.Size(847, 961);
            this.tblLytPnl_satısEkranı.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbl_onay);
            this.panel1.Controls.Add(this.txt_barkod);
            this.panel1.Controls.Add(this.txt_miktar);
            this.panel1.Controls.Add(this.lbl_nakit);
            this.panel1.Controls.Add(this.lbl_kart);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.lbl_barkod);
            this.panel1.Controls.Add(this.lbl_miktar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 94);
            this.panel1.TabIndex = 0;
            // 
            // lbl_onay
            // 
            this.lbl_onay.AutoSize = true;
            this.lbl_onay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_onay.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_onay.Location = new System.Drawing.Point(677, 44);
            this.lbl_onay.Name = "lbl_onay";
            this.lbl_onay.Size = new System.Drawing.Size(18, 20);
            this.lbl_onay.TabIndex = 14;
            this.lbl_onay.Text = "0";
            // 
            // txt_barkod
            // 
            this.txt_barkod.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_barkod.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_barkod.BorderSize = 2;
            this.txt_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barkod.Location = new System.Drawing.Point(109, 61);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkod.Multiline = false;
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_barkod.PasswordChar = false;
            this.txt_barkod.ReadOnly = false;
            this.txt_barkod.Size = new System.Drawing.Size(424, 33);
            this.txt_barkod.TabIndex = 12;
            this.txt_barkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_barkod.Texts = "";
            this.txt_barkod.UnderlinedStyle = false;
            // 
            // txt_miktar
            // 
            this.txt_miktar.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_miktar.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_miktar.BorderSize = 2;
            this.txt_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_miktar.Location = new System.Drawing.Point(7, 60);
            this.txt_miktar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_miktar.Multiline = false;
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_miktar.PasswordChar = false;
            this.txt_miktar.ReadOnly = false;
            this.txt_miktar.Size = new System.Drawing.Size(71, 33);
            this.txt_miktar.TabIndex = 11;
            this.txt_miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_miktar.Texts = "";
            this.txt_miktar.UnderlinedStyle = false;
            // 
            // lbl_nakit
            // 
            this.lbl_nakit.AutoSize = true;
            this.lbl_nakit.Location = new System.Drawing.Point(674, 27);
            this.lbl_nakit.Name = "lbl_nakit";
            this.lbl_nakit.Size = new System.Drawing.Size(30, 13);
            this.lbl_nakit.TabIndex = 7;
            this.lbl_nakit.Text = "nakit";
            // 
            // lbl_kart
            // 
            this.lbl_kart.AutoSize = true;
            this.lbl_kart.Location = new System.Drawing.Point(674, 9);
            this.lbl_kart.Name = "lbl_kart";
            this.lbl_kart.Size = new System.Drawing.Size(25, 13);
            this.lbl_kart.TabIndex = 6;
            this.lbl_kart.Text = "kart";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Image = global::BogaziciBarkodluSatis.Properties.Resources.ara2424;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(457, 22);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(76, 35);
            this.btn_ekle.TabIndex = 13;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_barkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_barkod.Location = new System.Drawing.Point(105, 38);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(60, 20);
            this.lbl_barkod.TabIndex = 3;
            this.lbl_barkod.Text = "Barkod";
            // 
            // lbl_miktar
            // 
            this.lbl_miktar.AutoSize = true;
            this.lbl_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_miktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_miktar.Location = new System.Drawing.Point(3, 38);
            this.lbl_miktar.Name = "lbl_miktar";
            this.lbl_miktar.Size = new System.Drawing.Size(52, 20);
            this.lbl_miktar.TabIndex = 2;
            this.lbl_miktar.Text = "Miktar";
            // 
            // grd_urunler
            // 
            this.grd_urunler.AllowUserToAddRows = false;
            this.grd_urunler.AllowUserToDeleteRows = false;
            this.grd_urunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_urunler.BackgroundColor = System.Drawing.Color.White;
            this.grd_urunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_urunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_urunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAdi,
            this.Fiyat,
            this.Miktar,
            this.Toplam,
            this.Sil});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_urunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_urunler.EnableHeadersVisualStyles = false;
            this.grd_urunler.Location = new System.Drawing.Point(3, 103);
            this.grd_urunler.Name = "grd_urunler";
            this.grd_urunler.ReadOnly = true;
            this.grd_urunler.RowHeadersVisible = false;
            this.grd_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_urunler.Size = new System.Drawing.Size(841, 725);
            this.grd_urunler.TabIndex = 1;
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // Toplam
            // 
            this.Toplam.HeaderText = "Toplam";
            this.Toplam.Name = "Toplam";
            this.Toplam.ReadOnly = true;
            // 
            // Sil
            // 
            this.Sil.HeaderText = "Sil";
            this.Sil.Image = global::BogaziciBarkodluSatis.Properties.Resources.remove;
            this.Sil.Name = "Sil";
            this.Sil.ReadOnly = true;
            // 
            // tblLytPnl_odemeYontemi
            // 
            this.tblLytPnl_odemeYontemi.ColumnCount = 4;
            this.tblLytPnl_odemeYontemi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytPnl_odemeYontemi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytPnl_odemeYontemi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytPnl_odemeYontemi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLytPnl_odemeYontemi.Controls.Add(this.btn_nakitKart, 2, 0);
            this.tblLytPnl_odemeYontemi.Controls.Add(this.btn_kart, 1, 0);
            this.tblLytPnl_odemeYontemi.Controls.Add(this.btn_nakit, 0, 0);
            this.tblLytPnl_odemeYontemi.Controls.Add(this.tblLytPnl_toplamTutar, 3, 0);
            this.tblLytPnl_odemeYontemi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPnl_odemeYontemi.Location = new System.Drawing.Point(0, 831);
            this.tblLytPnl_odemeYontemi.Margin = new System.Windows.Forms.Padding(0);
            this.tblLytPnl_odemeYontemi.Name = "tblLytPnl_odemeYontemi";
            this.tblLytPnl_odemeYontemi.RowCount = 1;
            this.tblLytPnl_odemeYontemi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnl_odemeYontemi.Size = new System.Drawing.Size(847, 130);
            this.tblLytPnl_odemeYontemi.TabIndex = 2;
            // 
            // btn_nakitKart
            // 
            this.btn_nakitKart.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_nakitKart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nakitKart.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btn_nakitKart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nakitKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_nakitKart.ForeColor = System.Drawing.Color.White;
            this.btn_nakitKart.Image = global::BogaziciBarkodluSatis.Properties.Resources.kartnakit;
            this.btn_nakitKart.Location = new System.Drawing.Point(339, 1);
            this.btn_nakitKart.Margin = new System.Windows.Forms.Padding(1);
            this.btn_nakitKart.Name = "btn_nakitKart";
            this.btn_nakitKart.Size = new System.Drawing.Size(167, 128);
            this.btn_nakitKart.TabIndex = 6;
            this.btn_nakitKart.Text = "NAKİT\r\n-\r\nKART (F3)";
            this.btn_nakitKart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nakitKart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_nakitKart.UseVisualStyleBackColor = false;
            this.btn_nakitKart.Click += new System.EventHandler(this.btn_nakitKart_Click);
            // 
            // btn_kart
            // 
            this.btn_kart.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_kart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_kart.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_kart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kart.ForeColor = System.Drawing.Color.White;
            this.btn_kart.Image = global::BogaziciBarkodluSatis.Properties.Resources.kredikarti;
            this.btn_kart.Location = new System.Drawing.Point(170, 1);
            this.btn_kart.Margin = new System.Windows.Forms.Padding(1);
            this.btn_kart.Name = "btn_kart";
            this.btn_kart.Size = new System.Drawing.Size(167, 128);
            this.btn_kart.TabIndex = 5;
            this.btn_kart.Text = "KART (F2)";
            this.btn_kart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_kart.UseVisualStyleBackColor = false;
            // 
            // btn_nakit
            // 
            this.btn_nakit.BackColor = System.Drawing.Color.Tomato;
            this.btn_nakit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_nakit.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btn_nakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_nakit.ForeColor = System.Drawing.Color.White;
            this.btn_nakit.Image = global::BogaziciBarkodluSatis.Properties.Resources.tl_48;
            this.btn_nakit.Location = new System.Drawing.Point(1, 1);
            this.btn_nakit.Margin = new System.Windows.Forms.Padding(1);
            this.btn_nakit.Name = "btn_nakit";
            this.btn_nakit.Size = new System.Drawing.Size(167, 128);
            this.btn_nakit.TabIndex = 4;
            this.btn_nakit.Text = "NAKİT (F1)";
            this.btn_nakit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nakit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_nakit.UseVisualStyleBackColor = false;
            this.btn_nakit.Click += new System.EventHandler(this.btn_nakit_Click);
            // 
            // tblLytPnl_toplamTutar
            // 
            this.tblLytPnl_toplamTutar.BackColor = System.Drawing.Color.Goldenrod;
            this.tblLytPnl_toplamTutar.ColumnCount = 1;
            this.tblLytPnl_toplamTutar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnl_toplamTutar.Controls.Add(this.txt_toplamTutar, 0, 0);
            this.tblLytPnl_toplamTutar.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblLytPnl_toplamTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPnl_toplamTutar.Location = new System.Drawing.Point(507, 0);
            this.tblLytPnl_toplamTutar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tblLytPnl_toplamTutar.Name = "tblLytPnl_toplamTutar";
            this.tblLytPnl_toplamTutar.RowCount = 2;
            this.tblLytPnl_toplamTutar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl_toplamTutar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl_toplamTutar.Size = new System.Drawing.Size(340, 129);
            this.tblLytPnl_toplamTutar.TabIndex = 3;
            // 
            // txt_toplamTutar
            // 
            this.txt_toplamTutar.BackColor = System.Drawing.Color.Goldenrod;
            this.txt_toplamTutar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_toplamTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_toplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_toplamTutar.ForeColor = System.Drawing.Color.White;
            this.txt_toplamTutar.Location = new System.Drawing.Point(1, 0);
            this.txt_toplamTutar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txt_toplamTutar.Name = "txt_toplamTutar";
            this.txt_toplamTutar.ReadOnly = true;
            this.txt_toplamTutar.Size = new System.Drawing.Size(338, 76);
            this.txt_toplamTutar.TabIndex = 0;
            this.txt_toplamTutar.Text = "0,00";
            this.txt_toplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_paraUstuGoster, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_paraUstu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 59);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_paraUstuGoster
            // 
            this.lbl_paraUstuGoster.AutoSize = true;
            this.lbl_paraUstuGoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_paraUstuGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_paraUstuGoster.ForeColor = System.Drawing.Color.White;
            this.lbl_paraUstuGoster.Location = new System.Drawing.Point(170, 0);
            this.lbl_paraUstuGoster.Name = "lbl_paraUstuGoster";
            this.lbl_paraUstuGoster.Size = new System.Drawing.Size(161, 59);
            this.lbl_paraUstuGoster.TabIndex = 1;
            this.lbl_paraUstuGoster.Text = "0,00";
            this.lbl_paraUstuGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_paraUstu
            // 
            this.lbl_paraUstu.AutoSize = true;
            this.lbl_paraUstu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_paraUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_paraUstu.ForeColor = System.Drawing.Color.White;
            this.lbl_paraUstu.Location = new System.Drawing.Point(3, 6);
            this.lbl_paraUstu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbl_paraUstu.Name = "lbl_paraUstu";
            this.lbl_paraUstu.Size = new System.Drawing.Size(161, 53);
            this.lbl_paraUstu.TabIndex = 0;
            this.lbl_paraUstu.Text = "Para Üstü:";
            this.lbl_paraUstu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.splitContainer2.Panel1.Controls.Add(this.tblLytPnl_uyeBilgi);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tblLytPnl_islemler);
            this.splitContainer2.Size = new System.Drawing.Size(833, 961);
            this.splitContainer2.SplitterDistance = 830;
            this.splitContainer2.TabIndex = 0;
            // 
            // tblLytPnl_uyeBilgi
            // 
            this.tblLytPnl_uyeBilgi.ColumnCount = 1;
            this.tblLytPnl_uyeBilgi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPnl_uyeBilgi.Controls.Add(this.tblLytPnl_uyeBtn, 0, 0);
            this.tblLytPnl_uyeBilgi.Controls.Add(this.grd_uyeBilgi, 0, 1);
            this.tblLytPnl_uyeBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPnl_uyeBilgi.Location = new System.Drawing.Point(0, 0);
            this.tblLytPnl_uyeBilgi.Margin = new System.Windows.Forms.Padding(0);
            this.tblLytPnl_uyeBilgi.Name = "tblLytPnl_uyeBilgi";
            this.tblLytPnl_uyeBilgi.RowCount = 2;
            this.tblLytPnl_uyeBilgi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLytPnl_uyeBilgi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLytPnl_uyeBilgi.Size = new System.Drawing.Size(833, 830);
            this.tblLytPnl_uyeBilgi.TabIndex = 0;
            // 
            // tblLytPnl_uyeBtn
            // 
            this.tblLytPnl_uyeBtn.ColumnCount = 2;
            this.tblLytPnl_uyeBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLytPnl_uyeBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tblLytPnl_uyeBtn.Controls.Add(this.txt_tcNo, 1, 3);
            this.tblLytPnl_uyeBtn.Controls.Add(this.txt_soyisim, 1, 1);
            this.tblLytPnl_uyeBtn.Controls.Add(this.lbl_tcNo, 0, 3);
            this.tblLytPnl_uyeBtn.Controls.Add(this.lbl_telNo, 0, 2);
            this.tblLytPnl_uyeBtn.Controls.Add(this.lbl_soyisim, 0, 1);
            this.tblLytPnl_uyeBtn.Controls.Add(this.lbl_isim, 0, 0);
            this.tblLytPnl_uyeBtn.Controls.Add(this.txt_isim, 1, 0);
            this.tblLytPnl_uyeBtn.Controls.Add(this.txt_telNo, 1, 2);
            this.tblLytPnl_uyeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPnl_uyeBtn.Location = new System.Drawing.Point(0, 0);
            this.tblLytPnl_uyeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.tblLytPnl_uyeBtn.Name = "tblLytPnl_uyeBtn";
            this.tblLytPnl_uyeBtn.RowCount = 4;
            this.tblLytPnl_uyeBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytPnl_uyeBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytPnl_uyeBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytPnl_uyeBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLytPnl_uyeBtn.Size = new System.Drawing.Size(833, 249);
            this.tblLytPnl_uyeBtn.TabIndex = 0;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_tcNo.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_tcNo.BorderSize = 2;
            this.txt_tcNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcNo.Location = new System.Drawing.Point(281, 194);
            this.txt_tcNo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txt_tcNo.Multiline = false;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tcNo.PasswordChar = false;
            this.txt_tcNo.ReadOnly = false;
            this.txt_tcNo.Size = new System.Drawing.Size(548, 47);
            this.txt_tcNo.TabIndex = 3;
            this.txt_tcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tcNo.Texts = "";
            this.txt_tcNo.UnderlinedStyle = false;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.BackColor = System.Drawing.SystemColors.Control;
            this.txt_soyisim.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_soyisim.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_soyisim.BorderSize = 2;
            this.txt_soyisim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyisim.ForeColor = System.Drawing.Color.DimGray;
            this.txt_soyisim.Location = new System.Drawing.Point(281, 70);
            this.txt_soyisim.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txt_soyisim.Multiline = false;
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Padding = new System.Windows.Forms.Padding(7);
            this.txt_soyisim.PasswordChar = false;
            this.txt_soyisim.ReadOnly = false;
            this.txt_soyisim.Size = new System.Drawing.Size(548, 47);
            this.txt_soyisim.TabIndex = 1;
            this.txt_soyisim.Texts = "";
            this.txt_soyisim.UnderlinedStyle = false;
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lbl_tcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_tcNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tcNo.ForeColor = System.Drawing.Color.White;
            this.lbl_tcNo.Location = new System.Drawing.Point(3, 187);
            this.lbl_tcNo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(271, 61);
            this.lbl_tcNo.TabIndex = 6;
            this.lbl_tcNo.Text = "T.C. Kimlik Numarası :";
            this.lbl_tcNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_telNo
            // 
            this.lbl_telNo.AutoSize = true;
            this.lbl_telNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lbl_telNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_telNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_telNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telNo.ForeColor = System.Drawing.Color.White;
            this.lbl_telNo.Location = new System.Drawing.Point(3, 125);
            this.lbl_telNo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_telNo.Name = "lbl_telNo";
            this.lbl_telNo.Size = new System.Drawing.Size(271, 60);
            this.lbl_telNo.TabIndex = 4;
            this.lbl_telNo.Text = "Telefon Numarası :";
            this.lbl_telNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lbl_soyisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_soyisim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.ForeColor = System.Drawing.Color.White;
            this.lbl_soyisim.Location = new System.Drawing.Point(3, 63);
            this.lbl_soyisim.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(271, 60);
            this.lbl_soyisim.TabIndex = 2;
            this.lbl_soyisim.Text = "Soyisim :";
            this.lbl_soyisim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lbl_isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_isim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.ForeColor = System.Drawing.Color.White;
            this.lbl_isim.Location = new System.Drawing.Point(3, 1);
            this.lbl_isim.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(271, 60);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "İsim :";
            this.lbl_isim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_isim
            // 
            this.txt_isim.BackColor = System.Drawing.SystemColors.Control;
            this.txt_isim.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_isim.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_isim.BorderSize = 2;
            this.txt_isim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isim.ForeColor = System.Drawing.Color.DimGray;
            this.txt_isim.Location = new System.Drawing.Point(281, 8);
            this.txt_isim.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txt_isim.Multiline = false;
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Padding = new System.Windows.Forms.Padding(7);
            this.txt_isim.PasswordChar = false;
            this.txt_isim.ReadOnly = false;
            this.txt_isim.Size = new System.Drawing.Size(548, 47);
            this.txt_isim.TabIndex = 0;
            this.txt_isim.Texts = "";
            this.txt_isim.UnderlinedStyle = false;
            // 
            // txt_telNo
            // 
            this.txt_telNo.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_telNo.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txt_telNo.BorderSize = 2;
            this.txt_telNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_telNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telNo.Location = new System.Drawing.Point(281, 132);
            this.txt_telNo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txt_telNo.Multiline = false;
            this.txt_telNo.Name = "txt_telNo";
            this.txt_telNo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_telNo.PasswordChar = false;
            this.txt_telNo.ReadOnly = false;
            this.txt_telNo.Size = new System.Drawing.Size(548, 47);
            this.txt_telNo.TabIndex = 2;
            this.txt_telNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_telNo.Texts = "";
            this.txt_telNo.UnderlinedStyle = false;
            // 
            // grd_uyeBilgi
            // 
            this.grd_uyeBilgi.AllowUserToAddRows = false;
            this.grd_uyeBilgi.AllowUserToDeleteRows = false;
            this.grd_uyeBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_uyeBilgi.BackgroundColor = System.Drawing.Color.White;
            this.grd_uyeBilgi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_uyeBilgi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_uyeBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_uyeBilgi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UyeUrunAdi,
            this.UyeFıyat,
            this.UyeMıktar,
            this.UyeToplam,
            this.UyeTarih});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_uyeBilgi.DefaultCellStyle = dataGridViewCellStyle4;
            this.grd_uyeBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_uyeBilgi.EnableHeadersVisualStyles = false;
            this.grd_uyeBilgi.Location = new System.Drawing.Point(0, 249);
            this.grd_uyeBilgi.Margin = new System.Windows.Forms.Padding(0);
            this.grd_uyeBilgi.Name = "grd_uyeBilgi";
            this.grd_uyeBilgi.ReadOnly = true;
            this.grd_uyeBilgi.RowHeadersVisible = false;
            this.grd_uyeBilgi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_uyeBilgi.Size = new System.Drawing.Size(833, 581);
            this.grd_uyeBilgi.TabIndex = 1;
            // 
            // UyeUrunAdi
            // 
            this.UyeUrunAdi.HeaderText = "Ürün Adı";
            this.UyeUrunAdi.Name = "UyeUrunAdi";
            this.UyeUrunAdi.ReadOnly = true;
            // 
            // UyeFıyat
            // 
            this.UyeFıyat.HeaderText = "Fiyat";
            this.UyeFıyat.Name = "UyeFıyat";
            this.UyeFıyat.ReadOnly = true;
            // 
            // UyeMıktar
            // 
            this.UyeMıktar.HeaderText = "Miktar";
            this.UyeMıktar.Name = "UyeMıktar";
            this.UyeMıktar.ReadOnly = true;
            // 
            // UyeToplam
            // 
            this.UyeToplam.HeaderText = "Toplam";
            this.UyeToplam.Name = "UyeToplam";
            this.UyeToplam.ReadOnly = true;
            // 
            // UyeTarih
            // 
            this.UyeTarih.HeaderText = "Tarih";
            this.UyeTarih.Name = "UyeTarih";
            this.UyeTarih.ReadOnly = true;
            // 
            // tblLytPnl_islemler
            // 
            this.tblLytPnl_islemler.ColumnCount = 2;
            this.tblLytPnl_islemler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl_islemler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl_islemler.Controls.Add(this.btn_sorgula, 1, 1);
            this.tblLytPnl_islemler.Controls.Add(this.btn_aboneIslemi, 0, 1);
            this.tblLytPnl_islemler.Controls.Add(this.btn_temizle, 1, 0);
            this.tblLytPnl_islemler.Controls.Add(this.btn_iade, 0, 0);
            this.tblLytPnl_islemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPnl_islemler.Location = new System.Drawing.Point(0, 0);
            this.tblLytPnl_islemler.Name = "tblLytPnl_islemler";
            this.tblLytPnl_islemler.RowCount = 2;
            this.tblLytPnl_islemler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl_islemler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnl_islemler.Size = new System.Drawing.Size(833, 127);
            this.tblLytPnl_islemler.TabIndex = 0;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_sorgula.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btn_sorgula.BorderColor = System.Drawing.Color.Black;
            this.btn_sorgula.BorderRadius = 17;
            this.btn_sorgula.BorderSize = 0;
            this.btn_sorgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sorgula.FlatAppearance.BorderSize = 0;
            this.btn_sorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgula.ForeColor = System.Drawing.Color.White;
            this.btn_sorgula.Image = global::BogaziciBarkodluSatis.Properties.Resources.query;
            this.btn_sorgula.Location = new System.Drawing.Point(417, 64);
            this.btn_sorgula.Margin = new System.Windows.Forms.Padding(1);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(415, 62);
            this.btn_sorgula.TabIndex = 14;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sorgula.TextColor = System.Drawing.Color.White;
            this.btn_sorgula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sorgula.UseVisualStyleBackColor = false;
            // 
            // btn_aboneIslemi
            // 
            this.btn_aboneIslemi.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_aboneIslemi.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.btn_aboneIslemi.BorderColor = System.Drawing.Color.Black;
            this.btn_aboneIslemi.BorderRadius = 17;
            this.btn_aboneIslemi.BorderSize = 0;
            this.btn_aboneIslemi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_aboneIslemi.FlatAppearance.BorderSize = 0;
            this.btn_aboneIslemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aboneIslemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aboneIslemi.ForeColor = System.Drawing.Color.White;
            this.btn_aboneIslemi.Image = global::BogaziciBarkodluSatis.Properties.Resources.sub;
            this.btn_aboneIslemi.Location = new System.Drawing.Point(1, 64);
            this.btn_aboneIslemi.Margin = new System.Windows.Forms.Padding(1);
            this.btn_aboneIslemi.Name = "btn_aboneIslemi";
            this.btn_aboneIslemi.Size = new System.Drawing.Size(414, 62);
            this.btn_aboneIslemi.TabIndex = 13;
            this.btn_aboneIslemi.Text = "Abone İşlemi";
            this.btn_aboneIslemi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aboneIslemi.TextColor = System.Drawing.Color.White;
            this.btn_aboneIslemi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aboneIslemi.UseVisualStyleBackColor = false;
            this.btn_aboneIslemi.Click += new System.EventHandler(this.btn_aboneIslemi_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_temizle.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_temizle.BorderColor = System.Drawing.Color.Black;
            this.btn_temizle.BorderRadius = 17;
            this.btn_temizle.BorderSize = 0;
            this.btn_temizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_temizle.FlatAppearance.BorderSize = 0;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Image = global::BogaziciBarkodluSatis.Properties.Resources.clear48481;
            this.btn_temizle.Location = new System.Drawing.Point(417, 1);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(415, 61);
            this.btn_temizle.TabIndex = 12;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.TextColor = System.Drawing.Color.White;
            this.btn_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_temizle.UseVisualStyleBackColor = false;
            // 
            // btn_iade
            // 
            this.btn_iade.BackColor = System.Drawing.Color.Tomato;
            this.btn_iade.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_iade.BorderColor = System.Drawing.Color.Black;
            this.btn_iade.BorderRadius = 17;
            this.btn_iade.BorderSize = 0;
            this.btn_iade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_iade.FlatAppearance.BorderSize = 0;
            this.btn_iade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iade.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iade.ForeColor = System.Drawing.Color.White;
            this.btn_iade.Image = global::BogaziciBarkodluSatis.Properties.Resources.iade;
            this.btn_iade.Location = new System.Drawing.Point(1, 1);
            this.btn_iade.Margin = new System.Windows.Forms.Padding(1);
            this.btn_iade.Name = "btn_iade";
            this.btn_iade.Size = new System.Drawing.Size(414, 61);
            this.btn_iade.TabIndex = 11;
            this.btn_iade.Text = "İade İşlemi";
            this.btn_iade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iade.TextColor = System.Drawing.Color.White;
            this.btn_iade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iade.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sil";
            this.dataGridViewImageColumn1.Image = global::BogaziciBarkodluSatis.Properties.Resources.remove;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 167;
            // 
            // fSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1684, 961);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1646, 1000);
            this.Name = "fSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ SAYFASI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tblLytPnl_satısEkranı.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_urunler)).EndInit();
            this.tblLytPnl_odemeYontemi.ResumeLayout(false);
            this.tblLytPnl_toplamTutar.ResumeLayout(false);
            this.tblLytPnl_toplamTutar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tblLytPnl_uyeBilgi.ResumeLayout(false);
            this.tblLytPnl_uyeBtn.ResumeLayout(false);
            this.tblLytPnl_uyeBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_uyeBilgi)).EndInit();
            this.tblLytPnl_islemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tblLytPnl_satısEkranı;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grd_urunler;
        private System.Windows.Forms.TableLayoutPanel tblLytPnl_odemeYontemi;
        private System.Windows.Forms.Button btn_nakit;
        private System.Windows.Forms.Button btn_nakitKart;
        private System.Windows.Forms.Button btn_kart;
        private System.Windows.Forms.TableLayoutPanel tblLytPnl_toplamTutar;
        private System.Windows.Forms.Label lbl_barkod;
        private System.Windows.Forms.Label lbl_miktar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toplam;
        private System.Windows.Forms.DataGridViewImageColumn Sil;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel tblLytPnl_uyeBilgi;
        private System.Windows.Forms.TableLayoutPanel tblLytPnl_uyeBtn;
        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.Label lbl_telNo;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TableLayoutPanel tblLytPnl_islemler;
        private System.Windows.Forms.DataGridView grd_uyeBilgi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeFıyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeMıktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeToplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeTarih;
        public System.Windows.Forms.Label lbl_nakit;
        public System.Windows.Forms.Label lbl_kart;
        public System.Windows.Forms.TextBox txt_toplamTutar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private lblStandart lbl_paraUstuGoster;
        private lblStandart lbl_paraUstu;
        private Controls.CntrlTextBox txt_soyisim;
        private Controls.CntrlTextBox txt_isim;
        private Controls.CntrlNumericTextBox txt_miktar;
        private Controls.CntrlNumericTextBox txt_barkod;
        private Controls.CntrlNumericTextBox txt_tcNo;
        private Controls.CntrlNumericTextBox txt_telNo;
        private Controls.CntrlButton btn_sorgula;
        private Controls.CntrlButton btn_aboneIslemi;
        private Controls.CntrlButton btn_temizle;
        private Controls.CntrlButton btn_iade;
        private lblStandart lbl_onay;
    }
}

