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
    public partial class frmÜrünListeleme : Form
    {
        public frmÜrünListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        private TextBox item;
        private void kategorigetir()
        {
            ComboKategori.Items.Clear();
            ComboKategori.Text ="";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboKategori.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünListeleme_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();

        }
        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun_", baglanti);
            adtr.Fill(daset, "urun_");
            dataGridView1.DataSource = daset.Tables["urun_"];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun_ where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close(); 
            daset.Tables["urun_"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi");

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            ComboKategori.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            ÜrünKodutxt.Text = dataGridView1.CurrentRow.Cells["ÜrünKodu"].Value.ToString();
            Özelliktxt.Text = dataGridView1.CurrentRow.Cells["Özellik"].Value.ToString();
            txtMiktarı.Text = dataGridView1.CurrentRow.Cells["Miktari"].Value.ToString();
            txtSatışFiyatı.Text = dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
        }

        private void btnGüncel_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text != "")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun_ set Marka=@Marka,ÜrünKodu=@ÜrünKodu,Özellik=@Özellik,Miktari=@Miktari,SatisFiyati=@SatisFiyati,Tarih=@Tarih where BarkodNo=@BarkodNo", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@Marka", ComboKategori.Text);
                komut.Parameters.AddWithValue("@ÜrünKodu", ÜrünKodutxt.Text);
                komut.Parameters.AddWithValue("@Özellik", Özelliktxt.Text);
                komut.Parameters.AddWithValue("@Miktari", Convert.ToInt32(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@SatisFiyati", Convert.ToDecimal(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["urun_"].Clear();
                ÜrünListele();
                MessageBox.Show("Ürün Güncellendi");

                foreach (Control item in this.Controls) ;
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
                {
                }
            }
            else
            {
                MessageBox.Show("Barkod no boş geçilemez","Uyarı");
            }
        }

        private void ComboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ComboKategori.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun_ where (BarkodNo+ÜrünKodu) like '%" + txtürünLisAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
