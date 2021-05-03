namespace SinemaRezervasyon.Bilgi
{
    partial class frmYoneticiGiris
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
            this.txtYoneticiAd = new System.Windows.Forms.TextBox();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYoneticiGiris = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoneticiGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYoneticiAd
            // 
            this.txtYoneticiAd.Location = new System.Drawing.Point(151, 38);
            this.txtYoneticiAd.Name = "txtYoneticiAd";
            this.txtYoneticiAd.Size = new System.Drawing.Size(125, 20);
            this.txtYoneticiAd.TabIndex = 0;
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.Location = new System.Drawing.Point(151, 76);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.PasswordChar = '*';
            this.txtYoneticiSifre.Size = new System.Drawing.Size(125, 20);
            this.txtYoneticiSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(90, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGiris.Image = global::SinemaRezervasyon.Properties.Resources.loggg;
            this.btnYoneticiGiris.Location = new System.Drawing.Point(282, 38);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(61, 58);
            this.btnYoneticiGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYoneticiGiris.TabIndex = 4;
            this.btnYoneticiGiris.TabStop = false;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // frmYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaRezervasyon.Properties.Resources.tr_tr_sinema_696x435;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 418);
            this.Controls.Add(this.btnYoneticiGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYoneticiSifre);
            this.Controls.Add(this.txtYoneticiAd);
            this.Name = "frmYoneticiGiris";
            this.Text = "frmYoneticiGiris";
            ((System.ComponentModel.ISupportInitialize)(this.btnYoneticiGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYoneticiAd;
        private System.Windows.Forms.TextBox txtYoneticiSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnYoneticiGiris;
    }
}