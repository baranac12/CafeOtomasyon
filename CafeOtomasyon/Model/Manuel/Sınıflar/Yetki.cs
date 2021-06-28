using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Model.Manuel.Sınıflar
{
    class Yetki
    {
        public int Id { get; set; }
        public string YetkiAdi { get; set; }

        public static implicit operator Yetki(Entities.Yetki v)
        {
            throw new NotImplementedException();
        }
    }
}
