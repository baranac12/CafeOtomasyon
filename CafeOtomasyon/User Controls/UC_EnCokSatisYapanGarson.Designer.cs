
namespace CafeOtomasyon.User_Controls
{
    partial class UC_EnCokSatisYapanGarson
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Son1AylikKazanc = new System.Windows.Forms.Button();
            this.btn_Son1Haftalik = new System.Windows.Forms.Button();
            this.dateTimePicker_gunlukMax = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_gunMın = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DGW_Tatli = new System.Windows.Forms.DataGridView();
            this.DGW_Icecek = new System.Windows.Forms.DataGridView();
            this.DGW_Yemek = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DGW_Toplam = new System.Windows.Forms.DataGridView();
            this.btnEnCok = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Tatli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Icecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Yemek)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Toplam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dateTimePicker_gunlukMax);
            this.panel2.Controls.Add(this.dateTimePicker_gunMın);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 117);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(453, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Son Tarihi Giriniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "İlk Tarihi Giriniz :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Son1AylikKazanc);
            this.panel1.Controls.Add(this.btn_Son1Haftalik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 42);
            this.panel1.TabIndex = 5;
            // 
            // btn_Son1AylikKazanc
            // 
            this.btn_Son1AylikKazanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_Son1AylikKazanc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Son1AylikKazanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Son1AylikKazanc.ForeColor = System.Drawing.Color.White;
            this.btn_Son1AylikKazanc.Location = new System.Drawing.Point(466, 0);
            this.btn_Son1AylikKazanc.Name = "btn_Son1AylikKazanc";
            this.btn_Son1AylikKazanc.Size = new System.Drawing.Size(466, 42);
            this.btn_Son1AylikKazanc.TabIndex = 5;
            this.btn_Son1AylikKazanc.Text = "Son 1 Aylık Rapor";
            this.btn_Son1AylikKazanc.UseVisualStyleBackColor = false;
            this.btn_Son1AylikKazanc.Click += new System.EventHandler(this.btn_Son1AylikKazanc_Click);
            // 
            // btn_Son1Haftalik
            // 
            this.btn_Son1Haftalik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_Son1Haftalik.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Son1Haftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Son1Haftalik.ForeColor = System.Drawing.Color.White;
            this.btn_Son1Haftalik.Location = new System.Drawing.Point(0, 0);
            this.btn_Son1Haftalik.Name = "btn_Son1Haftalik";
            this.btn_Son1Haftalik.Size = new System.Drawing.Size(466, 42);
            this.btn_Son1Haftalik.TabIndex = 4;
            this.btn_Son1Haftalik.Text = "Son 1 Haftalık Rapor";
            this.btn_Son1Haftalik.UseVisualStyleBackColor = false;
            this.btn_Son1Haftalik.Click += new System.EventHandler(this.btn_Son1Haftalik_Click);
            // 
            // dateTimePicker_gunlukMax
            // 
            this.dateTimePicker_gunlukMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gunlukMax.Location = new System.Drawing.Point(596, 63);
            this.dateTimePicker_gunlukMax.Name = "dateTimePicker_gunlukMax";
            this.dateTimePicker_gunlukMax.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_gunlukMax.TabIndex = 3;
            this.dateTimePicker_gunlukMax.Value = new System.DateTime(2021, 4, 27, 23, 59, 0, 0);
            this.dateTimePicker_gunlukMax.ValueChanged += new System.EventHandler(this.dateTimePicker_gunlukMax_ValueChanged);
            // 
            // dateTimePicker_gunMın
            // 
            this.dateTimePicker_gunMın.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gunMın.Location = new System.Drawing.Point(179, 63);
            this.dateTimePicker_gunMın.Name = "dateTimePicker_gunMın";
            this.dateTimePicker_gunMın.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_gunMın.TabIndex = 2;
            this.dateTimePicker_gunMın.Value = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker_gunMın.ValueChanged += new System.EventHandler(this.dateTimePicker_gunMın_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEnCok);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 253);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 5);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DGW_Tatli);
            this.panel5.Controls.Add(this.DGW_Icecek);
            this.panel5.Controls.Add(this.DGW_Yemek);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(932, 191);
            this.panel5.TabIndex = 10;
            // 
            // DGW_Tatli
            // 
            this.DGW_Tatli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGW_Tatli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGW_Tatli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.DGW_Tatli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Tatli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW_Tatli.Location = new System.Drawing.Point(310, 0);
            this.DGW_Tatli.Name = "DGW_Tatli";
            this.DGW_Tatli.RowHeadersVisible = false;
            this.DGW_Tatli.Size = new System.Drawing.Size(312, 191);
            this.DGW_Tatli.TabIndex = 15;
            // 
            // DGW_Icecek
            // 
            this.DGW_Icecek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGW_Icecek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGW_Icecek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.DGW_Icecek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Icecek.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGW_Icecek.Location = new System.Drawing.Point(622, 0);
            this.DGW_Icecek.Name = "DGW_Icecek";
            this.DGW_Icecek.RowHeadersVisible = false;
            this.DGW_Icecek.Size = new System.Drawing.Size(310, 191);
            this.DGW_Icecek.TabIndex = 14;
            // 
            // DGW_Yemek
            // 
            this.DGW_Yemek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGW_Yemek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGW_Yemek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.DGW_Yemek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Yemek.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGW_Yemek.Location = new System.Drawing.Point(0, 0);
            this.DGW_Yemek.Name = "DGW_Yemek";
            this.DGW_Yemek.RowHeadersVisible = false;
            this.DGW_Yemek.Size = new System.Drawing.Size(310, 191);
            this.DGW_Yemek.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DGW_Toplam);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 248);
            this.panel6.TabIndex = 1;
            // 
            // DGW_Toplam
            // 
            this.DGW_Toplam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGW_Toplam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGW_Toplam.BackgroundColor = System.Drawing.Color.White;
            this.DGW_Toplam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Toplam.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGW_Toplam.Location = new System.Drawing.Point(0, 0);
            this.DGW_Toplam.Name = "DGW_Toplam";
            this.DGW_Toplam.Size = new System.Drawing.Size(330, 219);
            this.DGW_Toplam.TabIndex = 0;
            // 
            // btnEnCok
            // 
            this.btnEnCok.FlatAppearance.BorderSize = 0;
            this.btnEnCok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.btnEnCok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnCok.Location = new System.Drawing.Point(466, 93);
            this.btnEnCok.Name = "btnEnCok";
            this.btnEnCok.Size = new System.Drawing.Size(382, 38);
            this.btnEnCok.TabIndex = 2;
            this.btnEnCok.UseVisualStyleBackColor = true;
            this.btnEnCok.Click += new System.EventHandler(this.btnEnCok_Click);
            // 
            // UC_EnCokSatisYapanGarson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_EnCokSatisYapanGarson";
            this.Size = new System.Drawing.Size(932, 561);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Tatli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Icecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Yemek)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Toplam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Son1AylikKazanc;
        private System.Windows.Forms.Button btn_Son1Haftalik;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gunlukMax;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gunMın;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DGW_Toplam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DGW_Tatli;
        private System.Windows.Forms.DataGridView DGW_Icecek;
        private System.Windows.Forms.DataGridView DGW_Yemek;
        private System.Windows.Forms.Button btnEnCok;
    }
}
