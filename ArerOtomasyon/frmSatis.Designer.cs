
using System;
using System.Windows.Forms;

namespace ArerOtomasyon
{
    partial class frmSatis
    {
        private const int V = 29;

        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxİşlemler = new System.Windows.Forms.GroupBox();
            this.txtMalzSatis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboKat = new System.Windows.Forms.ComboBox();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKoliNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.txtÖzellik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ÜrünKodutxt = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnGünc = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAraSepet = new System.Windows.Forms.Label();
            this.txtSepetLisAra = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSatışEkleme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.sepetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arerOtomasyonDataSet1 = new ArerOtomasyon.ArerOtomasyonDataSet1();
            this.sepetTableAdapter = new ArerOtomasyon.ArerOtomasyonDataSet1TableAdapters.sepetTableAdapter();
            this.tableAdapterManager = new ArerOtomasyon.ArerOtomasyonDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxİşlemler.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arerOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(575, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1427, 789);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBoxİşlemler
            // 
            this.groupBoxİşlemler.Controls.Add(this.txtMalzSatis);
            this.groupBoxİşlemler.Controls.Add(this.label7);
            this.groupBoxİşlemler.Controls.Add(this.comboKat);
            this.groupBoxİşlemler.Controls.Add(this.txtProjeAdi);
            this.groupBoxİşlemler.Controls.Add(this.label1);
            this.groupBoxİşlemler.Controls.Add(this.txtAçıklama);
            this.groupBoxİşlemler.Controls.Add(this.label11);
            this.groupBoxİşlemler.Controls.Add(this.txtKoliNo);
            this.groupBoxİşlemler.Controls.Add(this.label10);
            this.groupBoxİşlemler.Controls.Add(this.label9);
            this.groupBoxİşlemler.Controls.Add(this.txtMiktarı);
            this.groupBoxİşlemler.Controls.Add(this.txtÖzellik);
            this.groupBoxİşlemler.Controls.Add(this.label3);
            this.groupBoxİşlemler.Controls.Add(this.label4);
            this.groupBoxİşlemler.Controls.Add(this.label5);
            this.groupBoxİşlemler.Controls.Add(this.label6);
            this.groupBoxİşlemler.Controls.Add(this.ÜrünKodutxt);
            this.groupBoxİşlemler.Controls.Add(this.txtBarkodNo);
            this.groupBoxİşlemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxİşlemler.Location = new System.Drawing.Point(66, 73);
            this.groupBoxİşlemler.Name = "groupBoxİşlemler";
            this.groupBoxİşlemler.Size = new System.Drawing.Size(428, 811);
            this.groupBoxİşlemler.TabIndex = 2;
            this.groupBoxİşlemler.TabStop = false;
            this.groupBoxİşlemler.Text = "Malzeme Girişi";
            this.groupBoxİşlemler.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMalzSatis
            // 
            this.txtMalzSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzSatis.Location = new System.Drawing.Point(214, 49);
            this.txtMalzSatis.Multiline = true;
            this.txtMalzSatis.Name = "txtMalzSatis";
            this.txtMalzSatis.Size = new System.Drawing.Size(173, 27);
            this.txtMalzSatis.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(98, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Proje Adı";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // comboKat
            // 
            this.comboKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKat.FormattingEnabled = true;
            this.comboKat.Location = new System.Drawing.Point(214, 143);
            this.comboKat.Name = "comboKat";
            this.comboKat.Size = new System.Drawing.Size(173, 28);
            this.comboKat.TabIndex = 0;
            this.comboKat.SelectedIndexChanged += new System.EventHandler(this.comboKat_SelectedIndexChanged);
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeAdi.Location = new System.Drawing.Point(214, 332);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(173, 27);
            this.txtProjeAdi.TabIndex = 59;
            this.txtProjeAdi.TextChanged += new System.EventHandler(this.txtProjeAdi_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Malzeme Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAçıklama.Location = new System.Drawing.Point(43, 556);
            this.txtAçıklama.Multiline = true;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Size = new System.Drawing.Size(344, 216);
            this.txtAçıklama.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(51, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Özellik";
            // 
            // txtKoliNo
            // 
            this.txtKoliNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoliNo.Location = new System.Drawing.Point(214, 285);
            this.txtKoliNo.Name = "txtKoliNo";
            this.txtKoliNo.Size = new System.Drawing.Size(173, 27);
            this.txtKoliNo.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(51, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Açıklama";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(114, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Koli No";
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktarı.Location = new System.Drawing.Point(214, 238);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(173, 27);
            this.txtMiktarı.TabIndex = 5;
            // 
            // txtÖzellik
            // 
            this.txtÖzellik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÖzellik.Location = new System.Drawing.Point(43, 426);
            this.txtÖzellik.Multiline = true;
            this.txtÖzellik.Name = "txtÖzellik";
            this.txtÖzellik.Size = new System.Drawing.Size(344, 80);
            this.txtÖzellik.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(123, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ürün Kodu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(124, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(87, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Barkod No";
            // 
            // ÜrünKodutxt
            // 
            this.ÜrünKodutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜrünKodutxt.Location = new System.Drawing.Point(214, 191);
            this.ÜrünKodutxt.Name = "ÜrünKodutxt";
            this.ÜrünKodutxt.Size = new System.Drawing.Size(173, 27);
            this.ÜrünKodutxt.TabIndex = 7;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(214, 96);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(173, 27);
            this.txtBarkodNo.TabIndex = 9;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // btnGünc
            // 
            this.btnGünc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGünc.Location = new System.Drawing.Point(215, 908);
            this.btnGünc.Name = "btnGünc";
            this.btnGünc.Size = new System.Drawing.Size(122, 42);
            this.btnGünc.TabIndex = 4;
            this.btnGünc.Text = "Güncelle";
            this.btnGünc.UseVisualStyleBackColor = true;
            this.btnGünc.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(17, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // lblAraSepet
            // 
            this.lblAraSepet.AutoSize = true;
            this.lblAraSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraSepet.Location = new System.Drawing.Point(587, 85);
            this.lblAraSepet.Name = "lblAraSepet";
            this.lblAraSepet.Size = new System.Drawing.Size(42, 24);
            this.lblAraSepet.TabIndex = 37;
            this.lblAraSepet.Text = "Ara";
            // 
            // txtSepetLisAra
            // 
            this.txtSepetLisAra.Location = new System.Drawing.Point(635, 87);
            this.txtSepetLisAra.Name = "txtSepetLisAra";
            this.txtSepetLisAra.Size = new System.Drawing.Size(218, 22);
            this.txtSepetLisAra.TabIndex = 36;
            this.txtSepetLisAra.TextChanged += new System.EventHandler(this.txtürünLisAra_TextChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(372, 908);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 42);
            this.button6.TabIndex = 38;
            this.button6.Text = "Sil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSatışEkleme
            // 
            this.btnSatışEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışEkleme.Location = new System.Drawing.Point(66, 908);
            this.btnSatışEkleme.Name = "btnSatışEkleme";
            this.btnSatışEkleme.Size = new System.Drawing.Size(122, 42);
            this.btnSatışEkleme.TabIndex = 39;
            this.btnSatışEkleme.Text = "Ekle";
            this.btnSatışEkleme.UseVisualStyleBackColor = true;
            this.btnSatışEkleme.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1764, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(920, 260);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 27);
            this.txtID.TabIndex = 57;
            // 
            // sepetBindingSource
            // 
            this.sepetBindingSource.DataMember = "sepet";
            this.sepetBindingSource.DataSource = this.arerOtomasyonDataSet1;
            // 
            // arerOtomasyonDataSet1
            // 
            this.arerOtomasyonDataSet1.DataSetName = "ArerOtomasyonDataSet1";
            this.arerOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetTableAdapter
            // 
            this.sepetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.anasayfaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.firmaTableAdapter = null;
            this.tableAdapterManager.kategoribilgileriTableAdapter = null;
            this.tableAdapterManager.markabilgileriTableAdapter = null;
            this.tableAdapterManager.ProjeMalzemeTableAdapter = null;
            this.tableAdapterManager.projeTableAdapter = null;
            this.tableAdapterManager.sepetTableAdapter = this.sepetTableAdapter;
            this.tableAdapterManager.UpdateOrder = ArerOtomasyon.ArerOtomasyonDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urun_TableAdapter = null;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(706, 180);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(839, 615);
            this.dataGridView2.TabIndex = 58;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 972);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSatışEkleme);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblAraSepet);
            this.Controls.Add(this.btnGünc);
            this.Controls.Add(this.txtSepetLisAra);
            this.Controls.Add(this.groupBoxİşlemler);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxİşlemler.ResumeLayout(false);
            this.groupBoxİşlemler.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arerOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxİşlemler;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.TextBox txtÖzellik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ÜrünKodutxt;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnGünc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKoliNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAraSepet;
        private System.Windows.Forms.TextBox txtSepetLisAra;
        private System.Windows.Forms.ComboBox comboKat;
        private System.Windows.Forms.Button button6;
        private Button btnSatışEkleme;
        private PictureBox pictureBox1;
        private TextBox txtMalzSatis;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtID;
        private ArerOtomasyonDataSet1 arerOtomasyonDataSet1;
        private BindingSource sepetBindingSource;
        private ArerOtomasyonDataSet1TableAdapters.sepetTableAdapter sepetTableAdapter;
        private ArerOtomasyonDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public DataGridView dataGridView2;
        private Label label7;
        private TextBox txtProjeAdi;
    }
}

