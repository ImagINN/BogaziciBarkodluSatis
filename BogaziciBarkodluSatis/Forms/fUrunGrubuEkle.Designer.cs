namespace BogaziciBarkodluSatis
{
    partial class fUrunGrubuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUrunGrubuEkle));
            this.list_urunGrub = new System.Windows.Forms.ListBox();
            this.txt_urunGrubAdi = new BogaziciBarkodluSatis.txtStandart();
            this.lbl_urunGrubAdi = new BogaziciBarkodluSatis.lblStandart();
            this.btn_sil = new BogaziciBarkodluSatis.btnStandart();
            this.btn_ekle = new BogaziciBarkodluSatis.btnStandart();
            this.SuspendLayout();
            // 
            // list_urunGrub
            // 
            this.list_urunGrub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_urunGrub.FormattingEnabled = true;
            this.list_urunGrub.ItemHeight = 20;
            this.list_urunGrub.Location = new System.Drawing.Point(12, 73);
            this.list_urunGrub.Name = "list_urunGrub";
            this.list_urunGrub.Size = new System.Drawing.Size(262, 244);
            this.list_urunGrub.TabIndex = 2;
            // 
            // txt_urunGrubAdi
            // 
            this.txt_urunGrubAdi.AutoCompleteCustomSource.AddRange(new string[] {
            "Eldiven",
            "Kask",
            "Gözlük",
            "Ceket",
            "Pantolon",
            "Kızak ",
            "Kayak",
            "Snowboard"});
            this.txt_urunGrubAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_urunGrubAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_urunGrubAdi.BackColor = System.Drawing.Color.White;
            this.txt_urunGrubAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_urunGrubAdi.Location = new System.Drawing.Point(12, 37);
            this.txt_urunGrubAdi.Name = "txt_urunGrubAdi";
            this.txt_urunGrubAdi.Size = new System.Drawing.Size(262, 30);
            this.txt_urunGrubAdi.TabIndex = 1;
            // 
            // lbl_urunGrubAdi
            // 
            this.lbl_urunGrubAdi.AutoSize = true;
            this.lbl_urunGrubAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_urunGrubAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunGrubAdi.Location = new System.Drawing.Point(9, 9);
            this.lbl_urunGrubAdi.Name = "lbl_urunGrubAdi";
            this.lbl_urunGrubAdi.Size = new System.Drawing.Size(277, 18);
            this.lbl_urunGrubAdi.TabIndex = 0;
            this.lbl_urunGrubAdi.Text = "Eklemek istediğiniz ürün grubu adını girin.\r\n";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = global::BogaziciBarkodluSatis.Properties.Resources.garbage2;
            this.btn_sil.Location = new System.Drawing.Point(144, 321);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(1);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(130, 82);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Image = global::BogaziciBarkodluSatis.Properties.Resources.Ekle32;
            this.btn_ekle.Location = new System.Drawing.Point(12, 321);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(130, 82);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(285, 413);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_urunGrub);
            this.Controls.Add(this.txt_urunGrubAdi);
            this.Controls.Add(this.lbl_urunGrubAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 452);
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN GRUBU EKLEME SAYFASI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lblStandart lbl_urunGrubAdi;
        private txtStandart txt_urunGrubAdi;
        private System.Windows.Forms.ListBox list_urunGrub;
        private btnStandart btn_ekle;
        private btnStandart btn_sil;
    }
}