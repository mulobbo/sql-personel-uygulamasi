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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABC;Initial Catalog=Personelveritabani;Integrated Security=True");

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand girispaneli = new SqlCommand("select *from tbl_yonetici where kullaniciad=@a1 and sifre=@a2",baglanti);
            girispaneli.Parameters.AddWithValue("@a1", textBox1.Text);
            girispaneli.Parameters.AddWithValue("@a2", textBox2.Text);
            SqlDataReader dr1 = girispaneli.ExecuteReader();
            if(dr1.Read())
            {
                frmanaform frm = new frmanaform();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI YA DA ŞİFRE");
            }    

            baglanti.Close();
        }
    }
}
