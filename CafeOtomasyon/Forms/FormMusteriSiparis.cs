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
    public partial class FormMusteriSiparis : Form
    {
        public FormMusteriSiparis()
        {
            InitializeComponent();
            SiparisEkraniniGetir();
        }

        private void SiparisEkraniniGetir()
        {
            UC_Siparis uc = new UC_Siparis();
            uc.Dock = DockStyle.Fill;
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(uc);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMusteriAnaSayfa anasyf = new FormMusteriAnaSayfa();
            this.Hide();
            anasyf.ShowDialog();

        }
    }
}
