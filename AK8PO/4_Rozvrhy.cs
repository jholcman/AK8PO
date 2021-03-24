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
    public partial class Rozvrhy : Form
    {
        public Rozvrhy()
        {
            InitializeComponent();
        }
        private void Rozvrhy_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet18.Jazyk'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.jazykTableAdapter.Fill(this.databaseUTBDataSet18.Jazyk);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet17.Typ'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.typTableAdapter.Fill(this.databaseUTBDataSet17.Typ);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet16.Forma'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.formaTableAdapter.Fill(this.databaseUTBDataSet16.Forma);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet15.Semestr'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.semestrTableAdapter.Fill(this.databaseUTBDataSet15.Semestr);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet14.Rocnik'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.rocnikTableAdapter.Fill(this.databaseUTBDataSet14.Rocnik);

            LoadSkupinka();
            //LoadPredmet(0);
        }

        private void LoadSkupinka()
        {
            dataSkupinka.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Studenti ORDER BY zkratka ASC,rocnik ASC,semestr DESC");
        }
        private void LoadPredmet(int forma)
        {
            switch (forma)
            {
                case 1:
                    dataPredmet.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Predmet WHERE pocet_tydnu<>1 ORDER BY zkratka ASC");
                    break;
                case 2:
                    dataPredmet.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Predmet WHERE pocet_tydnu=1 ORDER BY zkratka ASC");
                    break;
                default:
                    dataPredmet.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Predmet ORDER BY zkratka ASC");
                    break;
            }
        }

        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }
        private void SmazatVybranyPredmet(object sender, EventArgs e)
        {
            int idRozvrh;
            idRozvrh = int.Parse(dataPredmetVybran.SelectedRows[0].Cells[0].Value.ToString());
 
            if (idRozvrh > 0)
            {
                var dotaz = MessageBox.Show("Opravdu vymazat tento záznam?", "Mazání záznamu",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (dotaz == DialogResult.Yes)
                {

                    StringLibrary.SmazatZaznam("DELETE FROM Rozvrh WHERE Id=" + idRozvrh.ToString());
                    MessageBox.Show("Záznam byl smazán", "Záznam byl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadVybranyPredmet();
                }

            }
            else
            {
                MessageBox.Show("Není vybrán žádný záznam pro smazání!", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void VyberPredmet(object sender, EventArgs e)
        {
            int idStudent;
            int idPredmet;
            idStudent = int.Parse(dataSkupinka.SelectedRows[0].Cells[0].Value.ToString());
            idPredmet = int.Parse(dataPredmet.SelectedRows[0].Cells[0].Value.ToString());
 
            if ((idStudent > 0) && (idPredmet > 0))
            {
                int pocetZaznamu = StringLibrary.SpoctiPrvky("SELECT COUNT(*) FROM Rozvrh WHERE (Id_studenti=" + idStudent.ToString() + " AND Id_predmet=" + idPredmet.ToString() + ")");

                if (pocetZaznamu == 0)
                {
                    StringLibrary.ZapisZaznam("INSERT INTO Rozvrh (Id_predmet, Id_studenti) VALUES (" + idPredmet.ToString() + ", " + idStudent.ToString() + ")");
                }
                else
                {
                    MessageBox.Show("Tento Předmět byl již vybrán!", "Vybrat jiný záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Není vybrán žádná Skupinka nebo Předmět", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadVybranyPredmet();
        }
        private void LoadVybranyPredmet()
        {
            int idStudent;
            idStudent = int.Parse(dataSkupinka.SelectedRows[0].Cells[0].Value.ToString());
            dataPredmetVybran.DataSource = StringLibrary.NactiDataTabulku("SELECT Rozvrh.Id, Rozvrh.Id_predmet, Predmet.zkratka FROM Rozvrh LEFT JOIN Predmet On Rozvrh.Id_predmet = Predmet.Id WHERE Rozvrh.Id_studenti = " + idStudent.ToString() + " ORDER BY Predmet.zkratka");
        }

        private void NactiPredmety(object sender, DataGridViewCellEventArgs e)
        {
            LoadVybranyPredmet();
            LoadPredmet(int.Parse(dataSkupinka.SelectedRows[0].Cells[4].Value.ToString()));
        }
    }
}
