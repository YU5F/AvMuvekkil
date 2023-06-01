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
    public partial class MuvekkilListeleme : Form
    {
        public MuvekkilListeleme()
        {
            InitializeComponent();
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

        private void MuvekkilListeleme_Load(object sender, EventArgs e)
        {
            GridTemizle();
        }

        private void GridTemizle()
        {
            string q = "Select Id, MuvekkilAdSoyad, MuvekkilTelefon, MuvekkilEposta from MuvekkilBilgileri";
            SQLiteCommand cmd = new SQLiteCommand(q, Baglan.con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgwMuvekkiller.DataSource = dt;
        }

        public static string senderKey;
        private string muvkey;
        private int secilen;

        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            MesajlasmaSayfasi fr = new MesajlasmaSayfasi();
            SQLiteCommand muvcmd = new SQLiteCommand("Select MuvekkilKey from MuvekkilBilgileri where Id = @id", Baglan.con);
            muvcmd.Parameters.AddWithValue("@id", dgwMuvekkiller.CurrentRow.Cells["Id"].Value);
            Baglan.con.Open();
            object result = muvcmd.ExecuteScalar();
            if(result != null)
            {
                fr.senderkey = senderKey;
                fr.receiverkey = result.ToString();
            }
            Baglan.con.Close();

            fr.Show();
        }

        private void btnMuvekkiller_Click(object sender, EventArgs e)
        {
            btnMuvekkiller.Visible = false;
            btnMuvekkillerim.Visible = true;
            btnBekleyen.Visible = false;
            btnKabul.Visible = false;
            btnReddet.Visible = false;
            btnMesajGonder.Visible = true;
            GridTemizle();
        }

        private void btnMuvekkillerim_Click(object sender, EventArgs e)
        {
            btnMuvekkiller.Visible = true;
            btnMuvekkillerim.Visible = false;
            btnBekleyen.Visible = true;
            btnMesajGonder.Visible = true;
            
        }

        private void btnBekleyen_Click(object sender, EventArgs e)
        {
            btnKabul.Visible = true;
            btnReddet.Visible = true;
            btnMesajGonder.Visible = false;
            SQLiteCommand cmd = new SQLiteCommand("Select * from SozlesmeBilgileri where Avukat = @avkey AND SozlesmeDurumu = @durum", Baglan.con);
            cmd.Parameters.AddWithValue("@avkey", senderKey);
            cmd.Parameters.AddWithValue("@durum", "Bekleniyor");
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgwMuvekkiller.DataSource = dt;
        }

        private void dgwMuvekkiller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the value of the clicked cell
                object cellValue = dgwMuvekkiller.Rows[e.RowIndex].Cells["Id"].Value;

                if(cellValue != null)
                {
                    secilen = Convert.ToInt32(cellValue);
                }
            }
        }

        private void btnKabul_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bu isteği kabul etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("Update SozlesmeBilgileri Set SozlesmeDurumu = @durum, SozlesmeTarihi = @tarih Where id = @id", Baglan.con);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@durum", "Kabul Edildi");
                    cmd.Parameters.AddWithValue("@id", secilen);
                    Baglan.con.Open();
                    cmd.ExecuteNonQuery();
                    Baglan.con.Close();
                    MessageBox.Show("Kabul Edildi");
                    btnBekleyen_Click(null, e);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    throw;
                }

            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu isteği reddetmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("Update SozlesmeBilgileri Set SozlesmeDurumu = @durum, SozlesmeTarihi = @tarih Where id = @id", Baglan.con);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@durum", "Reddedildi");
                    cmd.Parameters.AddWithValue("@id", secilen);
                    Baglan.con.Open();
                    cmd.ExecuteNonQuery();
                    Baglan.con.Close();
                    MessageBox.Show("Reddedildi");
                    btnBekleyen_Click(null, e);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    throw;
                }

            }
        }
    }
}
