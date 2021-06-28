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
    public partial class UC_İcecekler : UserControl
    {
        kafe_otomasyonDBEntities4 db = new kafe_otomasyonDBEntities4();
        public UC_İcecekler()
        {
            InitializeComponent();
            İcecekleriListele();
            butonKontrol();
            temizle();
            KategorileriListele();
        }
        private void KategorileriListele()
        {
            var icecekler = db.İçecekKategori;
            comboBox_Kategori.DisplayMember = "Ad";
            comboBox_Kategori.ValueMember = "id"; ;
            comboBox_Kategori.DataSource = icecekler.ToList();
        }

        private void İcecekleriListele()
        {
            bool evet = true, hayir = true;

            if (checkBox_Tumu.Checked)
            {
                hayir = false;
            }

            var icecekler = db.İçecekler.Where(k=> k.Durum==evet || k.Durum==hayir)
                .Select(s => new
                {
                        Id = s.id,
                        Kategori = s.İçecekKategori.Ad,
                        Adi=s.Ad,
                        Fiyati=s.Fiyat,
                        Durumu=s.Durum==true ? "A":"P"
                });
            dataGridView_Icecek.DataSource = icecekler.ToList();
        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            
            İçecekler icecek = new İçecekler();
            try
            {
                icecek.Ad = textBox_Adı.Text;
                icecek.Fiyat = decimal.Parse(textBox_Fiyat.Text);
                icecek.Durum = true;
                icecek.KategoriId = int.Parse(comboBox_Kategori.SelectedValue.ToString());
                label_message.Text = "Ekleme Başarılı.";
                db.İçecekler.Add(icecek);
                db.SaveChanges();
                temizle();

            }
            catch (Exception hata)
            {

                label_message.Text = "Hata: " + hata.Message.ToString();
            }

        }
        private void butonKontrol()
        {
            if (textBox_ID.Text!="0")
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
            comboBox_Kategori.Text = "Kategori Seçiniz.";
            label_message.Text="";
            checkBox_Tumu.Checked = true;
            butonKontrol();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
            İcecekleriListele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int silmeId = int.Parse(textBox_ID.Text);
            İçecekler icecek = db.İçecekler.Find(silmeId);
            icecek.Durum = false;
            db.SaveChanges();
            temizle();
            İcecekleriListele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int GunceelemeId = int.Parse(textBox_ID.Text);
            İçecekler icecek = db.İçecekler.Find(GunceelemeId);
            icecek.Ad = textBox_Adı.Text;
            icecek.Fiyat = decimal.Parse(textBox_Fiyat.Text);
            icecek.KategoriId =int.Parse( comboBox_Kategori.SelectedValue.ToString());
            icecek.Durum = true;
            db.SaveChanges();
            temizle();
            İcecekleriListele();
        }

        private void checkBox_Tumu_CheckedChanged(object sender, EventArgs e)
        {
            İcecekleriListele();
        }

        private void dataGridView_Icecek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = dataGridView_Icecek.SelectedRows[0].Cells["Id"].Value.ToString();
            textBox_Fiyat.Text = dataGridView_Icecek.SelectedRows[0].Cells["Fiyati"].Value.ToString();
            comboBox_Kategori.Text = dataGridView_Icecek.SelectedRows[0].Cells["Kategori"].Value.ToString();
            textBox_Adı.Text = dataGridView_Icecek.SelectedRows[0].Cells["Adi"].Value.ToString();
            butonKontrol();
        }
    }
}
