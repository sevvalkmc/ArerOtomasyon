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
    public partial class frmAnaSayfa : Form
    {
        public bool isComplete;
                    List<CommonValue> CV = new List<CommonValue>();
        public frmAnaSayfa()
        {
            InitializeComponent();
            //Çağrı InitializeComponent()(genellikle, en azından varsayılan oluşturucu denir Windowve UserControl) gerçekten kontrol(yerine ilk tahmin olarak hedef hiyerarşi kadar bir çağrı) kısmi sınıf için bir yöntem çağrıdır.
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
        DataSet daset = new DataSet();
        //bool durum;
        //private TextBox item;

        /*private void anasayfalistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from projefirma", baglanti);
            adtr.Fill(daset, "projefirma");

            dataGridView2.DataSource = daset.Tables["projefirma"];
            dataGridView2.Columns[1].Width = 30;
            dataGridView2.Columns[2].Width = 200;
            dataGridView2.Columns[3].Width = 200;

            baglanti.Close();

        }*/
        /*private void anasayfalistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 29;
            dataGridView1.Columns[2].Width = 225;
            dataGridView1.Columns[3].Width = 225;
            baglanti.Close();

        }
        /*private void anasayfalistele2()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView2.DataSource = daset.Tables["sepet"];
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            dataGridView2.Columns[12].Visible = false;
            dataGridView2.Columns[0].Width = 30;
            dataGridView2.Columns[1].Width = 275;
            dataGridView2.Columns[2].Width = 275;
            baglanti.Close();

        }*/

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            //anasayfalistele();

            checkBox1.Checked = true;

            /*if (Properties.Settings.Default.boxChecked)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            anasayfalistele();
            //anasayfalistele2();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProjeMalzeme malzeme = new frmProjeMalzeme();
            malzeme.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmKategori kategri = new frmKategori();
            kategri.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmFirmaEkle ekle = new frmFirmaEkle();
            ekle.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            frmSatis ikincianasayfa = new frmSatis();
            ikincianasayfa.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

            /*if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == true)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }*/
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtAnaSayfaAra_TextChanged(object sender, EventArgs e)
        {
            /*System.Data.DataTable tablo = new System.Data.DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from projefirma where (ProjeAdi+FirmaAdi) like '%" + txtAnaSayfaAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();*/
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProjeAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirmaAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            /*if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == true)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }*/

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.Name == "Boolean" && e.ColumnIndex == 0)
            {
                int rowIndex = dataGridView1.Rows.Add();
                for (int colCtr = 1; colCtr < dataGridView1.Columns.Count; colCtr++)
                {
                    dataGridView1.Rows[rowIndex].Cells[colCtr - 1].Value = dataGridView1.Rows[e.RowIndex].Cells[colCtr].Value;
                }
                dataGridView1.Rows[rowIndex].Visible = true;
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select ID, ProjeAdi, FirmaAdi From projefirma", baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);*/


            /*SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select ID, ProjeAdi, FirmaAdi From projefirma",baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
            }*/
            /*for (int n = 0; n < dataGridView1.Rows.Count; n++)
                {
                    if (dataGridView1.Rows[n+1].Cells[1].Value.ToString() == dataGridView1.Rows[n + 2].Cells[2].Value.ToString())
                    {
                         dataGridView1.AllowUserToAddRows = false;         
                }
                }*/
            MessageBox.Show("Kayıt başarıyla tamamlandı!");
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*if(e.ColumnIndex == 1 && e.RowIndex != -1)
            {
               // CV.Add(e.RowIndex);
            }

            /*DataGridViewCheckBoxCell checkedCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Column1"];

            bool isEnabled = false;
            if (checkedCell.AccessibilityObject.State.HasFlag(AccessibleStates.Checked))
            {
                isEnabled = true;
            }
            if (isEnabled)
            {
                // do your business process;
            }*/

            /*if (dataGridView1.CurrentCell.GetType() != typeof(DataGridViewCheckBoxCell))
                return;
            if (!dataGridView1.CurrentCell.IsInEditMode)
                return;
            if (!dataGridView1.IsCurrentCellDirty)
                return;
            dataGridView1.EndEdit();*/


            /*if (dataGridView1.Columns[e.ColumnIndex].Name == "IsSelected" && dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
            {
                bool isChecked = (bool)dataGridView1[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                if (isChecked == false)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["Tamamlandı"].Value = "";
                }
                dataGridView1.EndEdit();
            }*/
            /*// Remove focus
            dataGridView1.CurrentCell = null;
            // Put in updates
            Update();*/

        }

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            /*if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }*/
        }

        private void chkItems_CheckedChanged(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    chk.Value = chk.TrueValue;
                }
                else
                {
                    chk.Value = chk.FalseValue;
                }

            }
            dataGridView2.EndEdit();*/
            //Properties.Settings.Default.boxChecked = true;
            //Properties.Settings.Default.Save();
        }

        private void btnProjeBitsin_Click(object sender, EventArgs e)
        {
            frmProjeFirma projeFirma = new frmProjeFirma();
            projeFirma.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-173EPB2\\SQLEXPRESS;Initial Catalog=ArerOtomasyon;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select ID, ProjeAdi, FirmaAdi From projefirma", baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
                }
                //chkEntregue.CheckState = CheckState.Checked;
                //if (DataGridBoolColumn==true)
            }
        }


        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            /*if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }*/
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.EndEdit();  //Stop editing of cell.
            //MessageBox.Show("0 = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            //dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*if (e.ColumnIndex == Column1.Index && e.RowIndex != -1)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

                // Handle checkbox state change here
            }*/
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex != dataGridView2.Columns["Tamamlandı"].Index || e.RowIndex < 0)
            //return;

            /*Properties.Settings.Default.boxChecked = true;
            Properties.Settings.Default.Save();*/

        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
                var i = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        i++;
                    }
                }

                //Enable Button1 if Checkbox is Checked
                if (i > 0)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
            }*/
            //if (e.ColumnIndex == dataGridView1.Columns["Tamamlandı"].Index && e.RowIndex >= 0)
            //  dataGridView1.EndEdit();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //chkEntregue.CheckState = CheckState.Checked;
            //if (DataGridBoolColumn==true)
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<CommonValue> CV = new List<CommonValue>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == true)
                {
                    CV.Add(new CommonValue
                    {
                        //Tamamlandı = item.Cells[0].Value.ToString(),
                        ID = item.Cells[1].Value.ToString(),
                        ProjeAdi = item.Cells[2].Value.ToString(),
                        FirmaAdi = item.Cells[3].Value.ToString()

                    });
                }
            }
            frmTamamlananProjeler frm = new frmTamamlananProjeler();
            frm.Values = CV;
            frm.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<CommonValue> CV = new List<CommonValue>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {
                    CV.Add(new CommonValue
                    {
                        //Tamamlandı = item.Cells[0].Value.ToString(),
                        ID = item.Cells[1].Value.ToString(),
                        ProjeAdi = item.Cells[2].Value.ToString(),
                        FirmaAdi = item.Cells[3].Value.ToString()

                    });
                }
            }
            frmTamamlanmayanProjeler frm = new frmTamamlanmayanProjeler();
            frm.Values = CV;
            frm.ShowDialog();
        }

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        { 
           if (dataGridView2.CurrentCell.GetType() != typeof(DataGridViewCheckBoxCell))
                return;
            if (!dataGridView2.CurrentCell.IsInEditMode)
                return;
            if (!dataGridView2.IsCurrentCellDirty)
                return;
            dataGridView2.EndEdit();

        }*/

        /* private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
     {
         //SendKeys.Send("{tab}");

         /* if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
          {
              DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)dataGridView1.CurrentCell;
              if ((byte)cb.Value == 1)
              {
                  dataGridView1.CurrentRow.Cells["Tamamlandı"].Value = DateTime.Now.ToString();
              }
          }
          dataGridView1.EndEdit();
      }*/
        /*private void dataGridView1_Sorted(object sender, EventArgs e)
       {
           this.dataGridView1.FirstDisplayedCell = this.dataGridView1.CurrentCell;
        }*/
        /*private void RepositoryItemCheckEdit1_EditValueChanged(object sender, System.EventArgs e)
       {
        dataGridView23.PostEditor();

        var isNoneOfTheAboveChecked = false;

        for (int i = 0; i < dataGridView23.DataRowCount; i++)
        {
            if ((bool) (dataGridView23.GetRowCellValue(i, "NoneOfTheAbove")) && (bool) (dataGridView23.GetRowCellValue(i, "Answer")))
            {
                isNoneOfTheAboveChecked = true;
                break;
            }
        }

        if (isNoneOfTheAboveChecked)
        {
            for (int i = 0; i < dataGridView23.DataRowCount; i++)
            {
                if (!((bool)(dataGridView23.GetRowCellValue(i, "NoneOfTheAbove"))))
                {
                    dataGridView23.SetRowCellValue(i, "Answer", false);
                }
            }
        }
    }*/


        /*void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.GetType() != typeof(DataGridViewCheckBoxCell))
                return;
            if (!dataGridView2.CurrentCell.IsInEditMode)
                return;
            if (!dataGridView2.IsCurrentCellDirty)
                return;
            dataGridView2.EndEdit();
        }

        void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Tamamlandı"].Index && e.RowIndex >= 0)
                dataGridView2.EndEdit();
        }

        void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dataGridView2.Columns["Tamamlandı"].Index || e.RowIndex < 0)
                return;

            // Do your stuff here.

        }*/




        /*private void dataGridView2_CellMouseUp_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           if (e.ColumnIndex == dataGridView2.Columns["Tamamlandı"].Index && e.RowIndex >= 0)
              dataGridView2.EndEdit();
        } */

    }
    }


