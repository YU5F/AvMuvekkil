namespace AvukatMuvekkil
{
    partial class MuvekkilListeleme
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
            this.dgwMuvekkiller = new System.Windows.Forms.DataGridView();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnMuvekkillerim = new System.Windows.Forms.Button();
            this.btnBekleyen = new System.Windows.Forms.Button();
            this.btnKabul = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.btnMuvekkiller = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuvekkiller)).BeginInit();
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
            this.btnKucult.TabIndex = 32;
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
            this.btnKapat.TabIndex = 33;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dgwMuvekkiller
            // 
            this.dgwMuvekkiller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.dgwMuvekkiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMuvekkiller.Location = new System.Drawing.Point(12, 94);
            this.dgwMuvekkiller.Name = "dgwMuvekkiller";
            this.dgwMuvekkiller.Size = new System.Drawing.Size(744, 544);
            this.dgwMuvekkiller.TabIndex = 34;
            this.dgwMuvekkiller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMuvekkiller_CellClick);
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnMesajGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesajGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnMesajGonder.Location = new System.Drawing.Point(762, 94);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(226, 40);
            this.btnMesajGonder.TabIndex = 36;
            this.btnMesajGonder.Text = "Mesaj Gönder";
            this.btnMesajGonder.UseVisualStyleBackColor = false;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.icons8_left_100;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(47, 38);
            this.btnGeri.TabIndex = 37;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnMuvekkillerim
            // 
            this.btnMuvekkillerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnMuvekkillerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuvekkillerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuvekkillerim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnMuvekkillerim.Location = new System.Drawing.Point(762, 140);
            this.btnMuvekkillerim.Name = "btnMuvekkillerim";
            this.btnMuvekkillerim.Size = new System.Drawing.Size(226, 40);
            this.btnMuvekkillerim.TabIndex = 38;
            this.btnMuvekkillerim.Text = "Müvekkillerim";
            this.btnMuvekkillerim.UseVisualStyleBackColor = false;
            this.btnMuvekkillerim.Click += new System.EventHandler(this.btnMuvekkillerim_Click);
            // 
            // btnBekleyen
            // 
            this.btnBekleyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnBekleyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBekleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnBekleyen.Location = new System.Drawing.Point(762, 186);
            this.btnBekleyen.Name = "btnBekleyen";
            this.btnBekleyen.Size = new System.Drawing.Size(226, 40);
            this.btnBekleyen.TabIndex = 39;
            this.btnBekleyen.Text = "Bekleyenler";
            this.btnBekleyen.UseVisualStyleBackColor = false;
            this.btnBekleyen.Visible = false;
            this.btnBekleyen.Click += new System.EventHandler(this.btnBekleyen_Click);
            // 
            // btnKabul
            // 
            this.btnKabul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnKabul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKabul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKabul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnKabul.Location = new System.Drawing.Point(762, 232);
            this.btnKabul.Name = "btnKabul";
            this.btnKabul.Size = new System.Drawing.Size(110, 40);
            this.btnKabul.TabIndex = 40;
            this.btnKabul.Text = "Kabul et";
            this.btnKabul.UseVisualStyleBackColor = false;
            this.btnKabul.Visible = false;
            this.btnKabul.Click += new System.EventHandler(this.btnKabul_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnReddet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReddet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReddet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnReddet.Location = new System.Drawing.Point(878, 232);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(110, 40);
            this.btnReddet.TabIndex = 41;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Visible = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnMuvekkiller
            // 
            this.btnMuvekkiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnMuvekkiller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuvekkiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuvekkiller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnMuvekkiller.Location = new System.Drawing.Point(762, 140);
            this.btnMuvekkiller.Name = "btnMuvekkiller";
            this.btnMuvekkiller.Size = new System.Drawing.Size(226, 40);
            this.btnMuvekkiller.TabIndex = 42;
            this.btnMuvekkiller.Text = "Müvekkiller";
            this.btnMuvekkiller.UseVisualStyleBackColor = false;
            this.btnMuvekkiller.Visible = false;
            this.btnMuvekkiller.Click += new System.EventHandler(this.btnMuvekkiller_Click);
            // 
            // MuvekkilListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnMuvekkiller);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnKabul);
            this.Controls.Add(this.btnBekleyen);
            this.Controls.Add(this.btnMuvekkillerim);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnMesajGonder);
            this.Controls.Add(this.dgwMuvekkiller);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MuvekkilListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuvekkilListeleme";
            this.Load += new System.EventHandler(this.MuvekkilListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuvekkiller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dgwMuvekkiller;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnMuvekkillerim;
        private System.Windows.Forms.Button btnBekleyen;
        private System.Windows.Forms.Button btnKabul;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnMuvekkiller;
    }
}