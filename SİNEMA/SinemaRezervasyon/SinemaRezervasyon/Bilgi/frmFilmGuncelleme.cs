using SinemaRezervasyon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaRezervasyon.Bilgi
{
    public partial class frmFilmGuncelleme : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        int secimId = -1;
        bool edit = false;
        public frmFilmGuncelleme()
        {
            InitializeComponent();
        }

        private void frmFilmGuncelleme_Load(object sender, EventArgs e)
        {
            Combo();
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.blgFilms
                       select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.blgFilmTablo.FilmAdi;
                Liste.Rows[i].Cells[2].Value = k.blgSalon.SalonNo;
                Liste.Rows[i].Cells[3].Value = k.blgSean.Seans;
                Liste.Rows[i].Cells[4].Value = k.blgTur.TurAdi;
                Liste.Rows[i].Cells[5].Value = k.Fiyat;
                Liste.Rows[i].Cells[6].Value = k.ResimUrl;

                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        private void Combo()
        {
            txtTur.DataSource = db.blgTurs.ToList();
            txtTur.ValueMember = "Id";
            txtTur.DisplayMember = "TurAdi";
            txtTur.SelectedIndex = -1;

            txtSalon.Items.Clear();
            int seansadet = db.blgSeans.ToList().Count();
            var deneme = (from s in db.blgSalons select s).ToList();

            foreach (var k in deneme)
            {
                int salonadet = db.blgFilms.Where(x => x.SalonId == k.Id).ToList().Count(); //film tablosundaki salon ıd sayıları
                if (salonadet != seansadet)
                {
                    txtSalon.Items.Add(k.SalonNo);
                }
            }
        }

        private void txtSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSeans.Items.Clear();
            var TumSeans = db.blgSeans.ToList();
            int a = db.blgSalons.First(x => x.SalonNo == txtSalon.Text).Id;
            var DoluSeans = (from s in db.blgFilms where s.SalonId == a select s.SeansId).ToList();
            if (DoluSeans.Count == 0)
            {
                foreach (var t in TumSeans)
                {
                    txtSeans.Items.Add(t.Seans);
                }
            }

            else
            {
                foreach (var k in DoluSeans)
                {
                    foreach (var j in TumSeans)
                    {
                        if (DoluSeans.Count() != TumSeans.Count() && !DoluSeans.Contains(j.Id) && !txtSeans.Items.Contains(j.Seans))
                        {
                            txtSeans.Items.Add(j.Seans);
                        }
                    }
                }
            }      
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false)
                YeniKaydet();
        }
        private void Guncelle()
        {
            blgFilm flm = db.blgFilms.Find(secimId);
            flm.blgFilmTablo.FilmAdi = txtFilmAdi.Text;
            flm.Fiyat = Convert.ToDouble(txtFilmFiyat.Text);
            flm.SalonId = db.blgSalons.First(x => x.SalonNo == txtSalon.Text).Id;
            flm.SeansId = db.blgSeans.First(x => x.Seans == txtSeans.Text).Id;
            flm.TurId = db.blgTurs.First(x => x.TurAdi == txtTur.Text).Id;
            flm.ResimUrl = txtResim.Text;

            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
            Listele();
            Temizle();
        }
        private void Temizle()
        {
            foreach (Control con in split2.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox)
                {
                    con.Text = "";
                }
            }

            secimId = -1;
            edit = false;
        }
        private void YeniKaydet()
        {
            FilmKaydet();
            blgFilm flm = new blgFilm();
            flm.FilmTabloId = db.blgFilmTabloes.First(x => x.FilmAdi == txtFilmAdi.Text).Id;

            flm.SalonId = db.blgSalons.First(x => x.SalonNo == txtSalon.Text).Id;
            flm.SeansId = db.blgSeans.First(x => x.Seans == txtSeans.Text).Id;
            flm.TurId = db.blgTurs.First(x => x.TurAdi == txtTur.Text).Id;
            flm.Fiyat = Convert.ToDouble(txtFilmFiyat.Text);
            flm.ResimUrl = txtResim.Text;

            db.blgFilms.Add(flm);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
            Listele();
            Temizle();
        }
        private void FilmKaydet()
        {
            blgFilmTablo ft = new blgFilmTablo();
            ft.FilmAdi = txtFilmAdi.Text;
            db.blgFilmTabloes.Add(ft);
            db.SaveChanges();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
        }
        private void Ac(int secimId)
        {
            edit = true;
            blgFilm flm = db.blgFilms.Find(secimId);
            txtFilmAdi.Text = flm.blgFilmTablo.FilmAdi;
            txtSalon.Text = flm.blgSalon.SalonNo;
            txtSeans.Text = flm.blgSean.Seans;
            txtTur.Text = flm.blgTur.TurAdi;
            txtFilmFiyat.Text = flm.Fiyat.ToString();
            txtResim.Text = flm.ResimUrl;

            pictureBox1.ImageLocation = flm.ResimUrl;
        }
        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0)
            {
                Sil();
            }
        }
        private void Sil()
        {
            db.blgFilms.Remove(db.blgFilms.Find(secimId));
            db.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir");
            Listele();
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }
    }
}
