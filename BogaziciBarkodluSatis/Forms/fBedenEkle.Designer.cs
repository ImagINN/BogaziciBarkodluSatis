namespace BogaziciBarkodluSatis.Forms
{
    partial class fBedenEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBedenEkle));
            this.btn_sil = new BogaziciBarkodluSatis.btnStandart();
            this.btn_ekle = new BogaziciBarkodluSatis.btnStandart();
            this.list_beden = new System.Windows.Forms.ListBox();
            this.txt_beden = new BogaziciBarkodluSatis.txtStandart();
            this.lbl_beden = new BogaziciBarkodluSatis.lblStandart();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = global::BogaziciBarkodluSatis.Properties.Resources.garbage2;
            this.btn_sil.Location = new System.Drawing.Point(144, 323);
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
            this.btn_ekle.Location = new System.Drawing.Point(12, 323);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(130, 82);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            // 
            // list_beden
            // 
            this.list_beden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_beden.FormattingEnabled = true;
            this.list_beden.ItemHeight = 20;
            this.list_beden.Location = new System.Drawing.Point(12, 75);
            this.list_beden.Name = "list_beden";
            this.list_beden.Size = new System.Drawing.Size(262, 244);
            this.list_beden.TabIndex = 7;
            // 
            // txt_beden
            // 
            this.txt_beden.AutoCompleteCustomSource.AddRange(new string[] {
            "Eldiven",
            "Kask",
            "Gözlük",
            "Ceket",
            "Pantolon",
            "Kızak ",
            "Kayak",
            "Snowboard"});
            this.txt_beden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_beden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_beden.BackColor = System.Drawing.Color.White;
            this.txt_beden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_beden.Location = new System.Drawing.Point(12, 39);
            this.txt_beden.Name = "txt_beden";
            this.txt_beden.Size = new System.Drawing.Size(262, 30);
            this.txt_beden.TabIndex = 6;
            // 
            // lbl_beden
            // 
            this.lbl_beden.AutoSize = true;
            this.lbl_beden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_beden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_beden.Location = new System.Drawing.Point(9, 11);
            this.lbl_beden.Name = "lbl_beden";
            this.lbl_beden.Size = new System.Drawing.Size(216, 18);
            this.lbl_beden.TabIndex = 5;
            this.lbl_beden.Text = "Eklemek istediğiniz bedeni girin.\r\n";
            // 
            // fBedenEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 413);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_beden);
            this.Controls.Add(this.txt_beden);
            this.Controls.Add(this.lbl_beden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 452);
            this.Name = "fBedenEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beden Ekleme Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnStandart btn_sil;
        private btnStandart btn_ekle;
        private System.Windows.Forms.ListBox list_beden;
        private txtStandart txt_beden;
        private lblStandart lbl_beden;
    }
}