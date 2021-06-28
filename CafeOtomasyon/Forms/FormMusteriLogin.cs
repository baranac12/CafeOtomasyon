using CafeOtomasyon.Forms;
using CafeOtomasyon.Model.Entities;
using CafeOtomasyon.Model.Manuel.DBİslemler;
using CafeOtomasyon.Model.Manuel.Sınıflar;
using CafeOtomasyon.Properties;
using CafeOtomasyon.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{

    
    public partial class FormMusteriLogin : Form
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        public FormMusteriLogin()
        {
            InitializeComponent();


        }
     
        private void PaneleUCGetir(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(uc);

        }


        

        private void box_Küçült_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormKullanici klnc = new FormKullanici();
            this.Hide();
            klnc.ShowDialog();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxKadi_Giris.Text!="" && txtBoxParola_Giris.Text!="")
                {
                    kullanici kln = db.kullanici.Where(k => k.KAdi == txtBoxKadi_Giris.Text && k.Parola == txtBoxParola_Giris.Text).FirstOrDefault();
                    if (kln.YetkiId == 3)
                    {
                        if (kln != null && kln.Durumu != false)
                        {
                            MusteriLogin.Id = kln.id;
                            MusteriLogin.Adi = kln.İsim;
                            MusteriLogin.Soyadi = kln.Soyad;
                            MusteriLogin.KAdi = kln.KAdi;
                            MusteriLogin.Email = kln.Email;
                            MusteriLogin.YetkiAdi = kln.Yetki.YetkiAdi;
                            MusteriLogin.MasaNo = int.Parse(textBoxMasaNo.Text);
                            MusteriLogin.Telefon = kln.Telefon;
                            MusteriLogin.Parola = kln.Parola;
                            FormMusteriAnaSayfa frm = new FormMusteriAnaSayfa();
                            this.Hide();
                            frm.ShowDialog();

                        }
                        else
                        {
                            label_message.Text = "Kullanici Bilgileri doğru değil ";

                        }
                    }
                    else
                    {
                        label_message.Text = "Kullanici Bilgileri doğru değil ";

                    }
                }
                else
                {
                    label_message.Text = "Alanları Doldurunuz. ";
                }

            }
            catch (Exception hata)
            {

                label_message.Text = "Beklenmedik Hata : " + hata.Message;

            }
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)

        {


            try
            {

                kullanici k1 = new kullanici();
                k1.İsim = txtBoxAd_Kayit.Text;
                k1.Soyad = txtBoxSoyad_kayit.Text;
                k1.Telefon = txtBoxTel_kayit.Text;
                k1.Email = txtBoxMail_kayit.Text;
                k1.YetkiId = int.Parse(textBox_Yetki.Text);
                k1.KAdi = txtBoxKadi_kayit.Text;
                k1.Parola = txtBoxParola_kayit.Text;
                k1.Durumu = true;
                db.kullanici.Add(k1);
                db.SaveChanges();

                //Kullanici kln = new Kullanici();
                //KullaniciVeritabani vt = new KullaniciVeritabani();
                //kln.Adi = txtBoxAd_Kayit.Text;
                //kln.Soyadi = txtBoxSoyad_kayit.Text;
                //kln.Email = txtBoxMail_kayit.Text;
                //kln.Telefon = txtBoxTel_kayit.Text;
                //kln.KAdi = txtBoxKadi_kayit.Text;
                //kln.Parola = txtBoxParola_kayit.Text;
                //vt.MusteriEkle(kln);

                MessageBox.Show("Kayıt Başarılı", "Kayıt", MessageBoxButtons.OK);
                temizle();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "HATA", MessageBoxButtons.OK);
            }

        }

        private void temizle()
        {
            txtBoxAd_Kayit.Text = "";
            txtBoxSoyad_kayit.Text = "";
            txtBoxKadi_kayit.Text = "";
            txtBoxParola_kayit.Text = "";
            txtBoxTel_kayit.Text = "";
            txtBoxMail_kayit.Text = "";
        }
    }
}
