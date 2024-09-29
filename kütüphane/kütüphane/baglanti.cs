using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kütüphane
{
    public class Baglanti
    {
        public SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-471QMFA;Initial Catalog=kutuphane;Integrated Security=True");
        public void baglantiac()
        {
            
            SqlConnection.Open();
        }
        public void baglantikapat()
        {
            SqlConnection.Close();
        }
    }
}
