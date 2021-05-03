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
    public partial class frmHesap : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        public frmHesap()
        {
            InitializeComponent();
        }

        private void frmHesap_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToShortDateString();
            label8.Text = DateTime.Now.ToShortTimeString();
            Combo();
            Ciro();
            Listele();
            GunlukSatilanBilet();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblCiroes select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.ToplamBilet;
                Liste.Rows[i].Cells[2].Value = k.Tarih;
                Liste.Rows[i].Cells[3].Value = k.Ciro;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        private void YeniKaydet()
        {
            tblCiro cr = new tblCiro();
            cr.Ciro = Convert.ToInt32(txtCiro.Text);
            cr.Tarih = Convert.ToDateTime(label7.Text);
            cr.ToplamBilet = Convert.ToInt32(txtGunlukBiletToplami.Text);
            db.tblCiroes.Add(cr);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
            Listele();
        }
        private void Ciro()
        {
            DateTime c = Convert.ToDateTime(label7.Text);
            
            var a = db.tblSatis.Where(x => x.Tarih == c).Sum(x => x.Tutar);
            txtCiro.Text = a.ToString();
        }
        private void Combo()
        {
            var c = (from s in db.blgYiyeceks select s).ToList();
            foreach (var k in c)
            {
                txtYiyecekId.Items.Add(k.YiyecekAdi);
            }
            var b = (from s in db.blgIceceks select s).ToList();
            foreach (var k in b)
            {
                txtIcecekId.Items.Add(k.IcecekAdi);
            }
            var srg = (from s in db.blgFilmTabloes select s).ToList();
            foreach (var k in srg)
            {
                txtFilmId.Items.Add(k.FilmAdi);
            }
            var a = (from s in db.blgPersonels select s).ToList();
            foreach (var k in a)
            {
                txtPersonelId.Items.Add(k.PersonelAdi);
            }
        }
        private void FilmHesapla()
        {
            DateTime c = Convert.ToDateTime(label7.Text);
            int b = -1;
            b = db.blgFilmTabloes.First(x => x.FilmAdi == txtFilmId.Text).Id;
            var a = db.tblSatis.Where(x => x.FilmId == b && x.Tarih == c).Count();
            txtFilmMiktar.Text = a.ToString();
        }
        private void YiyecekHesapla()
        {
            DateTime c = Convert.ToDateTime(label7.Text);
            int b = -1;
            b = db.blgYiyeceks.First(x => x.YiyecekAdi == txtYiyecekId.Text).Id;
            var a = db.tblSatis.Where(x => x.YiyecekId == b && x.Tarih == c).Count();
            txtYiyecekMiktar.Text = a.ToString();
        }
        private void IcecekHesapla()
        {
            DateTime c = Convert.ToDateTime(label7.Text);
            int b = -1;
            b = db.blgIceceks.First(x => x.IcecekAdi == txtIcecekId.Text).Id;
            var a = db.tblSatis.Where(x => x.IcecekId == b && x.Tarih == c).Count();
            txtIcecekMiktar.Text = a.ToString();
        }
        private void PersonelHesapla()
        {
            DateTime c = Convert.ToDateTime(label7.Text);
            int b = -1;
            b = db.blgPersonels.First(x => x.PersonelAdi == txtPersonelId.Text).Id;
            var a = db.tblSatis.Where(x => x.PersonelId == b && x.Tarih == c).Count();
            txtPersonelMiktar.Text = a.ToString();
        }
        private void GunlukSatilanBilet()
        {
            DateTime c = Convert.ToDateTime(label7.Text);
            var a = db.tblSatis.Where(x => x.Tarih == c).Count();
            txtGunlukBiletToplami.Text = a.ToString();
        }

        private void txtFilmId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmHesapla();
        }

        private void txtYiyecekId_SelectedIndexChanged(object sender, EventArgs e)
        {
            YiyecekHesapla();
        }

        private void txtIcecekId_SelectedIndexChanged(object sender, EventArgs e)
        {
            IcecekHesapla();
        }

        private void txtPersonelId_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonelHesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(label8.Text) >= Convert.ToDateTime("16:09"))
            {
                YeniKaydet();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen mesai saatleri içinde kayıt işlemi gerçekleştirmeyin.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtBul.Text != "")
            {
                DateTime t = Convert.ToDateTime(txtBul.Text);

                Liste.Rows.Clear();
                int i = 0;
                var srg = (from s in db.tblCiroes where s.Tarih == t select s).ToList();
                foreach (var k in srg)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.ToplamBilet;
                    Liste.Rows[i].Cells[2].Value = txtBul.Text;
                    Liste.Rows[i].Cells[3].Value = k.Ciro;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
            }
        }
    }
}
