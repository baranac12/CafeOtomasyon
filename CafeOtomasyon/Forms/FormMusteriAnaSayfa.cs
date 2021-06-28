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

namespace CafeOtomasyon.Forms
{
    public partial class FormMusteriAnaSayfa : Form
    {
        bool AyarlardaMi;
        public FormMusteriAnaSayfa()
        {
            InitializeComponent();
            KullaniciBilgileri();
            timer_Zaman.Start();

        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
;
        }

        private void KullaniciBilgileri()
        {
            label_MusteriAdSoyad.Text = MusteriLogin.Adi + " " + MusteriLogin.Soyadi;
            label_mail.Text = MusteriLogin.Email;
            label_telefon.Text = MusteriLogin.Telefon;
        }
        private void PaneleUCGetir(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_AnaEkran.Controls.Clear();
            panel_AnaEkran.Controls.Add(uc);
        }




        private void timer_Zaman_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_zaman.Text = dt.ToString("HH:mm:ss");
        }


        private void btn_Buyult_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                btn_Buyult.Image = Resources.icons8_shrink_down_32;

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {

                this.WindowState = FormWindowState.Normal;
                btn_Buyult.Image = Resources.icons8_expand_32;
            }


        }

        private void box_Küçült_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Siparis_Click(object sender, EventArgs e)
        {
            UC_Siparis uc = new UC_Siparis();
            PaneleUCGetir(uc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UC_SiparisDurumuMusteri uc = new UC_SiparisDurumuMusteri();
            PaneleUCGetir(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_MusteriAyar uc = new UC_MusteriAyar();
            PaneleUCGetir(uc);
        }
    }
}
