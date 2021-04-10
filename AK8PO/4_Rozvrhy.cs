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
                    StringLibrary.SmazatZaznam("DELETE FROM Rozvrh WHERE Id=" + idRozvrh.ToString());
                    LoadPredmety();
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
                StringLibrary.ZapisZaznam("INSERT INTO Rozvrh (Id_predmet, Id_studenti) VALUES (" + idPredmet.ToString() + ", " + idStudent.ToString() + ")");
            }
            else
            {
                MessageBox.Show("Není vybrán žádná Skupinka nebo Předmět", "Vybrat záznam?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadPredmety();
        }
        private void LoadPredmety()
        {
             // vybrane predmety
            int idStudent = int.Parse(dataSkupinka.SelectedRows[0].Cells[0].Value.ToString());
            dataPredmetVybran.DataSource = StringLibrary.NactiDataTabulku("SELECT Rozvrh.Id, Rozvrh.Id_predmet, Predmet.zkratka FROM Rozvrh LEFT JOIN Predmet On Rozvrh.Id_predmet = Predmet.Id WHERE Rozvrh.Id_studenti=" + idStudent.ToString() + " ORDER BY Predmet.zkratka");

            // predmety na vyber
            int forma_studia = int.Parse(dataSkupinka.SelectedRows[0].Cells[4].Value.ToString());
            int semestr = int.Parse(dataSkupinka.SelectedRows[0].Cells[3].Value.ToString());
            switch (forma_studia)
            {
                case 1:
                    dataPredmet.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Predmet WHERE pocet_tydnu<>1 AND semestr=" + semestr.ToString() + " AND (SELECT COUNT(*) FROM Rozvrh WHERE Predmet.Id=Rozvrh.Id_predmet AND Rozvrh.Id_studenti=" + idStudent.ToString() + ")=0 ORDER BY zkratka ASC");
                    break;
                case 2:
                    dataPredmet.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Predmet WHERE pocet_tydnu=1 AND semestr=" + semestr.ToString() + " AND (SELECT COUNT(*) FROM Rozvrh WHERE Predmet.Id=Rozvrh.Id_predmet AND Rozvrh.Id_studenti=" + idStudent.ToString() + ")=0 ORDER BY zkratka ASC");
                    break;
                default:
                    dataPredmet.DataSource = StringLibrary.NactiDataTabulku("SELECT * FROM Predmet ORDER BY zkratka ASC");
                    break;
            }
            dataPredmetVybran.AllowDrop = true;
            dataPredmet.AllowDrop = true;

        }

        private void NactiPredmety(object sender, DataGridViewCellEventArgs e)
        {
            LoadPredmety();
        }
        //z prava do leva - vybrat předmět

        private void DataPredmetMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dataPredmetVybran.AllowDrop = true;
                dataPredmet.AllowDrop = false;
                DataGridView.HitTestInfo info = dataPredmet.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                        string text = (String)dataPredmet.Rows[info.RowIndex].Cells[0].Value.ToString();
                        if (text != null)
                        {
                            dataPredmet.DoDragDrop(text, DragDropEffects.Copy);
                        }
                }
            }
        }

        private void DataPredmetVybranDragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DataPredmetVybranDragDrop(object sender, DragEventArgs e)
        {

            int idStudent = int.Parse(dataSkupinka.SelectedRows[0].Cells[0].Value.ToString());
            int idPredmet = int.Parse(e.Data.GetData(DataFormats.Text).ToString());
            StringLibrary.ZapisZaznam("INSERT INTO Rozvrh (Id_predmet, Id_studenti) VALUES (" + idPredmet.ToString() + ", " + idStudent.ToString() + ")");
            LoadPredmety();
        }
        //z leva do prava - zrušit vybraný předmět
        private void DataPredmetVybranMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dataPredmetVybran.AllowDrop = false;
                dataPredmet.AllowDrop = true;
                DataGridView.HitTestInfo info = dataPredmetVybran.HitTest(e.X, e.Y);
                if (info.RowIndex >= 0)
                {
                    string text = (String)dataPredmetVybran.Rows[info.RowIndex].Cells[0].Value.ToString();
                    if (text != null)
                    {
                        dataPredmetVybran.DoDragDrop(text, DragDropEffects.Copy);
                    }
                }
            }
        }
        private void DataPredmetDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void DataPredmetDragDrop(object sender, DragEventArgs e)
        {
            int idRozvrh;
            idRozvrh = int.Parse(e.Data.GetData(DataFormats.Text).ToString());
            StringLibrary.ZapisZaznam("DELETE FROM Rozvrh WHERE Id = " + idRozvrh.ToString());
            LoadPredmety();
        }
    }
}
