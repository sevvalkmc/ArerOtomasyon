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
    public partial class frmFirmaEkle : Form
    {
        public frmFirmaEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        bool durum;
        private void firmakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from firma", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtFirmaID.Text == read["FirmaID"].ToString()) ;
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void frmFirmaEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firmakontrol();
            if (txtFirmaID.Text == "" || txtFirmaAdi.Text=="" )
            {
                MessageBox.Show("Boş Geçilemez!", "Uyarı");
            }
            else
            {
                if (durum == false)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into firma(FirmaID,FirmaAdi,Telefon,Adres,Email) values(@FirmaID,@FirmaAdi,@Telefon,@Adres,@Email)", baglanti);
                    komut.Parameters.AddWithValue("@FirmaID", txtFirmaID.Text);
                    komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                    komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                    komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Firma kaydı eklendi");
                }
                else
                {
                    MessageBox.Show("Böyle bir firma mevcut", "Uyarı");
                }
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }

        }

        private void txtFirmaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
