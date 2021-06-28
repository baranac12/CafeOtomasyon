using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Model.Manuel.Sınıflar
{
    class MusteriLogin
    {
        static public int Id { get; set; }
        static public int MasaNo { get; set; }
        static public string Adi { get; set; }
        static public string Soyadi { get; set; }
        static public string Telefon { get; set; }
        static public string Parola { get; set; }

        static public DateTime Tarih { get; set; }
        static public string Email { get; set; }
        static public string KAdi { get; set; }
        static public int YetkiId { get; set; }
        static public String YetkiAdi { get; set; }
    }
}
