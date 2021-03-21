
namespace AK8PO
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.databaseUTBDataSet32 = new AK8PO.DatabaseUTBDataSet32();
            this.databaseUTBDataSet32BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stitkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stitkyTableAdapter = new AK8PO.DatabaseUTBDataSet32TableAdapters.StitkyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stitekcisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetstudentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocethodinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocettydnuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vyucujiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkratkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typstitkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jazykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetboduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poznamkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseUTBDataSet32
            // 
            this.databaseUTBDataSet32.DataSetName = "DatabaseUTBDataSet32";
            this.databaseUTBDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseUTBDataSet32BindingSource
            // 
            this.databaseUTBDataSet32BindingSource.DataSource = this.databaseUTBDataSet32;
            this.databaseUTBDataSet32BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stitekcisloDataGridViewTextBoxColumn,
            this.pocetstudentuDataGridViewTextBoxColumn,
            this.pocethodinDataGridViewTextBoxColumn,
            this.pocettydnuDataGridViewTextBoxColumn,
            this.vyucujiciDataGridViewTextBoxColumn,
            this.zkratkaDataGridViewTextBoxColumn,
            this.typstitkuDataGridViewTextBoxColumn,
            this.jazykDataGridViewTextBoxColumn,
            this.pocetboduDataGridViewTextBoxColumn,
            this.poznamkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stitkyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(893, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // stitkyBindingSource
            // 
            this.stitkyBindingSource.DataMember = "Stitky";
            this.stitkyBindingSource.DataSource = this.databaseUTBDataSet32BindingSource;
            // 
            // stitkyTableAdapter
            // 
            this.stitkyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stitekcisloDataGridViewTextBoxColumn
            // 
            this.stitekcisloDataGridViewTextBoxColumn.DataPropertyName = "stitek_cislo";
            this.stitekcisloDataGridViewTextBoxColumn.HeaderText = "stitek_cislo";
            this.stitekcisloDataGridViewTextBoxColumn.Name = "stitekcisloDataGridViewTextBoxColumn";
            this.stitekcisloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pocetstudentuDataGridViewTextBoxColumn
            // 
            this.pocetstudentuDataGridViewTextBoxColumn.DataPropertyName = "pocet_studentu";
            this.pocetstudentuDataGridViewTextBoxColumn.HeaderText = "pocet_studentu";
            this.pocetstudentuDataGridViewTextBoxColumn.Name = "pocetstudentuDataGridViewTextBoxColumn";
            this.pocetstudentuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pocethodinDataGridViewTextBoxColumn
            // 
            this.pocethodinDataGridViewTextBoxColumn.DataPropertyName = "pocet_hodin";
            this.pocethodinDataGridViewTextBoxColumn.HeaderText = "pocet_hodin";
            this.pocethodinDataGridViewTextBoxColumn.Name = "pocethodinDataGridViewTextBoxColumn";
            this.pocethodinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pocettydnuDataGridViewTextBoxColumn
            // 
            this.pocettydnuDataGridViewTextBoxColumn.DataPropertyName = "pocet_tydnu";
            this.pocettydnuDataGridViewTextBoxColumn.HeaderText = "pocet_tydnu";
            this.pocettydnuDataGridViewTextBoxColumn.Name = "pocettydnuDataGridViewTextBoxColumn";
            this.pocettydnuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vyucujiciDataGridViewTextBoxColumn
            // 
            this.vyucujiciDataGridViewTextBoxColumn.DataPropertyName = "vyucujici";
            this.vyucujiciDataGridViewTextBoxColumn.HeaderText = "vyucujici";
            this.vyucujiciDataGridViewTextBoxColumn.Name = "vyucujiciDataGridViewTextBoxColumn";
            this.vyucujiciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zkratkaDataGridViewTextBoxColumn
            // 
            this.zkratkaDataGridViewTextBoxColumn.DataPropertyName = "zkratka";
            this.zkratkaDataGridViewTextBoxColumn.HeaderText = "zkratka";
            this.zkratkaDataGridViewTextBoxColumn.Name = "zkratkaDataGridViewTextBoxColumn";
            this.zkratkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typstitkuDataGridViewTextBoxColumn
            // 
            this.typstitkuDataGridViewTextBoxColumn.DataPropertyName = "typ_stitku";
            this.typstitkuDataGridViewTextBoxColumn.HeaderText = "typ_stitku";
            this.typstitkuDataGridViewTextBoxColumn.Name = "typstitkuDataGridViewTextBoxColumn";
            this.typstitkuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jazykDataGridViewTextBoxColumn
            // 
            this.jazykDataGridViewTextBoxColumn.DataPropertyName = "jazyk";
            this.jazykDataGridViewTextBoxColumn.HeaderText = "jazyk";
            this.jazykDataGridViewTextBoxColumn.Name = "jazykDataGridViewTextBoxColumn";
            this.jazykDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pocetboduDataGridViewTextBoxColumn
            // 
            this.pocetboduDataGridViewTextBoxColumn.DataPropertyName = "pocet_bodu";
            this.pocetboduDataGridViewTextBoxColumn.HeaderText = "pocet_bodu";
            this.pocetboduDataGridViewTextBoxColumn.Name = "pocetboduDataGridViewTextBoxColumn";
            this.pocetboduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poznamkaDataGridViewTextBoxColumn
            // 
            this.poznamkaDataGridViewTextBoxColumn.DataPropertyName = "poznamka";
            this.poznamkaDataGridViewTextBoxColumn.HeaderText = "poznamka";
            this.poznamkaDataGridViewTextBoxColumn.Name = "poznamkaDataGridViewTextBoxColumn";
            this.poznamkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 523);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource databaseUTBDataSet32BindingSource;
        private DatabaseUTBDataSet32 databaseUTBDataSet32;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stitkyBindingSource;
        private DatabaseUTBDataSet32TableAdapters.StitkyTableAdapter stitkyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stitekcisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetstudentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocethodinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocettydnuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vyucujiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typstitkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jazykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetboduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poznamkaDataGridViewTextBoxColumn;
    }
}