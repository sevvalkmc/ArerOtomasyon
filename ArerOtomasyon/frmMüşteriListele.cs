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
    public partial class frmMüşteriListele : Form
    {
        public frmMüşteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }
        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from firma", baglanti);
            adtr.Fill(daset, "firma");
            dataGridView1.DataSource = daset.Tables["firma"];
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 150;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirmaID.Text = dataGridView1.CurrentRow.Cells["FirmaID"].Value.ToString();
            txtFirmaAdi.Text = dataGridView1.CurrentRow.Cells["FirmaAdi"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update firma set FirmaAdi=@FirmaAdi,Telefon=@Telefon,Adres=@Adres,Email=@Email where FirmaID=@FirmaID ", baglanti);
            komut.Parameters.AddWithValue("@FirmaID", txtFirmaID.Text);
            komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["firma"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Firma Kaydı Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                { 
                    item.Text = "";
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from firma where FirmaID='" + dataGridView1.CurrentRow.Cells["FirmaID"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close(); daset.Tables["firma"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt Silindi");
            
        }

        private void txtIdAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from firma where (FirmaID+FirmaAdi+Telefon+Adres+Email) like '%"+txtIdAra.Text+ "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
