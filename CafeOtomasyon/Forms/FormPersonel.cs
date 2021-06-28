using CafeOtomasyon.Forms;
using CafeOtomasyon.Model.Entities;
using CafeOtomasyon.Model.Manuel.DBİslemler;
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

namespace CafeOtomasyon
{
    public partial class FormPersonel : Form
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();

        public FormPersonel()
        {
            InitializeComponent();
            label_message.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            FormKullanici frm = new FormKullanici();
            this.Close();
            frm.Show();

        }
        private void temizle()
        {
            txtBox_Kadi.Text = "";
            txtBox_Parola.Text = "";
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {

            //KullaniciVeritabani vt = new KullaniciVeritabani();
            //Kullanici kln = new Kullanici();
            //DataTable tablo = new DataTable();
            //try
            //{

            //    kln.KAdi =txtBox_Kadi.Text;
            //    kln.Parola = txtBox_Parola.Text;


            //    tablo = vt.Listele(kln);
            //    if (tablo.Rows.Count > 0)
            //    {
            //        FormYöneticiAnaSayfa frm = new FormYöneticiAnaSayfa();
            //        frm.ShowDialog();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        label_message.Text = "Kullanici Bilgileri doğru değil ";
            //    }
            //}
            //catch (Exception hata)
            //{

            //    label_message.Text = "Beklenmedik Hata : " + hata.Message;
            //}
            try
            {
                if (txtBox_Kadi.Text!=""  && txtBox_Parola.Text!="")
                {
                    kullanici kln = db.kullanici.Where(k => k.KAdi == txtBox_Kadi.Text && k.Parola == txtBox_Parola.Text).FirstOrDefault();
                    if (kln.YetkiId != 3)
                    {
                        if (kln != null)
                        {
                            Login.Id = kln.id;
                            Login.Adi = kln.İsim;
                            Login.Soyadi = kln.Soyad;
                            Login.KAdi = kln.KAdi;
                            Login.Email = kln.Email;
                            Login.YetkiId = kln.YetkiId;
                            Login.YetkiAdi = kln.Yetki.YetkiAdi;
                            KullaniciyaGoreEkranGetir(kln);

                        }
                        else
                        {
                            label_message.Text = "Kullanici Bilgileri doğru değil ";
                            temizle();
                        }
                    }
                    else
                    {
                        label_message.Text = "Kullanici Bilgileri doğru değil ";
                        temizle();
                    }
                }
                else
                {
                    label_message.Text = "Alanları Doldurunuz ";
                    temizle();
                }
            }
            catch (Exception hata)
            {

                label_message.Text = "Beklenmedik Hata : " + hata.Message;
                temizle();
            }
        }
        private void KullaniciyaGoreEkranGetir(kullanici klnc)
        {
            if (klnc.YetkiId == 1 || klnc.YetkiId == 2)
            {
                FormYöneticiAnaSayfa frm = new FormYöneticiAnaSayfa();
                this.Hide();
                frm.ShowDialog();
            }
            else if (klnc.YetkiId == 4 || klnc.YetkiId == 5)
            {
                FormSiparisDurumKontrol frm = new FormSiparisDurumKontrol();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                label_message.Text = "Kullanici Bilgileri doğru değil ";
                temizle();
            }
        }
    }
}
