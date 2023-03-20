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
    public partial class MuvekkilKayit : Form
    {
        public MuvekkilKayit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            string query = "Insert Into MuvekkilBilgileri (MuvekkilAdSoyad,MuvekkilSifre,MuvekkilEposta,MuvIP,MuvPort) values (@ad,@sifre,@eposta,@muvip,@muvport)";
            SQLiteCommand cmd = new SQLiteCommand(query, Baglan.con);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text + " " + txtSoyad.Text);
            cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@muvip", GetLocalIP());
            cmd.Parameters.AddWithValue("@muvport", 4000);
         
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                Baglan.con.Open();

                cmd.ExecuteNonQuery();

                Baglan.con.Close();

                if (MessageBox.Show("Kayıdınız Yapılmıştır", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MuvekkilGiris fr = new MuvekkilGiris();
                    fr.Show();
                }
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MuvekkilGiris fr = new MuvekkilGiris();
            fr.Show();
            this.Close();
        }
    }
}
