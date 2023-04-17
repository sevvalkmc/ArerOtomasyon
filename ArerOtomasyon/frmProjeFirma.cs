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
    public partial class frmProjeFirma : Form
    {
        public frmProjeFirma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        bool durum;
        private System.Windows.Forms.TextBox item;

        private void projekontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from projefirma", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtProjeAdi.Text == read["ProjeAdi"].ToString());
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void projefirmalistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from projefirma", baglanti);
            adtr.Fill(daset, "projefirma");
            dataGridView1.DataSource = daset.Tables["projefirma"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;

            baglanti.Close();

        }
        private void frmProjeFirma_Load(object sender, EventArgs e)
        {
            projekontrol();
            projefirmalistele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProjeAdi.Text = dataGridView1.CurrentRow.Cells["ProjeAdi"].Value.ToString();
            txtFirmaAdi.Text = dataGridView1.CurrentRow.Cells["FirmaAdi"].Value.ToString();
        }

        private void btnSatışEkleme_Click(object sender, EventArgs e)
        {
            projekontrol();

            if (durum == false)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into projefirma (ProjeAdi,FirmaAdi) values(@ProjeAdi,@FirmaAdi)", baglanti);
                komut.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["projefirma"].Clear();
                projefirmalistele();
                MessageBox.Show("Kayıt eklendi");

                frmAnaSayfa anasayfac = new frmAnaSayfa();
                anasayfac.ShowDialog();
            }
        }

        private void txtProjeAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirmaAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from ProjeFirma where ProjeAdi='" + dataGridView1.CurrentRow.Cells["ProjeAdi"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt silindi");
            daset.Tables["ProjeFirma"].Clear();
            projefirmalistele();
        }

        private void txtAnaSayfaAra_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataTable tablo = new System.Data.DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from projefirma where (ProjeAdi+FirmaAdi) like '%" + txtAnaSayfaAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
