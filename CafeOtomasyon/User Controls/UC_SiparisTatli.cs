using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Model.Entities;
using CafeOtomasyon.Model.Manuel.Sınıflar;

namespace CafeOtomasyon
{
    public partial class UC_SiparisTatli : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        int masa;
        int kullanici;
        public UC_SiparisTatli()
        {
            InitializeComponent();
            TatliListele();
            SiparisListele();
            SiparisTutarHesaplama();

        }
        private void TatliListele()
        {
            var tatlilar = db.Tatlı.Where(k => k.Durum == true)
    .Select(s => new
    {
        Id = s.id,
        Adi = s.Ad,
        İcindekiler = s.İçindekiler,
        Fiyati = s.Fiyat,
        Durumu = s.Durum == true ? "A" : "P"
    });
            dataGridView_Tatlı.DataSource = tatlilar.ToList();
            MasaKontrol();

        }

        private void MasaKontrol()
        {

            if (Login.YetkiId == 2 || Login.YetkiId == 1)
            {
                textBox_MasaNo.Text = Convert.ToString(Login.MasaNo);
                kullanici = Login.Id;
            }
            else if (MusteriLogin.MasaNo != null)
            {
                textBox_MasaNo.Text = Convert.ToString(MusteriLogin.MasaNo);
                kullanici = MusteriLogin.Id;

            }
        }

        private void SiparisListele()
        {
            /*
 * durum == V onay verilmiş siparis
 * durum == B onay bekleyen siparis
 * durum == K ödemesi yapılmış siparis
 */
            try
            {
                masa = Convert.ToInt32(textBox_MasaNo.Text);
                var siparis = db.Siparis.Where(w => w.Durum == "B" && w.MasaNo == masa && w.Tür == 2)
                    .Select(s => new
                    {
                        Id = s.id,
                        TatliAdı = s.Tatlı.Ad,
                        Tarih = s.VerilmeTarihi,
                        KullaniciId = s.KullaniciId,
                        Durum = s.Durum,
                        Tutar = s.Tutar
                    }

                    ); ;
                dataGridView_Siparis.DataSource = siparis.ToList();

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }


        }
        private void SiparisTutarHesaplama()
        {
            decimal tutar = 0;
            int adet = 0;
            for (int i = 0; i < dataGridView_Siparis.Rows.Count; i++)
            {
                tutar += decimal.Parse(dataGridView_Siparis.Rows[i].Cells["Tutar"].Value.ToString());
                adet = i + 1;
            }
            textBox_Tutar.Text = Convert.ToString(tutar);
            textBox_Adet.Text = Convert.ToString(adet);

        }

        private void button_Listele_Click(object sender, EventArgs e)
        {

            Siparis siparis = new Siparis();

            try
            {

                siparis.MasaNo = int.Parse(textBox_MasaNo.Text);
                siparis.TatliId = int.Parse(label_id.Text);
                siparis.VerilmeTarihi = DateTime.Now;
                siparis.KullaniciId = kullanici;
                siparis.Durum = "B";
                siparis.Tutar = decimal.Parse(textBox_Fiyat.Text);
                siparis.Tür = 2;
                label_message.Text = "Listeleme Başarılı.";
                db.Siparis.Add(siparis);
                db.SaveChanges();
                SiparisListele();
                SiparisTutarHesaplama();
            }
            catch (Exception hata)
            {
                label_message.Text = "Hata : " + hata.Message;
            }


        }

        private void button_SiparisGonder_Click(object sender, EventArgs e)
        {
            if (dataGridView_Siparis.DataSource != null)
            {
                SiparisDurumu sd = new SiparisDurumu();


                for (int i = 0; i < dataGridView_Siparis.Rows.Count; i++)
                {
                    try
                    {
                        int siparisId = int.Parse(dataGridView_Siparis.Rows[i].Cells["Id"].Value.ToString());

                        Siparis sprs = db.Siparis.Find(siparisId);
                        sprs.Durum = "V";
                        sd.SiparisId = siparisId;
                        sd.SiparisAlınmaTarih = sprs.VerilmeTarihi;
                        sd.Durum = "A";
                        /*
                         * A siparis alındı
                         * H hazırlanıyor
                         * T teslim edildi 
                         * O ödeme yapıldı
                         */
                        db.SiparisDurumu.Add(sd);
                        db.SaveChanges();

                        label_message.Text = "Sipariş tamamlandı.";




                    }
                    catch (Exception hata)
                    {

                        label_message.Text = "Hata :" + hata;
                    }


                }



            }
            else
            {
                label_message.Text = "Tamamlamak için sipariş veriniz";
            }
            textBox_Adet.Text = "0";
            textBox_Tutar.Text = "0";
            SiparisListele();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Siparis.SelectedRows.Count > 0)
            {
                int silmeId = int.Parse(dataGridView_Siparis.SelectedRows[0].Cells["Id"].Value.ToString());
                db.Siparis.Remove(db.Siparis.Find(silmeId));
                db.SaveChanges();
                SiparisListele();
                SiparisTutarHesaplama();
                TatliListele();
                label_message.Text = "Silme işlemi başarılı.";
            }
            else
            {
                label_message.Text = "Silmek için sipariş seçiniz";
            }
        }
        private void dataGridView_Tatlı_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label_id.Text = dataGridView_Tatlı.SelectedRows[0].Cells["Id"].Value.ToString();
            textBox_TatliAdi.Text = dataGridView_Tatlı.SelectedRows[0].Cells["Adi"].Value.ToString();
            textBox_Fiyat.Text = dataGridView_Tatlı.SelectedRows[0].Cells["Fiyati"].Value.ToString();
            richTextBox_İcindekiler.Text = dataGridView_Tatlı.SelectedRows[0].Cells["İcindekiler"].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
