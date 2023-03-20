﻿using System;
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
    public partial class AvukatBilgiGoruntuleme : Form
    {
        public AvukatBilgiGoruntuleme()
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
        public string secilen;
        private void AvukatBilgiGoruntuleme_Load(object sender, EventArgs e)
        {
            AvukatListeleme fr = new AvukatListeleme();
            
            string query = "SELECT AvukatAdSoyad,AvukatTelefon,AvukatEposta FROM AvukatBilgileri where AvukatEposta=@p1";
            SQLiteCommand komut = new SQLiteCommand(query, Baglan.con);
            komut.Parameters.AddWithValue("@p1", secilen);
            Baglan.con.Open();
            SQLiteDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblIsimSoyisim.Text = dr[0].ToString();
                lblMail.Text = dr[2].ToString();
                lblTelefon.Text += dr[1].ToString();
            }
            Baglan.con.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            MesajlasmaSayfasi fr = new MesajlasmaSayfasi();
            SQLiteCommand muvcmd = new SQLiteCommand("Select MuvIP, MuvPort from MuvekkilBilgileri where Id = @id", Baglan.con);
            SQLiteCommand avcmd = new SQLiteCommand("Select AvIP, AvPort from AvukatBilgileri where AvukatEposta=@p1", Baglan.con);
            avcmd.Parameters.AddWithValue("@p1", secilen);
            muvcmd.Parameters.AddWithValue("@id", AvukatMuvekkil.MuvekkilGiris.muvid);
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
            while(avdr.Read())
            {
                fr.avip = avdr["AvIP"].ToString();
                fr.avport = Convert.ToInt32(avdr["AvPort"]);
            }
            Baglan.con.Close();
            fr.Show();
        }
    }
}
