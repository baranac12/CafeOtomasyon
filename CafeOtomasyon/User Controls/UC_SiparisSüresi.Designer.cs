
namespace CafeOtomasyon.User_Controls
{
    partial class UC_SiparisSüresi
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
            this.btnBaar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMutfak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGW_Mutfak = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DGW_Bar = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Mutfak)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Bar)).BeginInit();
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
            this.dateTimePicker_gunMın.Value = new System.DateTime(2021, 5, 10, 0, 0, 0, 0);
            this.dateTimePicker_gunMın.ValueChanged += new System.EventHandler(this.dateTimePicker_gunMın_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBaar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnMutfak);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 92);
            this.panel3.TabIndex = 9;
            // 
            // btnBaar
            // 
            this.btnBaar.Location = new System.Drawing.Point(567, 39);
            this.btnBaar.Name = "btnBaar";
            this.btnBaar.Size = new System.Drawing.Size(220, 36);
            this.btnBaar.TabIndex = 2;
            this.btnBaar.UseVisualStyleBackColor = true;
            this.btnBaar.Click += new System.EventHandler(this.btnBaar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(573, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ortalama Bar Sipariş Süresi :";
            // 
            // btnMutfak
            // 
            this.btnMutfak.Location = new System.Drawing.Point(90, 39);
            this.btnMutfak.Name = "btnMutfak";
            this.btnMutfak.Size = new System.Drawing.Size(220, 36);
            this.btnMutfak.TabIndex = 2;
            this.btnMutfak.UseVisualStyleBackColor = true;
            this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ortalama Mutfak Sipariş Süresi :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGW_Mutfak);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 343);
            this.panel4.TabIndex = 10;
            // 
            // DGW_Mutfak
            // 
            this.DGW_Mutfak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGW_Mutfak.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGW_Mutfak.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.DGW_Mutfak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Mutfak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW_Mutfak.Location = new System.Drawing.Point(0, 0);
            this.DGW_Mutfak.Name = "DGW_Mutfak";
            this.DGW_Mutfak.RowHeadersVisible = false;
            this.DGW_Mutfak.Size = new System.Drawing.Size(466, 343);
            this.DGW_Mutfak.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DGW_Bar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(466, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 343);
            this.panel5.TabIndex = 11;
            // 
            // DGW_Bar
            // 
            this.DGW_Bar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGW_Bar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGW_Bar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.DGW_Bar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW_Bar.Location = new System.Drawing.Point(0, 0);
            this.DGW_Bar.Name = "DGW_Bar";
            this.DGW_Bar.RowHeadersVisible = false;
            this.DGW_Bar.Size = new System.Drawing.Size(466, 343);
            this.DGW_Bar.TabIndex = 1;
            // 
            // UC_SiparisSüresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_SiparisSüresi";
            this.Size = new System.Drawing.Size(932, 561);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Mutfak)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Bar)).EndInit();
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
        private System.Windows.Forms.Button btnBaar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DGW_Mutfak;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DGW_Bar;
    }
}
