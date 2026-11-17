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

namespace GörselProgramlama1.Sınıf._2dönemProjeOdevi
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSifreYenile_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtYeniSifre.Text != "")
            {
                SqlCommand guncelle = new SqlCommand("sifreGuncelle", bgl.baglan());
                guncelle.CommandType = CommandType.StoredProcedure;

                guncelle.Parameters.AddWithValue("@kulAdi", txtKullaniciAdi.Text);
                guncelle.Parameters.AddWithValue("@yeniSifre", txtYeniSifre.Text);

                // ExecuteNonQuery, işlem yapılan satır sayısını döndürür
                int sonuc = guncelle.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Your password has been successfully updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("No one was found registered with this username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the username and new password fields..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtYeniSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
 }
