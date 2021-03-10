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
        }

         private void Predmet_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet4.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
           // this.predmetTableAdapter2.Fill(this.databaseUTBDataSet4.Predmet);
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet2.Predmet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
           // this.predmetTableAdapter1.Fill(this.databaseUTBDataSet2.Predmet);
            LoadForm();

        }
        private void LoadForm()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Predmet", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            predmetyView.DataSource = dt;
        }
        private void VyberZaznamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vstupID.Text = predmetyView.SelectedRows[0].Cells[0].Value.ToString();
            vstupZkratka.Text = predmetyView.SelectedRows[0].Cells[1].Value.ToString();
            vstupPocet_tydnu.Text = predmetyView.SelectedRows[0].Cells[2].Value.ToString();
            vstupPrednasky.Text = predmetyView.SelectedRows[0].Cells[3].Value.ToString();
            vstupCviceni.Text = predmetyView.SelectedRows[0].Cells[4].Value.ToString();
            vstupSeminare.Text = predmetyView.SelectedRows[0].Cells[5].Value.ToString();
            vstupZakonceni.Text = predmetyView.SelectedRows[0].Cells[6].Value.ToString();
            vstupJazyk.Text = predmetyView.SelectedRows[0].Cells[7].Value.ToString();
            vstupVelikost_tridy.Text = predmetyView.SelectedRows[0].Cells[8].Value.ToString();
            vstupNazev_predmetu.Text = predmetyView.SelectedRows[0].Cells[9].Value.ToString();
            vstupPocet_kreditu.Text = predmetyView.SelectedRows[0].Cells[10].Value.ToString();
            vstupGarant_ustav.Text = predmetyView.SelectedRows[0].Cells[11].Value.ToString();
            vstupGarant_osoba.Text = predmetyView.SelectedRows[0].Cells[12].Value.ToString();
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
            vstupZakonceni.Text = "zk";
            vstupJazyk.Text = "CZ";
            vstupVelikost_tridy.Clear();
            vstupNazev_predmetu.Clear();
            vstupPocet_kreditu.Clear();
            vstupGarant_ustav.Clear();
            vstupGarant_osoba.Clear();
        }
        private void ZapsatZmeny(object sender, EventArgs e)
        {
            if (vstupID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE Predmet SET zkratka=@VstupZkratka, pocet_tydnu=@VstupPocet_tydnu, prednasky=@VstupPrednasky, cviceni=@VstupCviceni, seminare=@VstupSeminare, zakonceni=@VstupZakonceni, jazyk=@VstupJazyk, velikost_tridy=@VstupVelikost_tridy, nazev_predmetu=@VstupNazev_predmetu, pocet_kreditu=@VstupPocet_kreditu, garant_ustav=@VstupGarant_ustav, garant_osoba=@VstupGarant_osoba WHERE Id = @VstupID", con);

                cmd.Parameters.AddWithValue("@VstupID", int.Parse(vstupID.Text));
                cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
                cmd.Parameters.AddWithValue("@VstupPocet_tydnu", int.Parse(vstupPocet_tydnu.Text));
                cmd.Parameters.AddWithValue("@VstupPrednasky", int.Parse(vstupPrednasky.Text));
                cmd.Parameters.AddWithValue("@VstupCviceni", int.Parse(vstupCviceni.Text));
                cmd.Parameters.AddWithValue("@VstupSeminare", int.Parse(vstupSeminare.Text));
                cmd.Parameters.AddWithValue("@VstupZakonceni", vstupZakonceni.Text);
                cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.Text);
                cmd.Parameters.AddWithValue("@VstupVelikost_tridy", int.Parse(vstupVelikost_tridy.Text));
                cmd.Parameters.AddWithValue("@VstupNazev_predmetu", vstupNazev_predmetu.Text);
                cmd.Parameters.AddWithValue("@VstupPocet_kreditu", int.Parse(vstupPocet_kreditu.Text));
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
            if (vstupID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Predmet (zkratka, pocet_tydnu, prednasky, cviceni, seminare, zakonceni, jazyk, velikost_tridy, nazev_predmetu, pocet_kreditu, garant_ustav, garant_osoba) VALUES (@VstupZkratka, @VstupPocet_tydnu, @VstupPrednasky, @VstupCviceni, @VstupSeminare, @VstupZakonceni, @VstupJazyk, @VstupVelikost_tridy, @VstupNazev_predmetu, @VstupPocet_kreditu, @VstupGarant_ustav, @VstupGarant_osoba)", con);

                cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
                cmd.Parameters.AddWithValue("@VstupPocet_tydnu", int.Parse(vstupPocet_tydnu.Text));
                cmd.Parameters.AddWithValue("@VstupPrednasky", int.Parse(vstupPrednasky.Text));
                cmd.Parameters.AddWithValue("@VstupCviceni", int.Parse(vstupCviceni.Text));
                cmd.Parameters.AddWithValue("@VstupSeminare", int.Parse(vstupSeminare.Text));
                cmd.Parameters.AddWithValue("@VstupZakonceni", vstupZakonceni.Text);
                cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.Text);
                cmd.Parameters.AddWithValue("@VstupVelikost_tridy", int.Parse(vstupVelikost_tridy.Text));
                cmd.Parameters.AddWithValue("@VstupNazev_predmetu", vstupNazev_predmetu.Text);
                cmd.Parameters.AddWithValue("@VstupPocet_kreditu", int.Parse(vstupPocet_kreditu.Text));
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

        private void SmazatZaznam(object sender, EventArgs e)
        {
            if (vstupID.Text != "")
            {
                var dotaz = MessageBox.Show("Opravdu vymazat tento záznam?", "Mazání záznamu",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (dotaz == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM Predmet WHERE Id = @VstupID", con);

                    cmd.Parameters.AddWithValue("@VstupID", int.Parse(vstupID.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Záznam byl smazán", "Záznam byl smazán.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetForm();
                    LoadForm();

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
