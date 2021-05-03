namespace SinemaRezervasyon.Bilgi
{
    partial class frmFilmGuncelleme
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
            this.Salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAc = new System.Windows.Forms.Button();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.ComboBox();
            this.txtSeans = new System.Windows.Forms.ComboBox();
            this.txtSalon = new System.Windows.Forms.ComboBox();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Seans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.FilmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKapat = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).BeginInit();
            this.SuspendLayout();
            // 
            // Salon
            // 
            this.Salon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Salon.HeaderText = "Salon";
            this.Salon.MinimumWidth = 6;
            this.Salon.Name = "Salon";
            this.Salon.Width = 59;
            // 
            // Tur
            // 
            this.Tur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tur.HeaderText = "Tür";
            this.Tur.MinimumWidth = 6;
            this.Tur.Name = "Tur";
            this.Tur.Width = 48;
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(332, 162);
            this.btnAc.Margin = new System.Windows.Forms.Padding(2);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(22, 19);
            this.btnAc.TabIndex = 12;
            this.btnAc.Text = "...";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(151, 162);
            this.txtResim.Margin = new System.Windows.Forms.Padding(2);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(153, 20);
            this.txtResim.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Tan;
            this.label7.Location = new System.Drawing.Point(31, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Resim:";
            // 
            // txtTur
            // 
            this.txtTur.FormattingEnabled = true;
            this.txtTur.Location = new System.Drawing.Point(262, 97);
            this.txtTur.Margin = new System.Windows.Forms.Padding(2);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(92, 21);
            this.txtTur.TabIndex = 9;
            // 
            // txtSeans
            // 
            this.txtSeans.FormattingEnabled = true;
            this.txtSeans.Location = new System.Drawing.Point(151, 97);
            this.txtSeans.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeans.Name = "txtSeans";
            this.txtSeans.Size = new System.Drawing.Size(92, 21);
            this.txtSeans.TabIndex = 9;
            // 
            // txtSalon
            // 
            this.txtSalon.FormattingEnabled = true;
            this.txtSalon.Location = new System.Drawing.Point(38, 97);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(92, 21);
            this.txtSalon.TabIndex = 9;
            this.txtSalon.SelectedIndexChanged += new System.EventHandler(this.txtSalon_SelectedIndexChanged);
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 54;
            // 
            // Resim
            // 
            this.Resim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Resim.HeaderText = "Resim";
            this.Resim.MinimumWidth = 6;
            this.Resim.Name = "Resim";
            this.Resim.Width = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(290, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tür";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(31, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fiyat :";
            // 
            // txtFilmFiyat
            // 
            this.txtFilmFiyat.Location = new System.Drawing.Point(151, 132);
            this.txtFilmFiyat.Name = "txtFilmFiyat";
            this.txtFilmFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFilmFiyat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(227, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "FİLM GÜNCELLEME";
            // 
            // Seans
            // 
            this.Seans.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Seans.HeaderText = "Seans";
            this.Seans.MinimumWidth = 6;
            this.Seans.Name = "Seans";
            this.Seans.Width = 62;
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(151, 40);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(100, 20);
            this.txtFilmAdi.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(166, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seanslar :";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FilmAdi,
            this.Salon,
            this.Seans,
            this.Tur,
            this.Fiyat,
            this.Resim});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, -2);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.Size = new System.Drawing.Size(621, 88);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // FilmAdi
            // 
            this.FilmAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilmAdi.HeaderText = "Film Adı";
            this.FilmAdi.MinimumWidth = 6;
            this.FilmAdi.Name = "FilmAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salonlar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı :";
            // 
            // split2
            // 
            this.split2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split2.Dock = System.Windows.Forms.DockStyle.Top;
            this.split2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.split2.Panel1.BackgroundImage = global::SinemaRezervasyon.Properties.Resources.heykalkındostlar;
            this.split2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.split2.Panel1.Controls.Add(this.pictureBox1);
            this.split2.Panel1.Controls.Add(this.btnAc);
            this.split2.Panel1.Controls.Add(this.txtResim);
            this.split2.Panel1.Controls.Add(this.label7);
            this.split2.Panel1.Controls.Add(this.txtTur);
            this.split2.Panel1.Controls.Add(this.txtSeans);
            this.split2.Panel1.Controls.Add(this.txtSalon);
            this.split2.Panel1.Controls.Add(this.label6);
            this.split2.Panel1.Controls.Add(this.label5);
            this.split2.Panel1.Controls.Add(this.txtFilmFiyat);
            this.split2.Panel1.Controls.Add(this.txtFilmAdi);
            this.split2.Panel1.Controls.Add(this.label4);
            this.split2.Panel1.Controls.Add(this.label3);
            this.split2.Panel1.Controls.Add(this.label2);
            this.split2.Panel1.Controls.Add(this.label1);
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.Controls.Add(this.Liste);
            this.split2.Size = new System.Drawing.Size(625, 500);
            this.split2.SplitterDistance = 406;
            this.split2.TabIndex = 0;
            // 
            // split1
            // 
            this.split1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Name = "split1";
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.split2);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.BackColor = System.Drawing.Color.Black;
            this.split1.Panel2.BackgroundImage = global::SinemaRezervasyon.Properties.Resources.jokerbilader;
            this.split1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.split1.Panel2.Controls.Add(this.btnKapat);
            this.split1.Panel2.Controls.Add(this.btnSil);
            this.split1.Panel2.Controls.Add(this.btnKaydet);
            this.split1.Size = new System.Drawing.Size(825, 507);
            this.split1.SplitterDistance = 629;
            this.split1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(398, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Image = global::SinemaRezervasyon.Properties.Resources.close;
            this.btnKapat.Location = new System.Drawing.Point(19, 438);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(59, 55);
            this.btnKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKapat.TabIndex = 5;
            this.btnKapat.TabStop = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Image = global::SinemaRezervasyon.Properties.Resources.Sil;
            this.btnSil.Location = new System.Drawing.Point(19, 99);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(59, 55);
            this.btnSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSil.TabIndex = 4;
            this.btnSil.TabStop = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = global::SinemaRezervasyon.Properties.Resources.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(19, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(59, 53);
            this.btnKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.TabStop = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmFilmGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 507);
            this.Controls.Add(this.split1);
            this.Name = "frmFilmGuncelleme";
            this.Text = "frmFilmGuncelleme";
            this.Load += new System.EventHandler(this.frmFilmGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel1.PerformLayout();
            this.split2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKaydet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Salon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtTur;
        private System.Windows.Forms.ComboBox txtSeans;
        private System.Windows.Forms.ComboBox txtSalon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seans;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.PictureBox btnKapat;
        private System.Windows.Forms.PictureBox btnSil;
        private System.Windows.Forms.PictureBox btnKaydet;
    }
}