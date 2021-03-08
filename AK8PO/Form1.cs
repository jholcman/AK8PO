using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AK8PO
{
    public partial class Zamestnanci : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\UTB\1. ročník LS\AK8PO - Pokročilé programování\Projek\AK8PO\AK8PO\DatabaseUTB.mdf'; Integrated Security = True");
        public Zamestnanci()
        {
            InitializeComponent();

         }

        private void Zamestnanci_Load(object sender, EventArgs e)
        {
             LoadForm();
        }

        private void LoadForm()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Zamestnanci", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            zamestnanciView.DataSource = dt;
        }

        private void VyberZaznamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vstupID.Text = zamestnanciView.SelectedRows[0].Cells[0].Value.ToString();
            vstupPrijmeni.Text = zamestnanciView.SelectedRows[0].Cells[1].Value.ToString();
            vstupJmeno.Text = zamestnanciView.SelectedRows[0].Cells[2].Value.ToString();
            vstupTitul_pred.Text = zamestnanciView.SelectedRows[0].Cells[3].Value.ToString();
            vstupTitul_za.Text = zamestnanciView.SelectedRows[0].Cells[4].Value.ToString();
            vstupTelefon_pracovni.Text = zamestnanciView.SelectedRows[0].Cells[5].Value.ToString();
            vstupTelefon_soukromy.Text = zamestnanciView.SelectedRows[0].Cells[6].Value.ToString();
            vstupEmail_pracovni.Text = zamestnanciView.SelectedRows[0].Cells[7].Value.ToString();
            vstupEmail_soukromy.Text = zamestnanciView.SelectedRows[0].Cells[8].Value.ToString();
            vstupKancelar.Text = zamestnanciView.SelectedRows[0].Cells[9].Value.ToString();
            vstupUvazek.Text = zamestnanciView.SelectedRows[0].Cells[10].Value.ToString();
            vstupDoktorant.Text = zamestnanciView.SelectedRows[0].Cells[11].Value.ToString();
            vstupBodyBezAng.Text = zamestnanciView.SelectedRows[0].Cells[12].Value.ToString();
            vstupBodySAng.Text = zamestnanciView.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void ResetFormulare(object sender, EventArgs e)
        {
            ResetForm();
         }
        private void ResetForm()
        {
            vstupID.Clear();
            vstupPrijmeni.Clear();
            vstupJmeno.Clear();
            vstupTitul_pred.Clear();
            vstupTitul_za.Clear();
            vstupTelefon_pracovni.Clear();
            vstupTelefon_soukromy.Clear();
            vstupEmail_pracovni.Clear();
            vstupEmail_soukromy.Clear();
            vstupKancelar.Clear();
            vstupUvazek.Clear();
            vstupDoktorant.Text = "Ne";
            vstupBodyBezAng.Clear();
            vstupBodySAng.Clear();
        }

        private void NovyZaznam(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO Zamestnanci (prijmeni, jmeno, titul_pred, titul_za, telefon_pracovni, telefon_soukromy, email_pracovni, email_soukromy, kancelar, uvazek, doktorant, pracovni_body_bez_ang, pracovni_body_s_ang) Values (@VstupPrijmeni, @VstupJmeno, @VstupTitul_pred, @VstupTitul_za, @VstupTelefon_pracovni, @VstupTelefon_soukromy, @VstupEmail_pracovni, @VstupEmail_soukromy, @VstupKancelar, @VstupUvazek, @VstupDoktorant, @VstupBodyBezAng, @VstupBodySAng)", con);

            cmd.Parameters.AddWithValue("@VstupPrijmeni", vstupPrijmeni.Text);
            cmd.Parameters.AddWithValue("@VstupJmeno", vstupJmeno.Text);
            cmd.Parameters.AddWithValue("@VstupTitul_pred", vstupTitul_pred.Text);
            cmd.Parameters.AddWithValue("@VstupTitul_za", vstupTitul_za.Text);
            cmd.Parameters.AddWithValue("@VstupTelefon_pracovni", vstupTelefon_pracovni.Text);
            cmd.Parameters.AddWithValue("@VstupTelefon_soukromy", vstupTelefon_soukromy.Text);
            cmd.Parameters.AddWithValue("@VstupEmail_pracovni", vstupEmail_pracovni.Text);
            cmd.Parameters.AddWithValue("@VstupEmail_soukromy", vstupEmail_soukromy.Text);
            cmd.Parameters.AddWithValue("@VstupKancelar", vstupKancelar.Text);
            cmd.Parameters.AddWithValue("@VstupUvazek", Math.Round(float.Parse(vstupUvazek.Text),2));
            cmd.Parameters.AddWithValue("@VstupDoktorant", vstupDoktorant.Text);
            cmd.Parameters.AddWithValue("@VstupBodyBezAng", vstupBodyBezAng.Text);
            cmd.Parameters.AddWithValue("@VstupBodySAng", vstupBodySAng.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Záznam byl přidán", "Záznam byl přidán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ResetForm();
            LoadForm();
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

                    SqlCommand cmd = new SqlCommand("DELETE FROM Zamestnanci WHERE Id = @VstupID", con);

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
                SqlCommand cmd = new SqlCommand("UPDATE Zamestnanci SET prijmeni=@VstupPrijmeni, jmeno=@VstupJmeno, titul_pred=@VstupTitul_pred, titul_za=@VstupTitul_za, telefon_pracovni=@VstupTelefon_pracovni, telefon_soukromy=@VstupTelefon_soukromy, email_pracovni=@VstupEmail_pracovni, email_soukromy=@VstupEmail_soukromy, kancelar=@VstupKancelar, uvazek=@VstupUvazek, doktorant=@VstupDoktorant, pracovni_body_bez_ang=@VstupBodyBezAng, pracovni_body_s_ang=@VstupBodySAng WHERE Id = @VstupID", con);

                cmd.Parameters.AddWithValue("@VstupID", int.Parse(vstupID.Text));
                cmd.Parameters.AddWithValue("@VstupPrijmeni", vstupPrijmeni.Text);
                cmd.Parameters.AddWithValue("@VstupJmeno", vstupJmeno.Text);
                cmd.Parameters.AddWithValue("@VstupTitul_pred", vstupTitul_pred.Text);
                cmd.Parameters.AddWithValue("@VstupTitul_za", vstupTitul_za.Text);
                cmd.Parameters.AddWithValue("@VstupTelefon_pracovni", vstupTelefon_pracovni.Text);
                cmd.Parameters.AddWithValue("@VstupTelefon_soukromy", vstupTelefon_soukromy.Text);
                cmd.Parameters.AddWithValue("@VstupEmail_pracovni", vstupEmail_pracovni.Text);
                cmd.Parameters.AddWithValue("@VstupEmail_soukromy", vstupEmail_soukromy.Text);
                cmd.Parameters.AddWithValue("@VstupKancelar", vstupKancelar.Text);
                cmd.Parameters.AddWithValue("@VstupUvazek", Math.Round(float.Parse(vstupUvazek.Text),2));
                cmd.Parameters.AddWithValue("@VstupDoktorant", vstupDoktorant.Text);
                cmd.Parameters.AddWithValue("@VstupBodyBezAng", vstupBodyBezAng.Text);
                cmd.Parameters.AddWithValue("@VstupBodySAng", vstupBodySAng.Text);

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

        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }
    }
}
