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
    public partial class UC_MusteriAyar : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        public UC_MusteriAyar()
        {
            InitializeComponent();
            MusteriDuzenle();
        }

        private void MusteriDuzenle()
        {
            txtBoxAd.Text = MusteriLogin.Adi;
            txtBoxSoyad.Text = MusteriLogin.Soyadi;
            txtBoxMail.Text = MusteriLogin.Email;
            txtBoxTel.Text = MusteriLogin.Telefon;
            txtBoxKadi.Text = MusteriLogin.KAdi;
            txtBoxParola.Text = MusteriLogin.Parola;
            label_id.Text = Convert.ToString(MusteriLogin.Id);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int GunceelemeId = int.Parse(label_id.Text);
            kullanici klnc = db.kullanici.Find(GunceelemeId);
            klnc.İsim = txtBoxAd.Text;
            klnc.Soyad = txtBoxSoyad.Text;
            klnc.Email = txtBoxMail.Text;
            klnc.Telefon = txtBoxTel.Text;
            klnc.KAdi = txtBoxKadi.Text;
            klnc.Parola = txtBoxParola.Text;
            db.SaveChanges();
            label_message.Text = "Güncelleme Başarılı.";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int SilinenId = int.Parse(label_id.Text);
            kullanici klnc = db.kullanici.Find(SilinenId);
            klnc.Durumu = false;
            db.SaveChanges();
            FormKullanici frmKlnc = new FormKullanici();
            this.Hide();
            frmKlnc.ShowDialog();
        }
    }
}
