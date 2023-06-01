namespace AvukatMuvekkil
{
    partial class MuvekkilDosyaEkleme
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnKyt = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(28, 53);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(143, 59);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click_1);
            // 
            // btnKyt
            // 
            this.btnKyt.Location = new System.Drawing.Point(177, 53);
            this.btnKyt.Name = "btnKyt";
            this.btnKyt.Size = new System.Drawing.Size(143, 59);
            this.btnKyt.TabIndex = 1;
            this.btnKyt.Text = "Kaydet";
            this.btnKyt.UseVisualStyleBackColor = true;
            this.btnKyt.Click += new System.EventHandler(this.btnKyt_Click);
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
            this.btnGeri.Size = new System.Drawing.Size(33, 26);
            this.btnGeri.TabIndex = 30;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // MuvekkilDosyaEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(108)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(348, 124);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKyt);
            this.Controls.Add(this.btnSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuvekkilDosyaEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuvekkilDosyaEkleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnKyt;
        private System.Windows.Forms.Button btnGeri;
    }
}