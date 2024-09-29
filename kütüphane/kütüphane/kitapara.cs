using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kütüphane
{
    public class Kitapara : Baglanti
    {
        public void ara(SqlConnection baglanti, string kitapadi, DataGridView datagridview)
        {
            using (baglanti)
            {
                try
                {
                    string sorgu = string.IsNullOrEmpty(kitapadi) ?
                        "select * from kitaplar" :
                        "SELECT * FROM kitaplar WHERE kitapadi LIKE @kitapadi";

                   
                        SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                        cmd.Parameters.AddWithValue("@kitapadi", "%" + kitapadi + "%");


                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable datatable = new DataTable();
                        da.Fill(datatable);
                        


                        datagridview.DataSource = datatable;
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }

        }
    }
}
