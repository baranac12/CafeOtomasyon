namespace CafeOtomasyon
{
    partial class FormKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullanici));
            this.panel1 = new System.Windows.Forms.Panel();
            this.box_Küçült = new System.Windows.Forms.PictureBox();
            this.btn_Buyult = new System.Windows.Forms.PictureBox();
            this.picBox_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Personel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_Küçült)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buyult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.box_Küçült);
            this.panel1.Controls.Add(this.btn_Buyult);
            this.panel1.Controls.Add(this.picBox_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 39);
            this.panel1.TabIndex = 0;
            // 
            // box_Küçült
            // 
            this.box_Küçült.Dock = System.Windows.Forms.DockStyle.Right;
            this.box_Küçült.Image = ((System.Drawing.Image)(resources.GetObject("box_Küçült.Image")));
            this.box_Küçült.Location = new System.Drawing.Point(266, 0);
            this.box_Küçült.Name = "box_Küçült";
            this.box_Küçült.Size = new System.Drawing.Size(37, 39);
            this.box_Küçült.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_Küçült.TabIndex = 2;
            this.box_Küçült.TabStop = false;
            this.box_Küçült.Click += new System.EventHandler(this.box_Küçült_Click);
            // 
            // btn_Buyult
            // 
            this.btn_Buyult.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Buyult.Image = global::CafeOtomasyon.Properties.Resources.icons8_expand_32;
            this.btn_Buyult.Location = new System.Drawing.Point(303, 0);
            this.btn_Buyult.Name = "btn_Buyult";
            this.btn_Buyult.Size = new System.Drawing.Size(37, 39);
            this.btn_Buyult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Buyult.TabIndex = 2;
            this.btn_Buyult.TabStop = false;
            this.btn_Buyult.Click += new System.EventHandler(this.btn_Buyult_Click);
            // 
            // picBox_Exit
            // 
            this.picBox_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Exit.Image")));
            this.picBox_Exit.Location = new System.Drawing.Point(340, 0);
            this.picBox_Exit.Name = "picBox_Exit";
            this.picBox_Exit.Size = new System.Drawing.Size(37, 39);
            this.picBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Exit.TabIndex = 2;
            this.picBox_Exit.TabStop = false;
            this.picBox_Exit.Click += new System.EventHandler(this.picBox_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cafe Sipariş Otomasyonu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.btn_Personel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_musteri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 306);
            this.panel2.TabIndex = 1;
            // 
            // btn_Personel
            // 
            this.btn_Personel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_Personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Personel.ForeColor = System.Drawing.Color.White;
            this.btn_Personel.Location = new System.Drawing.Point(70, 172);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Size = new System.Drawing.Size(235, 44);
            this.btn_Personel.TabIndex = 0;
            this.btn_Personel.Text = "Personel Girişi";
            this.btn_Personel.UseVisualStyleBackColor = false;
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_musteri
            // 
            this.btn_musteri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_musteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_musteri.ForeColor = System.Drawing.Color.White;
            this.btn_musteri.Location = new System.Drawing.Point(70, 222);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(235, 44);
            this.btn_musteri.TabIndex = 0;
            this.btn_musteri.Text = "Müşteri Girişi";
            this.btn_musteri.UseVisualStyleBackColor = false;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // FormKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(377, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKullanici";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_Küçült)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buyult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.Button btn_Personel;
        private System.Windows.Forms.PictureBox picBox_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox box_Küçült;
        private System.Windows.Forms.PictureBox btn_Buyult;
    }
}