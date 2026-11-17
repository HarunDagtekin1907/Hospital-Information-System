using GörselProgramlama1.Sınıf._2dönemProjeOdevi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace GörselProgramlama1.Sınıf._2dönemProjeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        frmSqlBaglanti bgl = new frmSqlBaglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BeniHatirla == true)
            {
                
                kullanicitxt.Text = Properties.Settings.Default.KullaniciAdi;
                sifretxt.Text = Properties.Settings.Default.Sifre;
                chkHatirla.Checked = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 SignUp = new Form2();
            this.Hide();
            SignUp.ShowDialog();
            this.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string mevcutKayitlar = Properties.Settings.Default.KayitliHesaplar;
            Dictionary<string, string> hesaplar = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(mevcutKayitlar))
            {
                string[] kisiler = mevcutKayitlar.Split('|');
                foreach (string kisi in kisiler)
                {
                    if (kisi.Contains("="))
                    {
                        string[] parca = kisi.Split('=');
                        hesaplar[parca[0]] = parca[1];
                    }
                }
            }
            if (chkHatirla.Checked == true)
            {
                hesaplar[kullanicitxt.Text] = sifretxt.Text;
            }
            else
            {
                if (hesaplar.ContainsKey(kullanicitxt.Text))
                {
                    hesaplar.Remove(kullanicitxt.Text);
                }
            }

            List<string> yeniListe = new List<string>();
            foreach (var item in hesaplar)
            {
                yeniListe.Add(item.Key + "=" + item.Value);
            }
            Properties.Settings.Default.KayitliHesaplar = string.Join("|", yeniListe);
            Properties.Settings.Default.Save();
            if (kullanicitxt.Text != "" && sifretxt.Text != "")
            {
                SqlCommand giris = new SqlCommand("GirisYap",bgl.baglan());  
                giris.CommandType= CommandType.StoredProcedure;
                giris.Parameters.AddWithValue("kulAdiG",kullanicitxt.Text);
                giris.Parameters.AddWithValue("SifreG", sifretxt.Text);
                SqlDataReader dr = giris.ExecuteReader();
                if(dr.Read())
                {

                    Form3 anaSayfa = new Form3();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect. Please enter them again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sifretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ForgotPswlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword sifreFormu = new ForgotPassword();
            sifreFormu.ShowDialog();
        }

        private void kullanicitxt_TextChanged(object sender, EventArgs e)
        {
            string girilenAd = kullanicitxt.Text;
            string mevcutKayitlar = Properties.Settings.Default.KayitliHesaplar;

            if (!string.IsNullOrEmpty(mevcutKayitlar))
            {
                string[] kisiler = mevcutKayitlar.Split('|');
                bool bulundu = false;
                foreach (string kisi in kisiler)
                {
                    if (kisi.Contains("="))
                    {
                        string[] bolum = kisi.Split('=');

                        if (bolum[0] == girilenAd) 
                        {
                            sifretxt.Text = bolum[1]; 
                            chkHatirla.Checked = true; 
                            bulundu = true;
                            break;
                        }
                    }
                }
                if (bulundu == false)
                {
                    sifretxt.Text = "";
                    chkHatirla.Checked = false;
                }
            }
        }

    
    }
}
