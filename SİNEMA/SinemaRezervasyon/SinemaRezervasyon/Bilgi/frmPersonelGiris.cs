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
    public partial class frmPersonelGiris : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            blgPersonel p = db.blgPersonels.Where(x => x.KullaniciAdi == txtPersonelAd.Text && x.Sifre == txtPersonelSifre.Text).SingleOrDefault();
            if (p != null)
            {
                frmBiletSatis bilet = new frmBiletSatis();
                bilet.WindowState = FormWindowState.Maximized;
                bilet.Show();
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
            txtPersonelAd.Text = "";
            txtPersonelSifre.Text = "";
        }
    }
    }

