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
    public partial class UC_Menu : UserControl
    {
        int butonDefaultHeight = 35;
        public UC_Menu()
        {
            InitializeComponent();
        }
        public void butonBoyutClick(Button btn)
        {
            btn.Height = panel_ust.Height;
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
        private void PaneleUCGetir(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(uc);
        }

        private void btn_yemek_Click_1(object sender, EventArgs e)
        {
            butonBoyutClick(btn_yemek);
            butonBoyutNormal(btn_Icecek, btn_tatli);
            UC_Yemek uc = new UC_Yemek();
            PaneleUCGetir(uc);
        }

        private void btn_tatli_Click_1(object sender, EventArgs e)
        {
            butonBoyutClick(btn_tatli);
            butonBoyutNormal(btn_Icecek, btn_yemek);
            UC_Tatli uc = new UC_Tatli();
            PaneleUCGetir(uc);
        }

        private void btn_Icecek_Click_1(object sender, EventArgs e)
        {
            butonBoyutClick(btn_Icecek);
            butonBoyutNormal(btn_yemek, btn_tatli);
            UC_İcecekler uc = new UC_İcecekler();
            PaneleUCGetir(uc);
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            FormYöneticiAnaSayfa anasyf = new FormYöneticiAnaSayfa();
            this.Hide();
            anasyf.ShowDialog();
        }
    }
}
