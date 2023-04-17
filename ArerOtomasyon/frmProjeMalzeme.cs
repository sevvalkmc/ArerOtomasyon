using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
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
    public partial class frmProjeMalzeme : Form
    {
        public frmProjeMalzeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        bool durum;
        private System.Windows.Forms.TextBox item;

        /*private void projemalzemekontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtProjeMalzemeAdi.Text == read["ProjeAdi"].ToString()) ;
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }*/
        private void malzemelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select sepet.MalzemeAdi,projefirma.ProjeAdi from sepet inner join projefirma on(sepet.ProjeAdi=projefirma.ProjeAdi)", baglanti);
            adtr.Fill(daset, "ProjeMalzeme");
            dataGridView1.DataSource = daset.Tables["ProjeMalzeme"];
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 250;
            baglanti.Close();
        }          


        private void frmProjeMalzeme_Load(object sender, EventArgs e)
        {
            malzemelistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void comboProje_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProjeMalzemeAra_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataTable tablo = new System.Data.DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet where (ProjeAdi+MalzemeAdi) like '%" + txtProjeMalzemeAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        

        private void txtMalzemeler_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void btnEk_Click(object sender, EventArgs e)
        {

            if (txtProjeMalzemeAdi.Text == "" ) 
                {
                    MessageBox.Show("Proje adı boş geçilemez!", "Uyarı");
                }
                else
                {
                    
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into ProjeMalzeme (ProjeAdi,Malzemeler) values(@ProjeAdi,@Malzemeler)", baglanti);
                        komut.Parameters.AddWithValue("@ProjeAdi", txtProjeMalzemeAdi.Text);
                        komut.Parameters.AddWithValue("@Malzemeler", txtMalzemeler.Text);
                        
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Proje kaydı eklendi");
                        daset.Tables["ProjeMalzeme"].Clear();
                        malzemelistele();
                        foreach (Control item in this.Controls) ;
                        {
                    foreach (Control item in this.Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
                    }
                }
                    
                    
                }
            

        }*/

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProjeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtProjeMalzemeAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAraSepet_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
