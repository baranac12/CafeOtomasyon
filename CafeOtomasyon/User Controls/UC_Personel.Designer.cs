
namespace CafeOtomasyon.User_Controls
{
    partial class UC_Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Personel));
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dataGridView_PersonelListe = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_Tüm = new System.Windows.Forms.CheckBox();
            this.label_message = new System.Windows.Forms.Label();
            this.comboBox_Yetki = new System.Windows.Forms.ComboBox();
            this.textBox_PersonelMail = new System.Windows.Forms.TextBox();
            this.textBox_PersonelTelefon = new System.Windows.Forms.TextBox();
            this.textBox_PersonelParola = new System.Windows.Forms.TextBox();
            this.textBox_PersonelKadi = new System.Windows.Forms.TextBox();
            this.textBox_PersonelSoyad = new System.Windows.Forms.TextBox();
            this.textBox_PersonelID = new System.Windows.Forms.TextBox();
            this.textBox_PersonelAdı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_yetki = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PersonelListe)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(2, 194);
            this.panel15.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(930, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(2, 194);
            this.panel14.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(2, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(928, 2);
            this.panel13.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(2, 192);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(928, 2);
            this.panel12.TabIndex = 1;
            // 
            // dataGridView_PersonelListe
            // 
            this.dataGridView_PersonelListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PersonelListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_PersonelListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.dataGridView_PersonelListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_PersonelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PersonelListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.YetkiId});
            this.dataGridView_PersonelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_PersonelListe.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_PersonelListe.Name = "dataGridView_PersonelListe";
            this.dataGridView_PersonelListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_PersonelListe.RowHeadersVisible = false;
            this.dataGridView_PersonelListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PersonelListe.Size = new System.Drawing.Size(928, 190);
            this.dataGridView_PersonelListe.TabIndex = 4;
            this.dataGridView_PersonelListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PersonelListe_CellClick);
            this.dataGridView_PersonelListe.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_PersonelListe_RowHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // YetkiId
            // 
            this.YetkiId.DataPropertyName = "YetkiId";
            this.YetkiId.HeaderText = "YetkiId";
            this.YetkiId.Name = "YetkiId";
            this.YetkiId.ReadOnly = true;
            this.YetkiId.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel11.Controls.Add(this.dataGridView_PersonelListe);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.ForeColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(932, 194);
            this.panel11.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel16.Controls.Add(this.panel2);
            this.panel16.Controls.Add(this.panel1);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.panel18);
            this.panel16.Controls.Add(this.panel19);
            this.panel16.Controls.Add(this.panel20);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel16.Location = new System.Drawing.Point(0, 194);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(932, 317);
            this.panel16.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.checkBox_Tüm);
            this.panel2.Controls.Add(this.label_message);
            this.panel2.Controls.Add(this.comboBox_Yetki);
            this.panel2.Controls.Add(this.textBox_PersonelMail);
            this.panel2.Controls.Add(this.textBox_PersonelTelefon);
            this.panel2.Controls.Add(this.textBox_PersonelParola);
            this.panel2.Controls.Add(this.textBox_PersonelKadi);
            this.panel2.Controls.Add(this.textBox_PersonelSoyad);
            this.panel2.Controls.Add(this.textBox_PersonelID);
            this.panel2.Controls.Add(this.textBox_PersonelAdı);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label_yetki);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 313);
            this.panel2.TabIndex = 9;
            // 
            // checkBox_Tüm
            // 
            this.checkBox_Tüm.AutoSize = true;
            this.checkBox_Tüm.Checked = true;
            this.checkBox_Tüm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Tüm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_Tüm.ForeColor = System.Drawing.Color.White;
            this.checkBox_Tüm.Location = new System.Drawing.Point(139, 13);
            this.checkBox_Tüm.Name = "checkBox_Tüm";
            this.checkBox_Tüm.Size = new System.Drawing.Size(123, 20);
            this.checkBox_Tüm.TabIndex = 23;
            this.checkBox_Tüm.Text = "Tüm Personel";
            this.checkBox_Tüm.UseVisualStyleBackColor = true;
            this.checkBox_Tüm.CheckedChanged += new System.EventHandler(this.checkBox_Tüm_CheckedChanged);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_message.ForeColor = System.Drawing.Color.Maroon;
            this.label_message.Location = new System.Drawing.Point(136, 272);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(115, 16);
            this.label_message.TabIndex = 25;
            this.label_message.Text = "label_message";
            // 
            // comboBox_Yetki
            // 
            this.comboBox_Yetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Yetki.FormattingEnabled = true;
            this.comboBox_Yetki.Items.AddRange(new object[] {
            "Yönetici",
            "Garson"});
            this.comboBox_Yetki.Location = new System.Drawing.Point(139, 43);
            this.comboBox_Yetki.Name = "comboBox_Yetki";
            this.comboBox_Yetki.Size = new System.Drawing.Size(488, 21);
            this.comboBox_Yetki.TabIndex = 24;
            // 
            // textBox_PersonelMail
            // 
            this.textBox_PersonelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_PersonelMail.Location = new System.Drawing.Point(139, 235);
            this.textBox_PersonelMail.Name = "textBox_PersonelMail";
            this.textBox_PersonelMail.Size = new System.Drawing.Size(181, 20);
            this.textBox_PersonelMail.TabIndex = 21;
            this.textBox_PersonelMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PersonelTelefon
            // 
            this.textBox_PersonelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_PersonelTelefon.Location = new System.Drawing.Point(139, 200);
            this.textBox_PersonelTelefon.Name = "textBox_PersonelTelefon";
            this.textBox_PersonelTelefon.Size = new System.Drawing.Size(181, 20);
            this.textBox_PersonelTelefon.TabIndex = 20;
            this.textBox_PersonelTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PersonelParola
            // 
            this.textBox_PersonelParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_PersonelParola.Location = new System.Drawing.Point(446, 165);
            this.textBox_PersonelParola.Name = "textBox_PersonelParola";
            this.textBox_PersonelParola.Size = new System.Drawing.Size(181, 20);
            this.textBox_PersonelParola.TabIndex = 19;
            this.textBox_PersonelParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PersonelKadi
            // 
            this.textBox_PersonelKadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_PersonelKadi.Location = new System.Drawing.Point(446, 125);
            this.textBox_PersonelKadi.Name = "textBox_PersonelKadi";
            this.textBox_PersonelKadi.Size = new System.Drawing.Size(181, 20);
            this.textBox_PersonelKadi.TabIndex = 18;
            this.textBox_PersonelKadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PersonelSoyad
            // 
            this.textBox_PersonelSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_PersonelSoyad.Location = new System.Drawing.Point(139, 165);
            this.textBox_PersonelSoyad.Name = "textBox_PersonelSoyad";
            this.textBox_PersonelSoyad.Size = new System.Drawing.Size(181, 20);
            this.textBox_PersonelSoyad.TabIndex = 22;
            this.textBox_PersonelSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PersonelID
            // 
            this.textBox_PersonelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_PersonelID.Location = new System.Drawing.Point(139, 88);
            this.textBox_PersonelID.Name = "textBox_PersonelID";
            this.textBox_PersonelID.ReadOnly = true;
            this.textBox_PersonelID.Size = new System.Drawing.Size(488, 20);
            this.textBox_PersonelID.TabIndex = 17;
            this.textBox_PersonelID.Text = "0";
            this.textBox_PersonelID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PersonelAdı
            // 
            this.textBox_PersonelAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_PersonelAdı.Location = new System.Drawing.Point(139, 125);
            this.textBox_PersonelAdı.Name = "textBox_PersonelAdı";
            this.textBox_PersonelAdı.Size = new System.Drawing.Size(181, 20);
            this.textBox_PersonelAdı.TabIndex = 16;
            this.textBox_PersonelAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(381, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(342, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(378, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // label_yetki
            // 
            this.label_yetki.AutoSize = true;
            this.label_yetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_yetki.ForeColor = System.Drawing.Color.White;
            this.label_yetki.Location = new System.Drawing.Point(343, 24);
            this.label_yetki.Name = "label_yetki";
            this.label_yetki.Size = new System.Drawing.Size(97, 16);
            this.label_yetki.TabIndex = 15;
            this.label_yetki.Text = "Görev Seçim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.btn_Ekle);
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.btn_guncelle);
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(728, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 313);
            this.panel1.TabIndex = 8;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_Ekle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.Image")));
            this.btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ekle.Location = new System.Drawing.Point(19, 36);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(121, 46);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "    Ekle";
            this.btn_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Maroon;
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(19, 96);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 45);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "     Sil";
            this.btn_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(19, 154);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(121, 41);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "  Güncelle";
            this.btn_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Gray;
            this.btn_temizle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_temizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Location = new System.Drawing.Point(19, 207);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(121, 45);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "   Temizle";
            this.btn_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(2, 315);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(928, 2);
            this.panel17.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(2, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(928, 2);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel19.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel19.Location = new System.Drawing.Point(930, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(2, 317);
            this.panel19.TabIndex = 3;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(2, 317);
            this.panel20.TabIndex = 2;
            // 
            // UC_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel11);
            this.Name = "UC_Personel";
            this.Size = new System.Drawing.Size(932, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PersonelListe)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dataGridView_PersonelListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiId;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_Tüm;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.ComboBox comboBox_Yetki;
        private System.Windows.Forms.TextBox textBox_PersonelMail;
        private System.Windows.Forms.TextBox textBox_PersonelTelefon;
        private System.Windows.Forms.TextBox textBox_PersonelParola;
        private System.Windows.Forms.TextBox textBox_PersonelKadi;
        private System.Windows.Forms.TextBox textBox_PersonelSoyad;
        private System.Windows.Forms.TextBox textBox_PersonelID;
        private System.Windows.Forms.TextBox textBox_PersonelAdı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_yetki;
        private System.Windows.Forms.Label label1;
    }
}
