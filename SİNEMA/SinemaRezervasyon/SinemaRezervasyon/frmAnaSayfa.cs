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

namespace SinemaRezervasyon
{
    public partial class frmAnaSayfa : Form
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            Bilgi.frmYoneticiGiris yon = new Bilgi.frmYoneticiGiris();
            yon.WindowState = FormWindowState.Maximized;
            yon.Show();
            this.Hide();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            Bilgi.frmPersonelGiris pers = new Bilgi.frmPersonelGiris();
            pers.WindowState = FormWindowState.Maximized;
            pers.Show();
            this.Hide();
        }
    }
}
