namespace AvukatMuvekkil
{
    partial class GirisSayfasi
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMuvekkil = new System.Windows.Forms.Button();
            this.btnAvukat = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.law;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(325, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMuvekkil
            // 
            this.btnMuvekkil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnMuvekkil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuvekkil.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuvekkil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnMuvekkil.Location = new System.Drawing.Point(30, 441);
            this.btnMuvekkil.Name = "btnMuvekkil";
            this.btnMuvekkil.Size = new System.Drawing.Size(432, 197);
            this.btnMuvekkil.TabIndex = 1;
            this.btnMuvekkil.Text = "Müvekkil";
            this.btnMuvekkil.UseVisualStyleBackColor = false;
            this.btnMuvekkil.Click += new System.EventHandler(this.btnMuvekkil_Click);
            // 
            // btnAvukat
            // 
            this.btnAvukat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnAvukat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvukat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAvukat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnAvukat.Location = new System.Drawing.Point(538, 441);
            this.btnAvukat.Name = "btnAvukat";
            this.btnAvukat.Size = new System.Drawing.Size(432, 197);
            this.btnAvukat.TabIndex = 1;
            this.btnAvukat.Text = "Avukat";
            this.btnAvukat.UseVisualStyleBackColor = false;
            this.btnAvukat.Click += new System.EventHandler(this.btnAvukat_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnKapat.Location = new System.Drawing.Point(962, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(26, 23);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.Transparent;
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnKucult.Location = new System.Drawing.Point(930, 12);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(26, 23);
            this.btnKucult.TabIndex = 2;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAvukat);
            this.Controls.Add(this.btnMuvekkil);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "GirisSayfasi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GirisSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMuvekkil;
        private System.Windows.Forms.Button btnAvukat;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
    }
}

