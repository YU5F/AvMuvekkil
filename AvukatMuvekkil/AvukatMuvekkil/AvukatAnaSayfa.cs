using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvukatMuvekkil
{
    public partial class AvukatAnaSayfa : Form
    {
        public AvukatAnaSayfa()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public string TC;
        
        private void AvukatAnaSayfa_Load(object sender, EventArgs e)
        {
            string query = "SELECT AvukatAdSoyad,AvukatTelefon,AvukatEposta,AvukatTC,AvukatDavaKat,AvukatDT,AvukatMezuniyet,AvukatPic FROM AvukatBilgileri where AvukatTC=@p1";
            SQLiteCommand komut = new SQLiteCommand(query, Baglan.con);
            komut.Parameters.AddWithValue("@p1", TC);

            SQLiteDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblIsimSoyisim.Text = dr[0].ToString();
                lblMail.Text = dr[2].ToString();
                lblTelefon.Text += dr[1].ToString();
                lblTCKNO.Text += dr[3].ToString();
                lblDav.Text += dr[4].ToString();  
                lblDT.Text += dr[5].ToString();
                lblMez.Text += dr[6].ToString();
            }

            RetrieveImage();
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            int durum = radioMesgul.Checked? 0:1;

            string query = "UPDATE AvukatBilgileri Set AvukatDurum=@p1 where AvukatTC=@p2";
            SQLiteCommand cmd = new SQLiteCommand(query, Baglan.con);

            cmd.Parameters.AddWithValue("@p1", durum);
            cmd.Parameters.AddWithValue("@p2", TC);
            Baglan.con.Open();
            cmd.ExecuteNonQuery();
            Baglan.con.Close();

            MessageBox.Show("Durum Güncellenmiştir.");
        }

        private void RetrieveImage()
        {
            // Resmi veritabanından çek
            string query = "SELECT AvukatPic FROM AvukatBilgileri WHERE AvukatTC =@p1;";
            SQLiteCommand command = new SQLiteCommand(query, Baglan.con);
            command.Parameters.AddWithValue("@p1", TC); // Burada istediğiniz ImageID'yi belirtin
            object result = command.ExecuteScalar();
            if(result != null && result != DBNull.Value)
            {
                // Veriyi oku
                byte[] imageData = (byte[])command.ExecuteScalar();

                // Veriyi resme dönüştür
                if (imageData != null && imageData.Length > 0)
                {
                    // Veriyi resme dönüştür
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pcbAvukatResim.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            AvukatBilgiGüncelleme fr = new AvukatBilgiGüncelleme();
            fr.tc = TC.ToString();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisSayfasi fr = new GirisSayfasi();
            fr.Show();
            this.Close();
        }

        private void btnMuvekkilim_Click(object sender, EventArgs e)
        {
            MuvekkilListeleme fr = new MuvekkilListeleme();
            fr.ShowDialog();
        }

        private void BelgeBtn_Click(object sender, EventArgs e)
        {
            AvukatDosyaYukleme fr = new AvukatDosyaYukleme();
            fr.ShowDialog();
        }
    }
 }

