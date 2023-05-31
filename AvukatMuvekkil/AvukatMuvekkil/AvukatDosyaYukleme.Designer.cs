namespace AvukatMuvekkil
{
    partial class AvukatDosyaYukleme
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
            this.btnSec = new System.Windows.Forms.Button();
            this.btnKyt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(212, 203);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(151, 53);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnKyt
            // 
            this.btnKyt.Location = new System.Drawing.Point(385, 203);
            this.btnKyt.Name = "btnKyt";
            this.btnKyt.Size = new System.Drawing.Size(151, 53);
            this.btnKyt.TabIndex = 1;
            this.btnKyt.Text = "Kaydet";
            this.btnKyt.UseVisualStyleBackColor = true;
            this.btnKyt.Click += new System.EventHandler(this.btnKyt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AvukatDosyaYukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKyt);
            this.Controls.Add(this.btnSec);
            this.Name = "AvukatDosyaYukleme";
            this.Text = "DosyaYukleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnKyt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}