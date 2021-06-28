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
    public partial class UC_Kazanc : UserControl
    {
        public UC_Kazanc()
        {
            InitializeComponent();
        }
        private void KazancGetir()
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                dataGridView_Gunluk.DataSource = db.Hesap.Select(s => new
                {
                    Id = s.id,
                    kullaniciId = s.KullaniciId,
                    SiparisAdi = s.Siparis.Yemek.Ad + s.Siparis.Tatlı.Ad + s.Siparis.İçecekler.Ad,
                    Masa = s.Siparis.MasaNo,
                    OdemeSekli = s.OdemeTuru.Tur,
                    Tutar = s.ToplamTutar,
                    Tarih = s.Tarih
                }).ToList();


            }
            KazancHesapla();

        }

        private void KazancHesapla()
        {
            decimal kazanc = 0;
            if (dataGridView_Gunluk.DataSource != null)
            {
                for (int i = 0; i < dataGridView_Gunluk.Rows.Count; i++)
                {
                    kazanc += decimal.Parse(dataGridView_Gunluk.Rows[i].Cells["Tutar"].Value.ToString());
                }
                txt_KazancToplam.Text = Convert.ToString(kazanc);
            }
        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            FormYöneticiAnaSayfa frm = new FormYöneticiAnaSayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void dateTimePicker_gunlukMax_ValueChanged(object sender, EventArgs e)
        {
            SeciliGunlukKazancGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
        }

        private void SeciliGunlukKazancGetir(DateTime min, DateTime max)
        {
            using (kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4())
            {
                dataGridView_Gunluk.DataSource = db.Hesap.Where(w => w.Tarih >= min && w.Tarih <= max)
                    .Select(s => new
                    {
                        Id = s.id,
                        kullaniciId = s.KullaniciId,
                        SiparisAdi = s.Siparis.Yemek.Ad + s.Siparis.Tatlı.Ad + s.Siparis.İçecekler.Ad,
                        Masa = s.Siparis.MasaNo,
                        OdemeSekli = s.OdemeTuru.Tur,
                        Tutar = s.ToplamTutar,
                        Tarih = s.Tarih
                    }).ToList();


            }
            KazancHesapla();
        }

        private void Son1AylikKazanc_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = DateTime.Now.AddMonths(-1);

            SeciliGunlukKazancGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
        }

        private void btn_Son1Haftalik_Click(object sender, EventArgs e)
        {
            dateTimePicker_gunlukMax.Value = DateTime.Now;
            dateTimePicker_gunMın.Value = DateTime.Now.AddDays(-7);

            SeciliGunlukKazancGetir(dateTimePicker_gunMın.Value, dateTimePicker_gunlukMax.Value);
        }

    }
}
