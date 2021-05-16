using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLibraries;

namespace AK8PO
{
    public partial class Kapacita : Form
    {
        public Kapacita()
        {
            InitializeComponent();
        }

        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }

        private void Kapacita_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet41.Stitky'. Můžete jej přesunout nebo jej odstranit podle potřeby.
           // this.stitkyTableAdapter1.Fill(this.databaseUTBDataSet41.Stitky);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet36.TypStitku'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.typStitkuTableAdapter.Fill(this.databaseUTBDataSet36.TypStitku);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet35.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.predmetTableAdapter.Fill(this.databaseUTBDataSet35.Predmet);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet34.Stitky'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.stitkyTableAdapter.Fill(this.databaseUTBDataSet34.Stitky);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet33.Zamestnanci'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zamestnanciTableAdapter.Fill(this.databaseUTBDataSet33.Zamestnanci);
            StringLibrary.GenerujIdComboKapacitaJmeno(comboZamestnanec, 1);
            float uvazekZamestnance = StringLibrary.NactiUvazekKapacita(1);
            uvazekLabel.Text = uvazekZamestnance.ToString();
            uvazekPBLabel.Text = (uvazekZamestnance * 1000).ToString();
            vybraneStitky.DataSource = "";
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stitkyTableAdapter.FillBy(this.databaseUTBDataSet34.Stitky);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ZobrazKartu(object sender, EventArgs e)
        {
            int idZamestnanec = int.Parse(comboZamestnanec.SelectedValue.ToString());
            float uvazekZamestnance = StringLibrary.NactiUvazekKapacita(idZamestnanec);
            uvazekLabel.Text = uvazekZamestnance.ToString();
            uvazekPBLabel.Text = (uvazekZamestnance * 1000).ToString();

            dataPool.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Stitky WHERE id_zamestnanec=0 AND id_predmet<>0");
            float celkemBodu = StringLibrary.NactiPrimaVyuka(dataPrimaVyuka, idZamestnanec);
            celkemPBLabel.Text = celkemBodu.ToString();
            double procento = Math.Ceiling(celkemBodu / float.Parse(uvazekPBLabel.Text) * 100);
            if (procento > 100) {
                celkemProcentoLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                celkemProcentoLabel.ForeColor = System.Drawing.Color.Black;
            }
            celkemProcentoLabel.Text = procento.ToString() + " %";

        }

        private void ZobrazDoleva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pridatStitek.Visible = true;
            ubratStitek.Visible = false;
        }

        private void ZobrazDoprava_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pridatStitek.Visible = false;
            ubratStitek.Visible = true;
        }

        private void PolozkaCellClick(object sender, DataGridViewCellEventArgs e)
        {
            pridatStitek.Visible = false;
            ubratStitek.Visible = false;
            int typStitku;
            int zamestnanec = int.Parse(comboZamestnanec.SelectedValue.ToString());
            int predmet = int.Parse(dataPrimaVyuka.Rows[e.RowIndex].Cells[0].Value.ToString());
            int kliknutoNaCell = int.Parse(e.ColumnIndex.ToString());
            //MessageBox.Show(dataPrimaVyuka.SelectedCells[0].ColumnIndex.ToString(), "Záznam byl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (kliknutoNaCell == 7 || kliknutoNaCell == 8 || kliknutoNaCell == 9) 
            {
                switch (kliknutoNaCell)
                {
                    case 7:
                        typStitku = 4;
                        break;
                    case 8:
                        typStitku = 5;
                        break;
                    default:
                        typStitku = 6;
                        break;
                }
                vybraneStitky.DataSource = StringLibrary.NactiDataTabulku("SELECT Id,stitek_cislo,pocet_studentu FROM Stitky WHERE id_predmet=" + predmet.ToString() + " AND typ_stitku=" + typStitku.ToString() + " AND id_zamestnanec=" + zamestnanec.ToString());
            }
            else
            {
                vybraneStitky.DataSource = "";
            }
        }

        private void StitekZamestnanciClickButton(object sender, EventArgs e)
        {
            try
            {
                pridatStitek.Visible = false;
                ubratStitek.Visible = false;
                //dataPool.Columns["idPool"].Visible = true;
                int idStitek = int.Parse(dataPool.SelectedRows[0].Cells[0].Value.ToString());
                //dataPool.Columns["idPool"].Visible = false;

                int idZamestnanec = int.Parse(comboZamestnanec.SelectedValue.ToString());
                StringLibrary.ZapisZaznam("UPDATE Stitky SET id_zamestnanec=" + idZamestnanec.ToString() + " WHERE Id=" + idStitek.ToString());
                dataPool.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Stitky WHERE id_zamestnanec=0 AND id_predmet<>0");
                float celkemBodu = StringLibrary.NactiPrimaVyuka(dataPrimaVyuka, idZamestnanec);
                vybraneStitky.DataSource = "";
                celkemPBLabel.Text = celkemBodu.ToString();
                double procento = Math.Ceiling(celkemBodu / float.Parse(uvazekPBLabel.Text) * 100);
                if (procento > 100)
                {
                    celkemProcentoLabel.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    celkemProcentoLabel.ForeColor = System.Drawing.Color.Black;
                }
                celkemProcentoLabel.Text = procento.ToString() + " %";



                //MessageBox.Show(idStitek.ToString(), "Záznam byl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
            }
        }

        private void StitekDoPooluClickButton(object sender, EventArgs e)
        {
            pridatStitek.Visible = false;
            ubratStitek.Visible = false;
            //vybraneStitky.Columns["idPrehled"].Visible = true;
            int idStitekVybran = int.Parse(vybraneStitky.SelectedRows[0].Cells[0].Value.ToString());
            //vybraneStitky.Columns["idPrehled"].Visible = false;

            int idZamestnanec = int.Parse(comboZamestnanec.SelectedValue.ToString());
            StringLibrary.ZapisZaznam("UPDATE Stitky SET id_zamestnanec=0 WHERE Id=" + idStitekVybran.ToString());
            dataPool.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Stitky WHERE id_zamestnanec=0 AND id_predmet<>0");
            float celkemBodu = StringLibrary.NactiPrimaVyuka(dataPrimaVyuka, idZamestnanec);
            vybraneStitky.DataSource = "";
            celkemPBLabel.Text = celkemBodu.ToString();
            double procento = Math.Ceiling(celkemBodu / float.Parse(uvazekPBLabel.Text) * 100);
            if (procento > 100)
            {
                celkemProcentoLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                celkemProcentoLabel.ForeColor = System.Drawing.Color.Black;
            }
            celkemProcentoLabel.Text = procento.ToString() + " %";

        }
    }
}
