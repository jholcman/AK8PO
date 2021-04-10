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
    public partial class Predmet : Form
    {
        SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());

        public Predmet()
        {
            InitializeComponent();
            StringLibrary.GenerujIdCombo(vstupZakonceni, "Zakonceni", "Zakonceni_text", 1);
            StringLibrary.GenerujIdCombo(vstupJazyk, "Jazyk", "Jazyk_text", 1);
            StringLibrary.GenerujIdCombo(vstupSemestr, "Semestr", "Semestr_text", 1);
        }

        private void Predmet_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet40.Semestr'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.semestrTableAdapter.Fill(this.databaseUTBDataSet40.Semestr);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet39.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.predmetTableAdapter4.Fill(this.databaseUTBDataSet39.Predmet);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet38.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.predmetTableAdapter3.Fill(this.databaseUTBDataSet38.Predmet);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet13.Zakonceni'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zakonceniTableAdapter.Fill(this.databaseUTBDataSet13.Zakonceni);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet12.Jazyk'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.jazykTableAdapter.Fill(this.databaseUTBDataSet12.Jazyk);
             LoadForm();

        }
        private void LoadForm()
        {
            string dotaz = "SELECT * from Predmet ORDER BY zkratka ASC";
            predmetyView.DataSource = StringLibrary.NactiDataTabulku(dotaz);

        }
        private void VyberZaznamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vstupID.Text = predmetyView.SelectedRows[0].Cells[0].Value.ToString();
            vstupZkratka.Text = predmetyView.SelectedRows[0].Cells[1].Value.ToString();
            vstupPocet_tydnu.Text = predmetyView.SelectedRows[0].Cells[2].Value.ToString();
            vstupPrednasky.Text = predmetyView.SelectedRows[0].Cells[3].Value.ToString();
            vstupCviceni.Text = predmetyView.SelectedRows[0].Cells[4].Value.ToString();
            vstupSeminare.Text = predmetyView.SelectedRows[0].Cells[5].Value.ToString();
            vstupZakonceni.SelectedValue = int.Parse(predmetyView.SelectedRows[0].Cells[6].Value.ToString());
            vstupJazyk.SelectedValue = int.Parse(predmetyView.SelectedRows[0].Cells[7].Value.ToString());
            vstupVelikost_tridy.Text = predmetyView.SelectedRows[0].Cells[8].Value.ToString();
            vstupSemestr.SelectedValue = int.Parse(predmetyView.SelectedRows[0].Cells[9].Value.ToString());
            vstupNazev_predmetu.Text = predmetyView.SelectedRows[0].Cells[10].Value.ToString();
            vstupPocet_kreditu.Text = predmetyView.SelectedRows[0].Cells[11].Value.ToString();
            vstupGarant_ustav.Text = predmetyView.SelectedRows[0].Cells[12].Value.ToString();
            vstupGarant_osoba.Text = predmetyView.SelectedRows[0].Cells[13].Value.ToString();
        }
        private void ResetFormulare(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            vstupID.Clear();
            vstupZkratka.Clear();
            vstupPocet_tydnu.Clear();
            vstupPrednasky.Clear();
            vstupCviceni.Clear();
            vstupSeminare.Clear();
            vstupZakonceni.SelectedValue = 1;
            vstupJazyk.SelectedValue = 1;
            vstupVelikost_tridy.Clear();
            vstupSemestr.SelectedValue = 1;
            vstupNazev_predmetu.Clear();
            vstupPocet_kreditu.Clear();
            vstupGarant_ustav.Clear();
            vstupGarant_osoba.Clear();
        }
        private void ZapsatZmeny(object sender, EventArgs e)
        {
            if (vstupID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE Predmet SET zkratka=@VstupZkratka, pocet_tydnu=@VstupPocet_tydnu, prednasky=@VstupPrednasky, cviceni=@VstupCviceni, seminare=@VstupSeminare, zakonceni=@VstupZakonceni, jazyk=@VstupJazyk, velikost_tridy=@VstupVelikost_tridy, semestr=@VstupSemestr, nazev_predmetu=@VstupNazev_predmetu, pocet_kreditu=@VstupPocet_kreditu, garant_ustav=@VstupGarant_ustav, garant_osoba=@VstupGarant_osoba WHERE Id = @VstupID", con);

                if (!int.TryParse(vstupPocet_tydnu.Text, out int pocetTydnu)) { pocetTydnu = 14; }
                if (!int.TryParse(vstupPrednasky.Text, out int pocetP)) { pocetP = 0; }
                if (!int.TryParse(vstupCviceni.Text, out int pocetC)) { pocetC = 0; }
                if (!int.TryParse(vstupSeminare.Text, out int pocetS)) { pocetS = 0; }
                if (!int.TryParse(vstupVelikost_tridy.Text, out int trida)) { trida = 0; }
                if (!int.TryParse(vstupPocet_kreditu.Text, out int kredit)) { kredit = 0; }

                cmd.Parameters.AddWithValue("@VstupID", int.Parse(vstupID.Text));
                cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
                cmd.Parameters.AddWithValue("@VstupPocet_tydnu", pocetTydnu);
                cmd.Parameters.AddWithValue("@VstupPrednasky", pocetP);
                cmd.Parameters.AddWithValue("@VstupCviceni", pocetC);
                cmd.Parameters.AddWithValue("@VstupSeminare", pocetS);
                cmd.Parameters.AddWithValue("@VstupZakonceni", vstupZakonceni.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupVelikost_tridy", trida);
                cmd.Parameters.AddWithValue("@VstupSemestr", vstupSemestr.SelectedValue);
                cmd.Parameters.AddWithValue("@VstupNazev_predmetu", vstupNazev_predmetu.Text);
                cmd.Parameters.AddWithValue("@VstupPocet_kreditu", kredit);
                cmd.Parameters.AddWithValue("@VstupGarant_ustav", vstupGarant_ustav.Text);
                cmd.Parameters.AddWithValue("@VstupGarant_osoba", vstupGarant_osoba.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Záznam byl opraven", "Záznam byl opraven", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetForm();
                LoadForm();
            }
            else
            {
                MessageBox.Show("Není vybrán žádný záznam pro opravu!", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NovyZaznam(object sender, EventArgs e)
        {
            if (vstupZkratka.Text != "")
            {
                if (StringLibrary.SpoctiPrvky("SELECT COUNT(*) FROM Predmet WHERE zkratka='" + vstupZkratka.Text + "'") == 0) 
                { 
                    SqlCommand cmd = new SqlCommand("INSERT INTO Predmet (zkratka, pocet_tydnu, prednasky, cviceni, seminare, zakonceni, jazyk, velikost_tridy, semestr, nazev_predmetu, pocet_kreditu, garant_ustav, garant_osoba) VALUES (@VstupZkratka, @VstupPocet_tydnu, @VstupPrednasky, @VstupCviceni, @VstupSeminare, @VstupZakonceni, @VstupJazyk, @VstupVelikost_tridy, @VstupSemestr, @VstupNazev_predmetu, @VstupPocet_kreditu, @VstupGarant_ustav, @VstupGarant_osoba)", con);

                    if (!int.TryParse(vstupPocet_tydnu.Text, out int pocetTydnu)) { pocetTydnu = 14; }
                    if (!int.TryParse(vstupPrednasky.Text, out int pocetP)) { pocetP = 0; }
                    if (!int.TryParse(vstupCviceni.Text, out int pocetC)) { pocetC = 0; }
                    if (!int.TryParse(vstupSeminare.Text, out int pocetS)) { pocetS = 0; }
                    if (!int.TryParse(vstupVelikost_tridy.Text, out int trida)) { trida = 0; }
                    if (!int.TryParse(vstupPocet_kreditu.Text, out int kredit)) { kredit = 0; }
                    if (pocetTydnu < 1) pocetTydnu = 14;

                    cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
                    cmd.Parameters.AddWithValue("@VstupPocet_tydnu", pocetTydnu);
                    cmd.Parameters.AddWithValue("@VstupPrednasky", pocetP);
                    cmd.Parameters.AddWithValue("@VstupCviceni", pocetC);
                    cmd.Parameters.AddWithValue("@VstupSeminare", pocetS);
                    cmd.Parameters.AddWithValue("@VstupZakonceni", vstupZakonceni.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupVelikost_tridy", trida);
                    cmd.Parameters.AddWithValue("@VstupSemestr", vstupSemestr.SelectedValue);
                    cmd.Parameters.AddWithValue("@VstupNazev_predmetu", vstupNazev_predmetu.Text);
                    cmd.Parameters.AddWithValue("@VstupPocet_kreditu", kredit);
                    cmd.Parameters.AddWithValue("@VstupGarant_ustav", vstupGarant_ustav.Text);
                    cmd.Parameters.AddWithValue("@VstupGarant_osoba", vstupGarant_osoba.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Záznam byl vytvořen", "Záznam byl vytvořen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Tento předmět již existuje, údaje nebyly zapsány!", "Opravit záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nebylo možno vytvořit nový předmět bez názvu!", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SmazatZaznam(object sender, EventArgs e)
        {
            
           if (vstupID.Text != "")
            {
                if (StringLibrary.SpoctiPrvky("SELECT COUNT(*) FROM Rozvrh WHERE Id_predmet="+ vstupID.Text) == 0)
                {
                    var dotaz = MessageBox.Show("Opravdu vymazat tento záznam?", "Mazání záznamu",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

                    if (dotaz == DialogResult.Yes)
                    {
                        StringLibrary.SmazatZaznam("DELETE FROM Predmet WHERE Id=" + vstupID.Text);
                        MessageBox.Show("Záznam byl smazán", "Záznam byl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetForm();
                        LoadForm();
                    }
                }
                else
                {
                    MessageBox.Show("Tento předmět nelze smazat, je rozvrhován!!!", "Záznam nebyl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Není vybrán žádný záznam pro smazání!", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }
    }
}
