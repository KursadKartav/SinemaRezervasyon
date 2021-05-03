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
    public partial class frmIcecekGuncelleme : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        int secimId = -1;
        bool edit = false;
        public frmIcecekGuncelleme()
        {
            InitializeComponent();
        }

        private void frmIcecekGuncelleme_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.blgIceceks
                       select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.IcecekAdi;
                Liste.Rows[i].Cells[2].Value = k.Fiyat;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        private void Guncelle()
        {
            blgIcecek ick = db.blgIceceks.Find(secimId);
            ick.IcecekAdi = txtIcecekAdi.Text;
            ick.Fiyat = Convert.ToInt32(txtFiyat.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
            Listele();
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control con in split2.Panel1.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = "";
                }
            }
            secimId = -1;
            edit = false;
        }

        private void YeniKaydet()
        {
            blgIcecek ick = new blgIcecek();
            ick.IcecekAdi = txtIcecekAdi.Text;
            ick.Fiyat = Convert.ToDouble(txtFiyat.Text);

            db.blgIceceks.Add(ick);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
            Listele();
            Temizle();
        }
        private void Ac(int secimId)
        {

            edit = true;
            blgIcecek ick = db.blgIceceks.Find(secimId);
            txtIcecekAdi.Text = ick.IcecekAdi;
            txtFiyat.Text = ick.Fiyat.ToString();
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
        private void Sil()
        {
            db.blgIceceks.Remove(db.blgIceceks.Find(secimId));
            db.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir");
            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false)

                YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
        }
    }
}
