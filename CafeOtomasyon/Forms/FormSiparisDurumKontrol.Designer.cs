
namespace CafeOtomasyon.Forms
{
    partial class FormSiparisDurumKontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisDurumKontrol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_AnaBaslik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btn_HazırlananSiparis = new System.Windows.Forms.Button();
            this.btn_GelenSiparis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Iptal = new System.Windows.Forms.Label();
            this.btn_BilgiGonder = new System.Windows.Forms.Button();
            this.dataGridView_Siparisler = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Siparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label_AnaBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 36);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(761, 39);
            this.panel5.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(650, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(687, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(724, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.picBox_Exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(219, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cafe Sipariş Otomasyonu";
            // 
            // label_AnaBaslik
            // 
            this.label_AnaBaslik.AutoSize = true;
            this.label_AnaBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AnaBaslik.ForeColor = System.Drawing.Color.White;
            this.label_AnaBaslik.Location = new System.Drawing.Point(250, 9);
            this.label_AnaBaslik.Name = "label_AnaBaslik";
            this.label_AnaBaslik.Size = new System.Drawing.Size(212, 20);
            this.label_AnaBaslik.TabIndex = 3;
            this.label_AnaBaslik.Text = "Cafe Sipariş Otomasyonu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.btnIptal);
            this.panel2.Controls.Add(this.btn_HazırlananSiparis);
            this.panel2.Controls.Add(this.btn_GelenSiparis);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 412);
            this.panel2.TabIndex = 2;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Maroon;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(25, 358);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(142, 33);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "Siparis İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btn_HazırlananSiparis
            // 
            this.btn_HazırlananSiparis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HazırlananSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HazırlananSiparis.ForeColor = System.Drawing.Color.White;
            this.btn_HazırlananSiparis.Location = new System.Drawing.Point(0, 207);
            this.btn_HazırlananSiparis.Name = "btn_HazırlananSiparis";
            this.btn_HazırlananSiparis.Size = new System.Drawing.Size(200, 42);
            this.btn_HazırlananSiparis.TabIndex = 5;
            this.btn_HazırlananSiparis.Text = "Hazırlanan Siparis";
            this.btn_HazırlananSiparis.UseVisualStyleBackColor = true;
            this.btn_HazırlananSiparis.Click += new System.EventHandler(this.btn_HazırlananSiparis_Click);
            // 
            // btn_GelenSiparis
            // 
            this.btn_GelenSiparis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_GelenSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GelenSiparis.ForeColor = System.Drawing.Color.White;
            this.btn_GelenSiparis.Location = new System.Drawing.Point(0, 159);
            this.btn_GelenSiparis.Name = "btn_GelenSiparis";
            this.btn_GelenSiparis.Size = new System.Drawing.Size(200, 42);
            this.btn_GelenSiparis.TabIndex = 5;
            this.btn_GelenSiparis.Text = "Gelen Siparis";
            this.btn_GelenSiparis.UseVisualStyleBackColor = true;
            this.btn_GelenSiparis.Click += new System.EventHandler(this.btn_GelenSiparis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siparis Yönetim Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "________________________";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_Iptal);
            this.panel3.Controls.Add(this.btn_BilgiGonder);
            this.panel3.Controls.Add(this.dataGridView_Siparisler);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 412);
            this.panel3.TabIndex = 3;
            // 
            // label_Iptal
            // 
            this.label_Iptal.AutoSize = true;
            this.label_Iptal.Location = new System.Drawing.Point(20, 324);
            this.label_Iptal.Name = "label_Iptal";
            this.label_Iptal.Size = new System.Drawing.Size(0, 15);
            this.label_Iptal.TabIndex = 5;
            this.label_Iptal.Visible = false;
            // 
            // btn_BilgiGonder
            // 
            this.btn_BilgiGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_BilgiGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BilgiGonder.ForeColor = System.Drawing.Color.White;
            this.btn_BilgiGonder.Location = new System.Drawing.Point(187, 324);
            this.btn_BilgiGonder.Name = "btn_BilgiGonder";
            this.btn_BilgiGonder.Size = new System.Drawing.Size(193, 55);
            this.btn_BilgiGonder.TabIndex = 4;
            this.btn_BilgiGonder.Text = "Durumu Bildir";
            this.btn_BilgiGonder.UseVisualStyleBackColor = false;
            this.btn_BilgiGonder.Click += new System.EventHandler(this.btn_BilgiGonder_Click);
            // 
            // dataGridView_Siparisler
            // 
            this.dataGridView_Siparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Siparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Siparisler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(193)))));
            this.dataGridView_Siparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Siparisler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Siparisler.Location = new System.Drawing.Point(0, 4);
            this.dataGridView_Siparisler.Name = "dataGridView_Siparisler";
            this.dataGridView_Siparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Siparisler.Size = new System.Drawing.Size(561, 292);
            this.dataGridView_Siparisler.TabIndex = 3;
            this.dataGridView_Siparisler.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Siparisler_RowHeaderMouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(561, 4);
            this.panel4.TabIndex = 1;
            // 
            // FormSiparisDurumKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(761, 448);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormSiparisDurumKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FıormSiparisDurumKontrol";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Siparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_AnaBaslik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Siparisler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BilgiGonder;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btn_HazırlananSiparis;
        private System.Windows.Forms.Button btn_GelenSiparis;
        private System.Windows.Forms.Label label_Iptal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
    }
}