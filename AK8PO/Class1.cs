using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        static SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
        public static String DatabazeRetezec()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\UTB\1. ročník LS\AK8PO - Pokročilé programování\Projek\AK8PO\AK8PO\DatabaseUTB.mdf'; Integrated Security = True";
        }

        public static void GenerujIdCombo(ComboBox c, string tableName, string columnName, int selectedValue)
        {

            //SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
            SqlCommand cmd = new SqlCommand("SELECT * from " + tableName + " ORDER BY Id ASC", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            c.DataSource = dt;
            c.DisplayMember = columnName;
            c.ValueMember = "Id";
            c.SelectedValue = selectedValue;
         }
        public static void GenerujIdComboStitekJmeno(ComboBox c, int selectedValue)
        {

            //SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
            SqlCommand cmd = new SqlCommand("select (prijmeni+' '+jmeno) as cele_jmeno,Id from Zamestnanci ORDER BY prijmeni COLLATE Latin1_General_CI_AS ASC", con);
            DataTable dt = new DataTable();

            DataColumn column;
            
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "cele_jmeno";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Id";
            dt.Columns.Add(column);
 
            DataRow dr = dt.NewRow();
            dr["cele_jmeno"] = "Zobraz všechny štítky";
            dr["Id"] = 0;
            dt.Rows.Add(dr);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            c.DisplayMember = "cele_jmeno";
            c.ValueMember = "Id";
            c.DataSource = dt;
            c.SelectedValue = selectedValue;
         }
        public static void GenerujIdComboStitekPredmet(ComboBox c, int selectedValue)
        {

            //SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
            SqlCommand cmd = new SqlCommand("select Rozvrh.Id_predmet,Predmet.zkratka FROM Rozvrh INNER JOIN Predmet ON Rozvrh.Id_predmet=Predmet.Id GROUP BY Predmet.zkratka,Rozvrh.Id_predmet ORDER BY Predmet.zkratka", con);
            DataTable dt = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "zkratka";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Id_predmet";
            dt.Columns.Add(column);

            DataRow dr = dt.NewRow();
            dr["zkratka"] = "Zobraz všechny štítky";
            dr["Id_predmet"] = 0;
            dt.Rows.Add(dr);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            c.DisplayMember = "zkratka";
            c.ValueMember = "Id_predmet";
            c.DataSource = dt;
            c.SelectedValue = selectedValue;
        }
        public static DataTable NactiDataTabulku(string dotaz)
        {
            SqlCommand cmd = new SqlCommand(dotaz, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public static string GenerujDotaz(int zam, int pre)
        {
            string filtr = " ";
            if (zam > 0 && pre == 0)
            {
                filtr = " WHERE s.id_zamestnanec=" + zam.ToString() + " ";
            }
            if (zam == 0 && pre > 0)
            {
                filtr = " WHERE s.id_predmet=" + pre.ToString() + " ";
            }
            if (zam > 0 && pre > 0)
            {
                filtr = " WHERE s.id_predmet=" + pre.ToString() + " AND s.id_zamestnanec = " + zam.ToString() + " ";
            }
            string dotaz = "SELECT s.Id, s.stitek_cislo, ISNULL(z.prijmeni + ' ' + z.jmeno, 'Neprirazen') as vyucujici, ISNULL(p.zkratka, 'Nezadan') AS zkratka, ISNULL(t.Typ_stitku_text, 'Nezadan') AS typ_stitku, s.pocet_studentu, s.pocet_hodin, s.pocet_tydnu, ISNULL(j.Jazyk_text, 'Nezadan') AS jazyk, ISNULL(s.pocet_bodu, 0) AS pocet_bodu, s.poznamka FROM Stitky AS s LEFT JOIN Zamestnanci AS z ON s.id_zamestnanec = z.Id LEFT JOIN Predmet AS p ON s.id_predmet = p.Id LEFT JOIN TypStitku AS t ON s.typ_stitku = t.Id LEFT JOIN Jazyk AS j ON s.jazyk = j.Id" + filtr + "ORDER BY vyucujici,zkratka,typ_stitku,stitek_cislo ASC";
            return dotaz;
        }
        internal static int SectiStudentyStitek(int idPredmet, int idZamestnanec)
        {
            int pocetStudentu = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select SUM(Studenti.pocet_studentu) FROM Studenti,Rozvrh WHERE Rozvrh.Id_predmet=@idStudenti AND Rozvrh.Id_studenti=Studenti.Id";
            cmd.Parameters.AddWithValue("@idStudenti", idPredmet);
            pocetStudentu = (int)cmd.ExecuteScalar();
            con.Close();
            return pocetStudentu;
        }

        internal static void GenerujStitky(int idPredmet, int idZamestnanec)
        {
            int pocetStudentu = 0;
            int velikostTridy = 0;
            int pocetPrednasek = 0;
            int pocetCviceni = 0;
            int pocetSeminaru = 0;
            int jazykVyuky = 0;
            int pocetTydnu = 0;
            pocetStudentu = SectiStudentyStitek(idPredmet, idZamestnanec);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select * FROM Predmet WHERE Predmet.Id=@idPredmet";
            cmd.Parameters.AddWithValue("@idPredmet", idPredmet);
            SqlDataReader data = cmd.ExecuteReader();
            data.Read();
            pocetPrednasek = int.Parse(data["prednasky"].ToString());
            pocetCviceni = int.Parse(data["cviceni"].ToString());
            pocetSeminaru = int.Parse(data["seminare"].ToString());
            velikostTridy = int.Parse(data["velikost_tridy"].ToString());
            pocetTydnu = int.Parse(data["pocet_tydnu"].ToString());
            jazykVyuky = int.Parse(data["jazyk"].ToString());
            con.Close();

            float pocetBodu = 0;
            float bodoveHodnoceniP = 0;
            float bodoveHodnoceniC = 0;
            float bodoveHodnoceniS = 0;
            if (jazykVyuky == 1)
            {
                bodoveHodnoceniP = float.Parse(StringLibrary.NactiHodnotuGlobal(1));
                bodoveHodnoceniC = float.Parse(StringLibrary.NactiHodnotuGlobal(2));
                bodoveHodnoceniS = float.Parse(StringLibrary.NactiHodnotuGlobal(3));
            }
            if (jazykVyuky == 2)
            {
                bodoveHodnoceniP = float.Parse(StringLibrary.NactiHodnotuGlobal(4));
                bodoveHodnoceniC = float.Parse(StringLibrary.NactiHodnotuGlobal(5));
                bodoveHodnoceniS = float.Parse(StringLibrary.NactiHodnotuGlobal(6));
            }

            string prikaz = "INSERT INTO Stitky (stitek_cislo, id_zamestnanec, id_predmet, typ_stitku, pocet_studentu, pocet_hodin, pocet_tydnu, jazyk, pocet_bodu, poznamka) VALUES (@stitekCislo, @idZamestnanec, @idPredmet, @typStitku, @pocetStudentu, @pocetHodin, @pocetTydnu, @jazyk, @pocetBodu, @poznamka)";

            pocetBodu = bodoveHodnoceniP * pocetPrednasek * pocetTydnu;
            if (pocetPrednasek > 0)
            {

                string poznamka = "Přednáška štítek č. 1";
                ZapisStitekDoDatabaze(prikaz, 1, idZamestnanec, idPredmet, 4, pocetStudentu, pocetPrednasek, pocetTydnu, jazykVyuky, pocetBodu, poznamka);

            }
            pocetBodu = bodoveHodnoceniC * pocetCviceni * pocetTydnu;
            if (pocetCviceni > 0)
            {
                if (pocetStudentu > velikostTridy) 
                { 
                    int pracovniPocetStudentu = pocetStudentu;                              //počet studentů celkem
                    Decimal cPS = Math.Ceiling((Decimal)pocetStudentu / velikostTridy);     //počet štítku pro generování
                    Decimal cOS = Math.Ceiling((Decimal)pocetStudentu / (int)cPS);          //počet studentů v jednom štítku 
 
                    int citacPocetStitku = (int)cPS;   //počet štítku pro generování
                    int citacObsahStitku = (int)cOS;   //počet studentů v jednom štítku 

                    for (int i = 1; i <= citacPocetStitku; i++)
                    {
                        if (i == (int)citacPocetStitku) { citacObsahStitku = pracovniPocetStudentu; }

                        string poznamka = "Cvičení štítek č." + i.ToString();
                        ZapisStitekDoDatabaze(prikaz, i, idZamestnanec, idPredmet, 5, citacObsahStitku, pocetCviceni, pocetTydnu, jazykVyuky, pocetBodu, poznamka);

                        pracovniPocetStudentu = pracovniPocetStudentu - citacObsahStitku;
                    }
                    //con.Close();
                }
                else
                {
                    ZapisStitekDoDatabaze(prikaz, 1, idZamestnanec, idPredmet, 5, pocetStudentu, pocetCviceni, pocetTydnu, jazykVyuky, pocetBodu, "Cvičení štítek č.1");
                }

            }
            pocetBodu = bodoveHodnoceniS * pocetSeminaru * pocetTydnu;
            if (pocetSeminaru > 0)
            {
                if (pocetStudentu > velikostTridy)
                {
                    int pracovniPocetStudentu = pocetStudentu;                              //počet studentů celkem
                    Decimal cPS = Math.Ceiling((Decimal)pocetStudentu / velikostTridy);     //počet štítku pro generování
                    Decimal cOS = Math.Ceiling((Decimal)pocetStudentu / (int)cPS);          //počet studentů v jednom štítku 

                    int citacPocetStitku = (int)cPS;   //počet štítku pro generování
                    int citacObsahStitku = (int)cOS;   //počet studentů v jednom štítku 

                    for (int i = 1; i <= citacPocetStitku; i++)
                    {
                        if (i == citacPocetStitku) { citacObsahStitku = pracovniPocetStudentu; }

                        string poznamka = "Seminář štítek č." + i.ToString();
                        ZapisStitekDoDatabaze(prikaz, i, idZamestnanec, idPredmet, 6, citacObsahStitku, pocetSeminaru, pocetTydnu, jazykVyuky, pocetBodu, poznamka);

                        pracovniPocetStudentu = pracovniPocetStudentu - citacObsahStitku;
                    }
                    //con.Close();
                }
                else
                {
                    ZapisStitekDoDatabaze(prikaz, 1, idZamestnanec, idPredmet, 6, pocetStudentu, pocetSeminaru, pocetTydnu, jazykVyuky, pocetBodu, "Seminář štítek č.1");
                }
            }
        }

        private static void ZapisStitekDoDatabaze(string prikaz, int stitekCislo, int idZamestnanec, int idPredmet, int typStitku, int pocetStudentu, int pocetHodin, int pocetTydnu, int jazykVyuky, float pocetBodu, string poznamka)
        {
            SqlCommand cmd = new SqlCommand();
 
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = prikaz;

            cmd.Parameters.AddWithValue("@stitekCislo", stitekCislo);
            cmd.Parameters.AddWithValue("@idZamestnanec", idZamestnanec);
            cmd.Parameters.AddWithValue("@idPredmet", idPredmet);
            cmd.Parameters.AddWithValue("@typStitku", typStitku);
            cmd.Parameters.AddWithValue("@pocetStudentu", pocetStudentu);
            cmd.Parameters.AddWithValue("@pocetHodin", pocetHodin);
            cmd.Parameters.AddWithValue("@pocetTydnu", pocetTydnu);
            cmd.Parameters.AddWithValue("@jazyk", jazykVyuky);
            cmd.Parameters.AddWithValue("@pocetBodu", Math.Round(pocetBodu, 2));
            cmd.Parameters.AddWithValue("@poznamka", poznamka);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        internal static int SpoctiPrvky(string prikaz)
        {
            int pocet;
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = prikaz;
            pocet = (int)cmd.ExecuteScalar();
            con.Close();
            return pocet;
        }
        internal static void BarvaNeprirazenych(DataGridView dataStitky, Color barva)
        {
            foreach (DataGridViewRow radek in dataStitky.Rows)
            {
                //MessageBox.Show("Change color:" + radek.Cells[5].Value.ToString());
                if (radek.Cells[5].Value.ToString() == "Neprirazen") 
                {
                    radek.DefaultCellStyle.BackColor = barva;
                }
            }
        }
        internal static String NactiHodnotuGlobal(int a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM Global WHERE Id=@VstupID";
            cmd.Parameters.AddWithValue("@VstupID", a);
            SqlDataReader data = cmd.ExecuteReader();
            String b;
            data.Read();
            b = data["hodnota"].ToString();
            con.Close();
            return b;
        }
        internal static void UlozHodnotuGlobal(int a, float b)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE Global SET hodnota=@VstupHodnota WHERE Id = @VstupID";
            cmd.Parameters.AddWithValue("@VstupID", a);
            cmd.Parameters.AddWithValue("@VstupHodnota", Math.Round(b, 2));
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}