using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvukatMuvekkil
{
    public partial class MuvekkilDosyaEkleme : Form
    {
        public MuvekkilDosyaEkleme()
        {
            InitializeComponent();
        }
        string dosyaYol = null;
        string dosyaYol2 = null;
        string kayıtYol = null;

        private void btnSec_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYol = Path.GetFileName(openFileDialog1.FileName);
                dosyaYol2 = Path.GetFullPath(openFileDialog1.FileName);
            }

            else
            {
                MessageBox.Show("Lütfen Dosya Seçiniz");
            }
        }

        private void btnKyt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            kayıtYol = folderBrowserDialog1.SelectedPath.ToString();

            File.Copy(dosyaYol2, kayıtYol + "\\" + dosyaYol);
            MessageBox.Show("Dosyanız kaydedildi.");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}