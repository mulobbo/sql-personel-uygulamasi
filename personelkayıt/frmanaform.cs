using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//SQL KULLANMAK İÇİN KÜTÜPHANE
using System.Runtime.CompilerServices;

namespace personelkayıt
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABC;Initial Catalog=Personelveritabani;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelveritabaniDataSet.Tbl_Personel);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelveritabaniDataSet.Tbl_Personel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          int durum = 0;
            if (radioButton1.Checked == true)
            {
                durum = 1;
            }


            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into Tbl_personel(perad,persoyad,persehir,permaas,perdurum,permeslek) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", Convert.ToInt16(maskedTextBox1.Text));
           
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", textBox4.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("KAYIT BAŞARILI");
          


           
        }

        void sil()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Focus();




        }
        private void button3_Click(object sender, EventArgs e)
        {
            sil(); 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
           comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string durum= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if (durum=="True")
            {
                radioButton1.Checked = true;
            }
            else
            { 
                radioButton2.Checked = true;
            }
            textBox4.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from tbl_personel where perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("k1",textBox1.Text);
            komutsil.ExecuteNonQuery();
          

            baglanti.Close();
            MessageBox.Show("SEÇİLİ KAYIT BAŞARIYLA SİLİNMİŞTİR");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int durum = 0;
            if (radioButton1.Checked == true)
            {
                durum = 1;
            }
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update tbl_personel set perad=@a1,persoyad=@a2,persehir=@a3,permaas=@a4,perdurum=@a5,permeslek=@a6 where perid=@a7",baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a3", comboBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a4", maskedTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a5", durum);
            komutguncelle.Parameters.AddWithValue("@a6", textBox4.Text);
            komutguncelle.Parameters.AddWithValue("@a7", textBox1.Text);

            komutguncelle.ExecuteNonQuery();
             baglanti.Close();
            MessageBox.Show("BİLGİLER BAŞARIYLA GÜNCELLENMİSTİR");



            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmistatistik fr = new frmistatistik();
            fr.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmgrafik fr = new frmgrafik();
                fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmraporlar rapor = new frmraporlar();
            rapor.Show();
        }
    }
}
