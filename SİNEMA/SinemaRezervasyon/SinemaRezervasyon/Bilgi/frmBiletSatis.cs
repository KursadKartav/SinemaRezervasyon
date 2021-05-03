using SinemaRezervasyon.Data;
using SinemaRezervasyon.Fonksiyonlar;
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
    public partial class frmBiletSatis : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        int secimId = -1;
        bool edit = false;
        double toplam = 0;
        int mavikoltuk = 0;
        Numaralar N = new Numaralar();
        public frmBiletSatis()
        {
            InitializeComponent();
        }

        private void frmBiletSatis_Load(object sender, EventArgs e)
        {
            txtBiletNo.Text = N.BiletNo();
            Combo();
        }
        private void Combo()
        {
            txtYiyecekId.Items.Clear();
            txtYiyecekId.DataSource = db.blgYiyeceks.ToList();
            txtYiyecekId.ValueMember = "Id";
            txtYiyecekId.DisplayMember = "YiyecekAdi";
            txtYiyecekId.SelectedIndex = 0;

            txtIcecekId.Items.Clear();
            txtIcecekId.DataSource = db.blgIceceks.ToList();
            txtIcecekId.ValueMember = "Id";
            txtIcecekId.DisplayMember = "IcecekAdi";
            txtIcecekId.SelectedIndex = 0;

            txtPersonelId.Items.Clear();
            txtPersonelId.DataSource = db.blgPersonels.ToList();
            txtPersonelId.ValueMember = "Id";
            txtPersonelId.DisplayMember = "PersonelAdi";
            txtPersonelId.SelectedIndex = 0;

            txtFilmId.Items.Clear();
            var srg = (from s in db.blgFilmTabloes
                       select s).ToList();
            foreach (var k in srg)
            {
                txtFilmId.Items.Add(k.FilmAdi);
            }
        }
        private void Yazdir()
        {
            int a = -1;
            a = db.blgFilmTabloes.First(y => y.FilmAdi == txtFilmId.Text).Id;
            int b = -1;
            b = db.blgSalons.First(z => z.SalonNo == txtSalonId.Text).Id;
            int d = -1;
            d = db.blgSeans.First(c => c.Seans == txtSeansId.Text).Id;
            DateTime dtTarih = Convert.ToDateTime(txtTarih.Text);

            var fiyatsrg = (from s in db.blgFilms where s.FilmTabloId == a && s.SalonId == b && s.SeansId == d select s.Fiyat);

            toplam = Convert.ToDouble(db.blgYiyeceks.First(x => x.YiyecekAdi == txtYiyecekId.Text).Fiyat);
            toplam += Convert.ToDouble(db.blgIceceks.First(x => x.IcecekAdi == txtIcecekId.Text).Fiyat);
            toplam += Convert.ToDouble(fiyatsrg.First()) * mavikoltuk;

            lblToplamTutar.Text = toplam.ToString();
            lblAdSoyad.Text = txtAdSoyad.Text;
            lblFilmAdi.Text = txtFilmId.Text;
            lblSalon.Text = txtSalonId.Text;
            lblSeans.Text = txtSeansId.Text;
            lblKoltukNo.Text = lblSelectKoltuk.Text;
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            YeniKaydet();
            Temizle();
        }
        private void YeniKaydet()
        {
            tblSati satis = new tblSati();
            string[] koltuklar;
            koltuklar = lblSelectKoltuk.Text.Split('-');
            foreach (var i in koltuklar)
            {
                if (i != "")
                {
                    satis.Tarih = Convert.ToDateTime(txtTarih.Text);
                    satis.SeansId = db.blgSeans.First(x => x.Seans == txtSeansId.Text).Id;
                    satis.SalonId = db.blgSalons.First(x => x.SalonNo == txtSalonId.Text).Id;
                    satis.PersonelId = db.blgPersonels.First(x => x.PersonelAdi == txtPersonelId.Text).Id;
                    satis.KoltukId = db.blgKoltuks.First(x => x.KoltukNo == i).Id;
                    satis.FilmId = db.blgFilmTabloes.First(x => x.FilmAdi == txtFilmId.Text).Id;
                    satis.BiletNo = txtBiletNo.Text;
                    satis.AdSoyad = txtAdSoyad.Text;
                    satis.BiletAdet = 1;
                    satis.YiyecekId = db.blgYiyeceks.First(x => x.YiyecekAdi == txtYiyecekId.Text).Id;
                    satis.IcecekId = db.blgIceceks.First(x => x.IcecekAdi == txtIcecekId.Text).Id;
                    satis.Tutar = Convert.ToDouble(lblToplamTutar.Text) / mavikoltuk;

                    db.tblSatis.Add(satis);
                    db.SaveChanges();
                    MessageBox.Show(i + " Numaralı koltuk alınmıştır.");
                }
            }
        }
        private void KoltukDuzen()
        {
            pnlKoltukDuzen.Controls.Clear();
            lblSelectKoltuk.Text = "";
            int Eklenenbuton_height = 0;
            int Soldan = 0, Ustten = 0;
            int kirmizi = 0;
            int a = Convert.ToInt32(db.blgSalons.First(x => x.SalonNo == txtSalonId.Text).KoltukSayisi);

            Button[] kltk = new Button[a];

            for (int i = 0; i < a; i++)
            {
                kirmizi = i + 1;

                kltk[i] = new Button();
                kltk[i].Text = "" + (i + 1);
                kltk[i].Height = 50;
                kltk[i].Width = 30;

                int f = -1;
                f = db.blgFilmTabloes.First(y => y.FilmAdi == txtFilmId.Text).Id;
                int b = -1;
                b = db.blgSalons.First(z => z.SalonNo == txtSalonId.Text).Id;
                int d = -1;
                d = db.blgSeans.First(c => c.Seans == txtSeansId.Text).Id;
                DateTime dtTarih = Convert.ToDateTime(txtTarih.Text);

                int dolukoltuk = 0;
                var srg = (from s in db.tblSatis where s.FilmId == f && s.SalonId == b && s.SeansId == d && s.Tarih==dtTarih select s).ToList();
                foreach (var q in srg)
                {
                    if (q.KoltukId == kirmizi)
                    {
                        dolukoltuk = 1;
                    }
                }
                if (dolukoltuk == 1)
                {
                    kltk[i].BackColor = Color.Red;
                }
                else
                {
                    kltk[i].BackColor = Color.Green;
                }
                pnlKoltukDuzen.Controls.Add(kltk[i]);
                Ustten = (kltk[i].Height * (Eklenenbuton_height / kltk[i].Height));
                Eklenenbuton_height += kltk[i].Height;
                switch (Eklenenbuton_height > pnlKoltukDuzen.Height)
                {
                    case true:
                        Ustten = 0;
                        Soldan += kltk[i].Width;
                        Eklenenbuton_height = kltk[i].Height;
                        break;
                }
                kltk[i].Location = new Point(Soldan + 10, Ustten + 10);
                kltk[i].Click += new EventHandler(b_Click);
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            if (mavikoltuk < 4)
            {
                if (((Button)sender).BackColor == Color.Red || ((Button)sender).BackColor == Color.Blue)
                {
                    MessageBox.Show(((Button)sender).Text + " Numaralı koltuk doludur.Başka koltuk seçiniz.");
                }
                else
                {
                    if (mavikoltuk != 3)
                    {
                        ((Button)sender).BackColor = Color.Blue;
                        mavikoltuk += 1;
                        lblSelectKoltuk.Text += ((Button)sender).Text + "-";
                    }
                    else
                    {
                        ((Button)sender).BackColor = Color.Blue;
                        mavikoltuk += 1;
                        lblSelectKoltuk.Text += ((Button)sender).Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("Tek seferde en fazla 4 koltuk seçebilirsiniz.");
            }
        }
        private void Temizle()
        {
            foreach (Control con in split1.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";

                }
                lblSelectKoltuk.Text = "";
                secimId = -1;
                edit = false;
            }
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            Yazdir();
        }

        private void txtFilmId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalonId.Items.Clear();
            int a = db.blgFilmTabloes.First(x => x.FilmAdi == txtFilmId.Text).Id;
            var srg = (from s in db.blgFilms
                       where s.FilmTabloId == a
                       select s).ToList();
            foreach (var k in srg)
            {
                if (!txtSalonId.Items.Contains(k.blgSalon.SalonNo))
                {
                    txtSalonId.Items.Add(k.blgSalon.SalonNo);
                }
            }
        }

        private void txtSalonId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSeansId.Items.Clear();
            int b = db.blgFilmTabloes.First(x => x.FilmAdi == txtFilmId.Text).Id;
            int a = db.blgSalons.First(x => x.SalonNo == txtSalonId.Text).Id;
            var srg = (from s in db.blgFilms
                       where s.SalonId == a && s.FilmTabloId == b
                       select s).ToList();
            foreach (var k in srg)
            {
                if (!txtSeansId.Items.Contains(k.blgSean.Seans))
                {
                    txtSeansId.Items.Add(k.blgSean.Seans);
                }
            }
        }
        private void txtSeansId_SelectedIndexChanged(object sender, EventArgs e)
        {
            KoltukDuzen();
        }
    }
}
