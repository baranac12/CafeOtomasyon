
namespace CafeOtomasyon.Forms
{
    partial class FormMusteriSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriSiparis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.box_Kucult = new System.Windows.Forms.PictureBox();
            this.btn_Buyult = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_AnaBaslik = new System.Windows.Forms.Label();
            this.panel_UC = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_Kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buyult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_AnaBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 36);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.box_Kucult);
            this.panel2.Controls.Add(this.btn_Buyult);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 39);
            this.panel2.TabIndex = 5;
            // 
            // box_Kucult
            // 
            this.box_Kucult.Dock = System.Windows.Forms.DockStyle.Right;
            this.box_Kucult.Image = ((System.Drawing.Image)(resources.GetObject("box_Kucult.Image")));
            this.box_Kucult.Location = new System.Drawing.Point(821, 0);
            this.box_Kucult.Name = "box_Kucult";
            this.box_Kucult.Size = new System.Drawing.Size(37, 39);
            this.box_Kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_Kucult.TabIndex = 2;
            this.box_Kucult.TabStop = false;
            this.box_Kucult.Click += new System.EventHandler(this.box_Küçült_Click);
            // 
            // btn_Buyult
            // 
            this.btn_Buyult.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Buyult.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buyult.Image")));
            this.btn_Buyult.Location = new System.Drawing.Point(858, 0);
            this.btn_Buyult.Name = "btn_Buyult";
            this.btn_Buyult.Size = new System.Drawing.Size(37, 39);
            this.btn_Buyult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Buyult.TabIndex = 2;
            this.btn_Buyult.TabStop = false;
            this.btn_Buyult.Click += new System.EventHandler(this.btn_Buyult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(895, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cafe Sipariş Otomasyonu";
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
            // panel_UC
            // 
            this.panel_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_UC.Location = new System.Drawing.Point(0, 36);
            this.panel_UC.Name = "panel_UC";
            this.panel_UC.Size = new System.Drawing.Size(932, 561);
            this.panel_UC.TabIndex = 2;
            // 
            // FormMusteriSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(932, 597);
            this.Controls.Add(this.panel_UC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMusteriSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMusteriSiparis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_Kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buyult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_AnaBaslik;
        private System.Windows.Forms.Panel panel_UC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox box_Kucult;
        private System.Windows.Forms.PictureBox btn_Buyult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}