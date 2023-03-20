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
            string q = "Select Id, MuvekkilAdSoyad, MuvekkilTelefon, MuvekkilEposta from MuvekkilBilgileri";
            SQLiteCommand cmd = new SQLiteCommand(q, Baglan.con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgwMuvekkiller.DataSource= dt;
        }

        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            MesajlasmaSayfasi fr = new MesajlasmaSayfasi();
            SQLiteCommand muvcmd = new SQLiteCommand("Select MuvIP, MuvPort from MuvekkilBilgileri where Id = @id", Baglan.con);
            SQLiteCommand avcmd = new SQLiteCommand("Select AvIP, AvPort from AvukatBilgileri where Id=@p1", Baglan.con);
            avcmd.Parameters.AddWithValue("@p1", AvukatMuvekkil.AvukatGiris.avid);
            muvcmd.Parameters.AddWithValue("@id", dgwMuvekkiller.CurrentRow.Cells["Id"].Value);
            Baglan.con.Open();
            SQLiteDataReader dr = muvcmd.ExecuteReader();
            while (dr.Read())
            {
                fr.muvip = dr["MuvIP"].ToString();
                fr.muvport = Convert.ToInt32(dr["MuvPort"]);
            }
            Baglan.con.Close();
            Baglan.con.Open();
            SQLiteDataReader avdr = avcmd.ExecuteReader();
            while (avdr.Read())
            {
                fr.avip = avdr["AvIP"].ToString();
                fr.avport = Convert.ToInt32(avdr["AvPort"]);
            }
            Baglan.con.Close();

            fr.Show();
        }
    }
}
