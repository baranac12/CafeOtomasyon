using CafeOtomasyon.Forms;
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

    public partial class UC_Siparis : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        private int butonDefaultHeight = 37;
        private int butonClickHeigt = 65;
        public UC_Siparis()
        {
            InitializeComponent();

        }
        
 

        private void PaneleUCGetir(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(uc);
        }
        public void butonBoyutClick(Button btn)
        {
            btn.Height = butonClickHeigt;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.White;
            btn.BackColor = Color.FromArgb(15, 86, 114);
            btn.ForeColor = Color.White;
        }
        public void butonBoyutNormal(Button btn, Button btn1)
        {
            btn.Height = butonDefaultHeight;
            btn1.Height = butonDefaultHeight;
            btn.BackColor = Color.FromArgb(43, 115, 121);
            btn1.BackColor = Color.FromArgb(43, 115, 121);
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.White;
            btn1.FlatAppearance.BorderSize = 1;
            btn1.FlatAppearance.BorderColor = Color.White;
            btn.ForeColor = Color.White;
            btn1.ForeColor = Color.White;

        }


        private void btn_Yemek_Click(object sender, EventArgs e)
        {
            butonBoyutClick(btn_Yemek);
            butonBoyutNormal(btn_Icecek, btn_Tatli);
            UC_SiparisYemek uc = new UC_SiparisYemek();
            PaneleUCGetir(uc);
        }

        private void btn_Tatli_Click(object sender, EventArgs e)
        {
            butonBoyutClick(btn_Tatli);
            butonBoyutNormal(btn_Yemek, btn_Icecek);
            UC_SiparisTatli uc = new UC_SiparisTatli();
            PaneleUCGetir(uc);
        }

        private void btn_Icecek_Click(object sender, EventArgs e)
        {
            try
            {
                butonBoyutClick(btn_Icecek);
                butonBoyutNormal(btn_Yemek, btn_Tatli);
                UC_SiparisIcecek uc = new UC_SiparisIcecek();
                PaneleUCGetir(uc);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


        }
    }
}
