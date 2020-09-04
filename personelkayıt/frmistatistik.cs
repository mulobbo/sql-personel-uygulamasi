using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//SQL KODU KÜTÜPHANESİ

namespace personelkayıt
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABC;Initial Catalog=Personelveritabani;Integrated Security=True");
        private void frmistatistik_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand toplamkisi = new SqlCommand("select count(*) from tbl_personel", baglanti);
            SqlDataReader dr1 = toplamkisi.ExecuteReader();
            while(dr1.Read())
            {
                label2.Text = dr1[0].ToString();

            }
         baglanti.Close();

            baglanti.Open();
            SqlCommand toplamevlikisi = new SqlCommand("select count(*) from tbl_personel where perdurum=1 ",baglanti);
            SqlDataReader dr2 = toplamevlikisi.ExecuteReader();
            while(dr2.Read())
            {
                label4.Text = dr2[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand toplambekarkisi = new SqlCommand("select count(*) from tbl_personel where perdurum=0 ", baglanti);
            SqlDataReader dr3 = toplambekarkisi.ExecuteReader();
            while (dr3.Read())
            {
                label6.Text = dr3[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand toplamfarklısehir = new SqlCommand("select count(distinct(persehir)) from tbl_personel ", baglanti);
            SqlDataReader dr4 = toplamfarklısehir.ExecuteReader();
            while (dr4.Read())
            {
                label8.Text = dr4[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand toplammaas = new SqlCommand("select sum(permaas) from tbl_personel ", baglanti);
            SqlDataReader dr5 = toplammaas.ExecuteReader();
            while (dr5.Read())
            {
                label10.Text = dr5[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand ortalamamaas = new SqlCommand("select avg(permaas) from tbl_personel ", baglanti);
            SqlDataReader dr6 = ortalamamaas.ExecuteReader();
            while (dr6.Read())
            {
                label12.Text = dr6[0].ToString();
            }

            baglanti.Close();








        }
    }
}
