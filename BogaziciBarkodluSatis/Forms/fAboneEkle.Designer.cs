namespace BogaziciBarkodluSatis.Forms
{
    partial class fAboneEkle
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
            this.list_abonelikTuru = new System.Windows.Forms.ListBox();
            this.txt_abonelikTuru = new BogaziciBarkodluSatis.txtStandart();
            this.lbl_abonelikTuru = new BogaziciBarkodluSatis.lblStandart();
            this.btn_sil = new BogaziciBarkodluSatis.btnStandart();
            this.btn_ekle = new BogaziciBarkodluSatis.btnStandart();
            this.SuspendLayout();
            // 
            // list_abonelikTuru
            // 
            this.list_abonelikTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_abonelikTuru.FormattingEnabled = true;
            this.list_abonelikTuru.ItemHeight = 20;
            this.list_abonelikTuru.Location = new System.Drawing.Point(12, 77);
            this.list_abonelikTuru.Name = "list_abonelikTuru";
            this.list_abonelikTuru.Size = new System.Drawing.Size(262, 244);
            this.list_abonelikTuru.TabIndex = 7;
            // 
            // txt_abonelikTuru
            // 
            this.txt_abonelikTuru.AutoCompleteCustomSource.AddRange(new string[] {
            "Eldiven",
            "Kask",
            "Gözlük",
            "Ceket",
            "Pantolon",
            "Kızak ",
            "Kayak",
            "Snowboard"});
            this.txt_abonelikTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_abonelikTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_abonelikTuru.BackColor = System.Drawing.Color.White;
            this.txt_abonelikTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_abonelikTuru.Location = new System.Drawing.Point(12, 41);
            this.txt_abonelikTuru.Name = "txt_abonelikTuru";
            this.txt_abonelikTuru.Size = new System.Drawing.Size(262, 30);
            this.txt_abonelikTuru.TabIndex = 6;
            // 
            // lbl_abonelikTuru
            // 
            this.lbl_abonelikTuru.AutoSize = true;
            this.lbl_abonelikTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_abonelikTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_abonelikTuru.Location = new System.Drawing.Point(9, 13);
            this.lbl_abonelikTuru.Name = "lbl_abonelikTuru";
            this.lbl_abonelikTuru.Size = new System.Drawing.Size(273, 18);
            this.lbl_abonelikTuru.TabIndex = 5;
            this.lbl_abonelikTuru.Text = "Eklemek istediğiniz abonelik türünü girin.\r\n";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = global::BogaziciBarkodluSatis.Properties.Resources.garbage2;
            this.btn_sil.Location = new System.Drawing.Point(144, 325);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(1);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(130, 82);
            this.btn_sil.TabIndex = 9;
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
            this.btn_ekle.Location = new System.Drawing.Point(12, 325);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(130, 82);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            // 
            // fAboneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 413);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_abonelikTuru);
            this.Controls.Add(this.txt_abonelikTuru);
            this.Controls.Add(this.lbl_abonelikTuru);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 452);
            this.Name = "fAboneEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAboneEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnStandart btn_sil;
        private btnStandart btn_ekle;
        private System.Windows.Forms.ListBox list_abonelikTuru;
        private txtStandart txt_abonelikTuru;
        private lblStandart lbl_abonelikTuru;
    }
}