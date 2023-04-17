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
    public partial class frmSatis : Form

    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        bool durum;
        private System.Windows.Forms.TextBox item;



        bool export_dgw_excel_1(DataGridView dgw)
        {
            
            bool durum2 = false;
            try
            {
                dgw.SelectAll();
                DataObject dataObj = dgw.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Excel.Application xlexcel;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                //Kodumuz buraya kadar gelip veri aktarımını tamamladı ise durum true yaparak işlemin başarılı
                //Olduğu bilgisini alıyoruz.
                durum2 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGrid Verileri Aktarılamadı : " + ex.Message);
            }
            return durum2;
        }
        bool export_dgw_excel_2(DataGridView dgw)
        {
            bool durum2 = false;
            try
            {
                Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Sütun Başlıkları
                for (j = 0; j < dgw.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgw.Columns[j].HeaderText;
                }

                StartRow++;

                //Datagridview İçeriği Yazdırılıyor
                for (i = 0; i < dgw.Rows.Count; i++)
                {
                    for (j = 0; j < dgw.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgw[j, i].Value == null ? "" : dgw[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
                //Kodumuz buraya kadar gelip veri aktarımını tamamladı ise durum true yaparak işlemin başarılı olduğu bilgisini alıyoruz.
                durum2 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGrid Verileri Aktarılamadı : " + ex.Message);
            }

            return durum2;
        }


        private void projekontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
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

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[8].Width = 600;
            dataGridView1.Columns[9].Width = 600;
            baglanti.Close();

        }
        private void kategorigetir()
        {
            comboKat.Items.Clear();
            comboKat.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKat.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }
        

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {

            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        

        private void frmSatis_Load(object sender, EventArgs e)
        {
            
            sepetlistele();
            kategorigetir();
        }

        private void btnSatışİşlemleri_Click(object sender, EventArgs e)
        {
            frmSatışİşlemleri sat = new frmSatışİşlemleri();
            sat.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmÜrünListeleme urun = new frmÜrünListeleme();
            urun.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtProjeAdi.Text != "")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update sepet set MalzemeAdi=@MalzemeAdi,BarkodNo=@BarkodNo,Marka=@Marka,ÜrünKodu=@ÜrünKodu,Miktari=@Miktari,KoliNo=@KoliNo,Özellik=@Özellik,Açıklama=@Açıklama where ProjeAdi=@ProjeAdi ", baglanti);
                komut.Parameters.AddWithValue("@MalzemeAdi", txtMalzSatis.Text);
                komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@Marka", comboKat.Text);
                komut.Parameters.AddWithValue("@ÜrünKodu", ÜrünKodutxt.Text);
                komut.Parameters.AddWithValue("@Miktari", Convert.ToInt32(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@KoliNo", txtKoliNo.Text);
                komut.Parameters.AddWithValue("@Özellik", txtÖzellik.Text);
                komut.Parameters.AddWithValue("@Açıklama", txtAçıklama.Text);
                komut.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                //komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["sepet"].Clear();
                sepetlistele();
                MessageBox.Show("Ürün Güncellendi");
                foreach (Control item in groupBoxİşlemler.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
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
                MessageBox.Show("Proje adı boş geçilemez", "Uyarı");
            }
            
            export_dgw_excel_1(dataGridView1);
        }

        private void txtürünLisAra_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataTable tablo = new System.Data.DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet where (MalzemeAdi+ProjeAdi+BarkodNo+ÜrünKodu) like '%" + txtSepetLisAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            projekontrol();
                if (txtProjeAdi.Text == "" || ÜrünKodutxt.Text == "")
                {
                    MessageBox.Show("Proje adı ve Ürün kodu Boş Geçilemez!", "Uyarı");
                }
                else
                {
                    if (durum == false)
                    {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into sepet (MalzemeAdi,BarkodNo,Marka,ÜrünKodu,Miktari,KoliNo,Özellik,Açıklama,ProjeAdi) values(@MalzemeAdi,@BarkodNo,@Marka,@ÜrünKodu,@Miktari,@KoliNo,@Özellik,@Açıklama,@ProjeAdi)", baglanti);
                    komut.Parameters.AddWithValue("@MalzemeAdi", txtMalzSatis.Text);                    
                    komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                    komut.Parameters.AddWithValue("@Marka", comboKat.Text);
                    komut.Parameters.AddWithValue("@ÜrünKodu", ÜrünKodutxt.Text);
                    komut.Parameters.AddWithValue("@Miktari", Convert.ToInt32(txtMiktarı.Text));
                    komut.Parameters.AddWithValue("@KoliNo", txtKoliNo.Text);
                    komut.Parameters.AddWithValue("@Özellik", txtÖzellik.Text);
                    komut.Parameters.AddWithValue("@Açıklama", txtAçıklama.Text);
                    komut.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
                    //komut.Parameters.AddWithValue("@FirmaAdi", txtFirmaAdi.Text);
                    //komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ürün kaydı eklendi");
                    daset.Tables["sepet"].Clear();
                    sepetlistele();
                    Temizle();
                }
                
                
                foreach (Control item in groupBoxİşlemler.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }

                }

            }
            
            export_dgw_excel_1(dataGridView1);
            frmAnaSayfa anasayfacık = new frmAnaSayfa();
            anasayfacık.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where ProjeAdi='"+dataGridView1.CurrentRow.Cells["ProjeAdi"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt silindi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            export_dgw_excel_1(dataGridView1);


        }







        private void comboKat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProjeAdi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Temizle()
        {
            if (txtProjeAdi.Text == "")
            {
                foreach (Control item in groupBoxİşlemler.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtMalzSatis.Text = dataGridView1.CurrentRow.Cells["MalzemeAdi"].Value.ToString();
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            comboKat.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            ÜrünKodutxt.Text = dataGridView1.CurrentRow.Cells["ÜrünKodu"].Value.ToString();
            txtMiktarı.Text = dataGridView1.CurrentRow.Cells["Miktari"].Value.ToString();
            txtKoliNo.Text = dataGridView1.CurrentRow.Cells["KoliNo"].Value.ToString();
            txtÖzellik.Text = dataGridView1.CurrentRow.Cells["Özellik"].Value.ToString();
            txtAçıklama.Text = dataGridView1.CurrentRow.Cells["Açıklama"].Value.ToString();
            txtProjeAdi.Text = dataGridView1.CurrentRow.Cells["ProjeAdi"].Value.ToString();
            //txtFirmaAdi.Text = dataGridView1.CurrentRow.Cells["FirmaAdi"].Value.ToString();




        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void txtProjeAdi_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
