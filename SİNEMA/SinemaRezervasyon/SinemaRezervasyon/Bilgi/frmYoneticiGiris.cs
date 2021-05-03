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
    public partial class frmYoneticiGiris : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            blgYonetici y = db.blgYoneticis.Where(x => x.KullaniciAdi == txtYoneticiAd.Text && x.Sifre == txtYoneticiSifre.Text).SingleOrDefault();
            if (y != null)
            {
                frmAdminAnasayfa ynt = new frmAdminAnasayfa();
                ynt.WindowState = FormWindowState.Maximized;
                ynt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre Hatalı");
                Temizle();
            }      
        }
        private void Temizle()
        {
            txtYoneticiAd.Text = "";
            txtYoneticiSifre.Text = "";
        }
    }
}
