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
    public partial class AvukatGiris : Form
    {
        public AvukatGiris()
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

        private void AvukatGiris_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtTCKNO.Text.Trim() == "" && txtSifre.Text.Trim() == "")
            {
                MessageBox.Show("Alanları Boş bırakmayınız");
            }

            else
            {
                string query = "SELECT * FROM AvukatBilgileri WHERE AvukatTC=@ad AND AvukatSifre=@sifre";

                Baglan.con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, Baglan.con);
                cmd.Parameters.AddWithValue("@ad", txtTCKNO.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    AvukatAnaSayfa fr = new AvukatAnaSayfa();
                    fr.TC = txtTCKNO.Text;
                    fr.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Eposta veya Şifre hatalı");
                }
                Baglan.con.Close();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            AvukatKayit fr = new AvukatKayit();
            fr.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisSayfasi fr = new GirisSayfasi();
            fr.Show();
            this.Close();
        }
    }
}
