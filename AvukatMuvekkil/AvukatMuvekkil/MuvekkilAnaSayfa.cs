using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvukatMuvekkil
{
    public partial class MuvekkilAnaSayfa : Form
    {
        public MuvekkilAnaSayfa()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public string kulAd;
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAvukatlar_Click(object sender, EventArgs e)
        {
            AvukatListeleme fr = new AvukatListeleme();
            fr.ShowDialog();
        }
        
        public void MuvekkilAnaSayfa_Load(object sender, EventArgs e)
        {
            string query = "SELECT MuvekkilAdSoyad,MuvekkilTelefon,MuvekkilEposta,MuvekkilTC,MuvekkilDT FROM MuvekkilBilgileri where MuvekkilEposta=@p1";
            SQLiteCommand komut = new SQLiteCommand(query, Baglan.con);
            komut.Parameters.AddWithValue("@p1", kulAd);

            Baglan.con.Open();
            SQLiteDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblIsimSoyisim.Text = dr[0].ToString();
                lblMail.Text = dr[2].ToString();
                lblTelefon.Text = dr[1].ToString();
                lblTC.Text = dr[3].ToString();
                lblMuvDT.Text = dr[4].ToString();

                if (lblTelefon.Text == "")
                {
                    lblTelefon.Text = "Telefon Eklemek İçin Bilgilerinizi Güncelleyin ";
                }
            }
            Baglan.con.Close();

            RetrieveImage();
        }

        private void RetrieveImage()
        {
            // Resmi veritabanından çek
            string query = "SELECT MuvekkilPic FROM MuvekkilBilgileri WHERE MuvekkilEposta =@p1;";
            SQLiteCommand command = new SQLiteCommand(query, Baglan.con);
            command.Parameters.AddWithValue("@p1", kulAd); // Burada istediğiniz ImageID'yi belirtin

            if (Baglan.con != null)
            {
                Baglan.con.Open();
                object result = command.ExecuteScalar();
                if(result != null && result != DBNull.Value)
                {// Veriyi oku
                    byte[] imageData = (byte[])command.ExecuteScalar();

                    // Veriyi resme dönüştür
                    if (imageData != null && imageData.Length > 0)
                    {
                        // Veriyi resme dönüştür
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pcbMuvekkilResim.Image = Image.FromStream(ms);
                        }
                    }
                }
                Baglan.con.Close();
            }
                
            else
            {
                // Hata durumunu ele al veya hata mesajını göster
            }           
        }

        public string mail;

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            MuvekkilGiris fr = new MuvekkilGiris();
            fr.Show();
            this.Close();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            MuvekkilBilgiGuncelleme fr = new MuvekkilBilgiGuncelleme();
            fr.eposta = lblMail.Text;
            fr.Show();
        }

        private void btnBelgeler_Click(object sender, EventArgs e)
        {
            MuvekkilDosyaEkleme fr = new MuvekkilDosyaEkleme();
            fr.Show();
        }
    }
}
