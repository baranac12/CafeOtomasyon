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
    public partial class UC_Personel : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        public UC_Personel()
        {
            InitializeComponent();
            PersonelListele();
            butonKontrol();
            temizle();
            YetkiListele();
        }

        private void YetkiListele()
        {
            var yetkiler = db.Yetki;
            comboBox_Yetki.DisplayMember = "YetkiAdi";
            comboBox_Yetki.ValueMember = "id"; ;
            comboBox_Yetki.DataSource = yetkiler.ToList();
        }

        private void PersonelListele()
        {
            bool evet = true, hayir = true;

            if (checkBox_Tüm.Checked)
            {
                hayir = false;
            }

            var personel = db.kullanici.Where(w => w.YetkiId != 3 && (w.Durumu == evet || w.Durumu == hayir))
                .Select(s => new
                {
                    Id = s.id,
                    YetkiId = s.YetkiId,
                    YetkiAdi = s.Yetki.YetkiAdi,
                    Adi = s.İsim,
                    Soyadi = s.Soyad,
                    Telefonu = s.Telefon,
                    Mail = s.Email,
                    KullaniciAdi = s.KAdi,
                    Parolasi = s.Parola,
                    Durum = s.Durumu == true ? "A" : "P",

                });
            dataGridView_PersonelListe.DataSource = personel.ToList();
        }
        private void butonKontrol()
        {
            if (textBox_PersonelID.Text != "0")
            {
                btn_sil.Enabled = true;
                btn_guncelle.Enabled = true;
            }
            else
            {
                btn_sil.Enabled = false;
                btn_guncelle.Enabled = false;
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {

            try
            {
                kullanici k1 = new kullanici();
                k1.İsim = textBox_PersonelAdı.Text;
                k1.Soyad = textBox_PersonelSoyad.Text;
                k1.Telefon = textBox_PersonelTelefon.Text;
                k1.Email = textBox_PersonelMail.Text;
                k1.KAdi = textBox_PersonelKadi.Text;
                k1.Parola = textBox_PersonelParola.Text;
                //if (comboBox_Yetki.SelectedIndex==0)
                //{
                //    k1.YetkiId = 1;
                //}
                //else if (comboBox_Yetki.SelectedIndex == 1)
                //{
                //    k1.YetkiId = 2;
                //}
                //else
                //{
                //    label_message.Text = "Hatalı seçim yaptınız";
                //}
                k1.Yetki = db.Yetki.Find(int.Parse(comboBox_Yetki.SelectedValue.ToString()));
                k1.Durumu = true;
                db.kullanici.Add(k1);
                db.SaveChanges();
                label_message.Text = "Kayıt Başarılı";
                temizle();


            }
            catch (Exception hata)
            {

                label_message.Text = "Hata : " + hata.Message.ToString();
            }
            PersonelListele();

        }

        private void temizle()
        {
            textBox_PersonelID.Text = "0";
            textBox_PersonelAdı.Text = "";
            textBox_PersonelSoyad.Text = "";
            textBox_PersonelTelefon.Text = "";
            textBox_PersonelMail.Text = "";
            textBox_PersonelKadi.Text = "";
            textBox_PersonelParola.Text = "";
            comboBox_Yetki.Text = "";
            label_message.Text = "";
            PersonelListele();
            butonKontrol();

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int silmeId = int.Parse(textBox_PersonelID.Text);
            kullanici klnc = db.kullanici.Find(silmeId);
            klnc.Durumu = false;
            db.SaveChanges();
            temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int guncellemeId = int.Parse(textBox_PersonelID.Text);
            kullanici klnc = db.kullanici.Find(guncellemeId);
            klnc.İsim = textBox_PersonelAdı.Text;
            klnc.Soyad = textBox_PersonelSoyad.Text;
            klnc.Telefon = textBox_PersonelTelefon.Text;
            klnc.Email = textBox_PersonelMail.Text;
            klnc.KAdi = textBox_PersonelKadi.Text;
            klnc.Parola = textBox_PersonelParola.Text;
            klnc.Durumu = true;
            klnc.Yetki = db.Yetki.Find(int.Parse(comboBox_Yetki.SelectedValue.ToString()));
            db.SaveChanges();
            temizle();
        }

        private void dataGridView_PersonelListe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
 

        }

        private void checkBox_Tüm_CheckedChanged(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void dataGridView_PersonelListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_PersonelID.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["Id"].Value.ToString();
            textBox_PersonelAdı.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["Adi"].Value.ToString();
            textBox_PersonelSoyad.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["Soyadi"].Value.ToString();
            textBox_PersonelTelefon.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["Telefonu"].Value.ToString();
            textBox_PersonelMail.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["Mail"].Value.ToString();
            textBox_PersonelKadi.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["KullaniciAdi"].Value.ToString();
            textBox_PersonelParola.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["Parolasi"].Value.ToString();
            comboBox_Yetki.Text = dataGridView_PersonelListe.SelectedRows[0].Cells["YetkiAdi"].Value.ToString();
            butonKontrol();

        }

    }
}
