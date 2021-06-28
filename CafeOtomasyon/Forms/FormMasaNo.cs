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

namespace CafeOtomasyon.Forms
{
    public partial class FormMasaNo : Form
    {
        public FormMasaNo()
        {
            InitializeComponent();
        }
        private void btn_durum_Click(object sender, EventArgs e)
        {
           // Login.MasaNo = int.Parse(textBox_MasaNo.Text);
           // FormSiparisDurumu frm = new FormSiparisDurumu();
           // this.Hide();
           // frm.ShowDialog();
        }  //

        private void btn_DevamEt_Click(object sender, EventArgs e)
        {
            Login.MasaNo = int.Parse(textBox_MasaNo.Text);
            this.Hide();
            //MessageBox.Show(textBox_MasaNo.Text + " numaralı masaya siparis girebilirsiniz."," Masa Numarası ",MessageBoxButtons.OK);
        }
    }
}
