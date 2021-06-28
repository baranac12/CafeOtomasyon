using CafeOtomasyon.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.User_Controls
{
    public partial class UC_EnCokSatisYapanGarson : UserControl
    {
        public UC_EnCokSatisYapanGarson()
        {
            InitializeComponent();


        }
        private void SeciliTatliRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                DGW_Tatli.DataSource = db.Hesap.Where(w => w.Siparis.TatliId != null && w.Tarih >= min && w.Tarih <= max && w.Siparis.Durum == "O" && (w.kullanici.YetkiId == 2 || w.kullanici.YetkiId == 1))
                .GroupBy(g => g.KullaniciId)
                .Select(s =>
                     new
                     {
                         GarsonAdi = s.FirstOrDefault().kullanici.İsim + " " + s.FirstOrDefault().kullanici.Soyad,
                         SatisTuru = "Tatli",
                         Kazanc = s.Sum(p => p.ToplamTutar)


                     }).OrderByDescending(o => o.Kazanc).ToList();

            }
        }
        private void SeciliİcecekRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                DGW_Icecek.DataSource = db.Hesap.Where(w => w.Siparis.İcecekId != null && w.Tarih >= min && w.Tarih <= max && w.Siparis.Durum == "O" && (w.kullanici.YetkiId == 2|| w.kullanici.YetkiId ==1) )
                .GroupBy(g => g.KullaniciId)
                .Select(s =>
                     new
                     {
                         GarsonAdi = s.FirstOrDefault().kullanici.İsim + " " + s.FirstOrDefault().kullanici.Soyad,
                         SatisTuru= "İcecek",
                         Kazanc = s.Sum(p => p.ToplamTutar)


                     }).OrderByDescending(o => o.Kazanc).ToList();
            }
        }
        private void SeciliToplamRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                DGW_Toplam.DataSource = db.Hesap.Where(w => w.Tarih >= min && w.Tarih <= max && w.Siparis.Durum == "O" && (w.kullanici.YetkiId == 2 || w.kullanici.YetkiId == 1))
                .GroupBy(g => g.KullaniciId)
                .Select(s =>
                     new
                     {
                         GarsonAdi = s.FirstOrDefault().kullanici.İsim + " " + s.FirstOrDefault().kullanici.Soyad,
                         Kazanc = s.Sum(p => p.ToplamTutar)


                     }).OrderByDescending(o => o.Kazanc).ToList();
            }
        }

        private void SeciliYemekRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {

                DGW_Yemek.DataSource = db.Hesap.Where(w => w.Siparis.YemekId != null && w.Tarih >= min && w.Tarih <= max && w.Siparis.Durum == "O" && (w.kullanici.YetkiId == 2 || w.kullanici.YetkiId == 1))
.GroupBy(g => g.KullaniciId)
.Select(s =>
     new
     {
         GarsonAdi = s.FirstOrDefault().kullanici.İsim + " " + s.FirstOrDefault().kullanici.Soyad,
         SatisTuru = "Yemek",
         Kazanc = s.Sum(p => p.ToplamTutar)


     }).OrderByDescending(o => o.Kazanc).ToList();
            }
        }

        private void dateTimePicker_gunMın_ValueChanged(object sender, EventArgs e)
        {
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliToplamRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            EnCOkSatisYapanGarson();
        }

        private void dateTimePicker_gunlukMax_ValueChanged(object sender, EventArgs e)
        {
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliToplamRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            EnCOkSatisYapanGarson();
        }

        private void btn_Son1Haftalik_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = dateTimePicker_gunlukMax.Value.AddDays(-7);
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliToplamRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            EnCOkSatisYapanGarson();

        }

        private void btn_Son1AylikKazanc_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = dateTimePicker_gunlukMax.Value.AddMonths(-1);
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliToplamRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            EnCOkSatisYapanGarson();

        }
        private void EnCOkSatisYapanGarson()
        {
            String Isim = DGW_Toplam.Rows[0].Cells[0].Value.ToString();
            btnEnCok.Text = Isim.ToUpper();
            btnEnCok.ForeColor = Color.White;
            btnEnCok.BackColor = Color.FromArgb(15, 86, 114);
            
        }

        private void btnEnCok_Click(object sender, EventArgs e)
        {
            if (btnEnCok.Text!="")
            {
                MessageBox.Show("Seçili Süreçte En Çok Satış Yapan Garson ------>   " + btnEnCok.Text, "En Çok Satış Yapan Garson", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tarih Seçiniz" + btnEnCok.Text, "En Çok Satış Yapan Garson", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
