
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
            this.rocnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formastudiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typstudiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jazykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pridatPredmet = new System.Windows.Forms.Button();
            this.predmetVybranyId = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rozvrhId = new System.Windows.Forms.Label();
            this.smazatVybranyPredmet = new System.Windows.Forms.Button();
            this.pocetVP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSkupinka)).BeginInit();
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
            this.zkratkaDataGridViewTextBoxColumn.Width = 150;
            // 
            // rocnikDataGridViewTextBoxColumn
            // 
            this.rocnikDataGridViewTextBoxColumn.DataPropertyName = "rocnik";
            this.rocnikDataGridViewTextBoxColumn.HeaderText = "Roč.";
            this.rocnikDataGridViewTextBoxColumn.Name = "rocnikDataGridViewTextBoxColumn";
            this.rocnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.rocnikDataGridViewTextBoxColumn.ToolTipText = "Ročník";
            this.rocnikDataGridViewTextBoxColumn.Width = 35;
            // 
            // semestrDataGridViewTextBoxColumn
            // 
            this.semestrDataGridViewTextBoxColumn.DataPropertyName = "semestr";
            this.semestrDataGridViewTextBoxColumn.HeaderText = "Sem.";
            this.semestrDataGridViewTextBoxColumn.Name = "semestrDataGridViewTextBoxColumn";
            this.semestrDataGridViewTextBoxColumn.ReadOnly = true;
            this.semestrDataGridViewTextBoxColumn.ToolTipText = "Semestr";
            this.semestrDataGridViewTextBoxColumn.Width = 35;
            // 
            // formastudiaDataGridViewTextBoxColumn
            // 
            this.formastudiaDataGridViewTextBoxColumn.DataPropertyName = "forma_studia";
            this.formastudiaDataGridViewTextBoxColumn.HeaderText = "For.";
            this.formastudiaDataGridViewTextBoxColumn.Name = "formastudiaDataGridViewTextBoxColumn";
            this.formastudiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.formastudiaDataGridViewTextBoxColumn.ToolTipText = "Forma studia";
            this.formastudiaDataGridViewTextBoxColumn.Width = 30;
            // 
            // typstudiaDataGridViewTextBoxColumn
            // 
            this.typstudiaDataGridViewTextBoxColumn.DataPropertyName = "typ_studia";
            this.typstudiaDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typstudiaDataGridViewTextBoxColumn.Name = "typstudiaDataGridViewTextBoxColumn";
            this.typstudiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.typstudiaDataGridViewTextBoxColumn.ToolTipText = "Typ studia";
            this.typstudiaDataGridViewTextBoxColumn.Width = 50;
            // 
            // jazykDataGridViewTextBoxColumn
            // 
            this.jazykDataGridViewTextBoxColumn.DataPropertyName = "jazyk";
            this.jazykDataGridViewTextBoxColumn.HeaderText = "Jaz.";
            this.jazykDataGridViewTextBoxColumn.Name = "jazykDataGridViewTextBoxColumn";
            this.jazykDataGridViewTextBoxColumn.ReadOnly = true;
            this.jazykDataGridViewTextBoxColumn.ToolTipText = "Jazyk studia";
            this.jazykDataGridViewTextBoxColumn.Width = 40;
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
            this.predmetId.Location = new System.Drawing.Point(945, 80);
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
            this.predmetVybranyId.Location = new System.Drawing.Point(794, 80);
            this.predmetVybranyId.Name = "predmetVybranyId";
            this.predmetVybranyId.Size = new System.Drawing.Size(13, 13);
            this.predmetVybranyId.TabIndex = 12;
            this.predmetVybranyId.Text = "--";
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
            // rozvrhId
            // 
            this.rozvrhId.AutoSize = true;
            this.rozvrhId.BackColor = System.Drawing.SystemColors.Control;
            this.rozvrhId.Location = new System.Drawing.Point(608, 80);
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
            // Rozvrhy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rocnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formastudiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typstudiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jazykDataGridViewTextBoxColumn;
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
    }
}