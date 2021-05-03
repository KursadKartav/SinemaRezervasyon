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
    public partial class frmYiyecekGuncelleme : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        int secimId = -1;
        bool edit = false;
        public frmYiyecekGuncelleme()
        {
            InitializeComponent();
        }

        private void frmYiyecekGuncelleme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false)

                YeniKaydet();
        }
        private void YeniKaydet()
        {
            blgYiyecek yck = new blgYiyecek();
            yck.YiyecekAdi = txtYiyecek.Text;
            yck.Fiyat = Convert.ToDouble(txtFiyat.Text);

            db.blgYiyeceks.Add(yck);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");
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

        private void Guncelle()
        {
            blgYiyecek yck = db.blgYiyeceks.Find(secimId);
            yck.YiyecekAdi = txtYiyecek.Text;
            yck.Fiyat = Convert.ToInt32(txtFiyat.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
            Listele();
            Temizle();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.blgYiyeceks
                       select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.YiyecekAdi;
                Liste.Rows[i].Cells[2].Value = k.Fiyat;
                i++;
            }
            Liste.AllowUserToAddRows = false;
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
            blgYiyecek yck = db.blgYiyeceks.Find(secimId);
            txtYiyecek.Text = yck.YiyecekAdi;
            txtFiyat.Text = yck.Fiyat.ToString();
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
            db.blgYiyeceks.Remove(db.blgYiyeceks.Find(secimId));
            db.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir");
            Listele();
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
