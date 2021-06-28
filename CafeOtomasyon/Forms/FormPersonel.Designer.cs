namespace CafeOtomasyon
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.label_message = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBox_Parola = new System.Windows.Forms.TextBox();
            this.label_parola = new System.Windows.Forms.Label();
            this.txtBox_Kadi = new System.Windows.Forms.TextBox();
            this.label_kadi = new System.Windows.Forms.Label();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBox_exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.ForeColor = System.Drawing.Color.Maroon;
            this.label_message.Location = new System.Drawing.Point(12, 334);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 16);
            this.label_message.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtBox_Parola
            // 
            this.txtBox_Parola.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Parola.Location = new System.Drawing.Point(92, 233);
            this.txtBox_Parola.Name = "txtBox_Parola";
            this.txtBox_Parola.PasswordChar = '*';
            this.txtBox_Parola.Size = new System.Drawing.Size(151, 22);
            this.txtBox_Parola.TabIndex = 1;
            this.txtBox_Parola.Tag = "";
            this.txtBox_Parola.Text = "1234";
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_parola.ForeColor = System.Drawing.Color.White;
            this.label_parola.Location = new System.Drawing.Point(143, 211);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(57, 18);
            this.label_parola.TabIndex = 0;
            this.label_parola.Text = "Parola";
            // 
            // txtBox_Kadi
            // 
            this.txtBox_Kadi.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Kadi.Location = new System.Drawing.Point(92, 179);
            this.txtBox_Kadi.Name = "txtBox_Kadi";
            this.txtBox_Kadi.Size = new System.Drawing.Size(151, 22);
            this.txtBox_Kadi.TabIndex = 0;
            this.txtBox_Kadi.Text = "admin";
            // 
            // label_kadi
            // 
            this.label_kadi.AutoSize = true;
            this.label_kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kadi.ForeColor = System.Drawing.Color.White;
            this.label_kadi.Location = new System.Drawing.Point(121, 156);
            this.label_kadi.Name = "label_kadi";
            this.label_kadi.Size = new System.Drawing.Size(99, 18);
            this.label_kadi.TabIndex = 0;
            this.label_kadi.Text = "Kullanıcı Adı";
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.btn_GirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_GirisYap.ForeColor = System.Drawing.Color.White;
            this.btn_GirisYap.Location = new System.Drawing.Point(121, 262);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(95, 41);
            this.btn_GirisYap.TabIndex = 2;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cafe Sipariş Otomasyonu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.picBox_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 33);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(231, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picBox_exit
            // 
            this.picBox_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBox_exit.Image = ((System.Drawing.Image)(resources.GetObject("picBox_exit.Image")));
            this.picBox_exit.Location = new System.Drawing.Point(297, 0);
            this.picBox_exit.Name = "picBox_exit";
            this.picBox_exit.Size = new System.Drawing.Size(33, 33);
            this.picBox_exit.TabIndex = 4;
            this.picBox_exit.TabStop = false;
            this.picBox_exit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(330, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.txtBox_Parola);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.txtBox_Kadi);
            this.Controls.Add(this.label_kadi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBox_Parola;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox txtBox_Kadi;
        private System.Windows.Forms.Label label_kadi;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBox_exit;
    }
}