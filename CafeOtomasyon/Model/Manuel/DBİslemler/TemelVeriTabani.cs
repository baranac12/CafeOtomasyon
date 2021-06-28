using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Model.Manuel.DbIslemler
{
    abstract class TemelVeritabani
    {


        public SqlCommand komut;
        public SqlDataAdapter adaptor;
        public DataTable tablo;
        public SqlConnection baglanti;
        private string veriYolu;
        public string sorgu;

        public TemelVeritabani()
        {

            veriYolu = @"Data Source=DESKTOP-5INKELV\SQLEXPRESSS;Initial Catalog=kafe_otomasyonDB;Integrated Security=True";
        }
        public void Baglan()
        {
            baglanti = new SqlConnection(veriYolu);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            //
        }

        abstract public void Ekle(object obj);
        abstract public void MusteriEkle(object obj);
        abstract public void PersonelEkle(object obj);
        abstract public int EkleVeIdDon(object obj);
        abstract public void Sil(object obj);
        abstract public void Guncelle(object obj);
        abstract public DataTable Listele(object obj);
        abstract public DataTable Listele();

    }
}
