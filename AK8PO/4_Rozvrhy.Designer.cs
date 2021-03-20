
namespace AK8PO
{
    partial class Rozvrhy
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
            this.dataSkupinka = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkratkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rocnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rocnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet14 = new AK8PO.DatabaseUTBDataSet14();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.semestrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet15 = new AK8PO.DatabaseUTBDataSet15();
            this.formastudiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.formaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet16 = new AK8PO.DatabaseUTBDataSet16();
            this.typstudiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet17 = new AK8PO.DatabaseUTBDataSet17();
            this.jazykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jazykBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet18 = new AK8PO.DatabaseUTBDataSet18();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet5 = new AK8PO.DatabaseUTBDataSet5();
            this.studentiTableAdapter = new AK8PO.DatabaseUTBDataSet5TableAdapters.StudentiTableAdapter();
            this.dataPredmet = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkratkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet6 = new AK8PO.DatabaseUTBDataSet6();
            this.predmetTableAdapter = new AK8PO.DatabaseUTBDataSet6TableAdapters.PredmetTableAdapter();
            this.skupinkaId = new System.Windows.Forms.Label();
            this.predmetId = new System.Windows.Forms.Label();
            this.dataPredmetVybran = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pridatPredmet = new System.Windows.Forms.Button();
            this.predmetVybranyId = new System.Windows.Forms.Label();
            this.rozvrhId = new System.Windows.Forms.Label();
            this.smazatVybranyPredmet = new System.Windows.Forms.Button();
            this.pocetVP = new System.Windows.Forms.Label();
            this.rocnikTableAdapter = new AK8PO.DatabaseUTBDataSet14TableAdapters.RocnikTableAdapter();
            this.semestrTableAdapter = new AK8PO.DatabaseUTBDataSet15TableAdapters.SemestrTableAdapter();
            this.formaTableAdapter = new AK8PO.DatabaseUTBDataSet16TableAdapters.FormaTableAdapter();
            this.typTableAdapter = new AK8PO.DatabaseUTBDataSet17TableAdapters.TypTableAdapter();
            this.jazykTableAdapter = new AK8PO.DatabaseUTBDataSet18TableAdapters.JazykTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSkupinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazykBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPredmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPredmetVybran)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(939, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zpět do hlavní nabídky";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ZpetNaHlavni);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rozvrhy hodin pro jednotlivé kroužky a ročníky";
            // 
            // dataSkupinka
            // 
            this.dataSkupinka.AllowUserToAddRows = false;
            this.dataSkupinka.AllowUserToDeleteRows = false;
            this.dataSkupinka.AllowUserToResizeColumns = false;
            this.dataSkupinka.AllowUserToResizeRows = false;
            this.dataSkupinka.AutoGenerateColumns = false;
            this.dataSkupinka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSkupinka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.zkratkaDataGridViewTextBoxColumn,
            this.rocnikDataGridViewTextBoxColumn,
            this.semestrDataGridViewTextBoxColumn,
            this.formastudiaDataGridViewTextBoxColumn,
            this.typstudiaDataGridViewTextBoxColumn,
            this.jazykDataGridViewTextBoxColumn});
            this.dataSkupinka.DataSource = this.studentiBindingSource;
            this.dataSkupinka.Location = new System.Drawing.Point(22, 55);
            this.dataSkupinka.MultiSelect = false;
            this.dataSkupinka.Name = "dataSkupinka";
            this.dataSkupinka.ReadOnly = true;
            this.dataSkupinka.RowHeadersVisible = false;
            this.dataSkupinka.RowHeadersWidth = 20;
            this.dataSkupinka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataSkupinka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSkupinka.ShowEditingIcon = false;
            this.dataSkupinka.Size = new System.Drawing.Size(418, 689);
            this.dataSkupinka.TabIndex = 5;
            this.dataSkupinka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZobrazIdSkupinky);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // zkratkaDataGridViewTextBoxColumn
            // 
            this.zkratkaDataGridViewTextBoxColumn.DataPropertyName = "zkratka";
            this.zkratkaDataGridViewTextBoxColumn.HeaderText = "Skupinka";
            this.zkratkaDataGridViewTextBoxColumn.Name = "zkratkaDataGridViewTextBoxColumn";
            this.zkratkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zkratkaDataGridViewTextBoxColumn.Width = 80;
            // 
            // rocnikDataGridViewTextBoxColumn
            // 
            this.rocnikDataGridViewTextBoxColumn.DataPropertyName = "rocnik";
            this.rocnikDataGridViewTextBoxColumn.DataSource = this.rocnikBindingSource;
            this.rocnikDataGridViewTextBoxColumn.DisplayMember = "Rocnik_text";
            this.rocnikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rocnikDataGridViewTextBoxColumn.HeaderText = "Ročník";
            this.rocnikDataGridViewTextBoxColumn.Name = "rocnikDataGridViewTextBoxColumn";
            this.rocnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.rocnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rocnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rocnikDataGridViewTextBoxColumn.ToolTipText = "Ročník";
            this.rocnikDataGridViewTextBoxColumn.ValueMember = "Id";
            this.rocnikDataGridViewTextBoxColumn.Width = 35;
            // 
            // rocnikBindingSource
            // 
            this.rocnikBindingSource.DataMember = "Rocnik";
            this.rocnikBindingSource.DataSource = this.databaseUTBDataSet14;
            // 
            // databaseUTBDataSet14
            // 
            this.databaseUTBDataSet14.DataSetName = "DatabaseUTBDataSet14";
            this.databaseUTBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // semestrDataGridViewTextBoxColumn
            // 
            this.semestrDataGridViewTextBoxColumn.DataPropertyName = "semestr";
            this.semestrDataGridViewTextBoxColumn.DataSource = this.semestrBindingSource;
            this.semestrDataGridViewTextBoxColumn.DisplayMember = "Semestr_text";
            this.semestrDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.semestrDataGridViewTextBoxColumn.HeaderText = "Semestr";
            this.semestrDataGridViewTextBoxColumn.Name = "semestrDataGridViewTextBoxColumn";
            this.semestrDataGridViewTextBoxColumn.ReadOnly = true;
            this.semestrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.semestrDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.semestrDataGridViewTextBoxColumn.ToolTipText = "Semestr";
            this.semestrDataGridViewTextBoxColumn.ValueMember = "Id";
            this.semestrDataGridViewTextBoxColumn.Width = 70;
            // 
            // semestrBindingSource
            // 
            this.semestrBindingSource.DataMember = "Semestr";
            this.semestrBindingSource.DataSource = this.databaseUTBDataSet15;
            // 
            // databaseUTBDataSet15
            // 
            this.databaseUTBDataSet15.DataSetName = "DatabaseUTBDataSet15";
            this.databaseUTBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formastudiaDataGridViewTextBoxColumn
            // 
            this.formastudiaDataGridViewTextBoxColumn.DataPropertyName = "forma_studia";
            this.formastudiaDataGridViewTextBoxColumn.DataSource = this.formaBindingSource;
            this.formastudiaDataGridViewTextBoxColumn.DisplayMember = "Forma_text";
            this.formastudiaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.formastudiaDataGridViewTextBoxColumn.HeaderText = "Forma";
            this.formastudiaDataGridViewTextBoxColumn.Name = "formastudiaDataGridViewTextBoxColumn";
            this.formastudiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.formastudiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formastudiaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.formastudiaDataGridViewTextBoxColumn.ToolTipText = "Forma studia";
            this.formastudiaDataGridViewTextBoxColumn.ValueMember = "Id";
            this.formastudiaDataGridViewTextBoxColumn.Width = 70;
            // 
            // formaBindingSource
            // 
            this.formaBindingSource.DataMember = "Forma";
            this.formaBindingSource.DataSource = this.databaseUTBDataSet16;
            // 
            // databaseUTBDataSet16
            // 
            this.databaseUTBDataSet16.DataSetName = "DatabaseUTBDataSet16";
            this.databaseUTBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typstudiaDataGridViewTextBoxColumn
            // 
            this.typstudiaDataGridViewTextBoxColumn.DataPropertyName = "typ_studia";
            this.typstudiaDataGridViewTextBoxColumn.DataSource = this.typBindingSource;
            this.typstudiaDataGridViewTextBoxColumn.DisplayMember = "Typ_text";
            this.typstudiaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typstudiaDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typstudiaDataGridViewTextBoxColumn.Name = "typstudiaDataGridViewTextBoxColumn";
            this.typstudiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.typstudiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typstudiaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typstudiaDataGridViewTextBoxColumn.ToolTipText = "Typ studia";
            this.typstudiaDataGridViewTextBoxColumn.ValueMember = "Id";
            this.typstudiaDataGridViewTextBoxColumn.Width = 50;
            // 
            // typBindingSource
            // 
            this.typBindingSource.DataMember = "Typ";
            this.typBindingSource.DataSource = this.databaseUTBDataSet17;
            // 
            // databaseUTBDataSet17
            // 
            this.databaseUTBDataSet17.DataSetName = "DatabaseUTBDataSet17";
            this.databaseUTBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jazykDataGridViewTextBoxColumn
            // 
            this.jazykDataGridViewTextBoxColumn.DataPropertyName = "jazyk";
            this.jazykDataGridViewTextBoxColumn.DataSource = this.jazykBindingSource;
            this.jazykDataGridViewTextBoxColumn.DisplayMember = "Jazyk_text";
            this.jazykDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jazykDataGridViewTextBoxColumn.HeaderText = "Jazyk";
            this.jazykDataGridViewTextBoxColumn.Name = "jazykDataGridViewTextBoxColumn";
            this.jazykDataGridViewTextBoxColumn.ReadOnly = true;
            this.jazykDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jazykDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jazykDataGridViewTextBoxColumn.ToolTipText = "Jazyk studia";
            this.jazykDataGridViewTextBoxColumn.ValueMember = "Id";
            this.jazykDataGridViewTextBoxColumn.Width = 50;
            // 
            // jazykBindingSource
            // 
            this.jazykBindingSource.DataMember = "Jazyk";
            this.jazykBindingSource.DataSource = this.databaseUTBDataSet18;
            // 
            // databaseUTBDataSet18
            // 
            this.databaseUTBDataSet18.DataSetName = "DatabaseUTBDataSet18";
            this.databaseUTBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.databaseUTBDataSet5;
            // 
            // databaseUTBDataSet5
            // 
            this.databaseUTBDataSet5.DataSetName = "DatabaseUTBDataSet5";
            this.databaseUTBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // dataPredmet
            // 
            this.dataPredmet.AllowUserToAddRows = false;
            this.dataPredmet.AllowUserToDeleteRows = false;
            this.dataPredmet.AllowUserToResizeColumns = false;
            this.dataPredmet.AllowUserToResizeRows = false;
            this.dataPredmet.AutoGenerateColumns = false;
            this.dataPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPredmet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.zkratkaDataGridViewTextBoxColumn1});
            this.dataPredmet.DataSource = this.predmetBindingSource;
            this.dataPredmet.Location = new System.Drawing.Point(939, 106);
            this.dataPredmet.MultiSelect = false;
            this.dataPredmet.Name = "dataPredmet";
            this.dataPredmet.ReadOnly = true;
            this.dataPredmet.RowHeadersVisible = false;
            this.dataPredmet.RowHeadersWidth = 20;
            this.dataPredmet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataPredmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPredmet.Size = new System.Drawing.Size(215, 638);
            this.dataPredmet.TabIndex = 6;
            this.dataPredmet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZobrazIdPredmetu);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // zkratkaDataGridViewTextBoxColumn1
            // 
            this.zkratkaDataGridViewTextBoxColumn1.DataPropertyName = "zkratka";
            this.zkratkaDataGridViewTextBoxColumn1.HeaderText = "Předmět";
            this.zkratkaDataGridViewTextBoxColumn1.Name = "zkratkaDataGridViewTextBoxColumn1";
            this.zkratkaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zkratkaDataGridViewTextBoxColumn1.ToolTipText = "Zkratka předmětu";
            this.zkratkaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.databaseUTBDataSet6;
            // 
            // databaseUTBDataSet6
            // 
            this.databaseUTBDataSet6.DataSetName = "DatabaseUTBDataSet6";
            this.databaseUTBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // skupinkaId
            // 
            this.skupinkaId.AutoSize = true;
            this.skupinkaId.BackColor = System.Drawing.SystemColors.Control;
            this.skupinkaId.Location = new System.Drawing.Point(463, 64);
            this.skupinkaId.Name = "skupinkaId";
            this.skupinkaId.Size = new System.Drawing.Size(13, 13);
            this.skupinkaId.TabIndex = 7;
            this.skupinkaId.Text = "--";
            // 
            // predmetId
            // 
            this.predmetId.AutoSize = true;
            this.predmetId.Location = new System.Drawing.Point(906, 106);
            this.predmetId.Name = "predmetId";
            this.predmetId.Size = new System.Drawing.Size(13, 13);
            this.predmetId.TabIndex = 8;
            this.predmetId.Text = "--";
            // 
            // dataPredmetVybran
            // 
            this.dataPredmetVybran.AllowUserToAddRows = false;
            this.dataPredmetVybran.AllowUserToDeleteRows = false;
            this.dataPredmetVybran.AllowUserToResizeColumns = false;
            this.dataPredmetVybran.AllowUserToResizeRows = false;
            this.dataPredmetVybran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPredmetVybran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_predmet,
            this.zkratka});
            this.dataPredmetVybran.Location = new System.Drawing.Point(601, 106);
            this.dataPredmetVybran.MultiSelect = false;
            this.dataPredmetVybran.Name = "dataPredmetVybran";
            this.dataPredmetVybran.ReadOnly = true;
            this.dataPredmetVybran.RowHeadersVisible = false;
            this.dataPredmetVybran.RowHeadersWidth = 20;
            this.dataPredmetVybran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPredmetVybran.Size = new System.Drawing.Size(215, 545);
            this.dataPredmetVybran.TabIndex = 9;
            this.dataPredmetVybran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZobrazIdVybranehoPredmetu);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id_rozvrh";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Id_predmet
            // 
            this.Id_predmet.DataPropertyName = "Id_predmet";
            this.Id_predmet.HeaderText = "Id";
            this.Id_predmet.Name = "Id_predmet";
            this.Id_predmet.ReadOnly = true;
            this.Id_predmet.Width = 40;
            // 
            // zkratka
            // 
            this.zkratka.DataPropertyName = "zkratka";
            this.zkratka.HeaderText = "Předmět";
            this.zkratka.Name = "zkratka";
            this.zkratka.ReadOnly = true;
            this.zkratka.Width = 150;
            // 
            // pridatPredmet
            // 
            this.pridatPredmet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatPredmet.Location = new System.Drawing.Point(844, 309);
            this.pridatPredmet.Name = "pridatPredmet";
            this.pridatPredmet.Size = new System.Drawing.Size(75, 23);
            this.pridatPredmet.TabIndex = 10;
            this.pridatPredmet.Text = "<<<<";
            this.pridatPredmet.UseVisualStyleBackColor = true;
            this.pridatPredmet.Click += new System.EventHandler(this.VyberPredmet);
            // 
            // predmetVybranyId
            // 
            this.predmetVybranyId.AutoSize = true;
            this.predmetVybranyId.BackColor = System.Drawing.SystemColors.Control;
            this.predmetVybranyId.Location = new System.Drawing.Point(841, 106);
            this.predmetVybranyId.Name = "predmetVybranyId";
            this.predmetVybranyId.Size = new System.Drawing.Size(13, 13);
            this.predmetVybranyId.TabIndex = 12;
            this.predmetVybranyId.Text = "--";
            // 
            // rozvrhId
            // 
            this.rozvrhId.AutoSize = true;
            this.rozvrhId.BackColor = System.Drawing.SystemColors.Control;
            this.rozvrhId.Location = new System.Drawing.Point(564, 106);
            this.rozvrhId.Name = "rozvrhId";
            this.rozvrhId.Size = new System.Drawing.Size(13, 13);
            this.rozvrhId.TabIndex = 13;
            this.rozvrhId.Text = "--";
            // 
            // smazatVybranyPredmet
            // 
            this.smazatVybranyPredmet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smazatVybranyPredmet.Location = new System.Drawing.Point(601, 670);
            this.smazatVybranyPredmet.Name = "smazatVybranyPredmet";
            this.smazatVybranyPredmet.Size = new System.Drawing.Size(215, 30);
            this.smazatVybranyPredmet.TabIndex = 14;
            this.smazatVybranyPredmet.Text = "Smazat vybraný předmět";
            this.smazatVybranyPredmet.UseVisualStyleBackColor = true;
            this.smazatVybranyPredmet.Click += new System.EventHandler(this.SmazatVybranyPredmet);
            // 
            // pocetVP
            // 
            this.pocetVP.AutoSize = true;
            this.pocetVP.Location = new System.Drawing.Point(875, 344);
            this.pocetVP.Name = "pocetVP";
            this.pocetVP.Size = new System.Drawing.Size(13, 13);
            this.pocetVP.TabIndex = 15;
            this.pocetVP.Text = "--";
            // 
            // rocnikTableAdapter
            // 
            this.rocnikTableAdapter.ClearBeforeFill = true;
            // 
            // semestrTableAdapter
            // 
            this.semestrTableAdapter.ClearBeforeFill = true;
            // 
            // formaTableAdapter
            // 
            this.formaTableAdapter.ClearBeforeFill = true;
            // 
            // typTableAdapter
            // 
            this.typTableAdapter.ClearBeforeFill = true;
            // 
            // jazykTableAdapter
            // 
            this.jazykTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(619, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rozvrhované předměty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(956, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Všechny předměty UTB";
            // 
            // Rozvrhy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pocetVP);
            this.Controls.Add(this.smazatVybranyPredmet);
            this.Controls.Add(this.rozvrhId);
            this.Controls.Add(this.predmetVybranyId);
            this.Controls.Add(this.pridatPredmet);
            this.Controls.Add(this.dataPredmetVybran);
            this.Controls.Add(this.predmetId);
            this.Controls.Add(this.skupinkaId);
            this.Controls.Add(this.dataPredmet);
            this.Controls.Add(this.dataSkupinka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Rozvrhy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rozvrhy hodin pro jednotlivé kroužky";
            this.Load += new System.EventHandler(this.Rozvrhy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSkupinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semestrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jazykBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPredmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPredmetVybran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSkupinka;
        private DatabaseUTBDataSet5 databaseUTBDataSet5;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DatabaseUTBDataSet5TableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.DataGridView dataPredmet;
        private DatabaseUTBDataSet6 databaseUTBDataSet6;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private DatabaseUTBDataSet6TableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkratkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label skupinkaId;
        private System.Windows.Forms.Label predmetId;
        private System.Windows.Forms.DataGridView dataPredmetVybran;
        private System.Windows.Forms.Button pridatPredmet;
        private System.Windows.Forms.Label predmetVybranyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkratka;
        private System.Windows.Forms.Label rozvrhId;
        private System.Windows.Forms.Button smazatVybranyPredmet;
        private System.Windows.Forms.Label pocetVP;
        private DatabaseUTBDataSet14 databaseUTBDataSet14;
        private System.Windows.Forms.BindingSource rocnikBindingSource;
        private DatabaseUTBDataSet14TableAdapters.RocnikTableAdapter rocnikTableAdapter;
        private DatabaseUTBDataSet15 databaseUTBDataSet15;
        private System.Windows.Forms.BindingSource semestrBindingSource;
        private DatabaseUTBDataSet15TableAdapters.SemestrTableAdapter semestrTableAdapter;
        private DatabaseUTBDataSet16 databaseUTBDataSet16;
        private System.Windows.Forms.BindingSource formaBindingSource;
        private DatabaseUTBDataSet16TableAdapters.FormaTableAdapter formaTableAdapter;
        private DatabaseUTBDataSet17 databaseUTBDataSet17;
        private System.Windows.Forms.BindingSource typBindingSource;
        private DatabaseUTBDataSet17TableAdapters.TypTableAdapter typTableAdapter;
        private DatabaseUTBDataSet18 databaseUTBDataSet18;
        private System.Windows.Forms.BindingSource jazykBindingSource;
        private DatabaseUTBDataSet18TableAdapters.JazykTableAdapter jazykTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rocnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn semestrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn formastudiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typstudiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jazykDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}