namespace CafeOtomasyon
{
    partial class UC_SiparisYemek
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
            this.richTextBox_İcindekiler = new System.Windows.Forms.RichTextBox();
            this.textBox_Fiyat = new System.Windows.Forms.TextBox();
            this.textBox_YemekAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Fiyat = new System.Windows.Forms.Label();
            this.label_YemekAdi = new System.Windows.Forms.Label();
            this.dataGridView_Yemekler = new System.Windows.Forms.DataGridView();
            this.KategoriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Listele = new System.Windows.Forms.Button();
            this.dataGridView_Siparis = new System.Windows.Forms.DataGridView();
            this.YemekId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SiparisGonder = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Tutar = new System.Windows.Forms.Label();
            this.textBox_Adet = new System.Windows.Forms.TextBox();
            this.textBox_Tutar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.textBox_MasaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Yemekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Siparis)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_İcindekiler
            // 
            this.richTextBox_İcindekiler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_İcindekiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(223)))), ((int)(((byte)(241)))));
            this.richTextBox_İcindekiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_İcindekiler.Location = new System.Drawing.Point(198, 295);
            this.richTextBox_İcindekiler.Name = "richTextBox_İcindekiler";
            this.richTextBox_İcindekiler.Size = new System.Drawing.Size(307, 106);
            this.richTextBox_İcindekiler.TabIndex = 16;
            this.richTextBox_İcindekiler.Text = "";
            // 
            // textBox_Fiyat
            // 
            this.textBox_Fiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Fiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(223)))), ((int)(((byte)(241)))));
            this.textBox_Fiyat.Location = new System.Drawing.Point(198, 267);
            this.textBox_Fiyat.Name = "textBox_Fiyat";
            this.textBox_Fiyat.ReadOnly = true;
            this.textBox_Fiyat.Size = new System.Drawing.Size(307, 22);
            this.textBox_Fiyat.TabIndex = 13;
            this.textBox_Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_YemekAdi
            // 
            this.textBox_YemekAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_YemekAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(223)))), ((int)(((byte)(241)))));
            this.textBox_YemekAdi.Location = new System.Drawing.Point(198, 236);
            this.textBox_YemekAdi.Name = "textBox_YemekAdi";
            this.textBox_YemekAdi.ReadOnly = true;
            this.textBox_YemekAdi.Size = new System.Drawing.Size(307, 22);
            this.textBox_YemekAdi.TabIndex = 14;
            this.textBox_YemekAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "İçindekiler :";
            // 
            // label_Fiyat
            // 
            this.label_Fiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Fiyat.AutoSize = true;
            this.label_Fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Fiyat.ForeColor = System.Drawing.Color.White;
            this.label_Fiyat.Location = new System.Drawing.Point(113, 269);
            this.label_Fiyat.Name = "label_Fiyat";
            this.label_Fiyat.Size = new System.Drawing.Size(58, 18);
            this.label_Fiyat.TabIndex = 11;
            this.label_Fiyat.Text = "Fiyatı :";
            // 
            // label_YemekAdi
            // 
            this.label_YemekAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_YemekAdi.AutoSize = true;
            this.label_YemekAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_YemekAdi.ForeColor = System.Drawing.Color.White;
            this.label_YemekAdi.Location = new System.Drawing.Point(71, 238);
            this.label_YemekAdi.Name = "label_YemekAdi";
            this.label_YemekAdi.Size = new System.Drawing.Size(97, 18);
            this.label_YemekAdi.TabIndex = 12;
            this.label_YemekAdi.Text = "Yemek Adı :";
            // 
            // dataGridView_Yemekler
            // 
            this.dataGridView_Yemekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Yemekler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Yemekler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.dataGridView_Yemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Yemekler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategoriId,
            this.KategoriAdi});
            this.dataGridView_Yemekler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Yemekler.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Yemekler.Name = "dataGridView_Yemekler";
            this.dataGridView_Yemekler.Size = new System.Drawing.Size(617, 210);
            this.dataGridView_Yemekler.TabIndex = 19;
            this.dataGridView_Yemekler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Yemekler_RowHeaderMouseClick);
            // 
            // KategoriId
            // 
            this.KategoriId.DataPropertyName = "KategoriId";
            this.KategoriId.HeaderText = "KategoriId";
            this.KategoriId.Name = "KategoriId";
            this.KategoriId.ReadOnly = true;
            this.KategoriId.Visible = false;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.DataPropertyName = "Yemek";
            this.KategoriAdi.HeaderText = "KategoriAdi";
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.ReadOnly = true;
            this.KategoriAdi.Visible = false;
            // 
            // button_Listele
            // 
            this.button_Listele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.button_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Listele.ForeColor = System.Drawing.Color.White;
            this.button_Listele.Location = new System.Drawing.Point(271, 441);
            this.button_Listele.Name = "button_Listele";
            this.button_Listele.Size = new System.Drawing.Size(147, 32);
            this.button_Listele.TabIndex = 7;
            this.button_Listele.Text = "Listeye Ekle";
            this.button_Listele.UseVisualStyleBackColor = false;
            this.button_Listele.Click += new System.EventHandler(this.button_Listele_Click);
            // 
            // dataGridView_Siparis
            // 
            this.dataGridView_Siparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Siparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_Siparis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.dataGridView_Siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Siparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YemekId,
            this.Id});
            this.dataGridView_Siparis.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Siparis.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Siparis.Name = "dataGridView_Siparis";
            this.dataGridView_Siparis.Size = new System.Drawing.Size(312, 313);
            this.dataGridView_Siparis.TabIndex = 5;
            // 
            // YemekId
            // 
            this.YemekId.DataPropertyName = "YemekId";
            this.YemekId.HeaderText = "YemekId";
            this.YemekId.Name = "YemekId";
            this.YemekId.ReadOnly = true;
            this.YemekId.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // btn_SiparisGonder
            // 
            this.btn_SiparisGonder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SiparisGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.btn_SiparisGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SiparisGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SiparisGonder.ForeColor = System.Drawing.Color.Black;
            this.btn_SiparisGonder.Location = new System.Drawing.Point(146, 441);
            this.btn_SiparisGonder.Name = "btn_SiparisGonder";
            this.btn_SiparisGonder.Size = new System.Drawing.Size(147, 32);
            this.btn_SiparisGonder.TabIndex = 7;
            this.btn_SiparisGonder.Text = "Siparişi Tamamla";
            this.btn_SiparisGonder.UseVisualStyleBackColor = false;
            this.btn_SiparisGonder.Click += new System.EventHandler(this.btn_SiparisGonder_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(35, 441);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(98, 32);
            this.btn_Sil.TabIndex = 6;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Siparis Adeti :";
            // 
            // label_Tutar
            // 
            this.label_Tutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Tutar.AutoSize = true;
            this.label_Tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Tutar.ForeColor = System.Drawing.Color.White;
            this.label_Tutar.Location = new System.Drawing.Point(19, 382);
            this.label_Tutar.Name = "label_Tutar";
            this.label_Tutar.Size = new System.Drawing.Size(100, 15);
            this.label_Tutar.TabIndex = 8;
            this.label_Tutar.Text = "Toplam Tutar :";
            // 
            // textBox_Adet
            // 
            this.textBox_Adet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Adet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox_Adet.Location = new System.Drawing.Point(135, 348);
            this.textBox_Adet.Name = "textBox_Adet";
            this.textBox_Adet.ReadOnly = true;
            this.textBox_Adet.Size = new System.Drawing.Size(147, 22);
            this.textBox_Adet.TabIndex = 11;
            this.textBox_Adet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Tutar
            // 
            this.textBox_Tutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Tutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox_Tutar.Location = new System.Drawing.Point(135, 379);
            this.textBox_Tutar.Name = "textBox_Tutar";
            this.textBox_Tutar.ReadOnly = true;
            this.textBox_Tutar.Size = new System.Drawing.Size(147, 22);
            this.textBox_Tutar.TabIndex = 10;
            this.textBox_Tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.textBox_Tutar);
            this.panel1.Controls.Add(this.textBox_Adet);
            this.panel1.Controls.Add(this.label_Tutar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Sil);
            this.panel1.Controls.Add(this.btn_SiparisGonder);
            this.panel1.Controls.Add(this.dataGridView_Siparis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(620, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 495);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(617, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 495);
            this.panel2.TabIndex = 18;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(333, 217);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 16);
            this.label_id.TabIndex = 43;
            this.label_id.Text = "id";
            this.label_id.Visible = false;
            // 
            // label_message
            // 
            this.label_message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_message.AutoSize = true;
            this.label_message.ForeColor = System.Drawing.Color.Maroon;
            this.label_message.Location = new System.Drawing.Point(13, 469);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(115, 16);
            this.label_message.TabIndex = 44;
            this.label_message.Text = "label_message";
            // 
            // textBox_MasaNo
            // 
            this.textBox_MasaNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MasaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox_MasaNo.Location = new System.Drawing.Point(336, 413);
            this.textBox_MasaNo.Name = "textBox_MasaNo";
            this.textBox_MasaNo.Size = new System.Drawing.Size(147, 22);
            this.textBox_MasaNo.TabIndex = 46;
            this.textBox_MasaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Masa No :";
            // 
            // UC_SiparisYemek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.textBox_MasaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.dataGridView_Yemekler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox_İcindekiler);
            this.Controls.Add(this.textBox_Fiyat);
            this.Controls.Add(this.button_Listele);
            this.Controls.Add(this.textBox_YemekAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Fiyat);
            this.Controls.Add(this.label_YemekAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_SiparisYemek";
            this.Size = new System.Drawing.Size(932, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Yemekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Siparis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_İcindekiler;
        private System.Windows.Forms.TextBox textBox_Fiyat;
        private System.Windows.Forms.TextBox textBox_YemekAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Fiyat;
        private System.Windows.Forms.Label label_YemekAdi;
        private System.Windows.Forms.DataGridView dataGridView_Yemekler;
        private System.Windows.Forms.Button button_Listele;
        private System.Windows.Forms.DataGridView dataGridView_Siparis;
        private System.Windows.Forms.Button btn_SiparisGonder;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Tutar;
        private System.Windows.Forms.TextBox textBox_Adet;
        private System.Windows.Forms.TextBox textBox_Tutar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YemekId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.TextBox textBox_MasaNo;
        private System.Windows.Forms.Label label3;
    }
}
