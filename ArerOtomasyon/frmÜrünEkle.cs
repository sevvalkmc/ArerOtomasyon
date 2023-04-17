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

namespace ArerOtomasyon
{
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        private TextBox item;
        bool durum;
        private void urunkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun_", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkdNo.Text == read["BarkodNo"].ToString());
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }


        private void kategorigetir()
        {
            ComboKategori.Items.Clear();
            ComboKategori.Text = "";
            cmbKategori.Items.Clear();
            cmbKategori.Text = "";


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri",baglanti );
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboKategori.Items.Add(read["Kategori"].ToString());
                cmbKategori.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnGüncelle_Click(object sender, EventArgs e)
        {
         



        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            urunkontrol();
            if (txtBarkdNo.Text == "" || txtÜrünKodu.Text == "")
            {
                MessageBox.Show("Boş Geçilemez!", "Uyarı");
            }
            else
            {
                if (durum == false)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into urun_(BarkodNo,Marka,ÜrünKodu,Özellik,Miktari,SatisFiyati,Tarih) values(@BarkodNo,@Marka,@ÜrünKodu,@Özellik,@Miktari,@SatisFiyati,@Tarih)", baglanti);
                    komut.Parameters.AddWithValue("@BarkodNo", txtBarkdNo.Text);
                    komut.Parameters.AddWithValue("@Marka", cmbKategori.Text);
                    komut.Parameters.AddWithValue("@ÜrünKodu", txtÜrünKodu.Text);
                    komut.Parameters.AddWithValue("@Özellik", txtÖzellik.Text);
                    komut.Parameters.AddWithValue("@Miktari", Convert.ToInt32(txtMikt.Text));
                    komut.Parameters.AddWithValue("@SatisFiyati", (txtSatFiy.Text));
                    komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ürün kaydı eklendi");
                }

                else 
                {
                    MessageBox.Show("Böyle bir ürün kaydı mevcut", "Uyarı");
                }
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            
        }
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ComboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMikt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text =="")
            {
                foreach (Control item in groupBoxVarOlanÜrün.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun_ where BarkodNo like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboKategori.Text = read["Marka"].ToString();
                ÜrünKodutxt.Text = read["ÜrünKodu"].ToString();
                Özelliktxt.Text = read["Özellik"].ToString();
                txtMiktarı.Text = read["Miktari"].ToString();
                txtSatışFiyatı.Text = read["SatisFiyati"].ToString();
            }
            baglanti.Close();
        }

        private void txtMiktarı_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
