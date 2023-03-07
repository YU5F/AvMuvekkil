using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvukatMuvekkil
{
    public partial class AvukatBilgiGüncelleme : Form
    {
        public AvukatBilgiGüncelleme()
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

        private void btnGeri_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string query = "Update AvukatBilgileri Set AvukatAdSoyad=@p1,AvukatEposta=@p2,AvukatTelefon=@p3 Where AvukatTC=@p4";

            SQLiteCommand cmd = new SQLiteCommand(query, Baglan.con);

            cmd.Parameters.AddWithValue("@p1", txtAd.Text + " " + txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txtEposta.Text);
            cmd.Parameters.AddWithValue("@p3",txtTelefon.Text);
            cmd.Parameters.AddWithValue("@p4", tc);
            Baglan.con.Open();
            cmd.ExecuteNonQuery();
            Baglan.con.Close();

            MessageBox.Show("Bilgileriniz Güncellenmiştir.");
        }
        public string tc;
        private void AvukatBilgiGüncelleme_Load(object sender, EventArgs e)
        {
            string query = "SELECT AvukatAdSoyad,AvukatTelefon,AvukatEposta,AvukatTC FROM AvukatBilgileri where AvukatTC=@p1";
            SQLiteCommand komut = new SQLiteCommand(query, Baglan.con);
            komut.Parameters.AddWithValue("@p1", tc);

            Baglan.con.Open();
            SQLiteDataReader dr = komut.ExecuteReader();      

            while (dr.Read())
            {
                string AdSoyad = dr[0].ToString();
                string[] dizin = AdSoyad.Split(' ');
                txtAd.Text = dizin[0];
                txtSoyad.Text = dizin[1];
                txtEposta.Text = dr[2].ToString();
                txtTelefon.Text += dr[1].ToString();        
            }
            Baglan.con.Close();        
        }
    }
}
