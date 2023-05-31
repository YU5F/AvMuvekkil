namespace AvukatMuvekkil
{
    partial class AvukatAnaSayfa
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
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.pcbAvukatResim = new System.Windows.Forms.PictureBox();
            this.lblIsimSoyisim = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTCKNO = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioMusait = new System.Windows.Forms.RadioButton();
            this.radioMesgul = new System.Windows.Forms.RadioButton();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.btnDurum = new System.Windows.Forms.Button();
            this.btnMuvekkilim = new System.Windows.Forms.Button();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblMez = new System.Windows.Forms.Label();
            this.lblDav = new System.Windows.Forms.Label();
            this.BelgeBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvukatResim)).BeginInit();
            this.SuspendLayout();
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
            this.btnKucult.TabIndex = 9;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
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
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // pcbAvukatResim
            // 
            this.pcbAvukatResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.pcbAvukatResim.Location = new System.Drawing.Point(12, 12);
            this.pcbAvukatResim.Name = "pcbAvukatResim";
            this.pcbAvukatResim.Size = new System.Drawing.Size(150, 150);
            this.pcbAvukatResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAvukatResim.TabIndex = 11;
            this.pcbAvukatResim.TabStop = false;
            // 
            // lblIsimSoyisim
            // 
            this.lblIsimSoyisim.AutoSize = true;
            this.lblIsimSoyisim.BackColor = System.Drawing.Color.Transparent;
            this.lblIsimSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsimSoyisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblIsimSoyisim.Location = new System.Drawing.Point(168, 12);
            this.lblIsimSoyisim.Name = "lblIsimSoyisim";
            this.lblIsimSoyisim.Size = new System.Drawing.Size(215, 39);
            this.lblIsimSoyisim.TabIndex = 12;
            this.lblIsimSoyisim.Text = "İsim Soyisim";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblMail.Location = new System.Drawing.Point(171, 56);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(58, 29);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail";
            // 
            // lblTCKNO
            // 
            this.lblTCKNO.AutoSize = true;
            this.lblTCKNO.BackColor = System.Drawing.Color.Transparent;
            this.lblTCKNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCKNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblTCKNO.Location = new System.Drawing.Point(335, 179);
            this.lblTCKNO.Name = "lblTCKNO";
            this.lblTCKNO.Size = new System.Drawing.Size(157, 39);
            this.lblTCKNO.TabIndex = 12;
            this.lblTCKNO.Text = "TCKNO: ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblTelefon.Location = new System.Drawing.Point(332, 226);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(160, 39);
            this.lblTelefon.TabIndex = 12;
            this.lblTelefon.Text = "Telefon : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(342, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Durum : ";
            // 
            // radioMusait
            // 
            this.radioMusait.AutoSize = true;
            this.radioMusait.BackColor = System.Drawing.Color.Transparent;
            this.radioMusait.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMusait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.radioMusait.Location = new System.Drawing.Point(651, 412);
            this.radioMusait.Name = "radioMusait";
            this.radioMusait.Size = new System.Drawing.Size(138, 43);
            this.radioMusait.TabIndex = 13;
            this.radioMusait.TabStop = true;
            this.radioMusait.Text = "Müsait";
            this.radioMusait.UseVisualStyleBackColor = false;
            // 
            // radioMesgul
            // 
            this.radioMesgul.AutoSize = true;
            this.radioMesgul.BackColor = System.Drawing.Color.Transparent;
            this.radioMesgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMesgul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.radioMesgul.Location = new System.Drawing.Point(498, 412);
            this.radioMesgul.Name = "radioMesgul";
            this.radioMesgul.Size = new System.Drawing.Size(147, 43);
            this.radioMesgul.TabIndex = 13;
            this.radioMesgul.TabStop = true;
            this.radioMesgul.Text = "Meşgul";
            this.radioMesgul.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnCikis.Location = new System.Drawing.Point(12, 561);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(169, 77);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnBilgiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBilgiGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(328, 466);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(169, 77);
            this.btnBilgiGuncelle.TabIndex = 17;
            this.btnBilgiGuncelle.Text = "Bilgileri GÜncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // btnDurum
            // 
            this.btnDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnDurum.Location = new System.Drawing.Point(503, 466);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(169, 77);
            this.btnDurum.TabIndex = 18;
            this.btnDurum.Text = "Durum Güncelle";
            this.btnDurum.UseVisualStyleBackColor = false;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // btnMuvekkilim
            // 
            this.btnMuvekkilim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnMuvekkilim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuvekkilim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMuvekkilim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnMuvekkilim.Location = new System.Drawing.Point(503, 549);
            this.btnMuvekkilim.Name = "btnMuvekkilim";
            this.btnMuvekkilim.Size = new System.Drawing.Size(169, 77);
            this.btnMuvekkilim.TabIndex = 18;
            this.btnMuvekkilim.Text = "Muvekkilerim";
            this.btnMuvekkilim.UseVisualStyleBackColor = false;
            this.btnMuvekkilim.Click += new System.EventHandler(this.btnMuvekkilim_Click);
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.BackColor = System.Drawing.Color.Transparent;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblDT.Location = new System.Drawing.Point(248, 273);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(244, 39);
            this.lblDT.TabIndex = 19;
            this.lblDT.Text = "Doğum Tarihi: ";
            // 
            // lblMez
            // 
            this.lblMez.AutoSize = true;
            this.lblMez.BackColor = System.Drawing.Color.Transparent;
            this.lblMez.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblMez.Location = new System.Drawing.Point(297, 367);
            this.lblMez.Name = "lblMez";
            this.lblMez.Size = new System.Drawing.Size(195, 39);
            this.lblMez.TabIndex = 20;
            this.lblMez.Text = "Mezuniyet: ";
            // 
            // lblDav
            // 
            this.lblDav.AutoSize = true;
            this.lblDav.BackColor = System.Drawing.Color.Transparent;
            this.lblDav.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.lblDav.Location = new System.Drawing.Point(212, 320);
            this.lblDav.Name = "lblDav";
            this.lblDav.Size = new System.Drawing.Size(281, 39);
            this.lblDav.TabIndex = 21;
            this.lblDav.Text = "Dava Kategorisi: ";
            // 
            // BelgeBtn
            // 
            this.BelgeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.BelgeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BelgeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BelgeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.BelgeBtn.Location = new System.Drawing.Point(328, 549);
            this.BelgeBtn.Name = "BelgeBtn";
            this.BelgeBtn.Size = new System.Drawing.Size(169, 77);
            this.BelgeBtn.TabIndex = 23;
            this.BelgeBtn.Text = "Belgeler";
            this.BelgeBtn.UseVisualStyleBackColor = false;
            this.BelgeBtn.Click += new System.EventHandler(this.BelgeBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AvukatAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.BelgeBtn);
            this.Controls.Add(this.lblDav);
            this.Controls.Add(this.lblMez);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.btnMuvekkilim);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.radioMesgul);
            this.Controls.Add(this.radioMusait);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTCKNO);
            this.Controls.Add(this.lblIsimSoyisim);
            this.Controls.Add(this.pcbAvukatResim);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnKapat);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvukatAnaSayfa";
            this.Text = "AvukatAnaSayfa";
            this.Load += new System.EventHandler(this.AvukatAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvukatResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.PictureBox pcbAvukatResim;
        private System.Windows.Forms.Label lblIsimSoyisim;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTCKNO;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioMusait;
        private System.Windows.Forms.RadioButton radioMesgul;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.Button btnDurum;
        private System.Windows.Forms.Button btnMuvekkilim;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblMez;
        private System.Windows.Forms.Label lblDav;
        private System.Windows.Forms.Button BelgeBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}