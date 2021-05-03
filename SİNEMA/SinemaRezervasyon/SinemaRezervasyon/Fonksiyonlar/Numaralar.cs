using SinemaRezervasyon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaRezervasyon.Fonksiyonlar
{
    class Numaralar
    {
        SinemaaDbEntities db = new SinemaaDbEntities();
        public string BiletNo()
        {
            try
            {
                double numara = double.Parse((from s in db.tblSatis orderby s.Id descending select s).First().BiletNo);
                numara++;
                string num = numara.ToString().PadLeft(10, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000000001";
            }
        }
    }
}
