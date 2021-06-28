
namespace CafeOtomasyon.User_Controls
{
    partial class UC_EnCokSatilan
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
            this.DGW_Tatli = new System.Windows.Forms.DataGridView();
            this.DGW_Icecek = new System.Windows.Forms.DataGridView();
            this.DGW_Yemek = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Tatli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Icecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Yemek)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(932, 126);
            this.panel2.TabIndex = 7;
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
            this.dateTimePicker_gunlukMax.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            this.dateTimePicker_gunlukMax.ValueChanged += new System.EventHandler(this.dateTimePicker_gunlukMax_ValueChanged);
            // 
            // dateTimePicker_gunMın
            // 
            this.dateTimePicker_gunMın.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gunMın.Location = new System.Drawing.Point(179, 63);
            this.dateTimePicker_gunMın.Name = "dateTimePicker_gunMın";
            this.dateTimePicker_gunMın.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_gunMın.TabIndex = 2;
            this.dateTimePicker_gunMın.Value = new System.DateTime(2021, 6, 15, 12, 46, 17, 0);
            this.dateTimePicker_gunMın.ValueChanged += new System.EventHandler(this.dateTimePicker_gunMın_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 94);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGW_Tatli);
            this.panel4.Controls.Add(this.DGW_Icecek);
            this.panel4.Controls.Add(this.DGW_Yemek);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 341);
            this.panel4.TabIndex = 9;
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
            this.DGW_Tatli.Size = new System.Drawing.Size(312, 341);
            this.DGW_Tatli.TabIndex = 2;
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
            this.DGW_Icecek.Size = new System.Drawing.Size(310, 341);
            this.DGW_Icecek.TabIndex = 1;
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
            this.DGW_Yemek.Size = new System.Drawing.Size(310, 341);
            this.DGW_Yemek.TabIndex = 0;
            // 
            // UC_EnCokSatilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_EnCokSatilan";
            this.Size = new System.Drawing.Size(932, 561);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Tatli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Icecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Yemek)).EndInit();
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
        private System.Windows.Forms.DataGridView DGW_Tatli;
        private System.Windows.Forms.DataGridView DGW_Icecek;
        private System.Windows.Forms.DataGridView DGW_Yemek;
    }
}
