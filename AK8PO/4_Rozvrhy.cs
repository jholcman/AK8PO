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
        SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
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
            LoadPredmet();
        }

        private void LoadSkupinka()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Studenti ORDER BY zkratka ASC,rocnik ASC,semestr DESC", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataSkupinka.DataSource = dt;
        }
        private void LoadPredmet()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Predmet ORDER BY zkratka ASC", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataPredmet.DataSource = dt;
        }

        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }

        private void ZobrazIdSkupinky(object sender, DataGridViewCellEventArgs e)
        {
            LoadVybranyPredmet();
        }

        private void ZobrazIdPredmetu(object sender, DataGridViewCellEventArgs e)
        {
            int idPredmet;
            idPredmet = int.Parse(dataPredmet.SelectedRows[0].Cells[0].Value.ToString());
            predmetId.Text = idPredmet.ToString();

        }

        private void ZobrazIdVybranehoPredmetu(object sender, DataGridViewCellEventArgs e)
        {
            int idVybranyPredmet;
            int idRozvrh;
            idRozvrh = int.Parse(dataPredmetVybran.SelectedRows[0].Cells[0].Value.ToString());
            idVybranyPredmet = int.Parse(dataPredmetVybran.SelectedRows[0].Cells[1].Value.ToString());
            predmetVybranyId.Text = idVybranyPredmet.ToString();
            rozvrhId.Text = idRozvrh.ToString();

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

                    SqlCommand cmd = new SqlCommand("DELETE FROM Rozvrh WHERE Id = @Id_rozvrh", con);

                    cmd.Parameters.AddWithValue("@Id_rozvrh", int.Parse(dataPredmetVybran.SelectedRows[0].Cells[0].Value.ToString()));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            if ((idStudent > 0) && (idPredmet > 0))
            {

                cmd.CommandText = "SELECT COUNT(*) FROM Rozvrh WHERE (Id_studenti=@IdStudent AND Id_predmet=@IdPredmet)";
                cmd.Parameters.AddWithValue("@IdStudent", idStudent);
                cmd.Parameters.AddWithValue("@IdPredmet", idPredmet);
                int pocetZaznamu = (int)cmd.ExecuteScalar();
                pocetVP.Text = pocetZaznamu.ToString();

                if (pocetZaznamu == 0)
                {
                    cmd.CommandText = "INSERT INTO Rozvrh (Id_predmet, Id_studenti) VALUES (@IdPredmet, @IdStudent)";
                    //cmd.Parameters.AddWithValue("@IdStudent", idStudent);
                    //cmd.Parameters.AddWithValue("@IdPredmet", idPredmet);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tento Předmět byl přidán!", "Vše OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            con.Close();
            LoadVybranyPredmet();
        }
        private void LoadVybranyPredmet()
        {
            int idStudent;
            idStudent = int.Parse(dataSkupinka.SelectedRows[0].Cells[0].Value.ToString());
            skupinkaId.Text = idStudent.ToString();

            SqlCommand cmd = new SqlCommand("SELECT Rozvrh.Id,Rozvrh.Id_predmet,Predmet.zkratka FROM Rozvrh LEFT JOIN Predmet On Rozvrh.Id_predmet=Predmet.Id WHERE Rozvrh.Id_studenti=@IdStudent ORDER BY Predmet.zkratka", con);
            cmd.Parameters.AddWithValue("@IdStudent", idStudent);

            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataPredmetVybran.DataSource = dt;
        }

    }
}
