using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UtilityLibraries;

namespace AK8PO
{
    public partial class Studenti : Form
    {
        SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());

        public Studenti()
        {
            InitializeComponent();

            StringLibrary.GenerujIdCombo(vstupRocnik, "Rocnik", "Rocnik_text", 1);
            StringLibrary.GenerujIdCombo(vstupSemestr, "Semestr", "Semestr_text", 1);
            StringLibrary.GenerujIdCombo(vstupForma_studia, "Forma", "Forma_text", 1);
            StringLibrary.GenerujIdCombo(vstupTyp_studia, "Typ", "Typ_text", 1);
            StringLibrary.GenerujIdCombo(vstupJazyk, "Jazyk", "Jazyk_text", 1);

        }
        private void Studenti_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet11.Jazyk'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.jazykTableAdapter1.Fill(this.databaseUTBDataSet11.Jazyk);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet10.Typ'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.typTableAdapter1.Fill(this.databaseUTBDataSet10.Typ);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet9.Forma'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.formaTableAdapter1.Fill(this.databaseUTBDataSet9.Forma);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet8.Semestr'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.semestrTableAdapter1.Fill(this.databaseUTBDataSet8.Semestr);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet7.Rocnik'. Můžete jej přesunout nebo jej odstranit podle potřeby.
           this.rocnikTableAdapter1.Fill(this.databaseUTBDataSet7.Rocnik);
            LoadForm();
        }

        private void LoadForm()
        {
            string dotaz = "SELECT * from Studenti ORDER BY zkratka ASC,rocnik ASC,semestr DESC";
            studentiView.DataSource = StringLibrary.NactiDataTabulku(dotaz);
        }
        private void VyberZaznamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vstupID.Text = studentiView.SelectedRows[0].Cells[0].Value.ToString();
            vstupZkratka.Text = studentiView.SelectedRows[0].Cells[1].Value.ToString();
            vstupRocnik.SelectedValue = studentiView.SelectedRows[0].Cells[2].Value;
            vstupSemestr.SelectedValue = int.Parse(studentiView.SelectedRows[0].Cells[3].Value.ToString());
            vstupPocetStudentu.Text = studentiView.SelectedRows[0].Cells[4].Value.ToString();
            vstupForma_studia.SelectedValue = int.Parse(studentiView.SelectedRows[0].Cells[5].Value.ToString());
            vstupTyp_studia.SelectedValue = int.Parse(studentiView.SelectedRows[0].Cells[6].Value.ToString());
            vstupJazyk.SelectedValue = int.Parse(studentiView.SelectedRows[0].Cells[7].Value.ToString());
            vstupNazev_studia.Text = studentiView.SelectedRows[0].Cells[8].Value.ToString();
 
        }

        private void ResetFormulare(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            vstupID.Clear();
            vstupZkratka.Clear();
            vstupRocnik.SelectedValue = 1;
            vstupSemestr.SelectedValue = 1;
            vstupPocetStudentu.Clear();
            vstupForma_studia.SelectedValue = 1;
            vstupTyp_studia.SelectedValue = 1;
            vstupJazyk.SelectedValue = 1;
            vstupNazev_studia.Clear();
        }

        private void SmazatZaznam(object sender, EventArgs e)
        {
            if (vstupID.Text != "")
            {
                if (StringLibrary.SpoctiPrvky("SELECT COUNT(*) FROM Rozvrh WHERE Id_studenti=" + vstupID.Text) == 0)
                {
                    var dotaz = MessageBox.Show("Opravdu vymazat tento záznam?", "Mazání záznamu",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

                    if (dotaz == DialogResult.Yes)
                    {
                        StringLibrary.SmazatZaznam("DELETE FROM Studenti WHERE Id=" + vstupID.Text);
                        MessageBox.Show("Záznam byl smazán", "Záznam byl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetForm();
                        LoadForm();
                    }
                }
                else
                {
                    MessageBox.Show("Tuto skupinu nelze smazat,je rozvrhována!!!", "Záznam nebyl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Není vybrán žádný záznam pro smazání!", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZapsatZmeny(object sender, EventArgs e)
        {
            if (vstupID.Text != "")
            {

                if (StringLibrary.SpoctiPrvky("SELECT COUNT(*) FROM Studenti WHERE (zkratka=" + vstupZkratka.Text + " AND rocnik=" + vstupRocnik.SelectedValue.ToString() + " AND semestr=" + vstupSemestr.SelectedValue.ToString() + " AND Id<>" + vstupID.Text + ")") == 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "UPDATE Studenti SET zkratka=@VstupZkratka, rocnik=@VstupRocnik, semestr=@VstupSemestr, pocet_studentu=@VstupPocetStudentu, forma_studia=@VstupForma_studia, typ_studia=@VstupTyp_studia, jazyk=@VstupJazyk, nazev_studia=@VstupNazev_studia WHERE Id = @VstupID";

                    if (!int.TryParse(vstupPocetStudentu.Text, out int pocetS)) { pocetS = 0; }

                    cmd.Parameters.AddWithValue("@VstupID", int.Parse(vstupID.Text));
                    cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
                    cmd.Parameters.AddWithValue("@VstupRocnik", vstupRocnik.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupSemestr", vstupSemestr.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupPocetStudentu", pocetS);
                    cmd.Parameters.AddWithValue("@VstupForma_studia", vstupForma_studia.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupTyp_studia", vstupTyp_studia.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupNazev_studia", vstupNazev_studia.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Záznam byl opraven", "Záznam byl opraven", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Tato SKUPINA pro zadaný ROČNÍK a SEMESTR již existuje, záznam nebyl opraven!", "Zadat jinou skupinu?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Není vybrán žádný záznam pro opravu!", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NovyZaznam(object sender, EventArgs e)
        {
            if (StringLibrary.SpoctiPrvky("SELECT COUNT(*) FROM Studenti WHERE (zkratka=" + vstupZkratka.Text + " AND rocnik=" + vstupRocnik.SelectedValue.ToString() + " AND semestr=" + vstupSemestr.SelectedValue.ToString() + ")") == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO Studenti(zkratka, rocnik, semestr, pocet_studentu, forma_studia, typ_studia, jazyk, nazev_studia) VALUES(@VstupZkratka, @VstupRocnik, @VstupSemestr, @VstupPocetStudentu, @VstupForma_studia, @VstupTyp_studia, @VstupJazyk, @VstupNazev_studia)";

                if (!int.TryParse(vstupPocetStudentu.Text, out int pocetS)) { pocetS = 0; }

                cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
                cmd.Parameters.AddWithValue("@VstupRocnik", vstupRocnik.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupSemestr", vstupSemestr.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupPocetStudentu", pocetS);
                cmd.Parameters.AddWithValue("@VstupForma_studia", vstupForma_studia.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupTyp_studia", vstupTyp_studia.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupNazev_studia", vstupNazev_studia.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Záznam byl přidán", "Záznam byl přidán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetForm();
                LoadForm();
            }
            else
            {
                MessageBox.Show("Tato SKUPINA pro zadaný ROČNÍK a SEMESTR již existuje, záznam nebyl přidán!", "Zadat jinou skupinu?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }
    }
}
