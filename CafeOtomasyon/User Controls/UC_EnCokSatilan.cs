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
    public partial class UC_EnCokSatilan : UserControl
    {
        String Yemek;
        String Icecek;
        String Tatli;
        public UC_EnCokSatilan()
        {
            InitializeComponent();
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = DateTime.Now;





        }

        private void SeciliTatliRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                DGW_Tatli.DataSource = db.Hesap.Where(w => w.Siparis.TatliId != null && w.Tarih >= min && w.Tarih <= max && w.Siparis.Durum == "O")
                .GroupBy(g => g.Siparis.Tatlı.Ad).Where(w => w.Count() >= 1)
                .Select(s =>
                     new
                     {
                         TatliAdi = s.FirstOrDefault().Siparis.Tatlı.Ad,
                         Adet = s.Count()
                     }).Distinct().OrderByDescending(o => o.Adet).ToList();

            }
        }
        private void SeciliİcecekRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                DGW_Icecek.DataSource = db.Hesap.Where(w => w.Siparis.İcecekId != null && w.Tarih >= min && w.Tarih <= max && w.Siparis.Durum == "O")
                        .GroupBy(g => g.Siparis.İçecekler.Ad).Where(w => w.Count() >= 1)
                        .Select(s =>
                        new
                        {
                            IcecekAdi = s.FirstOrDefault().Siparis.İçecekler.Ad,
                            Adet = s.Count()
                        }).Distinct().OrderByDescending(o => o.Adet).ToList();
            }
        }

        private void SeciliYemekRaporGetir(DateTime min, DateTime max )
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {

                DGW_Yemek.DataSource = db.Hesap.Where(w => w.Siparis.YemekId != null && w.Tarih >= min && w.Tarih <= max && w.Siparis.Durum == "O")
                    .GroupBy(g => g.Siparis.Yemek.Ad).Where(w => w.Count() >= 1)
                    .Select(s =>
                              new
                              {
                                  YemekAdi = s.FirstOrDefault().Siparis.Yemek.Ad,
                                  Adet = s.Count()
                              }).Distinct().OrderByDescending(o => o.Adet).ToList();
            }
        }


         



  
    

        private void dateTimePicker_gunMın_ValueChanged(object sender, EventArgs e)
        {
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
        }

        private void dateTimePicker_gunlukMax_ValueChanged(object sender, EventArgs e)
        {
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
        }

        private void btn_Son1Haftalik_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = dateTimePicker_gunlukMax.Value.AddDays(-7);
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            TimeSpan sonuc = dateTimePicker_gunlukMax.Value - dateTimePicker_gunMın.Value;

        }

        private void btn_Son1AylikKazanc_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = dateTimePicker_gunlukMax.Value.AddMonths(-1);
            SeciliYemekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliTatliRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
        }
    }
}
