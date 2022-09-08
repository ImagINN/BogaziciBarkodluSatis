namespace BogaziciBarkodluSatis.Forms
{
    partial class fAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cactusSoft = new BogaziciBarkodluSatis.lblStandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_fiyatGuncelle = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_fiyatGuncelleForm = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_gelirGiderForm = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.btn_raporlarForm = new BogaziciBarkodluSatis.Controls.CntrlButton();
            this.lbl_logo = new BogaziciBarkodluSatis.lblStandart();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_logo);
            this.panel1.Controls.Add(this.lbl_cactusSoft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 45);
            this.panel1.TabIndex = 0;
            // 
            // lbl_cactusSoft
            // 
            this.lbl_cactusSoft.AutoSize = true;
            this.lbl_cactusSoft.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cactusSoft.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_cactusSoft.Location = new System.Drawing.Point(39, 17);
            this.lbl_cactusSoft.Name = "lbl_cactusSoft";
            this.lbl_cactusSoft.Size = new System.Drawing.Size(121, 19);
            this.lbl_cactusSoft.TabIndex = 5;
            this.lbl_cactusSoft.Text = "Cactus Soft";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 45);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_fiyatGuncelle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_fiyatGuncelleForm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_gelirGiderForm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_raporlarForm, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 147);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_fiyatGuncelle
            // 
            this.btn_fiyatGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.btn_fiyatGuncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(80)))));
            this.btn_fiyatGuncelle.BorderColor = System.Drawing.Color.Black;
            this.btn_fiyatGuncelle.BorderRadius = 35;
            this.btn_fiyatGuncelle.BorderSize = 0;
            this.btn_fiyatGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_fiyatGuncelle.FlatAppearance.BorderSize = 0;
            this.btn_fiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fiyatGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_fiyatGuncelle.Image = global::BogaziciBarkodluSatis.Properties.Resources.fiyatguncelletl4854;
            this.btn_fiyatGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fiyatGuncelle.Location = new System.Drawing.Point(325, 3);
            this.btn_fiyatGuncelle.Name = "btn_fiyatGuncelle";
            this.btn_fiyatGuncelle.Size = new System.Drawing.Size(155, 141);
            this.btn_fiyatGuncelle.TabIndex = 2;
            this.btn_fiyatGuncelle.Text = "Fiyat Güncelle";
            this.btn_fiyatGuncelle.TextColor = System.Drawing.Color.White;
            this.btn_fiyatGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fiyatGuncelle.UseVisualStyleBackColor = false;
            this.btn_fiyatGuncelle.Click += new System.EventHandler(this.btn_fiyatGuncelleForm_Click);
            // 
            // btn_fiyatGuncelleForm
            // 
            this.btn_fiyatGuncelleForm.BackColor = System.Drawing.Color.DimGray;
            this.btn_fiyatGuncelleForm.BackgroundColor = System.Drawing.Color.DimGray;
            this.btn_fiyatGuncelleForm.BorderColor = System.Drawing.Color.Black;
            this.btn_fiyatGuncelleForm.BorderRadius = 35;
            this.btn_fiyatGuncelleForm.BorderSize = 0;
            this.btn_fiyatGuncelleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_fiyatGuncelleForm.FlatAppearance.BorderSize = 0;
            this.btn_fiyatGuncelleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fiyatGuncelleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fiyatGuncelleForm.ForeColor = System.Drawing.Color.White;
            this.btn_fiyatGuncelleForm.Image = global::BogaziciBarkodluSatis.Properties.Resources.backArrow;
            this.btn_fiyatGuncelleForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fiyatGuncelleForm.Location = new System.Drawing.Point(486, 3);
            this.btn_fiyatGuncelleForm.Name = "btn_fiyatGuncelleForm";
            this.btn_fiyatGuncelleForm.Size = new System.Drawing.Size(155, 141);
            this.btn_fiyatGuncelleForm.TabIndex = 3;
            this.btn_fiyatGuncelleForm.Text = "Geri";
            this.btn_fiyatGuncelleForm.TextColor = System.Drawing.Color.White;
            this.btn_fiyatGuncelleForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fiyatGuncelleForm.UseVisualStyleBackColor = false;
            this.btn_fiyatGuncelleForm.Click += new System.EventHandler(this.btn_baslangıc_Click);
            // 
            // btn_gelirGiderForm
            // 
            this.btn_gelirGiderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.btn_gelirGiderForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.btn_gelirGiderForm.BorderColor = System.Drawing.Color.Black;
            this.btn_gelirGiderForm.BorderRadius = 35;
            this.btn_gelirGiderForm.BorderSize = 0;
            this.btn_gelirGiderForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gelirGiderForm.FlatAppearance.BorderSize = 0;
            this.btn_gelirGiderForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gelirGiderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gelirGiderForm.ForeColor = System.Drawing.Color.White;
            this.btn_gelirGiderForm.Image = global::BogaziciBarkodluSatis.Properties.Resources.faura641;
            this.btn_gelirGiderForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gelirGiderForm.Location = new System.Drawing.Point(3, 3);
            this.btn_gelirGiderForm.Name = "btn_gelirGiderForm";
            this.btn_gelirGiderForm.Size = new System.Drawing.Size(155, 141);
            this.btn_gelirGiderForm.TabIndex = 0;
            this.btn_gelirGiderForm.Text = "Ek Gelir ve Faturalar";
            this.btn_gelirGiderForm.TextColor = System.Drawing.Color.White;
            this.btn_gelirGiderForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gelirGiderForm.UseVisualStyleBackColor = false;
            this.btn_gelirGiderForm.Click += new System.EventHandler(this.btn_gelirGiderForm_Click);
            // 
            // btn_raporlarForm
            // 
            this.btn_raporlarForm.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_raporlarForm.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.btn_raporlarForm.BorderColor = System.Drawing.Color.Black;
            this.btn_raporlarForm.BorderRadius = 35;
            this.btn_raporlarForm.BorderSize = 0;
            this.btn_raporlarForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_raporlarForm.FlatAppearance.BorderSize = 0;
            this.btn_raporlarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporlarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporlarForm.ForeColor = System.Drawing.Color.White;
            this.btn_raporlarForm.Image = global::BogaziciBarkodluSatis.Properties.Resources.rapor4854;
            this.btn_raporlarForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_raporlarForm.Location = new System.Drawing.Point(164, 3);
            this.btn_raporlarForm.Name = "btn_raporlarForm";
            this.btn_raporlarForm.Size = new System.Drawing.Size(155, 141);
            this.btn_raporlarForm.TabIndex = 1;
            this.btn_raporlarForm.Text = "Raporlar";
            this.btn_raporlarForm.TextColor = System.Drawing.Color.White;
            this.btn_raporlarForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_raporlarForm.UseVisualStyleBackColor = false;
            this.btn_raporlarForm.Click += new System.EventHandler(this.btn_raporlarForm_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_logo.ForeColor = System.Drawing.Color.Black;
            this.lbl_logo.Image = global::BogaziciBarkodluSatis.Properties.Resources.cactus24;
            this.lbl_logo.Location = new System.Drawing.Point(1, -1);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(42, 46);
            this.lbl_logo.TabIndex = 4;
            this.lbl_logo.Text = "..";
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 251);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.CntrlButton btn_raporlarForm;
        private Controls.CntrlButton btn_gelirGiderForm;
        private Controls.CntrlButton btn_fiyatGuncelleForm;
        private Controls.CntrlButton btn_fiyatGuncelle;
        private lblStandart lbl_logo;
        private lblStandart lbl_cactusSoft;
    }
}