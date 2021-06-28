
namespace CafeOtomasyon.User_Controls
{
    partial class UC_Menu
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
            this.panel_UC = new System.Windows.Forms.Panel();
            this.panel_ust = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Icecek = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tatli = new System.Windows.Forms.Button();
            this.panel_yemek = new System.Windows.Forms.Panel();
            this.btn_yemek = new System.Windows.Forms.Button();
            this.panel_ust.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_yemek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_UC
            // 
            this.panel_UC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_UC.Location = new System.Drawing.Point(0, 50);
            this.panel_UC.Name = "panel_UC";
            this.panel_UC.Size = new System.Drawing.Size(932, 511);
            this.panel_UC.TabIndex = 4;
            // 
            // panel_ust
            // 
            this.panel_ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_ust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ust.Controls.Add(this.panel1);
            this.panel_ust.Controls.Add(this.panel7);
            this.panel_ust.Controls.Add(this.panel_yemek);
            this.panel_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_ust.Location = new System.Drawing.Point(0, 0);
            this.panel_ust.Name = "panel_ust";
            this.panel_ust.Size = new System.Drawing.Size(932, 50);
            this.panel_ust.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel7.Controls.Add(this.btn_Icecek);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(610, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 48);
            this.panel7.TabIndex = 2;
            // 
            // btn_Icecek
            // 
            this.btn_Icecek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_Icecek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Icecek.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Icecek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_Icecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Icecek.ForeColor = System.Drawing.Color.White;
            this.btn_Icecek.Location = new System.Drawing.Point(0, 13);
            this.btn_Icecek.Name = "btn_Icecek";
            this.btn_Icecek.Size = new System.Drawing.Size(320, 35);
            this.btn_Icecek.TabIndex = 6;
            this.btn_Icecek.Text = "İçecekler";
            this.btn_Icecek.UseVisualStyleBackColor = false;
            this.btn_Icecek.Click += new System.EventHandler(this.btn_Icecek_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.btn_tatli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(290, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 48);
            this.panel1.TabIndex = 1;
            // 
            // btn_tatli
            // 
            this.btn_tatli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_tatli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_tatli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_tatli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_tatli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tatli.ForeColor = System.Drawing.Color.White;
            this.btn_tatli.Location = new System.Drawing.Point(0, 13);
            this.btn_tatli.Name = "btn_tatli";
            this.btn_tatli.Size = new System.Drawing.Size(320, 35);
            this.btn_tatli.TabIndex = 6;
            this.btn_tatli.Text = "Tatlılar";
            this.btn_tatli.UseVisualStyleBackColor = false;
            this.btn_tatli.Click += new System.EventHandler(this.btn_tatli_Click_1);
            // 
            // panel_yemek
            // 
            this.panel_yemek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel_yemek.Controls.Add(this.btn_yemek);
            this.panel_yemek.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_yemek.Location = new System.Drawing.Point(0, 0);
            this.panel_yemek.Name = "panel_yemek";
            this.panel_yemek.Size = new System.Drawing.Size(290, 48);
            this.panel_yemek.TabIndex = 0;
            // 
            // btn_yemek
            // 
            this.btn_yemek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_yemek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_yemek.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_yemek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.btn_yemek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yemek.ForeColor = System.Drawing.Color.White;
            this.btn_yemek.Location = new System.Drawing.Point(0, 13);
            this.btn_yemek.Name = "btn_yemek";
            this.btn_yemek.Size = new System.Drawing.Size(290, 35);
            this.btn_yemek.TabIndex = 6;
            this.btn_yemek.Text = "Yemekler";
            this.btn_yemek.UseVisualStyleBackColor = false;
            this.btn_yemek.Click += new System.EventHandler(this.btn_yemek_Click_1);
            // 
            // UC_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_UC);
            this.Controls.Add(this.panel_ust);
            this.Name = "UC_Menu";
            this.Size = new System.Drawing.Size(932, 561);
            this.panel_ust.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_yemek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_UC;
        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_Icecek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_tatli;
        private System.Windows.Forms.Panel panel_yemek;
        private System.Windows.Forms.Button btn_yemek;
    }
}
