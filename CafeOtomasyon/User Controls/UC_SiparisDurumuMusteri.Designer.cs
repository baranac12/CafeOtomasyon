
namespace CafeOtomasyon.User_Controls
{
    partial class UC_SiparisDurumuMusteri
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
            this.btnTeslimEdilen = new System.Windows.Forms.Button();
            this.btnGonderilen = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_id = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_Siparis = new System.Windows.Forms.DataGridView();
            this.textBox_Tutar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_OdemeYap = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Siparis)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTeslimEdilen
            // 
            this.btnTeslimEdilen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btnTeslimEdilen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeslimEdilen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimEdilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimEdilen.ForeColor = System.Drawing.Color.White;
            this.btnTeslimEdilen.Location = new System.Drawing.Point(306, 0);
            this.btnTeslimEdilen.Name = "btnTeslimEdilen";
            this.btnTeslimEdilen.Size = new System.Drawing.Size(323, 41);
            this.btnTeslimEdilen.TabIndex = 6;
            this.btnTeslimEdilen.Text = "Teslim Edilen Siparişler";
            this.btnTeslimEdilen.UseVisualStyleBackColor = false;
            this.btnTeslimEdilen.Click += new System.EventHandler(this.btnTeslimEdilen_Click);
            // 
            // btnGonderilen
            // 
            this.btnGonderilen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btnGonderilen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGonderilen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonderilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonderilen.ForeColor = System.Drawing.Color.White;
            this.btnGonderilen.Location = new System.Drawing.Point(0, 0);
            this.btnGonderilen.Name = "btnGonderilen";
            this.btnGonderilen.Size = new System.Drawing.Size(306, 41);
            this.btnGonderilen.TabIndex = 5;
            this.btnGonderilen.Text = "Gönderilen Siparişler";
            this.btnGonderilen.UseVisualStyleBackColor = false;
            this.btnGonderilen.Click += new System.EventHandler(this.btnGonderilen_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTeslimEdilen);
            this.panel5.Controls.Add(this.btnGonderilen);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(629, 41);
            this.panel5.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.Black;
            this.label_id.Location = new System.Drawing.Point(33, 7);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 16);
            this.label_id.TabIndex = 4;
            this.label_id.Visible = false;
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIptal.BackColor = System.Drawing.Color.Maroon;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(409, 21);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(208, 42);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "Sipariş İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÖDENECEK TUTAR ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.panel3.Controls.Add(this.dataGridView_Siparis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 340);
            this.panel3.TabIndex = 8;
            // 
            // dataGridView_Siparis
            // 
            this.dataGridView_Siparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Siparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Siparis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.dataGridView_Siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Siparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dataGridView_Siparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Siparis.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Siparis.Name = "dataGridView_Siparis";
            this.dataGridView_Siparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Siparis.Size = new System.Drawing.Size(629, 340);
            this.dataGridView_Siparis.TabIndex = 0;
            // 
            // textBox_Tutar
            // 
            this.textBox_Tutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Tutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Tutar.Location = new System.Drawing.Point(208, 31);
            this.textBox_Tutar.Name = "textBox_Tutar";
            this.textBox_Tutar.ReadOnly = true;
            this.textBox_Tutar.Size = new System.Drawing.Size(162, 22);
            this.textBox_Tutar.TabIndex = 1;
            this.textBox_Tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_id);
            this.panel2.Controls.Add(this.btnIptal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_Tutar);
            this.panel2.Controls.Add(this.btn_OdemeYap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 84);
            this.panel2.TabIndex = 7;
            // 
            // btn_OdemeYap
            // 
            this.btn_OdemeYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_OdemeYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OdemeYap.ForeColor = System.Drawing.Color.White;
            this.btn_OdemeYap.Location = new System.Drawing.Point(409, 13);
            this.btn_OdemeYap.Name = "btn_OdemeYap";
            this.btn_OdemeYap.Size = new System.Drawing.Size(208, 58);
            this.btn_OdemeYap.TabIndex = 0;
            this.btn_OdemeYap.Text = "ÖDEME YAP";
            this.btn_OdemeYap.UseVisualStyleBackColor = false;
            this.btn_OdemeYap.Visible = false;
            this.btn_OdemeYap.Click += new System.EventHandler(this.btn_OdemeYap_Click);
            // 
            // UC_SiparisDurumuMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_SiparisDurumuMusteri";
            this.Size = new System.Drawing.Size(629, 424);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Siparis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTeslimEdilen;
        private System.Windows.Forms.Button btnGonderilen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_Siparis;
        private System.Windows.Forms.TextBox textBox_Tutar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_OdemeYap;
    }
}
