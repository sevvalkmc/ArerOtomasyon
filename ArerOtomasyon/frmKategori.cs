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


namespace ArerOtomasyon
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text==read["Kategori"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        
        private void frmKategori_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (textBox1.Text=="")
            {
                MessageBox.Show("Boş Geçilemez!","Uyarı");
            }
            else
            { 
                if (durum == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into kategoribilgileri(Kategori) values ('" + textBox1.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Marka Eklendi");

                }
                else
                {
                    MessageBox.Show("Böyle bir marka mevcut", "Uyarı");
                }
                textBox1.Text = "";

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
