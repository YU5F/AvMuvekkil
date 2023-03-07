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
            string query = "SELECT AvukatAdSoyad,AvukatTelefon,AvukatEposta,AvukatTC FROM AvukatBilgileri where AvukatTC=@p1";
            SQLiteCommand komut = new SQLiteCommand(query, Baglan.con);
            komut.Parameters.AddWithValue("@p1", TC);

            SQLiteDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblIsimSoyisim.Text = dr[0].ToString();
                lblMail.Text = dr[2].ToString();
                lblTelefon.Text += dr[1].ToString();
                lblTCKNO.Text += dr[3].ToString();
            }
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
    }
 }

