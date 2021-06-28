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
    public partial class UC_SiparisSüresi : UserControl

    {
        int toplam;
        int toplamMTFK;
        int kayitSayisi;
        int kayıtSayisiMTFK;
        decimal ortalama;
        decimal ortalamaMTFK;
        int deger;
        int degerMTFK;

        public UC_SiparisSüresi()
        {
            InitializeComponent();
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = DateTime.Now;
            DGW_Mutfak.DataSource = null;
            DGW_Bar.DataSource = null;

            btnBaar.Text = null;
            btnMutfak.Text = null;




        }
        private void SeciliMuftakRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                DGW_Mutfak.DataSource = db.Hesap.Where(w => w.Siparis.YemekId!= null || w.Siparis.TatliId!=null && (w.Siparis.VerilmeTarihi >= min && w.Siparis.TeslimTarihi <= max)&& w.Siparis.Durum == "O")
            
                .Select(s =>
                     new
                     {
                         SiparisAdi= s.Siparis.Yemek.Ad + s.Siparis.Tatlı.Ad ,
                         SiparisVerilmeZamani = s.Siparis.VerilmeTarihi,
                         SiparisTeslimEdilmeTarihi = s.Siparis.TeslimTarihi
                     }).ToList();

            }
            OrtalamaHesaplamaMutfak(DGW_Mutfak, btnMutfak);


        }
        private void OrtalamaHesaplamaMutfak(DataGridView DGW, Button btn)
        {

            try
            {
                for (int i = 0; i < DGW.Rows.Count; i++)
                {
                    DateTime d1 = Convert.ToDateTime(DGW.Rows[i].Cells[2].Value);
                    DateTime d2 = Convert.ToDateTime(DGW.Rows[i].Cells[1].Value);

                    TimeSpan timeSpan = d1 - d2;

                    toplamMTFK += Convert.ToInt32(timeSpan.Minutes) + (Convert.ToInt32(timeSpan.Hours) * 60);
                    kayıtSayisiMTFK += 1;

                }
                ortalamaMTFK = toplamMTFK / kayıtSayisiMTFK;
                btn.Text = Convert.ToString(ortalamaMTFK);
                degerMTFK = int.Parse(btn.Text);

                if (degerMTFK > 60)
                {
                    btn.BackColor = Color.Red;
                }
                else if (degerMTFK <= 60 && degerMTFK > 55)
                {
                    btn.BackColor = Color.Orange;
                }
                else if (degerMTFK <= 55 && degerMTFK > 50)
                {
                    btn.BackColor = Color.Yellow;
                }
                else if (degerMTFK <= 50)
                {
                    btn.BackColor = Color.Green;
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


        }
        private void SeciliİcecekRaporGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                DGW_Bar.DataSource = db.Hesap.Where(w => w.Siparis.İcecekId!=null && w.Siparis.VerilmeTarihi >= min && w.Siparis.TeslimTarihi <= max && w.Siparis.Durum == "O")

                .Select(s =>
                     new
                     {
                         SiparisAdi = s.Siparis.İçecekler.Ad,
                         SiparisVerilmeZamani = s.Siparis.VerilmeTarihi,
                         SiparisTeslimEdilmeTarihi = s.Siparis.TeslimTarihi
                     }).ToList();
                
            }
            OrtalamaHesaplama(DGW_Bar, btnBaar);

        }
        private void OrtalamaHesaplama(DataGridView DGW, Button btn)
        {

            try
            {
                for (int i = 0; i < DGW.Rows.Count; i++)
                {
                    DateTime d1 = Convert.ToDateTime(DGW.Rows[i].Cells[2].Value);
                    DateTime d2 = Convert.ToDateTime(DGW.Rows[i].Cells[1].Value);

                    TimeSpan timeSpan = d1 - d2;

                    toplam += Convert.ToInt32(timeSpan.Minutes) + (Convert.ToInt32(timeSpan.Hours) * 60);
                    kayitSayisi += 1;

                }
                ortalama = toplam / kayitSayisi;
                btn.Text = Convert.ToString(ortalama);
                deger = int.Parse(btn.Text);

                if (deger>60)
                {
                    btn.BackColor = Color.Red;
                }else if (deger<=60 && deger > 55)
                {
                    btn.BackColor = Color.Orange;
                }else if(deger <= 55 && deger > 50)
                {
                    btn.BackColor = Color.Yellow;
                }
                else if(deger<=50)
                {
                    btn.BackColor = Color.Green;
                }
                   
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


        }

        private void dateTimePicker_gunMın_ValueChanged(object sender, EventArgs e)
        {
            SeciliMuftakRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);


        }

        private void dateTimePicker_gunlukMax_ValueChanged(object sender, EventArgs e)
        {
            SeciliMuftakRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);

        }

        private void btn_Son1Haftalik_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = dateTimePicker_gunlukMax.Value.AddDays(-7);
            SeciliMuftakRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);


        }

        private void btn_Son1AylikKazanc_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = dateTimePicker_gunlukMax.Value.AddDays(-30);
            SeciliMuftakRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
            SeciliİcecekRaporGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);

        }

        private void btnMutfak_Click(object sender, EventArgs e)
        
        {
            if (btnMutfak.Text!= null)
            {
                btnMessageBox(btnMutfak);

            }
            else
            {
                MessageBox.Show("Tarih giriniz ", "HATA", MessageBoxButtons.OK);

            }

        }

        private void btnMessageBox(Button btn)
        {
                        int btnDeger;
            int azaltılan;
            btnDeger = int.Parse(btn.Text);
            
            if (btnDeger > 60)
            {
                azaltılan = btnDeger -60;
                MessageBox.Show("Ortalamanız Kötü. ------> En az " + azaltılan + " dakika kadar düşürülmeli ","ORTALAMA BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
            }else if (btnDeger<=60 && btnDeger > 55)
            {
                azaltılan = btnDeger-55;
                MessageBox.Show("Ortalamanız Orta Derecede. ------> En az " + azaltılan + " dakika kadar düşürülmeli ", "ORTALAMA BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
            }else if (btnDeger<=55 && btnDeger > 50)
            {
                azaltılan = btnDeger - 50;
                MessageBox.Show("Ortalamanız İyi Derecede. ------> Daha iyisi için " + azaltılan + " dakika kadar düşürülmeli ", "ORTALAMA BİLGİSİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (btnDeger<=50)
            {
                MessageBox.Show("Ortalamanız Son derecede iyi  ", "ORTALAMA BİLGİSİ",MessageBoxButtons.OK);

            }

}

        private void btnBaar_Click(object sender, EventArgs e)
        {
            if (btnBaar.Text != null)
            {
                btnMessageBox(btnBaar);

            }
            else
            {
                MessageBox.Show("Tarih giriniz ", "HATA", MessageBoxButtons.OK);

            }
        }
    }
}
