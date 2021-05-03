using SinemaRezervasyon.Bilgi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaRezervasyon.Fonksiyonlar
{
    class Formlar
    {
        public void FilmGun()
        {
            frmFilmGuncelleme flm = new frmFilmGuncelleme();
            flm.MdiParent = frmAdminAnasayfa.ActiveForm;
            flm.WindowState = FormWindowState.Maximized;
            flm.Show();
        }
        public void IcGun()
        {
            frmIcecekGuncelleme ick = new frmIcecekGuncelleme();
            ick.MdiParent = frmAdminAnasayfa.ActiveForm;
            ick.WindowState = FormWindowState.Maximized;
            ick.Show();
        }
        public void YeGun()
        {
            frmYiyecekGuncelleme yck = new frmYiyecekGuncelleme();
            yck.MdiParent = frmAdminAnasayfa.ActiveForm;
            yck.WindowState = FormWindowState.Maximized;
            yck.Show();
        }
        public void PersGun()
        {
            frmPersonelGuncelleme pers = new frmPersonelGuncelleme();
            pers.MdiParent = frmAdminAnasayfa.ActiveForm;
            pers.WindowState = FormWindowState.Maximized;
            pers.Show();
        }

        public void PersGiris()
        {
            frmPersonelGuncelleme pers = new frmPersonelGuncelleme();
            pers.MdiParent = frmAdminAnasayfa.ActiveForm;
            pers.WindowState = FormWindowState.Maximized;
            pers.Show();
        }

        public void YonGiris()
        {
            frmPersonelGuncelleme pers = new frmPersonelGuncelleme();
            pers.MdiParent = frmAdminAnasayfa.ActiveForm;
            pers.WindowState = FormWindowState.Maximized;
            pers.Show();
        }
        public void HesapGiris()
        {
            frmHesap hsp = new frmHesap();
            hsp.MdiParent = frmAdminAnasayfa.ActiveForm;
            hsp.WindowState = FormWindowState.Maximized;
            hsp.Show();
        }
    }
}
