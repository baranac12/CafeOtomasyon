using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Model.Manuel.Sınıflar
{
    class Kullanici
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string KAdi { get; set; }
        public string Parola { get; set; }
        public Yetki Yetki { get; set; }


    }
}
