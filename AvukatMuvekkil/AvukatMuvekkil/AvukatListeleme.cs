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
    public partial class AvukatListeleme : Form
    {
        public AvukatListeleme()
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
        public string maillbl;
        private void AvukatListeleme_Load(object sender, EventArgs e)
        {
            string query = "Select Id,AvukatAdSoyad,AvukatTelefon,AvukatEposta From AvukatBilgileri";

            SQLiteCommand command = new SQLiteCommand(query,Baglan.con);

            DataTable dt = new DataTable();

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, Baglan.con);
            da.Fill(dt);

            dgwAvukatlar.DataSource = dt;

            MuvekkilAnaSayfa fr = new MuvekkilAnaSayfa();
            fr.mail = label2.Text;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            MuvekkilAnaSayfa fr = new MuvekkilAnaSayfa();
            fr.Show();
            this.Close();
        }
        public string kulAd;
        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            AvukatBilgiGoruntuleme fr = new AvukatBilgiGoruntuleme();
            fr.secilen = dgwAvukatlar.CurrentRow.Cells["AvukatEposta"].Value.ToString();
            fr.Show();
        }
        
        private void dgwAvukatlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AvukatBilgiGoruntuleme fr = new AvukatBilgiGoruntuleme();
            fr.secilen = dgwAvukatlar.CurrentRow.Cells["AvukatEposta"].Value.ToString();
        }
    }
}
