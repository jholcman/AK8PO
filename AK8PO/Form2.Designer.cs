
namespace AK8PO
{
    partial class Studenti
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
            this.studentiView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkratkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rocnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetstudentuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formastudiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typstudiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jazykDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevstudiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet = new AK8PO.DatabaseUTBDataSet();
            this.databaseUTBDataSet3 = new AK8PO.DatabaseUTBDataSet3();
            this.databaseUTBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clear_tlacitko = new System.Windows.Forms.Button();
            this.delete_tlacitko = new System.Windows.Forms.Button();
            this.new_tlacitko = new System.Windows.Forms.Button();
            this.update_tlacitko = new System.Windows.Forms.Button();
            this.studentiTableAdapter = new AK8PO.DatabaseUTBDataSetTableAdapters.StudentiTableAdapter();
            this.vstupID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.vstupNazev_studia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vstupPocetStudentu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vstupZkratka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vstupRocnik = new System.Windows.Forms.ComboBox();
            this.vstupSemestr = new System.Windows.Forms.ComboBox();
            this.vstupForma_studia = new System.Windows.Forms.ComboBox();
            this.vstupTyp_studia = new System.Windows.Forms.ComboBox();
            this.vstupJazyk = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentiView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(939, 13);
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
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Počty studentů v oborech na UTB";
            // 
            // studentiView
            // 
            this.studentiView.AllowUserToAddRows = false;
            this.studentiView.AllowUserToDeleteRows = false;
            this.studentiView.AutoGenerateColumns = false;
            this.studentiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentiView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.zkratkaDataGridViewTextBoxColumn,
            this.rocnikDataGridViewTextBoxColumn,
            this.semestrDataGridViewTextBoxColumn,
            this.pocetstudentuDataGridViewTextBoxColumn,
            this.formastudiaDataGridViewTextBoxColumn,
            this.typstudiaDataGridViewTextBoxColumn,
            this.jazykDataGridViewTextBoxColumn,
            this.nazevstudiaDataGridViewTextBoxColumn});
            this.studentiView.DataSource = this.studentiBindingSource;
            this.studentiView.Location = new System.Drawing.Point(17, 71);
            this.studentiView.Name = "studentiView";
            this.studentiView.ReadOnly = true;
            this.studentiView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentiView.Size = new System.Drawing.Size(623, 669);
            this.studentiView.TabIndex = 33;
            this.studentiView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VyberZaznamu_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zkratkaDataGridViewTextBoxColumn
            // 
            this.zkratkaDataGridViewTextBoxColumn.DataPropertyName = "zkratka";
            this.zkratkaDataGridViewTextBoxColumn.HeaderText = "zkratka";
            this.zkratkaDataGridViewTextBoxColumn.Name = "zkratkaDataGridViewTextBoxColumn";
            this.zkratkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rocnikDataGridViewTextBoxColumn
            // 
            this.rocnikDataGridViewTextBoxColumn.DataPropertyName = "rocnik";
            this.rocnikDataGridViewTextBoxColumn.HeaderText = "rocnik";
            this.rocnikDataGridViewTextBoxColumn.Name = "rocnikDataGridViewTextBoxColumn";
            this.rocnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semestrDataGridViewTextBoxColumn
            // 
            this.semestrDataGridViewTextBoxColumn.DataPropertyName = "semestr";
            this.semestrDataGridViewTextBoxColumn.HeaderText = "semestr";
            this.semestrDataGridViewTextBoxColumn.Name = "semestrDataGridViewTextBoxColumn";
            this.semestrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pocetstudentuDataGridViewTextBoxColumn
            // 
            this.pocetstudentuDataGridViewTextBoxColumn.DataPropertyName = "pocet_studentu";
            this.pocetstudentuDataGridViewTextBoxColumn.HeaderText = "pocet_studentu";
            this.pocetstudentuDataGridViewTextBoxColumn.Name = "pocetstudentuDataGridViewTextBoxColumn";
            this.pocetstudentuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formastudiaDataGridViewTextBoxColumn
            // 
            this.formastudiaDataGridViewTextBoxColumn.DataPropertyName = "forma_studia";
            this.formastudiaDataGridViewTextBoxColumn.HeaderText = "forma_studia";
            this.formastudiaDataGridViewTextBoxColumn.Name = "formastudiaDataGridViewTextBoxColumn";
            this.formastudiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typstudiaDataGridViewTextBoxColumn
            // 
            this.typstudiaDataGridViewTextBoxColumn.DataPropertyName = "typ_studia";
            this.typstudiaDataGridViewTextBoxColumn.HeaderText = "typ_studia";
            this.typstudiaDataGridViewTextBoxColumn.Name = "typstudiaDataGridViewTextBoxColumn";
            this.typstudiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jazykDataGridViewTextBoxColumn
            // 
            this.jazykDataGridViewTextBoxColumn.DataPropertyName = "jazyk";
            this.jazykDataGridViewTextBoxColumn.HeaderText = "jazyk";
            this.jazykDataGridViewTextBoxColumn.Name = "jazykDataGridViewTextBoxColumn";
            this.jazykDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazevstudiaDataGridViewTextBoxColumn
            // 
            this.nazevstudiaDataGridViewTextBoxColumn.DataPropertyName = "nazev_studia";
            this.nazevstudiaDataGridViewTextBoxColumn.HeaderText = "nazev_studia";
            this.nazevstudiaDataGridViewTextBoxColumn.Name = "nazevstudiaDataGridViewTextBoxColumn";
            this.nazevstudiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.databaseUTBDataSet;
            // 
            // databaseUTBDataSet
            // 
            this.databaseUTBDataSet.DataSetName = "DatabaseUTBDataSet";
            this.databaseUTBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseUTBDataSet3
            // 
            this.databaseUTBDataSet3.DataSetName = "DatabaseUTBDataSet3";
            this.databaseUTBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseUTBDataSet3BindingSource
            // 
            this.databaseUTBDataSet3BindingSource.DataSource = this.databaseUTBDataSet3;
            this.databaseUTBDataSet3BindingSource.Position = 0;
            // 
            // clear_tlacitko
            // 
            this.clear_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear_tlacitko.Location = new System.Drawing.Point(929, 695);
            this.clear_tlacitko.Name = "clear_tlacitko";
            this.clear_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.clear_tlacitko.TabIndex = 40;
            this.clear_tlacitko.Text = "Vymazat obsah záznamu";
            this.clear_tlacitko.UseVisualStyleBackColor = true;
            this.clear_tlacitko.Click += new System.EventHandler(this.ResetFormulare);
            // 
            // delete_tlacitko
            // 
            this.delete_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_tlacitko.Location = new System.Drawing.Point(663, 695);
            this.delete_tlacitko.Name = "delete_tlacitko";
            this.delete_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.delete_tlacitko.TabIndex = 39;
            this.delete_tlacitko.Text = "Smazat záznam";
            this.delete_tlacitko.UseVisualStyleBackColor = true;
            this.delete_tlacitko.Click += new System.EventHandler(this.SmazatZaznam);
            // 
            // new_tlacitko
            // 
            this.new_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_tlacitko.Location = new System.Drawing.Point(929, 632);
            this.new_tlacitko.Name = "new_tlacitko";
            this.new_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.new_tlacitko.TabIndex = 38;
            this.new_tlacitko.Text = "Zapsat nový záznam";
            this.new_tlacitko.UseVisualStyleBackColor = true;
            this.new_tlacitko.Click += new System.EventHandler(this.NovyZaznam);
            // 
            // update_tlacitko
            // 
            this.update_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update_tlacitko.Location = new System.Drawing.Point(662, 632);
            this.update_tlacitko.Name = "update_tlacitko";
            this.update_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.update_tlacitko.TabIndex = 37;
            this.update_tlacitko.Text = "Zapsat změny";
            this.update_tlacitko.UseVisualStyleBackColor = true;
            this.update_tlacitko.Click += new System.EventHandler(this.ZapsatZmeny);
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // vstupID
            // 
            this.vstupID.Enabled = false;
            this.vstupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupID.Location = new System.Drawing.Point(784, 106);
            this.vstupID.Name = "vstupID";
            this.vstupID.Size = new System.Drawing.Size(101, 22);
            this.vstupID.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(750, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 57;
            this.label15.Text = "ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupNazev_studia
            // 
            this.vstupNazev_studia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupNazev_studia.Location = new System.Drawing.Point(784, 380);
            this.vstupNazev_studia.MaxLength = 50;
            this.vstupNazev_studia.Name = "vstupNazev_studia";
            this.vstupNazev_studia.Size = new System.Drawing.Size(380, 22);
            this.vstupNazev_studia.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(660, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Plný název oboru";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(689, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Jazyk studia";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(700, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Typ studia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(685, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Forma studia";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupPocetStudentu
            // 
            this.vstupPocetStudentu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupPocetStudentu.Location = new System.Drawing.Point(784, 242);
            this.vstupPocetStudentu.MaxLength = 4;
            this.vstupPocetStudentu.Name = "vstupPocetStudentu";
            this.vstupPocetStudentu.Size = new System.Drawing.Size(101, 22);
            this.vstupPocetStudentu.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(675, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Počet studentů";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(713, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Semestr";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(721, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ročník";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupZkratka
            // 
            this.vstupZkratka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupZkratka.Location = new System.Drawing.Point(784, 139);
            this.vstupZkratka.Name = "vstupZkratka";
            this.vstupZkratka.Size = new System.Drawing.Size(101, 22);
            this.vstupZkratka.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(680, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Zkratka oboru";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupRocnik
            // 
            this.vstupRocnik.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupRocnik.FormattingEnabled = true;
            this.vstupRocnik.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.vstupRocnik.Location = new System.Drawing.Point(784, 172);
            this.vstupRocnik.Name = "vstupRocnik";
            this.vstupRocnik.Size = new System.Drawing.Size(101, 24);
            this.vstupRocnik.TabIndex = 59;
            // 
            // vstupSemestr
            // 
            this.vstupSemestr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupSemestr.FormattingEnabled = true;
            this.vstupSemestr.Items.AddRange(new object[] {
            "ZS",
            "LS"});
            this.vstupSemestr.Location = new System.Drawing.Point(784, 207);
            this.vstupSemestr.Name = "vstupSemestr";
            this.vstupSemestr.Size = new System.Drawing.Size(101, 24);
            this.vstupSemestr.TabIndex = 60;
            // 
            // vstupForma_studia
            // 
            this.vstupForma_studia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupForma_studia.FormattingEnabled = true;
            this.vstupForma_studia.Items.AddRange(new object[] {
            "P",
            "K",
            "PH"});
            this.vstupForma_studia.Location = new System.Drawing.Point(784, 275);
            this.vstupForma_studia.Name = "vstupForma_studia";
            this.vstupForma_studia.Size = new System.Drawing.Size(101, 24);
            this.vstupForma_studia.TabIndex = 61;
            // 
            // vstupTyp_studia
            // 
            this.vstupTyp_studia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupTyp_studia.FormattingEnabled = true;
            this.vstupTyp_studia.Items.AddRange(new object[] {
            "Bc.",
            "Mgr.",
            "Ph.D."});
            this.vstupTyp_studia.Location = new System.Drawing.Point(784, 310);
            this.vstupTyp_studia.Name = "vstupTyp_studia";
            this.vstupTyp_studia.Size = new System.Drawing.Size(101, 24);
            this.vstupTyp_studia.TabIndex = 62;
            // 
            // vstupJazyk
            // 
            this.vstupJazyk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupJazyk.FormattingEnabled = true;
            this.vstupJazyk.Items.AddRange(new object[] {
            "CZ",
            "ENG",
            "DE"});
            this.vstupJazyk.Location = new System.Drawing.Point(784, 345);
            this.vstupJazyk.Name = "vstupJazyk";
            this.vstupJazyk.Size = new System.Drawing.Size(101, 24);
            this.vstupJazyk.TabIndex = 63;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.vstupJazyk);
            this.Controls.Add(this.vstupTyp_studia);
            this.Controls.Add(this.vstupForma_studia);
            this.Controls.Add(this.vstupSemestr);
            this.Controls.Add(this.vstupRocnik);
            this.Controls.Add(this.vstupID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.vstupNazev_studia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vstupPocetStudentu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vstupZkratka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear_tlacitko);
            this.Controls.Add(this.delete_tlacitko);
            this.Controls.Add(this.new_tlacitko);
            this.Controls.Add(this.update_tlacitko);
            this.Controls.Add(this.studentiView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Studenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti a obory";
            this.Load += new System.EventHandler(this.Studenti_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.studentiView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentiView;
        private System.Windows.Forms.BindingSource databaseUTBDataSet3BindingSource;
        private DatabaseUTBDataSet3 databaseUTBDataSet3;
        private System.Windows.Forms.Button clear_tlacitko;
        private System.Windows.Forms.Button delete_tlacitko;
        private System.Windows.Forms.Button new_tlacitko;
        private System.Windows.Forms.Button update_tlacitko;
        private DatabaseUTBDataSet databaseUTBDataSet;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DatabaseUTBDataSetTableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkratkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rocnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetstudentuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formastudiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typstudiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jazykDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevstudiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox vstupID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox vstupNazev_studia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vstupPocetStudentu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vstupZkratka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vstupRocnik;
        private System.Windows.Forms.ComboBox vstupSemestr;
        private System.Windows.Forms.ComboBox vstupForma_studia;
        private System.Windows.Forms.ComboBox vstupTyp_studia;
        private System.Windows.Forms.ComboBox vstupJazyk;
    }
}