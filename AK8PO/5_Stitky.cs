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
        SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
        public Stitky()
        {
            InitializeComponent();
        }

        private void Stitky_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet23.Jazyk'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.jazykTableAdapter.Fill(this.databaseUTBDataSet23.Jazyk);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet22.TypStitku'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.typStitkuTableAdapter.Fill(this.databaseUTBDataSet22.TypStitku);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet21.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.predmetTableAdapter.Fill(this.databaseUTBDataSet21.Predmet);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet20.Zamestnanci'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zamestnanciTableAdapter.Fill(this.databaseUTBDataSet20.Zamestnanci);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet19.Stitky'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.stitkyTableAdapter.Fill(this.databaseUTBDataSet19.Stitky);

            StringLibrary.GenerujIdComboStitekJmeno(comboZamestnanec, 0);
            StringLibrary.GenerujIdComboStitekPredmet(comboPredmet, 0);
            LoadForm();
        }

        private void LoadForm()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Stitky ORDER BY id_zamestnanec,id_predmet,typ_stitku,pocet_studentu ASC", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataStitky.DataSource = dt;
        }
        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }

        private void vyberZamestnance(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            int a = (int)comboZamestnanec.SelectedValue;
            if (a > 0) { 
                cmd.CommandText = "SELECT COUNT(*) FROM Stitky WHERE id_zamestnanec=@idZamestnanec";
                cmd.Parameters.AddWithValue("@idZamestnanec", a);
                int pocetZaznamu = (int)cmd.ExecuteScalar();
                pocetStitkuZamestnanec.Text = pocetZaznamu.ToString();
            }
            else
            {
                pocetStitkuZamestnanec.Text = "----";
            }
            con.Close();
        }

        private void vyberPredmet(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            int a = (int)comboPredmet.SelectedValue;
            if (a > 0)
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Stitky WHERE id_predmet=@idPredmet";
                cmd.Parameters.AddWithValue("@idPredmet", a);
                int pocetZaznamu = (int)cmd.ExecuteScalar();
                pocetStitkuPredmet.Text = pocetZaznamu.ToString();
            }
            else
            {
                pocetStitkuPredmet.Text = "----";
            }
            con.Close();
        }
    }
}
