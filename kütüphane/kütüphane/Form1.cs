using System.Data.SqlClient;

namespace kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti baglanti = new Baglanti();
            baglanti.baglantiac();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from yetkili where kullaniciadi=@kadi and sifre=@sifre ", baglanti.SqlConnection);
                cmd.Parameters.AddWithValue("@kadi", textBox1.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
                SqlDataReader rdr= cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    kutuphane Kutuphane = new();
                    Kutuphane.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre hatalı");
                    textBox1.Clear();
                    textBox2.Clear();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("bağlantı başarısız");
            }
            


        }
    }
}
