
namespace CafeOtomasyon.Forms
{
    partial class FormMasaNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasaNo));
            this.textBox_MasaNo = new System.Windows.Forms.TextBox();
            this.btn_durum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DevamEt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_Exit = new System.Windows.Forms.PictureBox();
            this.label_AnaBaslik = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_MasaNo
            // 
            this.textBox_MasaNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MasaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox_MasaNo.Location = new System.Drawing.Point(60, 88);
            this.textBox_MasaNo.Name = "textBox_MasaNo";
            this.textBox_MasaNo.Size = new System.Drawing.Size(163, 20);
            this.textBox_MasaNo.TabIndex = 55;
            this.textBox_MasaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_durum
            // 
            this.btn_durum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_durum.BackColor = System.Drawing.Color.Maroon;
            this.btn_durum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durum.ForeColor = System.Drawing.Color.White;
            this.btn_durum.Location = new System.Drawing.Point(76, 120);
            this.btn_durum.Name = "btn_durum";
            this.btn_durum.Size = new System.Drawing.Size(133, 28);
            this.btn_durum.TabIndex = 56;
            this.btn_durum.Text = "Siparis Durumu";
            this.btn_durum.UseVisualStyleBackColor = false;
            this.btn_durum.Click += new System.EventHandler(this.btn_durum_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(87, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Masa No Giriniz :";
            // 
            // btn_DevamEt
            // 
            this.btn_DevamEt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DevamEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_DevamEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DevamEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DevamEt.ForeColor = System.Drawing.Color.White;
            this.btn_DevamEt.Location = new System.Drawing.Point(76, 158);
            this.btn_DevamEt.Name = "btn_DevamEt";
            this.btn_DevamEt.Size = new System.Drawing.Size(133, 28);
            this.btn_DevamEt.TabIndex = 57;
            this.btn_DevamEt.Text = "Devam Et";
            this.btn_DevamEt.UseVisualStyleBackColor = false;
            this.btn_DevamEt.Click += new System.EventHandler(this.btn_DevamEt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBox_Exit);
            this.panel1.Controls.Add(this.label_AnaBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 30);
            this.panel1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cafe Sipariş Otomasyonu";
            // 
            // picBox_Exit
            // 
            this.picBox_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Exit.Image")));
            this.picBox_Exit.Location = new System.Drawing.Point(245, 0);
            this.picBox_Exit.Name = "picBox_Exit";
            this.picBox_Exit.Size = new System.Drawing.Size(37, 30);
            this.picBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Exit.TabIndex = 4;
            this.picBox_Exit.TabStop = false;
            // 
            // label_AnaBaslik
            // 
            this.label_AnaBaslik.AutoSize = true;
            this.label_AnaBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AnaBaslik.ForeColor = System.Drawing.Color.White;
            this.label_AnaBaslik.Location = new System.Drawing.Point(339, 9);
            this.label_AnaBaslik.Name = "label_AnaBaslik";
            this.label_AnaBaslik.Size = new System.Drawing.Size(212, 20);
            this.label_AnaBaslik.TabIndex = 3;
            this.label_AnaBaslik.Text = "Cafe Sipariş Otomasyonu";
            // 
            // FormMasaNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(282, 216);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_MasaNo);
            this.Controls.Add(this.btn_durum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DevamEt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMasaNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMasaNo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MasaNo;
        private System.Windows.Forms.Button btn_durum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DevamEt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBox_Exit;
        private System.Windows.Forms.Label label_AnaBaslik;
        private System.Windows.Forms.Label label1;
    }
}