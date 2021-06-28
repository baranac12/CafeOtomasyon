using CafeOtomasyon.Properties;
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
    public partial class FormKullanici : Form
    {
        public FormKullanici()
        {
            InitializeComponent();
        }

        private void picBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            FormPersonel prsnl = new FormPersonel();
            this.Hide();
            prsnl.Show();
 
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            FormMusteriLogin mstr = new FormMusteriLogin();
            this.Hide();
            mstr.ShowDialog();
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
    }
}
