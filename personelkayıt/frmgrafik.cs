using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace personelkayıt
{
    public partial class frmgrafik : Form
    {
        public frmgrafik()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABC;Initial Catalog=Personelveritabani;Integrated Security=True");
        private void frmgrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sehirdagilimi = new SqlCommand("select persehir,count(*) from tbl_personel group by persehir",baglanti);
            SqlDataReader dr1 = sehirdagilimi.ExecuteReader();
            while(dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);

            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand meslekmaasdagilimi = new SqlCommand("select permeslek,avg(permaas) from tbl_personel group by permeslek", baglanti);
            SqlDataReader dr2 = meslekmaasdagilimi.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);

            }

            baglanti.Close();




        }
    }
}
