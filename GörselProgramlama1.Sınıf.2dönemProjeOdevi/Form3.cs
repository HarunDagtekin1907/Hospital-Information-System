using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlama1.Sınıf._2dönemProjeOdevi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        frmSqlBaglanti bgl=new frmSqlBaglanti();
        private void Form3_Load(object sender, EventArgs e)
        {
            this.tbl_HastaBilgiTableAdapter.Fill(this.db_HastaBilgiSistemiDataSet4.tbl_HastaBilgi);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listele();
            durumDoldur();
            bolumDoldur();
        }

        private void listele()
        {
            SqlCommand liste=new SqlCommand("listele",bgl.baglan());
            SqlDataAdapter da =new SqlDataAdapter(liste);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }
        private void durumDoldur()
        {
            SqlCommand durum = new SqlCommand("durumDoldur",bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2ComboBox2.DataSource = dt;
            guna2ComboBox2.DisplayMember= "durumAd";
            guna2ComboBox2.ValueMember= "durumId";

        }
        private void bolumDoldur()
        {
            SqlCommand bolum = new SqlCommand("bolumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(bolum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hDepartmenttxt.DataSource = dt;
            hDepartmenttxt.DisplayMember = "bolumAd";
            hDepartmenttxt.ValueMember = "bolumId";
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            listele();
           
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (hNametxt.Text !="" && hlastNametxt.Text != "" && hGendertxt.Text != "" && hComplainttxt.Text != "" && hTctxt.Text != "" && hPhonetxt.Text != "" && hAgetxt.Text != "" && guna2ComboBox2.Text != "" && hDepartmenttxt.Text != "")
            {
                kaydet();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void kaydet()
        {
            SqlCommand kaydet = new SqlCommand("kaydet",bgl.baglan());
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("@ad", hNametxt.Text);
            kaydet.Parameters.AddWithValue("@soyad", hlastNametxt.Text);
            kaydet.Parameters.AddWithValue("@tc", hTctxt.Text);
            kaydet.Parameters.AddWithValue("@tel", hPhonetxt.Text);
            kaydet.Parameters.AddWithValue("@cins", hGendertxt.Text);
            kaydet.Parameters.AddWithValue("@sikayet", hComplainttxt.Text);
            kaydet.Parameters.AddWithValue("@yas", int.Parse(hAgetxt.Text.ToString()));
            kaydet.Parameters.AddWithValue("@tarih", DateTime.Now);
            kaydet.Parameters.AddWithValue("@durum",guna2ComboBox2.SelectedValue);
            kaydet.Parameters.AddWithValue("@bolum", hDepartmenttxt.SelectedValue);
            if(lblex.Text == "True")
            {
                kaydet.Parameters.AddWithValue("@ex",1);     
            }
            else
            {
                kaydet.Parameters.AddWithValue("@ex", 0);
            }
            kaydet.ExecuteNonQuery();
            MessageBox.Show("Patient Added Successfully.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            IDtxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            hNametxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            hlastNametxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            hTctxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            hPhonetxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            hAgetxt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            hGendertxt.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            hComplainttxt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            timetxt.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            guna2ComboBox2.SelectedValue = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[9].Value);
            hDepartmenttxt.SelectedValue = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[10].Value);
            lblex.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();

        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if  (rbYes.Checked == true)
            {
                lblex.Text = "True";
            }
            else
            {
                lblex.Text = "False";
            }
        }

        private void lblex_TextChanged(object sender, EventArgs e)
        {
            if (lblex.Text == "True" )
            {
                rbYes.Checked = true;
            }
            else
            {
                rbNo.Checked = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text != "" && hNametxt.Text != "" && hlastNametxt.Text != "" && hTctxt.Text != "")
            {
                sil();
            }
            else
            {
                MessageBox.Show("Please select a patient from the list to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sil()
        {
            DialogResult dr = MessageBox.Show($"{IDtxt.Text} Patient Record Will Be Deleted.Do You Agree?", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("sil", bgl.baglan());
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("id", int.Parse(IDtxt.Text.ToString()));
                sil.ExecuteNonQuery();
                MessageBox.Show("The Patient Was Successfully Deleted.", "Patient Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele(); 
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (IDtxt.Text != "" && hNametxt.Text != "" && hlastNametxt.Text != "" && hGendertxt.Text != "" && hComplainttxt.Text != "" && hTctxt.Text != "" && hPhonetxt.Text != "" && hAgetxt.Text != "" && guna2ComboBox2.Text != "" && hDepartmenttxt.Text != "")
            {
                DialogResult dr = MessageBox.Show($"{IDtxt.Text} record number will be updated. Do You Agree?", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    guncelle();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields and make sure you select a patient from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void guncelle()
        {
            SqlCommand güncelle = new SqlCommand("güncelle", bgl.baglan());
            güncelle.CommandType = CommandType.StoredProcedure;
            güncelle.Parameters.AddWithValue("@id", int.Parse(IDtxt.Text));
            güncelle.Parameters.AddWithValue("@ad", hNametxt.Text);
            güncelle.Parameters.AddWithValue("@soyad", hlastNametxt.Text);
            güncelle.Parameters.AddWithValue("@tc", hTctxt.Text);
            güncelle.Parameters.AddWithValue("@tel", hPhonetxt.Text);
            güncelle.Parameters.AddWithValue("@cins", hGendertxt.Text);
            güncelle.Parameters.AddWithValue("@sikayet", hComplainttxt.Text);
            güncelle.Parameters.AddWithValue("@yas", int.Parse(hAgetxt.Text.ToString()));
            güncelle.Parameters.AddWithValue("@tarih", DateTime.Now);
            güncelle.Parameters.AddWithValue("@durum", guna2ComboBox2.SelectedValue);
            güncelle.Parameters.AddWithValue("@bolum", hDepartmenttxt.SelectedValue);
            if (lblex.Text == "True")
            {
                güncelle.Parameters.AddWithValue("@ex", 1);
            }
            else
            {
                güncelle.Parameters.AddWithValue("@ex", 0);
            }
            güncelle.ExecuteNonQuery();
            MessageBox.Show("Update process completed successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        private void temizle()
        {
            IDtxt.Text = "";
            hNametxt.Text = "";
            hlastNametxt.Text = "";
            hGendertxt.Text = "";
            hComplainttxt.Text = "";
            timetxt.Text = "";
            hTctxt.Text = "";
            hPhonetxt.Text = "";
            hAgetxt.Text = "";
            guna2ComboBox2.Text = "";
            hDepartmenttxt.Text = "";
            rbNo.Checked = true;
            lblex.Text ="False";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics fr = new Statistics();
            fr.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }
    }
}
