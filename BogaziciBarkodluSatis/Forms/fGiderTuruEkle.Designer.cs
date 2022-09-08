namespace BogaziciBarkodluSatis.Forms
{
    partial class fGiderTuruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiderTuruEkle));
            this.list_giderTuru = new System.Windows.Forms.ListBox();
            this.txt_giderTuru = new BogaziciBarkodluSatis.txtStandart();
            this.lbl_giderTuru = new BogaziciBarkodluSatis.lblStandart();
            this.btn_sil = new BogaziciBarkodluSatis.btnStandart();
            this.btn_ekle = new BogaziciBarkodluSatis.btnStandart();
            this.SuspendLayout();
            // 
            // list_giderTuru
            // 
            this.list_giderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_giderTuru.FormattingEnabled = true;
            this.list_giderTuru.ItemHeight = 20;
            this.list_giderTuru.Location = new System.Drawing.Point(13, 73);
            this.list_giderTuru.Name = "list_giderTuru";
            this.list_giderTuru.Size = new System.Drawing.Size(262, 244);
            this.list_giderTuru.TabIndex = 12;
            // 
            // txt_giderTuru
            // 
            this.txt_giderTuru.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.txt_giderTuru.BackColor = System.Drawing.Color.White;
            this.txt_giderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_giderTuru.Location = new System.Drawing.Point(13, 37);
            this.txt_giderTuru.Name = "txt_giderTuru";
            this.txt_giderTuru.Size = new System.Drawing.Size(262, 30);
            this.txt_giderTuru.TabIndex = 11;
            // 
            // lbl_giderTuru
            // 
            this.lbl_giderTuru.AutoSize = true;
            this.lbl_giderTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_giderTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_giderTuru.Location = new System.Drawing.Point(10, 9);
            this.lbl_giderTuru.Name = "lbl_giderTuru";
            this.lbl_giderTuru.Size = new System.Drawing.Size(250, 18);
            this.lbl_giderTuru.TabIndex = 10;
            this.lbl_giderTuru.Text = "Eklemek istediğiniz gider türünü girin.\r\n";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = global::BogaziciBarkodluSatis.Properties.Resources.garbage2;
            this.btn_sil.Location = new System.Drawing.Point(145, 321);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(1);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(130, 82);
            this.btn_sil.TabIndex = 14;
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
            this.btn_ekle.Location = new System.Drawing.Point(13, 321);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(130, 82);
            this.btn_ekle.TabIndex = 13;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            // 
            // fGiderTuruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 413);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_giderTuru);
            this.Controls.Add(this.txt_giderTuru);
            this.Controls.Add(this.lbl_giderTuru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 452);
            this.Name = "fGiderTuruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİDER TÜRÜ EKLEME SAYFASI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnStandart btn_sil;
        private btnStandart btn_ekle;
        private System.Windows.Forms.ListBox list_giderTuru;
        private txtStandart txt_giderTuru;
        private lblStandart lbl_giderTuru;
    }
}