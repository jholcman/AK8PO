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
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet36.TypStitku'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.typStitkuTableAdapter.Fill(this.databaseUTBDataSet36.TypStitku);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet35.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.predmetTableAdapter.Fill(this.databaseUTBDataSet35.Predmet);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet34.Stitky'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.stitkyTableAdapter.Fill(this.databaseUTBDataSet34.Stitky);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet33.Zamestnanci'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zamestnanciTableAdapter.Fill(this.databaseUTBDataSet33.Zamestnanci);
            StringLibrary.GenerujIdComboKapacitaJmeno(comboZamestnanec, 1);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
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
            dataPool.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Stitky WHERE id_zamestnanec=0 AND id_predmet<>0");
            StringLibrary.NactiPrimaVyuka(dataPrimaVyuka, idZamestnanec);
            StringLibrary.NactiZkouseni(dataZkouseni, idZamestnanec);
        }
    }
}
