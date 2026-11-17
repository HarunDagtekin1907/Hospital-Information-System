using System.Data.SqlClient;
namespace GörselProgramlama1.Sınıf._2dönemProjeOdevi
{
    internal class frmSqlBaglanti
    {
        string adres = @"Data Source=HARUN\SQLEXPRESS;Initial Catalog=db_HastaBilgiSistemi;Integrated Security=True";

        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(adres);
            baglanti.Open();
            return baglanti;
            
        }
    }
    
}

    
