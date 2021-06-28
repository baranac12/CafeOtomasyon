using CafeOtomasyon.Forms;
using CafeOtomasyon.Model.Entities;
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
    public partial class FormYöneticiAnaSayfa : Form
    {

        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        bool yoneticiMenuAcikMi,siparisAcikMi;
        int sliderYukseklik, SiparisSliderYukseklik;

        public FormYöneticiAnaSayfa()
        {
            InitializeComponent();
            YetkiKontrol();
            timer_zaman.Start();
            yoneticiMenuAcikMi = false;
            siparisAcikMi = false;
            sliderYukseklik = 140;
            SiparisSliderYukseklik = 110;
            KullaniciBİlgileri();
        }
        private void KullaniciBİlgileri()
        {
            label_KullaniciAdi.Text = Login.Adi + " " + Login.Soyadi;
            label_Yetki.Text = Login.YetkiAdi;
        }
        private void PaneleUCGetir(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_AnaEkran.Controls.Clear();
            panel_AnaEkran.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            panel_MasaNo.Visible = false;
            UC_Personel prnsl = new UC_Personel();
            PaneleUCGetir(prnsl);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panel_MasaNo.Visible = false;
            UC_Menu menu = new UC_Menu();
            PaneleUCGetir(menu);
        }


        private void btn_AylıkKazanc_Click(object sender, EventArgs e)
        {
            panel_MasaNo.Visible = false;
            UC_Kazanc kznc = new UC_Kazanc();
            PaneleUCGetir(kznc);
        }

        private void btn_Siparis_Click(object sender, EventArgs e)
        {
            timer_siparis.Start();
        }

        private void timer_slider_Tick(object sender, EventArgs e)
        {
            if (yoneticiMenuAcikMi)
            {
                //Menu kapancak

                panel_slider.Height = panel_slider.Height -35 ;
                btn_slider.Image = Resources.icons8_collapse_arrow_32;
                if (panel_slider.Height <= 63)
                {
                    yoneticiMenuAcikMi = false;
                    timer_slider.Stop();
                    this.Refresh();
                }


            }
            else
            {
                panel_slider.Height = panel_slider.Height + 35;
                btn_slider.Image = Resources.icons8_expand_arrow_32;
                if (panel_slider.Height>= sliderYukseklik)
                {
                    
                    yoneticiMenuAcikMi = true;
                    timer_slider.Stop();
                    this.Refresh();
                }
            }
        }

        private void btn_slider_Click(object sender, EventArgs e)
        {
            timer_slider.Start();
        }

        private void btn_EnCokSatilan_Click(object sender, EventArgs e)
        {
            panel_MasaNo.Visible = false;
            UC_EnCokSatilan uc = new UC_EnCokSatilan();
            PaneleUCGetir(uc);

        }

        private void btn_Ortalama_Click(object sender, EventArgs e)
        {
            panel_MasaNo.Visible = false;
            UC_SiparisSüresi uc = new UC_SiparisSüresi();
            PaneleUCGetir(uc);
        }
        private void YetkiKontrol()
        {
            if (Login.YetkiId==2)
            {
                btn_Personel.Visible=false;
                     btnMenu.Visible=false;
                    btnRapor.Visible=false;
                btn_slider.Visible = false;
            }
            else if (Login.YetkiId == 1)
            {
                btn_Personel.Visible = true;
                     btnMenu.Visible = true;
                    btnRapor.Visible = true;
                  btn_slider.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_MasaNo.Visible = false;
            UC_EnCokSatisYapanGarson uc = new UC_EnCokSatisYapanGarson();
            PaneleUCGetir(uc);
        }
        private void btn_EnCokSatisYapan_Click(object sender, EventArgs e)
        {
            panel_MasaNo.Visible = false;
            UC_EnCokSatisYapanGarson uc = new UC_EnCokSatisYapanGarson();
            PaneleUCGetir(uc);
        }
        private void btn_Buyult_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                btn_Buyult.Image = Resources.icons8_collapse_32;

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
        private void MasaNoListele()
        {
            var masaNo = db.Masa;
            CB_MasaNo.DisplayMember = "MasaNo";
            CB_MasaNo.ValueMember = "id"; ;
            CB_MasaNo.DataSource = masaNo.ToList();
        }

        private void btn_SiparisVer_Click(object sender, EventArgs e)
        {
            MasaNoListele();
            panel_MasaNo.Visible = true;
            UC_Siparis uc = new UC_Siparis();
            PaneleUCGetir(uc);
        }

        private void btn_SiparisDurumu_Click(object sender, EventArgs e)
        {
            MasaNoListele();
            panel_MasaNo.Visible = true;
            UC_SiparisDurumuMusteri uc = new UC_SiparisDurumuMusteri();
            PaneleUCGetir(uc);
        }

        private void CB_MasaNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Login.MasaNo = Convert.ToInt32(CB_MasaNo.SelectedValue);

            
        }

        private void timer_zaman_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_time.Text = dt.ToString("HH:mm:ss");
        }

        private void timer_siparis_Tick(object sender, EventArgs e)
        {
            if (siparisAcikMi)
            {
                //Menu kapancak

                panel_siparisSlider.Height = panel_siparisSlider.Height - 30;
                btn_sliderSiparis.Image = Resources.icons8_expand_arrow_32;
                if (panel_siparisSlider.Height == 50)
                {
                    siparisAcikMi = false;
                    timer_siparis.Stop();
                    this.Refresh();
                }


            }
            else
            {
                panel_siparisSlider.Height = panel_siparisSlider.Height +30;
                btn_sliderSiparis.Image = Resources.icons8_collapse_arrow_32;

                if (panel_siparisSlider.Height >= SiparisSliderYukseklik)
                {

                    siparisAcikMi = true;
                    timer_siparis.Stop();
                    this.Refresh();
                }
            }
        }

        private void btn_sliderSiparis_Click(object sender, EventArgs e)
        {
            timer_siparis.Start();
        }
    }
}
