﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AK8PO
{
    public partial class Studenti : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\UTB\1. ročník LS\AK8PO - Pokročilé programování\Projek\AK8PO\AK8PO\DatabaseUTB.mdf'; Integrated Security = True");

        public Studenti()
        {
            InitializeComponent();
        }
        private void Studenti_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Studenti", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            studentiView.DataSource = dt;
        }
        private void Studenti_Load_1(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet.Studenti'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.studentiTableAdapter.Fill(this.databaseUTBDataSet.Studenti);

        }

        private void VyberZaznamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vstupID.Text = studentiView.SelectedRows[0].Cells[0].Value.ToString();
            vstupZkratka.Text = studentiView.SelectedRows[0].Cells[1].Value.ToString();
            vstupRocnik.Text = studentiView.SelectedRows[0].Cells[2].Value.ToString();
            vstupSemestr.Text = studentiView.SelectedRows[0].Cells[3].Value.ToString();
            vstupPocetStudentu.Text = studentiView.SelectedRows[0].Cells[4].Value.ToString();
            vstupForma_studia.Text = studentiView.SelectedRows[0].Cells[5].Value.ToString();
            vstupTyp_studia.Text = studentiView.SelectedRows[0].Cells[6].Value.ToString();
            vstupJazyk.Text = studentiView.SelectedRows[0].Cells[7].Value.ToString();
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
            vstupRocnik.Text = "1";
            vstupSemestr.Text = "ZS";
            vstupPocetStudentu.Clear();
            vstupForma_studia.Text = "P";
            vstupTyp_studia.Text = "Bc.";
            vstupJazyk.Text = "CZ";
            vstupNazev_studia.Clear();
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

                    SqlCommand cmd = new SqlCommand("DELETE FROM Studenti WHERE Id = @VstupID", con);

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

        private void ZapsatZmeny(object sender, EventArgs e)
        {
            if (vstupID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE Studenti SET zkratka=@VstupZkratka, rocnik=@VstupRocnik, semestr=@VstupSemestr, pocet_studentu=@VstupPocetStudentu, forma_studia=@VstupForma_studia, typ_studia=@VstupTyp_studia, jazyk=@VstupJazyk, nazev_studia=@VstupNazev_studia WHERE Id = @VstupID", con);

                cmd.Parameters.AddWithValue("@VstupID", int.Parse(vstupID.Text));
                cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
                cmd.Parameters.AddWithValue("@VstupRocnik", vstupRocnik.Text);
                cmd.Parameters.AddWithValue("@VstupSemestr", vstupSemestr.Text);
                cmd.Parameters.AddWithValue("@VstupPocetStudentu", int.Parse(vstupPocetStudentu.Text));
                cmd.Parameters.AddWithValue("@VstupForma_studia", vstupForma_studia.Text);
                cmd.Parameters.AddWithValue("@VstupTyp_studia", vstupTyp_studia.Text);
                cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.Text);
                cmd.Parameters.AddWithValue("@VstupNazev_studia", vstupNazev_studia.Text);
 
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
            SqlCommand cmd = new SqlCommand("INSERT INTO Studenti SET zkratka=@VstupZkratka, rocnik=@VstupRocnik, semestr=@VstupSemestr, pocet_studentu=@VstupPocetStudentu, forma_studia=@VstupForma_studia, typ_studia=@VstupTyp_studia, jazyk=@VstupJazyk, nazev_studia=@VstupNazev_studia", con);

            //cmd.Parameters.AddWithValue("@VstupID", int.Parse(vstupID.Text));
            cmd.Parameters.AddWithValue("@VstupZkratka", vstupZkratka.Text);
            cmd.Parameters.AddWithValue("@VstupRocnik", vstupRocnik.Text);
            cmd.Parameters.AddWithValue("@VstupSemestr", vstupSemestr.Text);
            cmd.Parameters.AddWithValue("@VstupPocetStudentu", int.Parse(vstupPocetStudentu.Text));
            cmd.Parameters.AddWithValue("@VstupForma_studia", vstupForma_studia.Text);
            cmd.Parameters.AddWithValue("@VstupTyp_studia", vstupTyp_studia.Text);
            cmd.Parameters.AddWithValue("@VstupJazyk", vstupJazyk.Text);
            cmd.Parameters.AddWithValue("@VstupNazev_studia", vstupNazev_studia.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Záznam byl přidán", "Záznam byl přidán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ResetForm();
            LoadForm();

        }
        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }


    }
}
