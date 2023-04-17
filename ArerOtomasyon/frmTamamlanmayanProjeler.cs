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
    public partial class frmTamamlanmayanProjeler : Form
    {
        public frmTamamlanmayanProjeler()
        {
            InitializeComponent();
        }
        /*SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        bool durum;
        private System.Windows.Forms.TextBox item;*/

        /*private void anasayfalistele2()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 275;
            dataGridView1.Columns[2].Width = 275;
            baglanti.Close();

        }*/

        public List<CommonValue> Values { get; set; }
        public void AddToGrid(List<CommonValue> val)
        {
            if (val != null)
            {
                foreach (CommonValue item in val)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.ID;
                    dataGridView1.Rows[n].Cells[1].Value = item.ProjeAdi;
                    dataGridView1.Rows[n].Cells[2].Value = item.FirmaAdi;
                }
            }
            else
            {
                foreach (CommonValue item in val)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.ID;
                    dataGridView1.Rows[n].Cells[1].Value = item.ProjeAdi;
                    dataGridView1.Rows[n].Cells[2].Value = item.FirmaAdi;


                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTamamlanmayanProjeler_Load(object sender, EventArgs e)
        {
           // anasayfalistele2();

            AddToGrid(Values);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
