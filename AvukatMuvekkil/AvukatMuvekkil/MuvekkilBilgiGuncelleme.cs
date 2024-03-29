﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvukatMuvekkil
{
    public partial class MuvekkilBilgiGuncelleme : Form
    {
        public MuvekkilBilgiGuncelleme()
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
        public string eposta;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string query = "Update MuvekkilBilgileri Set MuvekkilAdSoyad=@p1,MuvekkilEposta=@p2,MuvekkilTelefon=@p3 Where MuvekkilEposta=@p4";

            SQLiteCommand cmd = new SQLiteCommand(query, Baglan.con);

            cmd.Parameters.AddWithValue("@p1", txtAd.Text + " " + txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txtEposta.Text);
            cmd.Parameters.AddWithValue("@p3", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@p4", eposta);


            Baglan.con.Open();
            cmd.ExecuteNonQuery();
            Baglan.con.Close();

            MessageBox.Show("Bilgileriniz Güncellenmiştir.");
        }

        private void MuvekkilBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            string query = "SELECT MuvekkilAdSoyad,MuvekkilTelefon,MuvekkilEposta FROM MuvekkilBilgileri where MuvekkilEposta=@p1";
            SQLiteCommand komut = new SQLiteCommand(query, Baglan.con);
            komut.Parameters.AddWithValue("@p1", eposta);

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

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp"; // Sadece resim dosyalarını filtrele

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string resimDosyaYolu = openFileDialog.FileName;

                // Resmi bir Image nesnesine yükle
                Image resim = Image.FromFile(resimDosyaYolu);

                // Resmi byte dizisine dönüştür
                byte[] resimVerisi;
                using (MemoryStream ms = new MemoryStream())
                {
                    resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    resimVerisi = ms.ToArray();
                }

                // SQLite veritabanına resmi kaydet
                string query = "Update MuvekkilBilgileri Set MuvekkilPic = @ResimVerisi Where MuvekkilEposta=@p1";
                SQLiteCommand command = new SQLiteCommand(query, Baglan.con);
                command.Parameters.AddWithValue("@p1", eposta);
                command.Parameters.AddWithValue("@ResimVerisi", resimVerisi);

                Baglan.con.Open();
                command.ExecuteNonQuery();
                Baglan.con.Close();

            }
        }
    }
}