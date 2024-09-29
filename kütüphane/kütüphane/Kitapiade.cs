using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kütüphane
{
    public class Kitapiade : Baglanti
    {
        public void iadeet(SqlConnection baglanti, string uyeadi, string uyesoyadi, string kitapadi, string kitapyazari, string iadetarihi)
        {
            // Gerekli alanların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(uyeadi) ||
                string.IsNullOrWhiteSpace(uyesoyadi) ||
                string.IsNullOrWhiteSpace(kitapadi) ||
                string.IsNullOrWhiteSpace(kitapyazari) ||
                string.IsNullOrWhiteSpace(iadetarihi))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.");
                return;
            }

            SqlTransaction sqlTransaction = null;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                // Transaction'ı başlat
                sqlTransaction = baglanti.BeginTransaction();

                // Kitap kontrolü için SQL komutunu oluştur
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM kitaplar WHERE kitapadi=@kitapadi AND kitapyazari=@kitapyazari AND musaitmi=0", baglanti, sqlTransaction))
                {
                    sqlCommand.Parameters.Add("@kitapadi", SqlDbType.VarChar).Value = kitapadi;
                    sqlCommand.Parameters.Add("@kitapyazari", SqlDbType.VarChar).Value = kitapyazari;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Close();

                            // Kitap iade güncellemesi için SQL komutunu oluştur
                            using (SqlCommand cmd = new SqlCommand("UPDATE kitaplar SET musaitmi=1 WHERE kitapadi=@kitapadi AND kitapyazari=@kitapyazari", baglanti, sqlTransaction))
                            {
                                cmd.Parameters.Add("@kitapadi", SqlDbType.VarChar).Value = kitapadi;
                                cmd.Parameters.Add("@kitapyazari", SqlDbType.VarChar).Value = kitapyazari;
                                cmd.ExecuteNonQuery(); // Transaction geçerli
                            }

                            // İade kaydı eklemek için SQL komutunu oluştur
                            using (SqlCommand iade = new SqlCommand("INSERT INTO iade(uyead,uyesoyad,kitapadi,kitapyazari,iadetarihi) VALUES(@uyead,@uyesoyad,@kitapadi,@kitapyazari,@iadetarihi)", baglanti, sqlTransaction))
                            {
                                iade.Parameters.Add("@uyead", SqlDbType.VarChar).Value = uyeadi;
                                iade.Parameters.Add("@uyesoyad", SqlDbType.VarChar).Value = uyesoyadi;
                                iade.Parameters.Add("@kitapadi", SqlDbType.VarChar).Value = kitapadi;
                                iade.Parameters.Add("@kitapyazari", SqlDbType.VarChar).Value = kitapyazari;
                                iade.Parameters.Add("@iadetarihi", SqlDbType.Date).Value = DateTime.Parse(iadetarihi);
                                iade.ExecuteNonQuery(); // Transaction geçerli
                            }

                            // İşlemi onayla
                            sqlTransaction.Commit();
                            MessageBox.Show("Başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Kitap zaten müsait.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda işlemi geri al
                if (sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
    }
}
