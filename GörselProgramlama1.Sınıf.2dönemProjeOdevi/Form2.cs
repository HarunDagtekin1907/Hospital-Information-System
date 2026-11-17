using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GörselProgramlama1.Sınıf._2dönemProjeOdevi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKayitOl_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(guna2TextBox1.Text) && !string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                SqlCommand kayit = new SqlCommand("kayitOL",bgl.baglan());
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.Parameters.AddWithValue("kulAdi",guna2TextBox1.Text);
                kayit.Parameters.AddWithValue("Sifre",guna2TextBox2.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("User Successfully Registered", "Registration Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
