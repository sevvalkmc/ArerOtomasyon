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
    public partial class frmTamamlananProjeler : Form
    {
        public frmTamamlananProjeler()
        {
            InitializeComponent();
        }
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
        }
        private void frmTamamlananProjeler_Load(object sender, EventArgs e)
        {
            AddToGrid(Values);

        }

        
    }
}
