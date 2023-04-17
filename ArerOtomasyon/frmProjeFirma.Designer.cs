
namespace ArerOtomasyon
{
    partial class frmProjeFirma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.btnSatışEkleme = new System.Windows.Forms.Button();
            this.txtMalzSatis = new System.Windows.Forms.TextBox();
            this.btnSill = new System.Windows.Forms.Button();
            this.lblAraSepet = new System.Windows.Forms.Label();
            this.txtAnaSayfaAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(69, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Firma Adı";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(174, 227);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(173, 27);
            this.txtFirmaAdi.TabIndex = 65;
            this.txtFirmaAdi.TextChanged += new System.EventHandler(this.txtFirmaAdi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Proje Adı";
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeAdi.Location = new System.Drawing.Point(174, 184);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(173, 27);
            this.txtProjeAdi.TabIndex = 63;
            this.txtProjeAdi.TextChanged += new System.EventHandler(this.txtProjeAdi_TextChanged);
            // 
            // btnSatışEkleme
            // 
            this.btnSatışEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışEkleme.Location = new System.Drawing.Point(174, 281);
            this.btnSatışEkleme.Name = "btnSatışEkleme";
            this.btnSatışEkleme.Size = new System.Drawing.Size(122, 42);
            this.btnSatışEkleme.TabIndex = 67;
            this.btnSatışEkleme.Text = "Ekle";
            this.btnSatışEkleme.UseVisualStyleBackColor = true;
            this.btnSatışEkleme.Click += new System.EventHandler(this.btnSatışEkleme_Click);
            // 
            // txtMalzSatis
            // 
            this.txtMalzSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzSatis.Location = new System.Drawing.Point(457, 323);
            this.txtMalzSatis.Multiline = true;
            this.txtMalzSatis.Name = "txtMalzSatis";
            this.txtMalzSatis.Size = new System.Drawing.Size(173, 27);
            this.txtMalzSatis.TabIndex = 68;
            // 
            // btnSill
            // 
            this.btnSill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSill.Location = new System.Drawing.Point(912, 558);
            this.btnSill.Name = "btnSill";
            this.btnSill.Size = new System.Drawing.Size(122, 37);
            this.btnSill.TabIndex = 69;
            this.btnSill.Text = "Sil";
            this.btnSill.UseVisualStyleBackColor = true;
            this.btnSill.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAraSepet
            // 
            this.lblAraSepet.AutoSize = true;
            this.lblAraSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraSepet.Location = new System.Drawing.Point(403, 89);
            this.lblAraSepet.Name = "lblAraSepet";
            this.lblAraSepet.Size = new System.Drawing.Size(42, 24);
            this.lblAraSepet.TabIndex = 71;
            this.lblAraSepet.Text = "Ara";
            // 
            // txtAnaSayfaAra
            // 
            this.txtAnaSayfaAra.Location = new System.Drawing.Point(451, 89);
            this.txtAnaSayfaAra.Multiline = true;
            this.txtAnaSayfaAra.Name = "txtAnaSayfaAra";
            this.txtAnaSayfaAra.Size = new System.Drawing.Size(243, 27);
            this.txtAnaSayfaAra.TabIndex = 70;
            this.txtAnaSayfaAra.TextChanged += new System.EventHandler(this.txtAnaSayfaAra_TextChanged);
            // 
            // frmProjeFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 672);
            this.Controls.Add(this.lblAraSepet);
            this.Controls.Add(this.txtAnaSayfaAra);
            this.Controls.Add(this.btnSill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMalzSatis);
            this.Controls.Add(this.btnSatışEkleme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProjeAdi);
            this.Name = "frmProjeFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProjeFirma";
            this.Load += new System.EventHandler(this.frmProjeFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.Button btnSatışEkleme;
        private System.Windows.Forms.TextBox txtMalzSatis;
        private System.Windows.Forms.Button btnSill;
        private System.Windows.Forms.Label lblAraSepet;
        private System.Windows.Forms.TextBox txtAnaSayfaAra;
    }
}