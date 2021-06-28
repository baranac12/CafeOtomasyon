using CafeOtomasyon.Model.Manuel.DbIslemler;
using CafeOtomasyon.Model.Manuel.Sınıflar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Model.Manuel.DBİslemler
{
    class KullaniciVeritabani : TemelVeritabani
    {
        public override void MusteriEkle(object obj)
        {
            Kullanici kln = (Kullanici)obj;
            Baglan();
            string sorgu = "insert into Kullanici values (3,'"+kln.Adi+"','"+kln.Soyadi+"','"+kln.Telefon+"','"+kln.Email+"','"+kln.KAdi+"','"+kln.Parola+"')";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
        public override void PersonelEkle(object obj)
        {
            Kullanici kln = (Kullanici)obj;
            Baglan();
            string sorgu = "insert into Kullanici values (2 ,'" + kln.Adi + "','" + kln.Soyadi + "','" + kln.Telefon + "','" + kln.Email + "','" + kln.KAdi + "','" + kln.Parola + "')";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override int EkleVeIdDon(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(object obj)
        {
            Kullanici kln = (Kullanici)obj;
            Baglan();
            sorgu = "select * from Kullanici where KAdi = @KAdi and Parola = @Parola";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@KAdi", kln.KAdi);
            komut.Parameters.AddWithValue("@Parola", kln.Parola);
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable Listele()
        {
           
            Baglan();
            string sorgu = "select * from Kullanici where Yetki in (1,2)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Ekle(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
