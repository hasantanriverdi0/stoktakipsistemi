namespace stoktakipsistemi
{
    partial class giriss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giriss));
            this.pnl_giris = new System.Windows.Forms.Panel();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.chc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pnl_giris
            // 
            this.pnl_giris.BackColor = System.Drawing.Color.Transparent;
            this.pnl_giris.Location = new System.Drawing.Point(86, 444);
            this.pnl_giris.Name = "pnl_giris";
            this.pnl_giris.Size = new System.Drawing.Size(383, 39);
            this.pnl_giris.TabIndex = 0;
            this.pnl_giris.Click += new System.EventHandler(this.pnl_giris_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(107, 194);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(204, 24);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(107, 268);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(204, 24);
            this.txt_sifre.TabIndex = 2;
            // 
            // chc
            // 
            this.chc.AutoSize = true;
            this.chc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chc.Location = new System.Drawing.Point(108, 297);
            this.chc.Name = "chc";
            this.chc.Size = new System.Drawing.Size(86, 17);
            this.chc.TabIndex = 3;
            this.chc.Text = "Şifreyi Göster";
            this.chc.UseVisualStyleBackColor = false;
            this.chc.CheckedChanged += new System.EventHandler(this.chc_CheckedChanged);
            // 
            // giriss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.chc);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.pnl_giris);
            this.Name = "giriss";
            this.Text = "Stok Takip Sistemi";
            this.Load += new System.EventHandler(this.giriss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_giris;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.CheckBox chc;
    }
}