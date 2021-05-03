namespace SinemaRezervasyon
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnYoneticiGiris = new System.Windows.Forms.PictureBox();
            this.btnPersonelGiris = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoneticiGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPersonelGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yönetici.png");
            this.ımageList1.Images.SetKeyName(1, "personel girişi.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(33, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "YÖNETİCİ GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(173, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PERSONEL GİRİŞİ";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "personel girişi.jpg");
            this.ımageList2.Images.SetKeyName(1, "yönetici.png");
            // 
            // btnYoneticiGiris
            // 
            this.btnYoneticiGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnYoneticiGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnYoneticiGiris.Image")));
            this.btnYoneticiGiris.Location = new System.Drawing.Point(36, 42);
            this.btnYoneticiGiris.Name = "btnYoneticiGiris";
            this.btnYoneticiGiris.Size = new System.Drawing.Size(113, 76);
            this.btnYoneticiGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnYoneticiGiris.TabIndex = 4;
            this.btnYoneticiGiris.TabStop = false;
            this.btnYoneticiGiris.Click += new System.EventHandler(this.btnYoneticiGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelGiris.Image = global::SinemaRezervasyon.Properties.Resources.personel_girişi;
            this.btnPersonelGiris.Location = new System.Drawing.Point(177, 42);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(111, 76);
            this.btnPersonelGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPersonelGiris.TabIndex = 5;
            this.btnPersonelGiris.TabStop = false;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaRezervasyon.Properties.Resources.tr_tr_sinema_696x435;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 413);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btnYoneticiGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnYoneticiGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPersonelGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox btnYoneticiGiris;
        private System.Windows.Forms.PictureBox btnPersonelGiris;
    }
}

