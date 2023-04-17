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
    public partial class frmProjeler : Form
    {
        public frmProjeler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DataSet daset = new DataSet();
        private void projelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from proje", baglanti);
            adtr.Fill(daset, "proje");
            dataGridView1.DataSource = daset.Tables["proje"];
            dataGridView1.Columns[2].Width = 600;
            baglanti.Close();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProjeler_Load(object sender, EventArgs e)
        {
            projelistele();
        }

        private void txtIdAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo1 = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from proje where (FirmaAdi+ProjeAdi) like '%" + txtProjeAra.Text + "%'", baglanti);
            adtr.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            baglanti.Close();
        }
    }
}
