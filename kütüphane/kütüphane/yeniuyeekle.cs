using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane
{
    public class Yeniuyeekle:Baglanti
    {
        public void ekle(SqlConnection connection,string uyeadi,string uyesoyadi)
        {
            if (string.IsNullOrEmpty(uyeadi) && string.IsNullOrEmpty(uyesoyadi))
            {
                MessageBox.Show("lütfen üye adı ve üye soyadı kısımlarını doldurunuz");
                return;
            }
            using (connection)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into uyeler(uyead,uyesoyad) values(@uyeadi,@uyesoyadi)", connection);
                    cmd.Parameters.AddWithValue("@uyeadi", uyeadi);
                    cmd.Parameters.AddWithValue("@uyesoyadi", uyesoyadi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yeni Üye Eklendi");
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("sqlcommand hatası");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            
        }
        
    }
}
