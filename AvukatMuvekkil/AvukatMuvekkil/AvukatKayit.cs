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
using System.Net;
using System.Net.Sockets;

namespace AvukatMuvekkil
{
    public partial class AvukatKayit : Form
    {
        public AvukatKayit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string avkey;
            avkey = txtAd.Text + rand.Next(0, 99999) + "Av";

            string query = "Insert Into AvukatBilgileri (AvukatAdSoyad,AvukatSifre,AvukatEposta,AvukatTC,AvIP,AvPort,AvukatKey) values (@ad,@sifre,@eposta,@TC,@avip,@avport,@avkey)";
            SQLiteCommand cmd = new SQLiteCommand(query, Baglan.con);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text + " " + txtSoyad.Text);
            cmd.Parameters.AddWithValue("@TC", txtTCKNO.Text); 
            cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@avip", GetLocalIP());
            cmd.Parameters.AddWithValue("@avport", 5000);
            cmd.Parameters.AddWithValue("@avkey", avkey);

            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                Baglan.con.Open();

                cmd.ExecuteNonQuery();

                Baglan.con.Close();

                if (MessageBox.Show("Kayıdınız Yapılmıştır", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AvukatGiris fr = new AvukatGiris();
            fr.Show();
            this.Close();
        }
    }
}
