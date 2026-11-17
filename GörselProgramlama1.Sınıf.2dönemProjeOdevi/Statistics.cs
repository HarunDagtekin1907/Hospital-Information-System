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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();
       private void ToplamHasta()
        {
            SqlCommand toplam = new SqlCommand("select count(*) from tbl_HastaBilgi", bgl.baglan());
            SqlDataReader dr = toplam.ExecuteReader();
            while (dr.Read())
            {
                lbltophasta.Text = dr[0].ToString();
            }
        }
        private void YasOrt()
        {
            SqlCommand ort = new SqlCommand("select AVG(hastaYas) from tbl_HastaBilgi", bgl.baglan());
            SqlDataReader dr = ort.ExecuteReader();
            while (dr.Read())
            {
                lblyasort.Text = dr[0].ToString();
            }
        }
        private void erkekToplam()
        {
            SqlCommand eort = new SqlCommand("select count(*) from tbl_HastaBilgi where hastaCinsiyet ='Erkek'", bgl.baglan());
            SqlDataReader dr = eort.ExecuteReader();
            while (dr.Read())
            {
                lblerkek.Text = dr[0].ToString();
            }
        }
        private void kadınToplam()
        {
            SqlCommand kort = new SqlCommand("select count(*) from tbl_HastaBilgi where hastaCinsiyet ='Kadın'", bgl.baglan());
            SqlDataReader dr = kort.ExecuteReader();
            while (dr.Read())
            {
                lblkadın.Text = dr[0].ToString();
            }
        }
        private void ExTop()
        {
            SqlCommand exSayi = new SqlCommand("select count(*) from tbl_HastaBilgi where hastaExMi = 1", bgl.baglan());
            SqlDataReader dr = exSayi.ExecuteReader();
            while (dr.Read())
            {
                lblexsayi.Text = dr[0].ToString();
            }
        }
        private void Statistics_Load(object sender, EventArgs e)
        {
            ToplamHasta();
            YasOrt();
            erkekToplam();
            kadınToplam();
            ExTop();
        }
    }
}
