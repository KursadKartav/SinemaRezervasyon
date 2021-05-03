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
    public partial class frmAdminAnasayfa : Form
    {
        Formlar F = new Formlar();
        public frmAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAdminAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            F.FilmGun();
        }

        private void ptnIcecek_Click(object sender, EventArgs e)
        {
            F.IcGun();
        }

        private void btnYiyecek_Click(object sender, EventArgs e)
        {
            F.YeGun();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            F.PersGiris();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            F.HesapGiris();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmAnaSayfa asayfa = new frmAnaSayfa();
            asayfa.Show();
            this.Hide();
        }
    }
}
