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
            this.dgwMuvekkiller.Size = new System.Drawing.Size(976, 485);
            this.dgwMuvekkiller.TabIndex = 34;
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.btnMesajGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesajGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.btnMesajGonder.Location = new System.Drawing.Point(762, 598);
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
            // MuvekkilListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AvukatMuvekkil.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 650);
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
    }
}