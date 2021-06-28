using CafeOtomasyon.Model.Entities;
using CafeOtomasyon.Model.Manuel.Sınıflar;
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
    public partial class UC_SiparisDurumuMusteri : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        TimeSpan fark;
        public UC_SiparisDurumuMusteri()
        {
            InitializeComponent();
        }



        private void SiparisDurumListele()
        {
            var durumlar = db.SiparisDurumu.Where(w => w.Durum == "T" && (w.Siparis.MasaNo == MusteriLogin.MasaNo || w.Siparis.MasaNo == Login.MasaNo))
                .Select(s => new
                {
                    Id = s.id,
                    SiparisId = s.SiparisId,
                    Siparis = s.Siparis.Yemek.Ad + s.Siparis.Tatlı.Ad + s.Siparis.İçecekler.Ad,
                    Fiyat = s.Siparis.Tutar,
                    VerilenZaman = s.Siparis.VerilmeTarihi,
                    GecenSure = "",
                    Durum = s.Durum


                });
            dataGridView_Siparis.DataSource = durumlar.ToList();
            FarkBulma();
            OdecenekTutarHesaplama();
        }
        private void TeslimOlmayanSiparisListele()
        {
            var durumlar = db.SiparisDurumu.Where(w => w.Durum == "H" || w.Durum == "A" && (w.Siparis.MasaNo == MusteriLogin.MasaNo || w.Siparis.MasaNo == Login.MasaNo))
    .Select(s => new
    {
        Id = s.id,
        SiparisId = s.SiparisId,
        Siparis = s.Siparis.Yemek.Ad + s.Siparis.Tatlı.Ad + s.Siparis.İçecekler.Ad,
        Fiyat = s.Siparis.Tutar,
        VerilenZaman = s.Siparis.VerilmeTarihi,
        GecenSure = "",
        Durum = s.Durum


    });
            dataGridView_Siparis.DataSource = durumlar.ToList();
            FarkBulma();
            OdecenekTutarHesaplama();
        }
        private void FarkBulma()
        {

            for (int i = 0; i < dataGridView_Siparis.RowCount - 1; i++)
            {
                TimeSpan ts = DateTime.Now - Convert.ToDateTime(dataGridView_Siparis.Rows[i].Cells["VerilenZaman"].Value);
                dataGridView_Siparis.Rows[i].Cells["GecenSure"].Value = ts;
            }
        }

        private void picBox_exit_Click(object sender, EventArgs e)
        {
            FormKullanici frm = new FormKullanici();
            this.Hide();
            frm.ShowDialog();
        }
        private void OdecenekTutarHesaplama()
        {
            decimal tutar = 0;
            for (int i = 0; i < dataGridView_Siparis.Rows.Count; i++)
            {
                tutar += decimal.Parse(dataGridView_Siparis.Rows[i].Cells["Fiyat"].Value.ToString());
            }
            textBox_Tutar.Text = Convert.ToString(tutar);

        }

        private void btn_OdemeYap_Click(object sender, EventArgs e)
        {

            if (dataGridView_Siparis.DataSource != null)
            {
                Hesap hsp = new Hesap();

                for (int i = 0; i < dataGridView_Siparis.Rows.Count; i++)
                {

                    try
                    {
                        int id = int.Parse(dataGridView_Siparis.Rows[i].Cells["Id"].Value.ToString());
                        SiparisDurumu sd = db.SiparisDurumu.Find(id);
                        Siparis sprs = db.Siparis.Find(sd.SiparisId);
                        sprs.Durum = "O";
                        sd.Durum = "O";
                        hsp.SiparisId = sd.SiparisId;
                        hsp.ToplamTutar = sd.Siparis.Tutar;
                        hsp.Tarih = DateTime.Now;
                        hsp.OdemeId = 1;

                        if (Login.YetkiId == 2 || Login.YetkiId==1)
                        {
                            hsp.KullaniciId = Login.Id;
                        }
                        else if (MusteriLogin.MasaNo != null)
                        {
                            hsp.KullaniciId = MusteriLogin.Id;
                        }
                        /*
                         * A siparis alındı
                         * H hazırlanıyor
                         * T teslim edildi 
                         * O ödeme yapıldı
                         */
                        db.Hesap.Add(hsp);
                        db.SaveChanges();




                    }
                    catch (Exception hata)
                    {

                        String mesage = "Hata :" + hata;
                        MessageBox.Show(mesage);
                    }


                }

            }
            String message = "Ödeme Yapıldı";
            MessageBox.Show(message);


        }

        private void btnGonderilen_Click(object sender, EventArgs e)
        {
            btn_OdemeYap.Visible = false;
            btnIptal.Visible = true;
            TeslimOlmayanSiparisListele();
        }

        private void btnTeslimEdilen_Click(object sender, EventArgs e)
        {
            btn_OdemeYap.Visible = true;
            btnIptal.Visible = false;
            SiparisDurumListele();
        }


        private void dataGridView_Siparis_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label_id.Text = dataGridView_Siparis.SelectedRows[0].Cells["Id"].Value.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (label_id.Text != null)
            {
                int silmeId = int.Parse(label_id.Text);
                SiparisDurumu sd = db.SiparisDurumu.Find(silmeId);
                Siparis sprs = db.Siparis.Find(sd.SiparisId);
                sd.Durum = "I";
                sprs.Durum = "I";
                db.SaveChanges();

            }
            TeslimOlmayanSiparisListele();

        }
    }
}
