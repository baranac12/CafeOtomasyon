using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Model.Entities;

namespace CafeOtomasyon
{
    public partial class UC_Tatli : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        public UC_Tatli()
        {
            InitializeComponent();
            TatliListele();
            butonKontrol();
            temizle();

        }


        private void TatliListele()
        {
            bool evet = true, hayir = true;

            if (checkBox_Tumu.Checked)
            {
                hayir = false;
            }

            var tatlilar = db.Tatlı.Where(k => k.Durum == evet || k.Durum == hayir)
                .Select(s => new
                {
                    Id = s.id,
                    
                    Adi = s.Ad,
                    Fiyati = s.Fiyat,
                    Durumu = s.Durum == true ? "A" : "P",
                    icindekiler = s.İçindekiler
                }) ;
            dataGridView_TatliListe.DataSource = tatlilar.ToList(); ;
        }

        private void dataGridView_TatliListe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TatliListele();
        }
        private void butonKontrol()
        {
            if (textBox_ID.Text != "0")
            {
                btn_sil.Enabled = true;
                btn_guncelle.Enabled = true;
            }
            else
            {
                btn_sil.Enabled = false;
                btn_guncelle.Enabled = false;
            }
            
        }

        private void temizle()
        {
            textBox_Adı.Text = "";
            textBox_Fiyat.Text = "";
            textBox_ID.Text = "0";
            richTextBox_İcindekiler.Text = "";
            label_message.Text = "";
            checkBox_Tumu.Checked = true;
            butonKontrol();
        }
       

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tatlı tatlı = new Tatlı();
            try
            {
                tatlı.Ad = textBox_Adı.Text;
                tatlı.Fiyat = decimal.Parse(textBox_Fiyat.Text);
                tatlı.Durum = true;
                tatlı.İçindekiler = richTextBox_İcindekiler.Text;
                label_message.Text = "Ekleme Başarılı.";
                db.Tatlı.Add(tatlı);
                db.SaveChanges();
                temizle();
                TatliListele();

            }
            catch (Exception hata)
            {

                label_message.Text = "Hata: " + hata.Message.ToString();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int silmeId = int.Parse(textBox_ID.Text);
            Tatlı tatlı = db.Tatlı.Find(silmeId);
            tatlı.Durum = false;
            db.SaveChanges();
            temizle();
            TatliListele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int GunceelemeId = int.Parse(textBox_ID.Text);
            Tatlı tatlı = db.Tatlı.Find(GunceelemeId);
            tatlı.Ad = textBox_Adı.Text;
            tatlı.Fiyat = decimal.Parse(textBox_Fiyat.Text);
            tatlı.İçindekiler = richTextBox_İcindekiler.Text;
            tatlı.Durum = true;
            db.SaveChanges();
            temizle();
            TatliListele();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
            TatliListele();
        }

        private void dataGridView_TatliListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = dataGridView_TatliListe.SelectedRows[0].Cells["Id"].Value.ToString();
            textBox_Fiyat.Text = dataGridView_TatliListe.SelectedRows[0].Cells["Fiyati"].Value.ToString();
            richTextBox_İcindekiler.Text = dataGridView_TatliListe.SelectedRows[0].Cells["icindekiler"].Value.ToString();
            textBox_Adı.Text = dataGridView_TatliListe.SelectedRows[0].Cells["Adi"].Value.ToString();
            butonKontrol();
        }
    }
}
