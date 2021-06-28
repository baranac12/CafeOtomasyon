
namespace CafeOtomasyon.User_Controls
{
    partial class UC_Kazanc
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KazancToplam = new System.Windows.Forms.TextBox();
            this.dateTimePicker_gunMın = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Son1AylikKazanc = new System.Windows.Forms.Button();
            this.btn_Son1Haftalik = new System.Windows.Forms.Button();
            this.dateTimePicker_gunlukMax = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Gunluk = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_KazancToplam);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 139);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(400, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOPLAM KAZANÇ";
            // 
            // txt_KazancToplam
            // 
            this.txt_KazancToplam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_KazancToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KazancToplam.Location = new System.Drawing.Point(383, 65);
            this.txt_KazancToplam.Name = "txt_KazancToplam";
            this.txt_KazancToplam.ReadOnly = true;
            this.txt_KazancToplam.Size = new System.Drawing.Size(204, 31);
            this.txt_KazancToplam.TabIndex = 0;
            // 
            // dateTimePicker_gunMın
            // 
            this.dateTimePicker_gunMın.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gunMın.Location = new System.Drawing.Point(179, 63);
            this.dateTimePicker_gunMın.Name = "dateTimePicker_gunMın";
            this.dateTimePicker_gunMın.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_gunMın.TabIndex = 2;
            this.dateTimePicker_gunMın.Value = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
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
            this.panel2.Size = new System.Drawing.Size(932, 106);
            this.panel2.TabIndex = 6;
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
            this.btn_Son1AylikKazanc.Text = "Son 1 Aylık Kazanç";
            this.btn_Son1AylikKazanc.UseVisualStyleBackColor = false;
            this.btn_Son1AylikKazanc.Click += new System.EventHandler(this.Son1AylikKazanc_Click);
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
            this.btn_Son1Haftalik.Text = "Son 1 Haftalık Kazanç";
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
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView_Gunluk);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 316);
            this.panel4.TabIndex = 8;
            // 
            // dataGridView_Gunluk
            // 
            this.dataGridView_Gunluk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Gunluk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_Gunluk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.dataGridView_Gunluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Gunluk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dataGridView_Gunluk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Gunluk.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Gunluk.Name = "dataGridView_Gunluk";
            this.dataGridView_Gunluk.RowHeadersVisible = false;
            this.dataGridView_Gunluk.Size = new System.Drawing.Size(932, 316);
            this.dataGridView_Gunluk.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // UC_Kazanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Kazanc";
            this.Size = new System.Drawing.Size(932, 561);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Gunluk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gunMın;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Son1AylikKazanc;
        private System.Windows.Forms.Button btn_Son1Haftalik;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gunlukMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KazancToplam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Gunluk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
