namespace stoktakipsistemi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnl_ekle = new System.Windows.Forms.Panel();
            this.pnl_sil = new System.Windows.Forms.Panel();
            this.pnl_guncelle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_cikis = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(62, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 224);
            this.listBox1.TabIndex = 0;
            // 
            // pnl_ekle
            // 
            this.pnl_ekle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ekle.Location = new System.Drawing.Point(62, 363);
            this.pnl_ekle.Name = "pnl_ekle";
            this.pnl_ekle.Size = new System.Drawing.Size(205, 50);
            this.pnl_ekle.TabIndex = 1;
            this.pnl_ekle.Click += new System.EventHandler(this.pnl_ekle_Click);
            // 
            // pnl_sil
            // 
            this.pnl_sil.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sil.Location = new System.Drawing.Point(285, 363);
            this.pnl_sil.Name = "pnl_sil";
            this.pnl_sil.Size = new System.Drawing.Size(211, 50);
            this.pnl_sil.TabIndex = 2;
            this.pnl_sil.Click += new System.EventHandler(this.pnl_sil_Click);
            // 
            // pnl_guncelle
            // 
            this.pnl_guncelle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_guncelle.Location = new System.Drawing.Point(60, 434);
            this.pnl_guncelle.Name = "pnl_guncelle";
            this.pnl_guncelle.Size = new System.Drawing.Size(208, 48);
            this.pnl_guncelle.TabIndex = 3;
            this.pnl_guncelle.Click += new System.EventHandler(this.pnl_guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // pnl_cikis
            // 
            this.pnl_cikis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cikis.Location = new System.Drawing.Point(288, 434);
            this.pnl_cikis.Name = "pnl_cikis";
            this.pnl_cikis.Size = new System.Drawing.Size(208, 48);
            this.pnl_cikis.TabIndex = 4;
            this.pnl_cikis.Click += new System.EventHandler(this.pnl_cikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_cikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_guncelle);
            this.Controls.Add(this.pnl_sil);
            this.Controls.Add(this.pnl_ekle);
            this.Controls.Add(this.listBox1);
            this.Name = "anasayfa";
            this.Text = "Stok Takip Sistemi";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnl_ekle;
        private System.Windows.Forms.Panel pnl_sil;
        private System.Windows.Forms.Panel pnl_guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_cikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}