namespace SinemaRezervasyon.Bilgi
{
    partial class frmHesap
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatilanBiletMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GunlukCiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGunlukBiletToplami = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.txtCiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelMiktar = new System.Windows.Forms.TextBox();
            this.txtIcecekMiktar = new System.Windows.Forms.TextBox();
            this.txtYiyecekMiktar = new System.Windows.Forms.TextBox();
            this.txtFilmMiktar = new System.Windows.Forms.TextBox();
            this.txtFilmId = new System.Windows.Forms.ComboBox();
            this.txtIcecekId = new System.Windows.Forms.ComboBox();
            this.txtYiyecekId = new System.Windows.Forms.ComboBox();
            this.txtPersonelId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SatilanBiletMiktari,
            this.Tarih,
            this.GunlukCiro});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 322);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(800, 128);
            this.Liste.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // SatilanBiletMiktari
            // 
            this.SatilanBiletMiktari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SatilanBiletMiktari.HeaderText = "Satılan BiletMiktarı";
            this.SatilanBiletMiktari.Name = "SatilanBiletMiktari";
            // 
            // Tarih
            // 
            this.Tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 56;
            // 
            // GunlukCiro
            // 
            this.GunlukCiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GunlukCiro.HeaderText = "Günlük Ciro";
            this.GunlukCiro.Name = "GunlukCiro";
            this.GunlukCiro.Width = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Tan;
            this.label8.Location = new System.Drawing.Point(548, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 112;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Tan;
            this.label7.Location = new System.Drawing.Point(445, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 111;
            this.label7.Text = "label7";
            // 
            // txtGunlukBiletToplami
            // 
            this.txtGunlukBiletToplami.Location = new System.Drawing.Point(495, 85);
            this.txtGunlukBiletToplami.Name = "txtGunlukBiletToplami";
            this.txtGunlukBiletToplami.Size = new System.Drawing.Size(100, 20);
            this.txtGunlukBiletToplami.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(365, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 109;
            this.label3.Text = "Satılan Bilet :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(512, 256);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(100, 20);
            this.txtBul.TabIndex = 108;
            // 
            // txtCiro
            // 
            this.txtCiro.Location = new System.Drawing.Point(495, 111);
            this.txtCiro.Name = "txtCiro";
            this.txtCiro.Size = new System.Drawing.Size(100, 20);
            this.txtCiro.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(422, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 106;
            this.label6.Text = "Ciro :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonelMiktar
            // 
            this.txtPersonelMiktar.Location = new System.Drawing.Point(137, 235);
            this.txtPersonelMiktar.Name = "txtPersonelMiktar";
            this.txtPersonelMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelMiktar.TabIndex = 105;
            // 
            // txtIcecekMiktar
            // 
            this.txtIcecekMiktar.Location = new System.Drawing.Point(137, 175);
            this.txtIcecekMiktar.Name = "txtIcecekMiktar";
            this.txtIcecekMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtIcecekMiktar.TabIndex = 104;
            // 
            // txtYiyecekMiktar
            // 
            this.txtYiyecekMiktar.Location = new System.Drawing.Point(136, 112);
            this.txtYiyecekMiktar.Name = "txtYiyecekMiktar";
            this.txtYiyecekMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtYiyecekMiktar.TabIndex = 103;
            // 
            // txtFilmMiktar
            // 
            this.txtFilmMiktar.Location = new System.Drawing.Point(137, 47);
            this.txtFilmMiktar.Name = "txtFilmMiktar";
            this.txtFilmMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtFilmMiktar.TabIndex = 102;
            // 
            // txtFilmId
            // 
            this.txtFilmId.FormattingEnabled = true;
            this.txtFilmId.Location = new System.Drawing.Point(31, 47);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.Size = new System.Drawing.Size(97, 21);
            this.txtFilmId.TabIndex = 101;
            this.txtFilmId.SelectedIndexChanged += new System.EventHandler(this.txtFilmId_SelectedIndexChanged);
            // 
            // txtIcecekId
            // 
            this.txtIcecekId.FormattingEnabled = true;
            this.txtIcecekId.Location = new System.Drawing.Point(34, 174);
            this.txtIcecekId.Name = "txtIcecekId";
            this.txtIcecekId.Size = new System.Drawing.Size(97, 21);
            this.txtIcecekId.TabIndex = 100;
            this.txtIcecekId.SelectedIndexChanged += new System.EventHandler(this.txtIcecekId_SelectedIndexChanged);
            // 
            // txtYiyecekId
            // 
            this.txtYiyecekId.FormattingEnabled = true;
            this.txtYiyecekId.Location = new System.Drawing.Point(31, 111);
            this.txtYiyecekId.Name = "txtYiyecekId";
            this.txtYiyecekId.Size = new System.Drawing.Size(97, 21);
            this.txtYiyecekId.TabIndex = 99;
            this.txtYiyecekId.SelectedIndexChanged += new System.EventHandler(this.txtYiyecekId_SelectedIndexChanged);
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.FormattingEnabled = true;
            this.txtPersonelId.Location = new System.Drawing.Point(27, 234);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(97, 21);
            this.txtPersonelId.TabIndex = 98;
            this.txtPersonelId.SelectedIndexChanged += new System.EventHandler(this.txtPersonelId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 97;
            this.label5.Text = "Personel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(133, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "Satış Miktarı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.ForeColor = System.Drawing.Color.Tan;
            this.label30.Location = new System.Drawing.Point(31, 148);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(69, 23);
            this.label30.TabIndex = 96;
            this.label30.Text = "İçecek";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.Color.Tan;
            this.label31.Location = new System.Drawing.Point(133, 148);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(104, 23);
            this.label31.TabIndex = 94;
            this.label31.Text = "Satış Miktarı";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Tan;
            this.label12.Location = new System.Drawing.Point(31, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 93;
            this.label12.Text = "Yiyecek";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Tan;
            this.label13.Location = new System.Drawing.Point(133, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 91;
            this.label13.Text = "Satış Miktarı";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(133, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Satış Miktarı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 90;
            this.label1.Text = "Filmler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = global::SinemaRezervasyon.Properties.Resources.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(601, 85);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(49, 46);
            this.btnKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKaydet.TabIndex = 113;
            this.btnKaydet.TabStop = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::SinemaRezervasyon.Properties.Resources.bull;
            this.pictureBox1.Location = new System.Drawing.Point(620, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaRezervasyon.Properties.Resources._44561982_rideau_rouge_avec_spot_sur_le_théâtre_ou_le_stade_de_cinéma_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGunlukBiletToplami);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.txtCiro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPersonelMiktar);
            this.Controls.Add(this.txtIcecekMiktar);
            this.Controls.Add(this.txtYiyecekMiktar);
            this.Controls.Add(this.txtFilmMiktar);
            this.Controls.Add(this.txtFilmId);
            this.Controls.Add(this.txtIcecekId);
            this.Controls.Add(this.txtYiyecekId);
            this.Controls.Add(this.txtPersonelId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Liste);
            this.Name = "frmHesap";
            this.Text = "frmHesap";
            this.Load += new System.EventHandler(this.frmHesap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatilanBiletMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn GunlukCiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGunlukBiletToplami;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.TextBox txtCiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelMiktar;
        private System.Windows.Forms.TextBox txtIcecekMiktar;
        private System.Windows.Forms.TextBox txtYiyecekMiktar;
        private System.Windows.Forms.TextBox txtFilmMiktar;
        private System.Windows.Forms.ComboBox txtFilmId;
        private System.Windows.Forms.ComboBox txtIcecekId;
        private System.Windows.Forms.ComboBox txtYiyecekId;
        private System.Windows.Forms.ComboBox txtPersonelId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}