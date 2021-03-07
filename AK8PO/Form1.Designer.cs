
namespace AK8PO
{
    partial class Zamestnanci
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vstupPrijmeni = new System.Windows.Forms.TextBox();
            this.vstupJmeno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vstupTitul_pred = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vstupTelefon_soukromy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vstupTelefon_pracovni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vstupTitul_za = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vstupKancelar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vstupEmail_soukromy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vstupEmail_pracovni = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vstupBodyBezAngl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vstupUvazek = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.vstupBodySAngl = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vstupID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.vstupDoktorant = new System.Windows.Forms.ComboBox();
            this.zamestnanciView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulpredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonpracovniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonsoukromyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailpracovniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailsoukromyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kancelarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uvazekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracovnibodybezangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracovnibodysangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseUTBDataSet3 = new AK8PO.DatabaseUTBDataSet3();
            this.zamestnanciTableAdapter = new AK8PO.DatabaseUTBDataSet3TableAdapters.ZamestnanciTableAdapter();
            this.update_tlacitko = new System.Windows.Forms.Button();
            this.new_tlacitko = new System.Windows.Forms.Button();
            this.delete_tlacitko = new System.Windows.Forms.Button();
            this.clear_tlacitko = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zaměstnanci UTB";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(939, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zpět do hlavní nabídky";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ZpetNaHlavni);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(722, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Příjmení";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupPrijmeni
            // 
            this.vstupPrijmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupPrijmeni.Location = new System.Drawing.Point(791, 140);
            this.vstupPrijmeni.Name = "vstupPrijmeni";
            this.vstupPrijmeni.Size = new System.Drawing.Size(380, 22);
            this.vstupPrijmeni.TabIndex = 4;
            // 
            // vstupJmeno
            // 
            this.vstupJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupJmeno.Location = new System.Drawing.Point(791, 170);
            this.vstupJmeno.Name = "vstupJmeno";
            this.vstupJmeno.Size = new System.Drawing.Size(380, 22);
            this.vstupJmeno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(729, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jméno";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupTitul_pred
            // 
            this.vstupTitul_pred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupTitul_pred.Location = new System.Drawing.Point(792, 205);
            this.vstupTitul_pred.Name = "vstupTitul_pred";
            this.vstupTitul_pred.Size = new System.Drawing.Size(217, 22);
            this.vstupTitul_pred.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(714, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Titul před";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupTelefon_soukromy
            // 
            this.vstupTelefon_soukromy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupTelefon_soukromy.Location = new System.Drawing.Point(792, 312);
            this.vstupTelefon_soukromy.Name = "vstupTelefon_soukromy";
            this.vstupTelefon_soukromy.Size = new System.Drawing.Size(380, 22);
            this.vstupTelefon_soukromy.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(662, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon soukromý";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupTelefon_pracovni
            // 
            this.vstupTelefon_pracovni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupTelefon_pracovni.Location = new System.Drawing.Point(791, 281);
            this.vstupTelefon_pracovni.Name = "vstupTelefon_pracovni";
            this.vstupTelefon_pracovni.Size = new System.Drawing.Size(380, 22);
            this.vstupTelefon_pracovni.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(669, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefon pracovní";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupTitul_za
            // 
            this.vstupTitul_za.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupTitul_za.Location = new System.Drawing.Point(791, 235);
            this.vstupTitul_za.Name = "vstupTitul_za";
            this.vstupTitul_za.Size = new System.Drawing.Size(218, 22);
            this.vstupTitul_za.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(728, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Titul za";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupKancelar
            // 
            this.vstupKancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupKancelar.Location = new System.Drawing.Point(793, 412);
            this.vstupKancelar.Name = "vstupKancelar";
            this.vstupKancelar.Size = new System.Drawing.Size(216, 22);
            this.vstupKancelar.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(717, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kancelář";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupEmail_soukromy
            // 
            this.vstupEmail_soukromy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupEmail_soukromy.Location = new System.Drawing.Point(792, 380);
            this.vstupEmail_soukromy.Name = "vstupEmail_soukromy";
            this.vstupEmail_soukromy.Size = new System.Drawing.Size(380, 22);
            this.vstupEmail_soukromy.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(670, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "E-mail soukromý";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupEmail_pracovni
            // 
            this.vstupEmail_pracovni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupEmail_pracovni.Location = new System.Drawing.Point(792, 346);
            this.vstupEmail_pracovni.Name = "vstupEmail_pracovni";
            this.vstupEmail_pracovni.Size = new System.Drawing.Size(380, 22);
            this.vstupEmail_pracovni.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(677, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "E-mail pracovní";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupBodyBezAngl
            // 
            this.vstupBodyBezAngl.Enabled = false;
            this.vstupBodyBezAngl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupBodyBezAngl.Location = new System.Drawing.Point(794, 522);
            this.vstupBodyBezAngl.Name = "vstupBodyBezAngl";
            this.vstupBodyBezAngl.Size = new System.Drawing.Size(380, 22);
            this.vstupBodyBezAngl.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(672, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Body (bez Angl.)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(712, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Doktorant";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupUvazek
            // 
            this.vstupUvazek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupUvazek.Location = new System.Drawing.Point(793, 459);
            this.vstupUvazek.MaxLength = 10;
            this.vstupUvazek.Name = "vstupUvazek";
            this.vstupUvazek.Size = new System.Drawing.Size(99, 22);
            this.vstupUvazek.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(689, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Úvazek (0 - 1)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupBodySAngl
            // 
            this.vstupBodySAngl.Enabled = false;
            this.vstupBodySAngl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupBodySAngl.Location = new System.Drawing.Point(794, 555);
            this.vstupBodySAngl.Name = "vstupBodySAngl";
            this.vstupBodySAngl.Size = new System.Drawing.Size(380, 22);
            this.vstupBodySAngl.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(687, 557);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Body (s Angl.)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupID
            // 
            this.vstupID.Enabled = false;
            this.vstupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupID.Location = new System.Drawing.Point(791, 102);
            this.vstupID.Name = "vstupID";
            this.vstupID.Size = new System.Drawing.Size(101, 22);
            this.vstupID.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(757, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vstupDoktorant
            // 
            this.vstupDoktorant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstupDoktorant.FormattingEnabled = true;
            this.vstupDoktorant.Items.AddRange(new object[] {
            "Ne",
            "Ano"});
            this.vstupDoktorant.Location = new System.Drawing.Point(794, 490);
            this.vstupDoktorant.Name = "vstupDoktorant";
            this.vstupDoktorant.Size = new System.Drawing.Size(121, 24);
            this.vstupDoktorant.TabIndex = 31;
            // 
            // zamestnanciView
            // 
            this.zamestnanciView.AllowUserToAddRows = false;
            this.zamestnanciView.AllowUserToDeleteRows = false;
            this.zamestnanciView.AutoGenerateColumns = false;
            this.zamestnanciView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zamestnanciView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.prijmeniDataGridViewTextBoxColumn,
            this.jmenoDataGridViewTextBoxColumn,
            this.titulpredDataGridViewTextBoxColumn,
            this.titulzaDataGridViewTextBoxColumn,
            this.telefonpracovniDataGridViewTextBoxColumn,
            this.telefonsoukromyDataGridViewTextBoxColumn,
            this.emailpracovniDataGridViewTextBoxColumn,
            this.emailsoukromyDataGridViewTextBoxColumn,
            this.kancelarDataGridViewTextBoxColumn,
            this.uvazekDataGridViewTextBoxColumn,
            this.doktorantDataGridViewTextBoxColumn,
            this.pracovnibodybezangDataGridViewTextBoxColumn,
            this.pracovnibodysangDataGridViewTextBoxColumn});
            this.zamestnanciView.DataSource = this.zamestnanciBindingSource;
            this.zamestnanciView.Location = new System.Drawing.Point(20, 74);
            this.zamestnanciView.Name = "zamestnanciView";
            this.zamestnanciView.ReadOnly = true;
            this.zamestnanciView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zamestnanciView.Size = new System.Drawing.Size(623, 669);
            this.zamestnanciView.TabIndex = 32;
            this.zamestnanciView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VyberZaznamu_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prijmeniDataGridViewTextBoxColumn
            // 
            this.prijmeniDataGridViewTextBoxColumn.DataPropertyName = "prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.HeaderText = "prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.Name = "prijmeniDataGridViewTextBoxColumn";
            this.prijmeniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jmenoDataGridViewTextBoxColumn
            // 
            this.jmenoDataGridViewTextBoxColumn.DataPropertyName = "jmeno";
            this.jmenoDataGridViewTextBoxColumn.HeaderText = "jmeno";
            this.jmenoDataGridViewTextBoxColumn.Name = "jmenoDataGridViewTextBoxColumn";
            this.jmenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulpredDataGridViewTextBoxColumn
            // 
            this.titulpredDataGridViewTextBoxColumn.DataPropertyName = "titul_pred";
            this.titulpredDataGridViewTextBoxColumn.HeaderText = "titul_pred";
            this.titulpredDataGridViewTextBoxColumn.Name = "titulpredDataGridViewTextBoxColumn";
            this.titulpredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulzaDataGridViewTextBoxColumn
            // 
            this.titulzaDataGridViewTextBoxColumn.DataPropertyName = "titul_za";
            this.titulzaDataGridViewTextBoxColumn.HeaderText = "titul_za";
            this.titulzaDataGridViewTextBoxColumn.Name = "titulzaDataGridViewTextBoxColumn";
            this.titulzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonpracovniDataGridViewTextBoxColumn
            // 
            this.telefonpracovniDataGridViewTextBoxColumn.DataPropertyName = "telefon_pracovni";
            this.telefonpracovniDataGridViewTextBoxColumn.HeaderText = "telefon_pracovni";
            this.telefonpracovniDataGridViewTextBoxColumn.Name = "telefonpracovniDataGridViewTextBoxColumn";
            this.telefonpracovniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonsoukromyDataGridViewTextBoxColumn
            // 
            this.telefonsoukromyDataGridViewTextBoxColumn.DataPropertyName = "telefon_soukromy";
            this.telefonsoukromyDataGridViewTextBoxColumn.HeaderText = "telefon_soukromy";
            this.telefonsoukromyDataGridViewTextBoxColumn.Name = "telefonsoukromyDataGridViewTextBoxColumn";
            this.telefonsoukromyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailpracovniDataGridViewTextBoxColumn
            // 
            this.emailpracovniDataGridViewTextBoxColumn.DataPropertyName = "email_pracovni";
            this.emailpracovniDataGridViewTextBoxColumn.HeaderText = "email_pracovni";
            this.emailpracovniDataGridViewTextBoxColumn.Name = "emailpracovniDataGridViewTextBoxColumn";
            this.emailpracovniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailsoukromyDataGridViewTextBoxColumn
            // 
            this.emailsoukromyDataGridViewTextBoxColumn.DataPropertyName = "email_soukromy";
            this.emailsoukromyDataGridViewTextBoxColumn.HeaderText = "email_soukromy";
            this.emailsoukromyDataGridViewTextBoxColumn.Name = "emailsoukromyDataGridViewTextBoxColumn";
            this.emailsoukromyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kancelarDataGridViewTextBoxColumn
            // 
            this.kancelarDataGridViewTextBoxColumn.DataPropertyName = "kancelar";
            this.kancelarDataGridViewTextBoxColumn.HeaderText = "kancelar";
            this.kancelarDataGridViewTextBoxColumn.Name = "kancelarDataGridViewTextBoxColumn";
            this.kancelarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uvazekDataGridViewTextBoxColumn
            // 
            this.uvazekDataGridViewTextBoxColumn.DataPropertyName = "uvazek";
            this.uvazekDataGridViewTextBoxColumn.HeaderText = "uvazek";
            this.uvazekDataGridViewTextBoxColumn.Name = "uvazekDataGridViewTextBoxColumn";
            this.uvazekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorantDataGridViewTextBoxColumn
            // 
            this.doktorantDataGridViewTextBoxColumn.DataPropertyName = "doktorant";
            this.doktorantDataGridViewTextBoxColumn.HeaderText = "doktorant";
            this.doktorantDataGridViewTextBoxColumn.Name = "doktorantDataGridViewTextBoxColumn";
            this.doktorantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pracovnibodybezangDataGridViewTextBoxColumn
            // 
            this.pracovnibodybezangDataGridViewTextBoxColumn.DataPropertyName = "pracovni_body_bez_ang";
            this.pracovnibodybezangDataGridViewTextBoxColumn.HeaderText = "pracovni_body_bez_ang";
            this.pracovnibodybezangDataGridViewTextBoxColumn.Name = "pracovnibodybezangDataGridViewTextBoxColumn";
            this.pracovnibodybezangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pracovnibodysangDataGridViewTextBoxColumn
            // 
            this.pracovnibodysangDataGridViewTextBoxColumn.DataPropertyName = "pracovni_body_s_ang";
            this.pracovnibodysangDataGridViewTextBoxColumn.HeaderText = "pracovni_body_s_ang";
            this.pracovnibodysangDataGridViewTextBoxColumn.Name = "pracovnibodysangDataGridViewTextBoxColumn";
            this.pracovnibodysangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zamestnanciBindingSource
            // 
            this.zamestnanciBindingSource.DataMember = "Zamestnanci";
            this.zamestnanciBindingSource.DataSource = this.databaseUTBDataSet3;
            // 
            // databaseUTBDataSet3
            // 
            this.databaseUTBDataSet3.DataSetName = "DatabaseUTBDataSet3";
            this.databaseUTBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamestnanciTableAdapter
            // 
            this.zamestnanciTableAdapter.ClearBeforeFill = true;
            // 
            // update_tlacitko
            // 
            this.update_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update_tlacitko.Location = new System.Drawing.Point(672, 604);
            this.update_tlacitko.Name = "update_tlacitko";
            this.update_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.update_tlacitko.TabIndex = 33;
            this.update_tlacitko.Text = "Zapsat změny";
            this.update_tlacitko.UseVisualStyleBackColor = true;
            this.update_tlacitko.Click += new System.EventHandler(this.ZapsatZmeny);
            // 
            // new_tlacitko
            // 
            this.new_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_tlacitko.Location = new System.Drawing.Point(939, 604);
            this.new_tlacitko.Name = "new_tlacitko";
            this.new_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.new_tlacitko.TabIndex = 34;
            this.new_tlacitko.Text = "Zapsat nový záznam";
            this.new_tlacitko.UseVisualStyleBackColor = true;
            this.new_tlacitko.Click += new System.EventHandler(this.NovyZaznam);
            // 
            // delete_tlacitko
            // 
            this.delete_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_tlacitko.Location = new System.Drawing.Point(673, 667);
            this.delete_tlacitko.Name = "delete_tlacitko";
            this.delete_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.delete_tlacitko.TabIndex = 35;
            this.delete_tlacitko.Text = "Smazat záznam";
            this.delete_tlacitko.UseVisualStyleBackColor = true;
            this.delete_tlacitko.Click += new System.EventHandler(this.SmazatZaznam);
            // 
            // clear_tlacitko
            // 
            this.clear_tlacitko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear_tlacitko.Location = new System.Drawing.Point(939, 667);
            this.clear_tlacitko.Name = "clear_tlacitko";
            this.clear_tlacitko.Size = new System.Drawing.Size(233, 45);
            this.clear_tlacitko.TabIndex = 36;
            this.clear_tlacitko.Text = "Vymazat obsah záznamu";
            this.clear_tlacitko.UseVisualStyleBackColor = true;
            this.clear_tlacitko.Click += new System.EventHandler(this.ResetFormulare);
            // 
            // Zamestnanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.clear_tlacitko);
            this.Controls.Add(this.delete_tlacitko);
            this.Controls.Add(this.new_tlacitko);
            this.Controls.Add(this.update_tlacitko);
            this.Controls.Add(this.zamestnanciView);
            this.Controls.Add(this.vstupDoktorant);
            this.Controls.Add(this.vstupID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.vstupBodySAngl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.vstupBodyBezAngl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vstupUvazek);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.vstupKancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vstupEmail_soukromy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vstupEmail_pracovni);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vstupTelefon_soukromy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vstupTelefon_pracovni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vstupTitul_za);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vstupTitul_pred);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vstupJmeno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vstupPrijmeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Zamestnanci";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaměstnanci UTB";
            this.Load += new System.EventHandler(this.Zamestnanci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUTBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vstupPrijmeni;
        private System.Windows.Forms.TextBox vstupJmeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vstupTitul_pred;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vstupTelefon_soukromy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vstupTelefon_pracovni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vstupTitul_za;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vstupKancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vstupEmail_soukromy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vstupEmail_pracovni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vstupBodyBezAngl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vstupUvazek;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox vstupBodySAngl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox vstupID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox vstupDoktorant;
        private System.Windows.Forms.DataGridView zamestnanciView;
        private DatabaseUTBDataSet3 databaseUTBDataSet3;
        private System.Windows.Forms.BindingSource zamestnanciBindingSource;
        private DatabaseUTBDataSet3TableAdapters.ZamestnanciTableAdapter zamestnanciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulpredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonpracovniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonsoukromyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailpracovniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailsoukromyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kancelarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uvazekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracovnibodybezangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracovnibodysangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button update_tlacitko;
        private System.Windows.Forms.Button new_tlacitko;
        private System.Windows.Forms.Button delete_tlacitko;
        private System.Windows.Forms.Button clear_tlacitko;
    }
}

