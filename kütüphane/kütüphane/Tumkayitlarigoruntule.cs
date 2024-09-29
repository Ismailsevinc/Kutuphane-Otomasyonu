using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane
{
    public class Tumkayitlarigoruntule:Baglanti
    {
        public void goruntule(SqlConnection baglanti,DataGridView dataGridView)
        {
            if (baglanti.State!=System.Data.ConnectionState.Open)
            {
                baglanti.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT  iade.iadeid, odunc1.oduncid,  iade.uyead,  iade.uyesoyad, odunc1.kitapadi, odunc1.kitapyazari,  odunc1.almatarihi , iade.iadetarihi FROM iade JOIN  odunc1 ON odunc1.kitapadi = iade.kitapadi;", baglanti);
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            dataGridView.DataSource = dt;
            baglanti.Close();
        }
    }
}
