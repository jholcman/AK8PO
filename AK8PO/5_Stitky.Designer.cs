
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
            this.dataStitky = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stitekcisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zamestnanciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet20 = new AK8PO.DatabaseUTBDataSet20();
            this.idpredmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet21 = new AK8PO.DatabaseUTBDataSet21();
            this.typstitkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typStitkuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet22 = new AK8PO.DatabaseUTBDataSet22();
            this.pocetstudentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocethodinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocettydnuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jazykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jazykBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet23 = new AK8PO.DatabaseUTBDataSet23();
            this.pocetboduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poznámkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stitkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet19 = new AK8PO.DatabaseUTBDataSet19();
            this.stitkyTableAdapter = new AK8PO.DatabaseUTBDataSet19TableAdapters.StitkyTableAdapter();
            this.zamestnanciTableAdapter = new AK8PO.DatabaseUTBDataSet20TableAdapters.ZamestnanciTableAdapter();
            this.predmetTableAdapter = new AK8PO.DatabaseUTBDataSet21TableAdapters.PredmetTableAdapter();
            this.typStitkuTableAdapter = new AK8PO.DatabaseUTBDataSet22TableAdapters.TypStitkuTableAdapter();
            this.jazykTableAdapter = new AK8PO.DatabaseUTBDataSet23TableAdapters.JazykTableAdapter();
            this.comboZamestnanec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPredmet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pocetStitkuPredmet = new System.Windows.Forms.Label();
            this.pocetStitkuZamestnanec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataStitky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typStitkuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazykBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet19)).BeginInit();
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
            // dataStitky
            // 
            this.dataStitky.AllowUserToAddRows = false;
            this.dataStitky.AllowUserToDeleteRows = false;
            this.dataStitky.AutoGenerateColumns = false;
            this.dataStitky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStitky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stitekcisloDataGridViewTextBoxColumn,
            this.idzamestnanecDataGridViewTextBoxColumn,
            this.idpredmetDataGridViewTextBoxColumn,
            this.typstitkuDataGridViewTextBoxColumn,
            this.pocetstudentuDataGridViewTextBoxColumn,
            this.pocethodinDataGridViewTextBoxColumn,
            this.pocettydnuDataGridViewTextBoxColumn,
            this.jazykDataGridViewTextBoxColumn,
            this.pocetboduDataGridViewTextBoxColumn,
            this.poznámkaDataGridViewTextBoxColumn});
            this.dataStitky.DataSource = this.stitkyBindingSource;
            this.dataStitky.Location = new System.Drawing.Point(17, 319);
            this.dataStitky.MultiSelect = false;
            this.dataStitky.Name = "dataStitky";
            this.dataStitky.ReadOnly = true;
            this.dataStitky.RowHeadersVisible = false;
            this.dataStitky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStitky.Size = new System.Drawing.Size(1155, 413);
            this.dataStitky.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 60F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // stitekcisloDataGridViewTextBoxColumn
            // 
            this.stitekcisloDataGridViewTextBoxColumn.DataPropertyName = "stitek_cislo";
            this.stitekcisloDataGridViewTextBoxColumn.FillWeight = 40F;
            this.stitekcisloDataGridViewTextBoxColumn.HeaderText = "Číslo štítku";
            this.stitekcisloDataGridViewTextBoxColumn.Name = "stitekcisloDataGridViewTextBoxColumn";
            this.stitekcisloDataGridViewTextBoxColumn.ReadOnly = true;
            this.stitekcisloDataGridViewTextBoxColumn.Width = 40;
            // 
            // idzamestnanecDataGridViewTextBoxColumn
            // 
            this.idzamestnanecDataGridViewTextBoxColumn.DataPropertyName = "id_zamestnanec";
            this.idzamestnanecDataGridViewTextBoxColumn.DataSource = this.zamestnanciBindingSource;
            this.idzamestnanecDataGridViewTextBoxColumn.DisplayMember = "prijmeni";
            this.idzamestnanecDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idzamestnanecDataGridViewTextBoxColumn.FillWeight = 120F;
            this.idzamestnanecDataGridViewTextBoxColumn.HeaderText = "Vyučující";
            this.idzamestnanecDataGridViewTextBoxColumn.Name = "idzamestnanecDataGridViewTextBoxColumn";
            this.idzamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzamestnanecDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idzamestnanecDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idzamestnanecDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idzamestnanecDataGridViewTextBoxColumn.Width = 120;
            // 
            // zamestnanciBindingSource
            // 
            this.zamestnanciBindingSource.DataMember = "Zamestnanci";
            this.zamestnanciBindingSource.DataSource = this.databaseUTBDataSet20;
            // 
            // databaseUTBDataSet20
            // 
            this.databaseUTBDataSet20.DataSetName = "DatabaseUTBDataSet20";
            this.databaseUTBDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idpredmetDataGridViewTextBoxColumn
            // 
            this.idpredmetDataGridViewTextBoxColumn.DataPropertyName = "id_predmet";
            this.idpredmetDataGridViewTextBoxColumn.DataSource = this.predmetBindingSource;
            this.idpredmetDataGridViewTextBoxColumn.DisplayMember = "zkratka";
            this.idpredmetDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idpredmetDataGridViewTextBoxColumn.FillWeight = 80F;
            this.idpredmetDataGridViewTextBoxColumn.HeaderText = "Předmět";
            this.idpredmetDataGridViewTextBoxColumn.Name = "idpredmetDataGridViewTextBoxColumn";
            this.idpredmetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpredmetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpredmetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpredmetDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idpredmetDataGridViewTextBoxColumn.Width = 80;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.databaseUTBDataSet21;
            // 
            // databaseUTBDataSet21
            // 
            this.databaseUTBDataSet21.DataSetName = "DatabaseUTBDataSet21";
            this.databaseUTBDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typstitkuDataGridViewTextBoxColumn
            // 
            this.typstitkuDataGridViewTextBoxColumn.DataPropertyName = "typ_stitku";
            this.typstitkuDataGridViewTextBoxColumn.DataSource = this.typStitkuBindingSource;
            this.typstitkuDataGridViewTextBoxColumn.DisplayMember = "Typ_stitku_text";
            this.typstitkuDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typstitkuDataGridViewTextBoxColumn.FillWeight = 80F;
            this.typstitkuDataGridViewTextBoxColumn.HeaderText = "Typ štítku";
            this.typstitkuDataGridViewTextBoxColumn.Name = "typstitkuDataGridViewTextBoxColumn";
            this.typstitkuDataGridViewTextBoxColumn.ReadOnly = true;
            this.typstitkuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typstitkuDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typstitkuDataGridViewTextBoxColumn.ValueMember = "Id";
            this.typstitkuDataGridViewTextBoxColumn.Width = 80;
            // 
            // typStitkuBindingSource
            // 
            this.typStitkuBindingSource.DataMember = "TypStitku";
            this.typStitkuBindingSource.DataSource = this.databaseUTBDataSet22;
            // 
            // databaseUTBDataSet22
            // 
            this.databaseUTBDataSet22.DataSetName = "DatabaseUTBDataSet22";
            this.databaseUTBDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pocetstudentuDataGridViewTextBoxColumn
            // 
            this.pocetstudentuDataGridViewTextBoxColumn.DataPropertyName = "pocet_studentu";
            this.pocetstudentuDataGridViewTextBoxColumn.FillWeight = 60F;
            this.pocetstudentuDataGridViewTextBoxColumn.HeaderText = "Studentů";
            this.pocetstudentuDataGridViewTextBoxColumn.Name = "pocetstudentuDataGridViewTextBoxColumn";
            this.pocetstudentuDataGridViewTextBoxColumn.ReadOnly = true;
            this.pocetstudentuDataGridViewTextBoxColumn.Width = 60;
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
            // jazykDataGridViewTextBoxColumn
            // 
            this.jazykDataGridViewTextBoxColumn.DataPropertyName = "jazyk";
            this.jazykDataGridViewTextBoxColumn.DataSource = this.jazykBindingSource;
            this.jazykDataGridViewTextBoxColumn.DisplayMember = "Jazyk_text";
            this.jazykDataGridViewTextBoxColumn.HeaderText = "Jazyk";
            this.jazykDataGridViewTextBoxColumn.Name = "jazykDataGridViewTextBoxColumn";
            this.jazykDataGridViewTextBoxColumn.ReadOnly = true;
            this.jazykDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jazykDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jazykDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // jazykBindingSource
            // 
            this.jazykBindingSource.DataMember = "Jazyk";
            this.jazykBindingSource.DataSource = this.databaseUTBDataSet23;
            // 
            // databaseUTBDataSet23
            // 
            this.databaseUTBDataSet23.DataSetName = "DatabaseUTBDataSet23";
            this.databaseUTBDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pocetboduDataGridViewTextBoxColumn
            // 
            this.pocetboduDataGridViewTextBoxColumn.DataPropertyName = "pocet_bodu";
            this.pocetboduDataGridViewTextBoxColumn.HeaderText = "pocet_bodu";
            this.pocetboduDataGridViewTextBoxColumn.Name = "pocetboduDataGridViewTextBoxColumn";
            this.pocetboduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poznámkaDataGridViewTextBoxColumn
            // 
            this.poznámkaDataGridViewTextBoxColumn.DataPropertyName = "poznámka";
            this.poznámkaDataGridViewTextBoxColumn.HeaderText = "poznámka";
            this.poznámkaDataGridViewTextBoxColumn.Name = "poznámkaDataGridViewTextBoxColumn";
            this.poznámkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stitkyBindingSource
            // 
            this.stitkyBindingSource.DataMember = "Stitky";
            this.stitkyBindingSource.DataSource = this.databaseUTBDataSet19;
            // 
            // databaseUTBDataSet19
            // 
            this.databaseUTBDataSet19.DataSetName = "DatabaseUTBDataSet19";
            this.databaseUTBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stitkyTableAdapter
            // 
            this.stitkyTableAdapter.ClearBeforeFill = true;
            // 
            // zamestnanciTableAdapter
            // 
            this.zamestnanciTableAdapter.ClearBeforeFill = true;
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
            // comboZamestnanec
            // 
            this.comboZamestnanec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZamestnanec.DropDownWidth = 150;
            this.comboZamestnanec.FormattingEnabled = true;
            this.comboZamestnanec.Location = new System.Drawing.Point(76, 72);
            this.comboZamestnanec.Name = "comboZamestnanec";
            this.comboZamestnanec.Size = new System.Drawing.Size(333, 21);
            this.comboZamestnanec.TabIndex = 10;
            this.comboZamestnanec.SelectedIndexChanged += new System.EventHandler(this.vyberZamestnance);
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
            this.label3.Location = new System.Drawing.Point(442, 75);
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
            this.comboPredmet.Location = new System.Drawing.Point(547, 72);
            this.comboPredmet.Name = "comboPredmet";
            this.comboPredmet.Size = new System.Drawing.Size(141, 21);
            this.comboPredmet.TabIndex = 12;
            this.comboPredmet.SelectedIndexChanged += new System.EventHandler(this.vyberPredmet);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Počet štítků:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Počet štítků:";
            // 
            // pocetStitkuPredmet
            // 
            this.pocetStitkuPredmet.AutoSize = true;
            this.pocetStitkuPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetStitkuPredmet.Location = new System.Drawing.Point(627, 109);
            this.pocetStitkuPredmet.Name = "pocetStitkuPredmet";
            this.pocetStitkuPredmet.Size = new System.Drawing.Size(18, 20);
            this.pocetStitkuPredmet.TabIndex = 16;
            this.pocetStitkuPredmet.Text = "0";
            // 
            // pocetStitkuZamestnanec
            // 
            this.pocetStitkuZamestnanec.AutoSize = true;
            this.pocetStitkuZamestnanec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocetStitkuZamestnanec.Location = new System.Drawing.Point(175, 109);
            this.pocetStitkuZamestnanec.Name = "pocetStitkuZamestnanec";
            this.pocetStitkuZamestnanec.Size = new System.Drawing.Size(18, 20);
            this.pocetStitkuZamestnanec.TabIndex = 17;
            this.pocetStitkuZamestnanec.Text = "0";
            // 
            // Stitky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pocetStitkuZamestnanec);
            this.Controls.Add(this.pocetStitkuPredmet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPredmet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboZamestnanec);
            this.Controls.Add(this.dataStitky);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Stitky";
            this.Text = "Pracovní štítky";
            this.Load += new System.EventHandler(this.Stitky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStitky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typStitkuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazykBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataStitky;
        private DatabaseUTBDataSet19 databaseUTBDataSet19;
        private System.Windows.Forms.BindingSource stitkyBindingSource;
        private DatabaseUTBDataSet19TableAdapters.StitkyTableAdapter stitkyTableAdapter;
        private DatabaseUTBDataSet20 databaseUTBDataSet20;
        private System.Windows.Forms.BindingSource zamestnanciBindingSource;
        private DatabaseUTBDataSet20TableAdapters.ZamestnanciTableAdapter zamestnanciTableAdapter;
        private DatabaseUTBDataSet21 databaseUTBDataSet21;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private DatabaseUTBDataSet21TableAdapters.PredmetTableAdapter predmetTableAdapter;
        private DatabaseUTBDataSet22 databaseUTBDataSet22;
        private System.Windows.Forms.BindingSource typStitkuBindingSource;
        private DatabaseUTBDataSet22TableAdapters.TypStitkuTableAdapter typStitkuTableAdapter;
        private DatabaseUTBDataSet23 databaseUTBDataSet23;
        private System.Windows.Forms.BindingSource jazykBindingSource;
        private DatabaseUTBDataSet23TableAdapters.JazykTableAdapter jazykTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stitekcisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idzamestnanecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpredmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typstitkuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetstudentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocethodinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocettydnuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jazykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetboduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poznámkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboZamestnanec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPredmet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pocetStitkuPredmet;
        private System.Windows.Forms.Label pocetStitkuZamestnanec;
    }
}