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
    public partial class UC_Yemek : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        public UC_Yemek()
        {
            InitializeComponent();
            YemekListele();
            temizle();
            KategorileriListele();
        }

        private void KategorileriListele()
        {
            var kategoriler = db.YemekKategori;
            comboBox_Kategori.DisplayMember = "Kategori";
            comboBox_Kategori.ValueMember = "id"; ;
            comboBox_Kategori.DataSource = kategoriler.ToList();
        }

        private void YemekListele()
        {
            bool evet = true, hayir = true;

            if (checkBox_Tumu.Checked)
            {
                hayir = false;
            }

            var yemekler = db.Yemek.Where(k => k.Durum == evet || k.Durum == hayir)
                .Select(s => new
                {
                    Id = s.id,
                    KategoriAdi=s.YemekKategori.Kategori,
                    Adi = s.Ad,
                    Fiyati = s.Fiyat,
                    Durumu = s.Durum == true ? "A" : "P",
                    icindekiler = s.İçindekiler
                });
            dataGridView_YemekListe.DataSource = yemekler.ToList(); ;
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
            comboBox_Kategori.Text = "Kategori Seçiniz.";
            textBox_Fiyat.Text = "";
            textBox_ID.Text = "0";
            richTextBox_İcindekiler.Text = "";
            label_message.Text = "";
            checkBox_Tumu.Checked = true;
            butonKontrol();
        }
        private void dataGridView_YemekListe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            YemekListele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Yemek yemek = new Yemek();
            try
            {
                yemek.Ad = textBox_Adı.Text;
                yemek.Fiyat = decimal.Parse(textBox_Fiyat.Text);
                yemek.Durum = true;
                yemek.İçindekiler = richTextBox_İcindekiler.Text;
                yemek.KategoriId = int.Parse(comboBox_Kategori.SelectedValue.ToString());
                label_message.Text = "Ekleme Başarılı.";
                db.Yemek.Add(yemek);
                db.SaveChanges();
                temizle();
                YemekListele();

            }
            catch (Exception hata)
            {

                label_message.Text = "Hata: " + hata.Message.ToString();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int silmeId = int.Parse(textBox_ID.Text);
            Yemek yemek = db.Yemek.Find(silmeId);
            yemek.Durum = false;
            db.SaveChanges();
            temizle();
            YemekListele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int GunceelemeId = int.Parse(textBox_ID.Text);
                Yemek yemek = db.Yemek.Find(GunceelemeId);
                yemek.Ad = textBox_Adı.Text;
                yemek.Fiyat = decimal.Parse(textBox_Fiyat.Text);
                yemek.İçindekiler = richTextBox_İcindekiler.Text;
                yemek.Durum = true;
                yemek.KategoriId = int.Parse(comboBox_Kategori.SelectedValue.ToString());
                db.SaveChanges();
                temizle();
                YemekListele();
            }
            catch (Exception hata)
            {

                label_message.Text = hata.Message.ToString();
            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
            butonKontrol();
        }

        private void dataGridView_YemekListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = dataGridView_YemekListe.SelectedRows[0].Cells["Id"].Value.ToString();
            textBox_Fiyat.Text = dataGridView_YemekListe.SelectedRows[0].Cells["Fiyati"].Value.ToString();
            richTextBox_İcindekiler.Text = dataGridView_YemekListe.SelectedRows[0].Cells["icindekiler"].Value.ToString();
            textBox_Adı.Text = dataGridView_YemekListe.SelectedRows[0].Cells["Adi"].Value.ToString();
            comboBox_Kategori.Text = dataGridView_YemekListe.SelectedRows[0].Cells["KategoriAdi"].Value.ToString();
            butonKontrol();
        }
    }
}
