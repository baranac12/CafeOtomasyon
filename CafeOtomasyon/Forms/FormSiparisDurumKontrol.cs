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

namespace CafeOtomasyon.Forms
{
    public partial class FormSiparisDurumKontrol : Form
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        public FormSiparisDurumKontrol()
        {
            InitializeComponent();

            GelenSiparisListele();
            
        }

        private void GelenSiparisListele()
        {
            if (Login.YetkiId==4)
            {
                var durumlar = db.SiparisDurumu.Where(w => w.Durum == "A" && w.Siparis.İcecekId==null)
               .Select(s => new
               {

                   Id= s.id,
                   SiparisAdi = s.Siparis.Yemek.Ad + s.Siparis.Tatlı.Ad ,
                  
                   Fiyat = s.Siparis.Tutar,
                   Tarih = s.Siparis.VerilmeTarihi,
                   Durum = s.Durum



               }) ;
                dataGridView_Siparisler.DataSource = durumlar.ToList();
            }
            else if(Login.YetkiId == 5)
            {
                var durumlar = db.SiparisDurumu.Where(w => w.Durum == "A" && w.Siparis.YemekId==null && w.Siparis.TatliId==null)
                    .Select(s => new
                    {
                        Id = s.id,
                        SiparisAdi = s.Siparis.İçecekler.Ad,
                        Fiyat = s.Siparis.Tutar,
                        Tarih = s.Siparis.VerilmeTarihi,
                        Durum = s.Durum


                    });
                dataGridView_Siparisler.DataSource = durumlar.ToList();
            }

        }
        private void HazirlananSiparisler()
        {
            if (Login.YetkiId == 4)
            {
                var durumlar = db.SiparisDurumu.Where(w => w.Durum == "H")
               .Select(s => new
               {
                   Id = s.id,
                   SiparisAdi = s.Siparis.Yemek.Ad + s.Siparis.Tatlı.Ad,
                   Fiyat = s.Siparis.Tutar,
                   Tarih = s.Siparis.OnaylanmaTarihi,
                   Durum = s.Durum


               });
                dataGridView_Siparisler.DataSource = durumlar.ToList();
            }
            else
            {
                var durumlar = db.SiparisDurumu.Where(w => w.Durum == "H")
                    .Select(s => new
                    {
                        Id = s.id,
                        Icecek = s.Siparis.İçecekler.Ad,
                        Fiyat = s.Siparis.Tutar,
                        Tarih = s.Siparis.OnaylanmaTarihi,
                        Durum = s.Durum


                    });
                dataGridView_Siparisler.DataSource = durumlar.ToList();
            }

        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            FormKullanici frm = new FormKullanici();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_GelenSiparis_Click(object sender, EventArgs e)
        {
            GelenSiparisListele();
        }

        private void btn_HazırlananSiparis_Click(object sender, EventArgs e)
        {
            HazirlananSiparisler();
        }

        private void btn_BilgiGonder_Click(object sender, EventArgs e)
        {
            if (dataGridView_Siparisler.SelectedRows.Count>0)
            {

                int alinanId = int.Parse(dataGridView_Siparisler.SelectedRows[0].Cells["Id"].Value.ToString());
                SiparisDurumu sd = db.SiparisDurumu.Find(alinanId);
                if (sd.Durum == "A")
                {
                    sd.Durum = "H";
                    sd.SiparisHazırlanmaTarih = DateTime.Now;
                    sd.Siparis.OnaylanmaTarihi = sd.SiparisHazırlanmaTarih;
                    
                    db.SaveChanges();
                    GelenSiparisListele();
                }
                else
                {
                    sd.Durum = "T";
                    sd.TeslimEdilmeTarih = DateTime.Now;
                    sd.Siparis.TeslimTarihi = sd.TeslimEdilmeTarih;
                    db.SaveChanges();
                    HazirlananSiparisler();
                }

            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (label_Iptal.Text != null)
            {
                int silmeId = int.Parse(label_Iptal.Text);
                SiparisDurumu sd = db.SiparisDurumu.Find(silmeId);
                Siparis sprs = db.Siparis.Find(sd.SiparisId);
                if (sd.Durum=="A")
                {
                    sd.Durum = "I";
                    sprs.Durum = "I";

                    db.SaveChanges();

                }
                else
                {
                    MessageBox.Show("HATALI SEÇİM !!","UYARI", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                db.SaveChanges();

            }
            GelenSiparisListele();

        }

        private void dataGridView_Siparisler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label_Iptal.Text = dataGridView_Siparisler.SelectedRows[0].Cells["Id"].Value.ToString();
        }

    }
}
