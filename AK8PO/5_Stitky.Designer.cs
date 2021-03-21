
namespace AK8PO
{
    partial class Stitky
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboZamestnanec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPredmet = new System.Windows.Forms.ComboBox();
            this.generujStitkyButton = new System.Windows.Forms.Button();
            this.generujStitkyPopis = new System.Windows.Forms.Label();
            this.dataStitky = new System.Windows.Forms.DataGridView();
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
            this.stitkyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet32BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet32 = new AK8PO.DatabaseUTBDataSet32();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet25 = new AK8PO.DatabaseUTBDataSet25();
            this.typStitkuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet26 = new AK8PO.DatabaseUTBDataSet26();
            this.jazykBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet27 = new AK8PO.DatabaseUTBDataSet27();
            this.stitkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet24 = new AK8PO.DatabaseUTBDataSet24();
            this.stitkyTableAdapter = new AK8PO.DatabaseUTBDataSet24TableAdapters.StitkyTableAdapter();
            this.predmetTableAdapter = new AK8PO.DatabaseUTBDataSet25TableAdapters.PredmetTableAdapter();
            this.typStitkuTableAdapter = new AK8PO.DatabaseUTBDataSet26TableAdapters.TypStitkuTableAdapter();
            this.jazykTableAdapter = new AK8PO.DatabaseUTBDataSet27TableAdapters.JazykTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataStitky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typStitkuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazykBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet24)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(939, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zpět do hlavní nabídky";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ZpetNaHlavni);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pracovní štítky zaměstnanců UTB";
            // 
            // comboZamestnanec
            // 
            this.comboZamestnanec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZamestnanec.DropDownWidth = 150;
            this.comboZamestnanec.FormattingEnabled = true;
            this.comboZamestnanec.Location = new System.Drawing.Point(76, 72);
            this.comboZamestnanec.Name = "comboZamestnanec";
            this.comboZamestnanec.Size = new System.Drawing.Size(333, 21);
            this.comboZamestnanec.TabIndex = 10;
            this.comboZamestnanec.SelectedIndexChanged += new System.EventHandler(this.VyberZamestnance);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vyučující:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Zkratka předmětu:";
            // 
            // comboPredmet
            // 
            this.comboPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPredmet.DropDownWidth = 150;
            this.comboPredmet.FormattingEnabled = true;
            this.comboPredmet.Location = new System.Drawing.Point(120, 109);
            this.comboPredmet.Name = "comboPredmet";
            this.comboPredmet.Size = new System.Drawing.Size(141, 21);
            this.comboPredmet.TabIndex = 12;
            this.comboPredmet.SelectedIndexChanged += new System.EventHandler(this.VyberPredmet);
            // 
            // generujStitkyButton
            // 
            this.generujStitkyButton.Location = new System.Drawing.Point(286, 109);
            this.generujStitkyButton.Name = "generujStitkyButton";
            this.generujStitkyButton.Size = new System.Drawing.Size(123, 38);
            this.generujStitkyButton.TabIndex = 18;
            this.generujStitkyButton.Text = "Generovat štítky";
            this.generujStitkyButton.UseVisualStyleBackColor = true;
            this.generujStitkyButton.Visible = false;
            this.generujStitkyButton.Click += new System.EventHandler(this.GenerujStitkyPredmet);
            // 
            // generujStitkyPopis
            // 
            this.generujStitkyPopis.AutoSize = true;
            this.generujStitkyPopis.Location = new System.Drawing.Point(227, 151);
            this.generujStitkyPopis.Name = "generujStitkyPopis";
            this.generujStitkyPopis.Size = new System.Drawing.Size(233, 13);
            this.generujStitkyPopis.TabIndex = 19;
            this.generujStitkyPopis.Text = "Pokud je zvolen vyučující vygenerují se pro něj";
            this.generujStitkyPopis.Visible = false;
            // 
            // dataStitky
            // 
            this.dataStitky.AllowUserToAddRows = false;
            this.dataStitky.AllowUserToDeleteRows = false;
            this.dataStitky.AutoGenerateColumns = false;
            this.dataStitky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStitky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataStitky.DataSource = this.stitkyBindingSource1;
            this.dataStitky.Location = new System.Drawing.Point(24, 281);
            this.dataStitky.MultiSelect = false;
            this.dataStitky.Name = "dataStitky";
            this.dataStitky.ReadOnly = true;
            this.dataStitky.RowHeadersVisible = false;
            this.dataStitky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStitky.Size = new System.Drawing.Size(1147, 468);
            this.dataStitky.TabIndex = 22;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // stitekcisloDataGridViewTextBoxColumn
            // 
            this.stitekcisloDataGridViewTextBoxColumn.DataPropertyName = "stitek_cislo";
            this.stitekcisloDataGridViewTextBoxColumn.HeaderText = "Číslo";
            this.stitekcisloDataGridViewTextBoxColumn.Name = "stitekcisloDataGridViewTextBoxColumn";
            this.stitekcisloDataGridViewTextBoxColumn.ReadOnly = true;
            this.stitekcisloDataGridViewTextBoxColumn.Width = 50;
            // 
            // pocetstudentuDataGridViewTextBoxColumn
            // 
            this.pocetstudentuDataGridViewTextBoxColumn.DataPropertyName = "pocet_studentu";
            this.pocetstudentuDataGridViewTextBoxColumn.HeaderText = "Studentů";
            this.pocetstudentuDataGridViewTextBoxColumn.Name = "pocetstudentuDataGridViewTextBoxColumn";
            this.pocetstudentuDataGridViewTextBoxColumn.ReadOnly = true;
            this.pocetstudentuDataGridViewTextBoxColumn.Width = 60;
            // 
            // pocethodinDataGridViewTextBoxColumn
            // 
            this.pocethodinDataGridViewTextBoxColumn.DataPropertyName = "pocet_hodin";
            this.pocethodinDataGridViewTextBoxColumn.HeaderText = "Hodin";
            this.pocethodinDataGridViewTextBoxColumn.Name = "pocethodinDataGridViewTextBoxColumn";
            this.pocethodinDataGridViewTextBoxColumn.ReadOnly = true;
            this.pocethodinDataGridViewTextBoxColumn.Width = 40;
            // 
            // pocettydnuDataGridViewTextBoxColumn
            // 
            this.pocettydnuDataGridViewTextBoxColumn.DataPropertyName = "pocet_tydnu";
            this.pocettydnuDataGridViewTextBoxColumn.HeaderText = "Týdnů";
            this.pocettydnuDataGridViewTextBoxColumn.Name = "pocettydnuDataGridViewTextBoxColumn";
            this.pocettydnuDataGridViewTextBoxColumn.ReadOnly = true;
            this.pocettydnuDataGridViewTextBoxColumn.Width = 40;
            // 
            // vyucujiciDataGridViewTextBoxColumn
            // 
            this.vyucujiciDataGridViewTextBoxColumn.DataPropertyName = "vyucujici";
            this.vyucujiciDataGridViewTextBoxColumn.FillWeight = 250F;
            this.vyucujiciDataGridViewTextBoxColumn.HeaderText = "Vyučující";
            this.vyucujiciDataGridViewTextBoxColumn.Name = "vyucujiciDataGridViewTextBoxColumn";
            this.vyucujiciDataGridViewTextBoxColumn.ReadOnly = true;
            this.vyucujiciDataGridViewTextBoxColumn.Width = 250;
            // 
            // zkratkaDataGridViewTextBoxColumn
            // 
            this.zkratkaDataGridViewTextBoxColumn.DataPropertyName = "zkratka";
            this.zkratkaDataGridViewTextBoxColumn.FillWeight = 40F;
            this.zkratkaDataGridViewTextBoxColumn.HeaderText = "Předmět";
            this.zkratkaDataGridViewTextBoxColumn.Name = "zkratkaDataGridViewTextBoxColumn";
            this.zkratkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zkratkaDataGridViewTextBoxColumn.Width = 60;
            // 
            // typstitkuDataGridViewTextBoxColumn
            // 
            this.typstitkuDataGridViewTextBoxColumn.DataPropertyName = "typ_stitku";
            this.typstitkuDataGridViewTextBoxColumn.HeaderText = "Typ štítku";
            this.typstitkuDataGridViewTextBoxColumn.Name = "typstitkuDataGridViewTextBoxColumn";
            this.typstitkuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jazykDataGridViewTextBoxColumn
            // 
            this.jazykDataGridViewTextBoxColumn.DataPropertyName = "jazyk";
            this.jazykDataGridViewTextBoxColumn.FillWeight = 40F;
            this.jazykDataGridViewTextBoxColumn.HeaderText = "Jazyk";
            this.jazykDataGridViewTextBoxColumn.Name = "jazykDataGridViewTextBoxColumn";
            this.jazykDataGridViewTextBoxColumn.ReadOnly = true;
            this.jazykDataGridViewTextBoxColumn.Width = 40;
            // 
            // pocetboduDataGridViewTextBoxColumn
            // 
            this.pocetboduDataGridViewTextBoxColumn.DataPropertyName = "pocet_bodu";
            this.pocetboduDataGridViewTextBoxColumn.FillWeight = 40F;
            this.pocetboduDataGridViewTextBoxColumn.HeaderText = "Body";
            this.pocetboduDataGridViewTextBoxColumn.Name = "pocetboduDataGridViewTextBoxColumn";
            this.pocetboduDataGridViewTextBoxColumn.ReadOnly = true;
            this.pocetboduDataGridViewTextBoxColumn.Width = 40;
            // 
            // poznamkaDataGridViewTextBoxColumn
            // 
            this.poznamkaDataGridViewTextBoxColumn.DataPropertyName = "poznamka";
            this.poznamkaDataGridViewTextBoxColumn.FillWeight = 400F;
            this.poznamkaDataGridViewTextBoxColumn.HeaderText = "Poznámka";
            this.poznamkaDataGridViewTextBoxColumn.Name = "poznamkaDataGridViewTextBoxColumn";
            this.poznamkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.poznamkaDataGridViewTextBoxColumn.Width = 400;
            // 
            // stitkyBindingSource1
            // 
            this.stitkyBindingSource1.DataMember = "Stitky";
            this.stitkyBindingSource1.DataSource = this.databaseUTBDataSet32BindingSource;
            // 
            // databaseUTBDataSet32BindingSource
            // 
            this.databaseUTBDataSet32BindingSource.DataSource = this.databaseUTBDataSet32;
            this.databaseUTBDataSet32BindingSource.Position = 0;
            // 
            // databaseUTBDataSet32
            // 
            this.databaseUTBDataSet32.DataSetName = "DatabaseUTBDataSet32";
            this.databaseUTBDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.databaseUTBDataSet25;
            // 
            // databaseUTBDataSet25
            // 
            this.databaseUTBDataSet25.DataSetName = "DatabaseUTBDataSet25";
            this.databaseUTBDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typStitkuBindingSource
            // 
            this.typStitkuBindingSource.DataMember = "TypStitku";
            this.typStitkuBindingSource.DataSource = this.databaseUTBDataSet26;
            // 
            // databaseUTBDataSet26
            // 
            this.databaseUTBDataSet26.DataSetName = "DatabaseUTBDataSet26";
            this.databaseUTBDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jazykBindingSource
            // 
            this.jazykBindingSource.DataMember = "Jazyk";
            this.jazykBindingSource.DataSource = this.databaseUTBDataSet27;
            // 
            // databaseUTBDataSet27
            // 
            this.databaseUTBDataSet27.DataSetName = "DatabaseUTBDataSet27";
            this.databaseUTBDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stitkyBindingSource
            // 
            this.stitkyBindingSource.DataMember = "Stitky";
            this.stitkyBindingSource.DataSource = this.databaseUTBDataSet24;
            // 
            // databaseUTBDataSet24
            // 
            this.databaseUTBDataSet24.DataSetName = "DatabaseUTBDataSet24";
            this.databaseUTBDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stitkyTableAdapter
            // 
            this.stitkyTableAdapter.ClearBeforeFill = true;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // typStitkuTableAdapter
            // 
            this.typStitkuTableAdapter.ClearBeforeFill = true;
            // 
            // jazykTableAdapter
            // 
            this.jazykTableAdapter.ClearBeforeFill = true;
            // 
            // Stitky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.dataStitky);
            this.Controls.Add(this.generujStitkyPopis);
            this.Controls.Add(this.generujStitkyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPredmet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboZamestnanec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Stitky";
            this.Text = "Pracovní štítky";
            this.Load += new System.EventHandler(this.Stitky_Load);
            this.Shown += new System.EventHandler(this.ZmenaObsahu);
            ((System.ComponentModel.ISupportInitialize)(this.dataStitky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typStitkuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazykBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboZamestnanec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPredmet;
        private System.Windows.Forms.Button generujStitkyButton;
        private System.Windows.Forms.Label generujStitkyPopis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataStitky;
        private DatabaseUTBDataSet24 databaseUTBDataSet24;
        private System.Windows.Forms.BindingSource stitkyBindingSource;
        private DatabaseUTBDataSet24TableAdapters.StitkyTableAdapter stitkyTableAdapter;
        private DatabaseUTBDataSet25 databaseUTBDataSet25;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private DatabaseUTBDataSet25TableAdapters.PredmetTableAdapter predmetTableAdapter;
        private DatabaseUTBDataSet26 databaseUTBDataSet26;
        private System.Windows.Forms.BindingSource typStitkuBindingSource;
        private DatabaseUTBDataSet26TableAdapters.TypStitkuTableAdapter typStitkuTableAdapter;
        private DatabaseUTBDataSet27 databaseUTBDataSet27;
        private System.Windows.Forms.BindingSource jazykBindingSource;
        private DatabaseUTBDataSet27TableAdapters.JazykTableAdapter jazykTableAdapter;
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
        private System.Windows.Forms.BindingSource stitkyBindingSource1;
        private System.Windows.Forms.BindingSource databaseUTBDataSet32BindingSource;
        private DatabaseUTBDataSet32 databaseUTBDataSet32;
    }
}