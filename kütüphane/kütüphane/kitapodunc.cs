using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane
{
    interface Ikitapodunc
    {
        void oduncal(SqlConnection baglanti, string uyead, string uyesoyad, string kitapadi, string kitapyazari, string almatarihi);
    }
    public class Kitapodunc:Baglanti,Ikitapodunc
    {
        public void oduncal(SqlConnection baglanti , string uyead,string uyesoyad,string  kitapadi,string kitapyazari,string almatarihi)
        {
            using (baglanti)
            {
                baglanti.Open();
                try
                {
                    SqlCommand musaitmi = new SqlCommand("select * from kitaplar where kitapadi=@kitapadi and musaitmi=1 ", baglanti);
                    musaitmi.Parameters.AddWithValue("@kitapadi", kitapadi);
                    using (SqlDataReader sqlDataReader = musaitmi.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            sqlDataReader.Close();
                            SqlTransaction transaction = baglanti.BeginTransaction();
                            try
                            {


                                SqlCommand musait = new SqlCommand("update kitaplar set musaitmi=0 where kitapadi=@kitapadi", baglanti);
                                musait.Transaction = transaction;
                                musait.Parameters.AddWithValue("@kitapadi", kitapadi);
                                musait.ExecuteNonQuery();



                                SqlCommand cmd = new SqlCommand("insert into odunc1(uyead,uyesoyad,kitapadi,kitapyazari,almatarihi) values(@uyead,@uyesoyad,@kitapadi,@kitapyazari,@almatarihi)", baglanti);
                                cmd.Parameters.AddWithValue("@uyead", uyead);
                                cmd.Parameters.AddWithValue("@uyesoyad", uyesoyad);
                                cmd.Parameters.AddWithValue("@kitapadi", kitapadi);
                                cmd.Parameters.AddWithValue("@kitapyazari", kitapyazari);
                                cmd.Parameters.AddWithValue("@almatarihi", almatarihi);
                                cmd.Transaction = transaction;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("ödünç alma başarılı");
                                sqlDataReader.Close();
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("hata" + ex.Message);
                            }

                        }
                    } 
                    
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {

                    if (baglanti.State == System.Data.ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }
           
            
        }
    }
}
