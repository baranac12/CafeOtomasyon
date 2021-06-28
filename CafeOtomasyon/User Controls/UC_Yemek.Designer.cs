namespace CafeOtomasyon
{
    partial class UC_Yemek
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Yemek));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_message = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_YemekListe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_Tumu = new System.Windows.Forms.CheckBox();
            this.comboBox_Kategori = new System.Windows.Forms.ComboBox();
            this.richTextBox_İcindekiler = new System.Windows.Forms.RichTextBox();
            this.textBox_Fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Adı = new System.Windows.Forms.TextBox();
            this.labnel_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_YemekListe)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.label_message);
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Controls.Add(this.btn_guncelle);
            this.panel1.Controls.Add(this.btn_Ekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 110);
            this.panel1.TabIndex = 0;
            // 
            // label_message
            // 
            this.label_message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_message.AutoSize = true;
            this.label_message.ForeColor = System.Drawing.Color.Maroon;
            this.label_message.Location = new System.Drawing.Point(13, 68);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(105, 15);
            this.label_message.TabIndex = 9;
            this.label_message.Text = "label_message";
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(493, 20);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 45);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "     Sil";
            this.btn_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_temizle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_temizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Location = new System.Drawing.Point(203, 20);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(121, 45);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "   Temizle";
            this.btn_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(348, 20);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(121, 45);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "  Güncelle";
            this.btn_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_Ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.Image")));
            this.btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ekle.Location = new System.Drawing.Point(638, 20);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(121, 45);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "    Ekle";
            this.btn_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_YemekListe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 180);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView_YemekListe
            // 
            this.dataGridView_YemekListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_YemekListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_YemekListe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_YemekListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_YemekListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_YemekListe.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_YemekListe.Name = "dataGridView_YemekListe";
            this.dataGridView_YemekListe.RowHeadersVisible = false;
            this.dataGridView_YemekListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_YemekListe.Size = new System.Drawing.Size(932, 180);
            this.dataGridView_YemekListe.TabIndex = 0;
            this.dataGridView_YemekListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_YemekListe_CellClick);
            this.dataGridView_YemekListe.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_YemekListe_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.checkBox_Tumu);
            this.panel2.Controls.Add(this.comboBox_Kategori);
            this.panel2.Controls.Add(this.richTextBox_İcindekiler);
            this.panel2.Controls.Add(this.textBox_Fiyat);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_ID);
            this.panel2.Controls.Add(this.textBox_Adı);
            this.panel2.Controls.Add(this.labnel_id);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 271);
            this.panel2.TabIndex = 3;
            // 
            // checkBox_Tumu
            // 
            this.checkBox_Tumu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Tumu.AutoSize = true;
            this.checkBox_Tumu.Checked = true;
            this.checkBox_Tumu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Tumu.Location = new System.Drawing.Point(400, 32);
            this.checkBox_Tumu.Name = "checkBox_Tumu";
            this.checkBox_Tumu.Size = new System.Drawing.Size(122, 19);
            this.checkBox_Tumu.TabIndex = 24;
            this.checkBox_Tumu.Text = "Hepsini Listele";
            this.checkBox_Tumu.UseVisualStyleBackColor = true;
            this.checkBox_Tumu.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox_Kategori
            // 
            this.comboBox_Kategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Kategori.FormattingEnabled = true;
            this.comboBox_Kategori.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_Kategori.Location = new System.Drawing.Point(154, 86);
            this.comboBox_Kategori.Name = "comboBox_Kategori";
            this.comboBox_Kategori.Size = new System.Drawing.Size(654, 23);
            this.comboBox_Kategori.TabIndex = 23;
            this.comboBox_Kategori.Text = "Kategori Seçiniz.";
            // 
            // richTextBox_İcindekiler
            // 
            this.richTextBox_İcindekiler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_İcindekiler.Location = new System.Drawing.Point(154, 147);
            this.richTextBox_İcindekiler.Name = "richTextBox_İcindekiler";
            this.richTextBox_İcindekiler.Size = new System.Drawing.Size(654, 82);
            this.richTextBox_İcindekiler.TabIndex = 22;
            this.richTextBox_İcindekiler.Text = "";
            // 
            // textBox_Fiyat
            // 
            this.textBox_Fiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Fiyat.Location = new System.Drawing.Point(514, 116);
            this.textBox_Fiyat.Name = "textBox_Fiyat";
            this.textBox_Fiyat.Size = new System.Drawing.Size(294, 21);
            this.textBox_Fiyat.TabIndex = 19;
            this.textBox_Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "İçindekiler";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ID.Location = new System.Drawing.Point(154, 58);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(654, 21);
            this.textBox_ID.TabIndex = 20;
            this.textBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Adı
            // 
            this.textBox_Adı.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Adı.Location = new System.Drawing.Point(154, 116);
            this.textBox_Adı.Name = "textBox_Adı";
            this.textBox_Adı.Size = new System.Drawing.Size(294, 21);
            this.textBox_Adı.TabIndex = 21;
            this.textBox_Adı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labnel_id
            // 
            this.labnel_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labnel_id.AutoSize = true;
            this.labnel_id.Location = new System.Drawing.Point(122, 64);
            this.labnel_id.Name = "labnel_id";
            this.labnel_id.Size = new System.Drawing.Size(21, 15);
            this.labnel_id.TabIndex = 16;
            this.labnel_id.Text = "ID";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adı";
            // 
            // UC_Yemek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Yemek";
            this.Size = new System.Drawing.Size(932, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_YemekListe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_YemekListe;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_Kategori;
        private System.Windows.Forms.RichTextBox richTextBox_İcindekiler;
        private System.Windows.Forms.TextBox textBox_Fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Adı;
        private System.Windows.Forms.Label labnel_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_Tumu;
        private System.Windows.Forms.Button btn_guncelle;
    }
}
