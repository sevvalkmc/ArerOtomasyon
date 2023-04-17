
namespace ArerOtomasyon
{
    partial class frmProjeMalzeme
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
            this.lblAraSepet = new System.Windows.Forms.Label();
            this.txtProjeMalzemeAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAraSepet
            // 
            this.lblAraSepet.AutoSize = true;
            this.lblAraSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraSepet.Location = new System.Drawing.Point(97, 76);
            this.lblAraSepet.Name = "lblAraSepet";
            this.lblAraSepet.Size = new System.Drawing.Size(187, 24);
            this.lblAraSepet.TabIndex = 39;
            this.lblAraSepet.Text = "Malzeme/Proje Ara";
            this.lblAraSepet.Click += new System.EventHandler(this.lblAraSepet_Click);
            // 
            // txtProjeMalzemeAra
            // 
            this.txtProjeMalzemeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeMalzemeAra.Location = new System.Drawing.Point(305, 73);
            this.txtProjeMalzemeAra.Multiline = true;
            this.txtProjeMalzemeAra.Name = "txtProjeMalzemeAra";
            this.txtProjeMalzemeAra.Size = new System.Drawing.Size(294, 27);
            this.txtProjeMalzemeAra.TabIndex = 38;
            this.txtProjeMalzemeAra.TextChanged += new System.EventHandler(this.txtProjeMalzemeAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 569);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmProjeMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 758);
            this.Controls.Add(this.lblAraSepet);
            this.Controls.Add(this.txtProjeMalzemeAra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProjeMalzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Malzeme Sayfası";
            this.Load += new System.EventHandler(this.frmProjeMalzeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAraSepet;
        private System.Windows.Forms.TextBox txtProjeMalzemeAra;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}