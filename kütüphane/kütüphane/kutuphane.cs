using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class kutuphane : Form
    {
        public kutuphane()
        {
            InitializeComponent();
        }

        private void kutuphane_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Baglanti baglanti = new Baglanti();
            baglanti.baglantiac();
            Yeniuyeekle yeniuyeekle = new Yeniuyeekle();
            yeniuyeekle.ekle(baglanti.SqlConnection, textuyeadi.Text.ToString(), textBoxuyesoyadi.Text.ToString());
            if (baglanti.SqlConnection.State == ConnectionState.Open)
            {
                baglanti.baglantikapat();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kitapara kitapara = new Kitapara();
            kitapara.baglantiac();
            kitapara.ara(kitapara.SqlConnection, textBoxaranacakkitap.Text.ToString(), dataGridView1);

            if (kitapara.SqlConnection.State == ConnectionState.Open)
            {
                kitapara.baglantikapat();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textuyeadi.Text) && !string.IsNullOrEmpty(textBoxuyesoyadi.Text) && !string.IsNullOrEmpty(textBoxkitapadi.Text) && !string.IsNullOrEmpty(textBoxkitapyazari.Text) && !string.IsNullOrEmpty(textBoxalmatarihi.Text))
            {
                Kitapodunc kitapodunc = new Kitapodunc();
                kitapodunc.oduncal(kitapodunc.SqlConnection, textuyeadi.Text.ToString(), textBoxuyesoyadi.Text.ToString(), textBoxkitapadi.Text.ToString(), textBoxkitapyazari.Text.ToString(), textBoxalmatarihi.Text.ToString());
                if (kitapodunc.SqlConnection.State == ConnectionState.Open)
                {
                    kitapodunc.SqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Kitapiade kitapiade = new Kitapiade();
            kitapiade.iadeet(kitapiade.SqlConnection, textuyeadi.Text.ToString(), textBoxuyesoyadi.Text.ToString(), textBoxkitapadi.Text.ToString(), textBoxkitapyazari.Text.ToString(), textBoxiadetarih.Text.ToString());



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tumkayitlarigoruntule tumkayitlarigoruntule = new();
            tumkayitlarigoruntule.goruntule(tumkayitlarigoruntule.SqlConnection, dataGridView1);
            if (tumkayitlarigoruntule.SqlConnection.State == ConnectionState.Open)
            {
                tumkayitlarigoruntule.SqlConnection.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti baglanti = new Baglanti();
                baglanti.baglantiac();
                using (SqlCommand sqlCommand = new SqlCommand("select * from uyeler", baglanti.SqlConnection))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                }
                baglanti.baglantikapat();
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata :"+ex);
            }

        }
    }
}
