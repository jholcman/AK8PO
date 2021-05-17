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

    public partial class Stitky : Form
    {
        public Stitky()
        {
            InitializeComponent();
        }

        public void Stitky_Load(object sender, EventArgs e)
        {

            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet27.Jazyk'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.jazykTableAdapter.Fill(this.databaseUTBDataSet27.Jazyk);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet26.TypStitku'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.typStitkuTableAdapter.Fill(this.databaseUTBDataSet26.TypStitku);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet25.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.predmetTableAdapter.Fill(this.databaseUTBDataSet25.Predmet);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet24.Stitky'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.stitkyTableAdapter.Fill(this.databaseUTBDataSet24.Stitky);

            StringLibrary.GenerujIdComboStitekJmeno(comboZamestnanec, 0);
            StringLibrary.GenerujIdComboStitekPredmet(comboPredmet, 0);
            AktualizujTable();
        }

        private void AktualizujTable()
        {
            string dotaz = "SELECT s.Id, s.stitek_cislo, ISNULL(z.prijmeni + ' ' + z.jmeno, 'Neprirazen') as vyucujici, ISNULL(p.zkratka, 'Nezadán') AS zkratka, ISNULL(t.Typ_stitku_text, 'Nezadan') AS typ_stitku, s.pocet_studentu, s.pocet_hodin, s.pocet_tydnu, ISNULL(j.Jazyk_text, 'Nezadan') AS jazyk, ISNULL(s.pocet_bodu, 0) AS pocet_bodu, s.poznamka FROM Stitky AS s LEFT JOIN Zamestnanci AS z ON s.id_zamestnanec = z.Id LEFT JOIN Predmet AS p ON s.id_predmet = p.Id LEFT JOIN TypStitku AS t ON s.typ_stitku = t.Id LEFT JOIN Jazyk AS j ON s.jazyk = j.Id ORDER BY vyucujici,zkratka,typ_stitku,stitek_cislo ASC";
            dataStitky.DataSource = StringLibrary.NactiDataTabulku(dotaz);
        }
        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }

        public void VyberZamestnance(object sender, EventArgs e)
        {
 
            int zam = (int)comboZamestnanec.SelectedValue;
            int pre;
            if (comboPredmet.SelectedValue == null) { pre = 0; } else { pre = (int)comboPredmet.SelectedValue; }
            
            string dotaz = StringLibrary.GenerujDotaz(zam, pre);
            dataStitky.DataSource = StringLibrary.NactiDataTabulku(dotaz);
            StringLibrary.BarvaNeprirazenych(dataStitky, Color.Yellow);
        }

        public void VyberPredmet(object sender, EventArgs e)
        {
           

            int a = (int)comboPredmet.SelectedValue;
            if (a > 0)
            {
                int pocetZaznamu = StringLibrary.SpoctiPrvky("SELECT COUNT(*) FROM Stitky WHERE id_predmet=" + a.ToString());
                if (pocetZaznamu > 0)
                {
                    generujStitkyButton.Visible = false;
                    generujStitkyPopis.Visible = false;

                }
                else
                {
                    generujStitkyButton.Visible = true;
                    generujStitkyPopis.Visible = true;

                }
            }
            else
            {
                generujStitkyButton.Visible = false;
                generujStitkyPopis.Visible = false;
            }

            int zam = (int)comboZamestnanec.SelectedValue;
            int pre = (int)comboPredmet.SelectedValue;
            string dotaz = StringLibrary.GenerujDotaz(zam, pre);
            dataStitky.DataSource = StringLibrary.NactiDataTabulku(dotaz);
            StringLibrary.BarvaNeprirazenych(dataStitky, Color.Yellow);
        }

        private void GenerujStitkyPredmet(object sender, EventArgs e)
        {
            int idPredmet = (int)comboPredmet.SelectedValue;
            int idZamestnanec = (int)comboZamestnanec.SelectedValue;
 
            StringLibrary.GenerujStitky(idPredmet, idZamestnanec);

            int zam = (int)comboZamestnanec.SelectedValue;
            int pre = (int)comboPredmet.SelectedValue;
            string dotaz = StringLibrary.GenerujDotaz(zam, pre);
            dataStitky.DataSource = StringLibrary.NactiDataTabulku(dotaz);

            generujStitkyButton.Visible = false;
            generujStitkyPopis.Visible = false;
            StringLibrary.BarvaNeprirazenych(dataStitky, Color.Yellow);
        }

        private void ZmenaObsahu(object sender, EventArgs e)
        {
            StringLibrary.BarvaNeprirazenych(dataStitky, Color.Yellow);
        }

        private void SmazatStitek(object sender, EventArgs e)
        {
            StringLibrary.SmazatZaznam("DELETE FROM Stitky WHERE Id=" + vstupID.Text);
            MessageBox.Show("Záznam byl smazán", "Záznam byl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textID.Visible = false;
            vstupID.Visible = false;
            vstupID.Text = "0";
            buttonSmazatID.Visible = false;

            AktualizujTable();
            StringLibrary.BarvaNeprirazenych(dataStitky, Color.Yellow);
        }

        private void VyberZaznam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (int.Parse(dataStitky.SelectedRows[0].Cells[2].Value.ToString()) == 0)
            {
                textID.Visible = true;
                vstupID.Visible = true;
                vstupID.Text = dataStitky.SelectedRows[0].Cells[0].Value.ToString();
                buttonSmazatID.Visible = true;
            }
            else
            {
                textID.Visible = false;
                vstupID.Visible = false;
                vstupID.Text = dataStitky.SelectedRows[0].Cells[0].Value.ToString();
                buttonSmazatID.Visible = false;

            }
        }
    }
}
