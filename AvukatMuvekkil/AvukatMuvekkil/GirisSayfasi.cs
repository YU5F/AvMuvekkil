using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvukatMuvekkil
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
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

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
        }

        private void btnMuvekkil_Click(object sender, EventArgs e)
        {
            MuvekkilGiris fr = new MuvekkilGiris();
            fr.Show();
            this.Hide();
        }

        private void btnAvukat_Click(object sender, EventArgs e)
        {
            AvukatGiris fr = new AvukatGiris();
            fr.Show();
            this.Hide();
        }
    }
}
