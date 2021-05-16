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
        public static void GenerujIdComboKapacitaJmeno(ComboBox c, int selectedValue)
        {

            //SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
            SqlCommand cmd = new SqlCommand("select (prijmeni+' '+jmeno) as cele_jmeno,Id,uvazek from Zamestnanci ORDER BY prijmeni COLLATE Latin1_General_CI_AS ASC", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            c.DisplayMember = "cele_jmeno";
            c.ValueMember = "Id";
            c.DataSource = dt;
            //c.SelectedValue = selectedValue;
            c.SelectedIndex = 0;
        }
        public static float NactiUvazekKapacita(int selectedValue)
        {

            float uvazek = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT uvazek FROM Zamestnanci WHERE Id=@idZamestnanec";
            cmd.Parameters.AddWithValue("@idZamestnanec", selectedValue);
            uvazek = float.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return uvazek;

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
            //int zakonceni = 0;
            string poznamka = "";
            string prikaz = "";
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
            //zakonceni = int.Parse(data["zakonceni"].ToString());
            con.Close();

            float pocetBodu = 0;
            float bodoveHodnoceniP = 0;
            float bodoveHodnoceniC = 0;
            float bodoveHodnoceniS = 0;
            //float bodoveHodnoceniZA = 0;
            //float bodoveHodnoceniKZ = 0;
            //float bodoveHodnoceniZK = 0;
            if (jazykVyuky == 1)
            {
                bodoveHodnoceniP = float.Parse(StringLibrary.NactiHodnotuGlobal(1));
                bodoveHodnoceniC = float.Parse(StringLibrary.NactiHodnotuGlobal(2));
                bodoveHodnoceniS = float.Parse(StringLibrary.NactiHodnotuGlobal(3));
                //bodoveHodnoceniZA = float.Parse(StringLibrary.NactiHodnotuGlobal(7));
                //bodoveHodnoceniKZ = float.Parse(StringLibrary.NactiHodnotuGlobal(8));
                //bodoveHodnoceniZK = float.Parse(StringLibrary.NactiHodnotuGlobal(9));
            }
            else
            {
                bodoveHodnoceniP = float.Parse(StringLibrary.NactiHodnotuGlobal(4));
                bodoveHodnoceniC = float.Parse(StringLibrary.NactiHodnotuGlobal(5));
                bodoveHodnoceniS = float.Parse(StringLibrary.NactiHodnotuGlobal(6));
                //bodoveHodnoceniZA = float.Parse(StringLibrary.NactiHodnotuGlobal(10));
                //bodoveHodnoceniKZ = float.Parse(StringLibrary.NactiHodnotuGlobal(11));
                //bodoveHodnoceniZK = float.Parse(StringLibrary.NactiHodnotuGlobal(12));
            }

            prikaz = "INSERT INTO Stitky (stitek_cislo, id_zamestnanec, id_predmet, typ_stitku, pocet_studentu, pocet_hodin, pocet_tydnu, jazyk, pocet_bodu, poznamka) VALUES (@stitekCislo, @idZamestnanec, @idPredmet, @typStitku, @pocetStudentu, @pocetHodin, @pocetTydnu, @jazyk, @pocetBodu, @poznamka)";

            
            if (pocetPrednasek > 0)
            {
                pocetBodu = bodoveHodnoceniP * pocetPrednasek * pocetTydnu;
                poznamka = "Přednáška štítek č. 1";
                ZapisStitekDoDatabaze(prikaz, 1, idZamestnanec, idPredmet, 4, pocetStudentu, pocetPrednasek, pocetTydnu, jazykVyuky, pocetBodu, poznamka);

                //pocetBodu = bodoveHodnoceniZK * pocetPrednasek * pocetStudentu; 
                //poznamka = "Zkoušení štítek č. 1";
                //ZapisStitekDoDatabaze(prikaz, 1, idZamestnanec, idPredmet, 3, pocetStudentu, pocetPrednasek, pocetTydnu, jazykVyuky, pocetBodu, poznamka);
            }
            
            if (pocetCviceni > 0)
            {
                pocetBodu = bodoveHodnoceniC * pocetCviceni * pocetTydnu;
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

                        poznamka = "Cvičení štítek č." + i.ToString();
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
            
            if (pocetSeminaru > 0)
            {
                pocetBodu = bodoveHodnoceniS * pocetSeminaru * pocetTydnu;
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

                        poznamka = "Seminář štítek č." + i.ToString();
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

        internal static void UpdateStitky(int idPredmet)
        {
            int idZamestnanec = 0;
            int pocetStudentu = 0;
            int velikostTridy = 0;
            int pocetPrednasek = 0;
            int pocetCviceni = 0;
            int pocetSeminaru = 0;
            int jazykVyuky = 0;
            int pocetTydnu = 0;
            //int zakonceni = 0;
            string poznamka = "";
            string prikaz = "";
            int pocetStitkuDatabaze;
            int pocetPruchodu;

            pocetStudentu = SectiStudentyStitek(idPredmet, 0);

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
            //zakonceni = int.Parse(data["zakonceni"].ToString());
            con.Close();

            float pocetBodu = 0;
            float bodoveHodnoceniP = 0;
            float bodoveHodnoceniC = 0;
            float bodoveHodnoceniS = 0;
            //float bodoveHodnoceniZA = 0;
            //float bodoveHodnoceniKZ = 0;
            //float bodoveHodnoceniZK = 0;
            if (jazykVyuky == 1)
            {
                bodoveHodnoceniP = float.Parse(StringLibrary.NactiHodnotuGlobal(1));
                bodoveHodnoceniC = float.Parse(StringLibrary.NactiHodnotuGlobal(2));
                bodoveHodnoceniS = float.Parse(StringLibrary.NactiHodnotuGlobal(3));
                //bodoveHodnoceniZA = float.Parse(StringLibrary.NactiHodnotuGlobal(7));
                //bodoveHodnoceniKZ = float.Parse(StringLibrary.NactiHodnotuGlobal(8));
                //bodoveHodnoceniZK = float.Parse(StringLibrary.NactiHodnotuGlobal(9));
            }
            else
            {
                bodoveHodnoceniP = float.Parse(StringLibrary.NactiHodnotuGlobal(4));
                bodoveHodnoceniC = float.Parse(StringLibrary.NactiHodnotuGlobal(5));
                bodoveHodnoceniS = float.Parse(StringLibrary.NactiHodnotuGlobal(6));
                //bodoveHodnoceniZA = float.Parse(StringLibrary.NactiHodnotuGlobal(10));
                //bodoveHodnoceniKZ = float.Parse(StringLibrary.NactiHodnotuGlobal(11));
                //bodoveHodnoceniZK = float.Parse(StringLibrary.NactiHodnotuGlobal(12));
            }

            prikaz = "INSERT INTO Stitky (stitek_cislo, id_zamestnanec, id_predmet, typ_stitku, pocet_studentu, pocet_hodin, pocet_tydnu, jazyk, pocet_bodu, poznamka) VALUES (@stitekCislo, @idZamestnanec, @idPredmet, @typStitku, @pocetStudentu, @pocetHodin, @pocetTydnu, @jazyk, @pocetBodu, @poznamka)";


            if (pocetPrednasek > 0)
            {
                int id_zaznam = StringLibrary.NactiHodnotuIntDB("SELECT Id FROM Stitky WHERE (id_predmet = " + idPredmet.ToString() + " AND typ_stitku = 4)");
                pocetBodu = bodoveHodnoceniP * pocetPrednasek * pocetTydnu;
                prikaz = "UPDATE Stitky SET (pocet_studentu, pocet_bodu) VALUES (" + pocetStudentu + ", " + pocetBodu  + ") WHERE Id="+id_zaznam;
                UpdateStitekDoDatabazePrednasky(prikaz);

            }

            if (pocetCviceni > 0)
            {
                pocetStitkuDatabaze = SpoctiPrvky("select COUNT(*) from Stitky where (id_predmet = " + idPredmet.ToString() + " AND typ_stitku = 5)");
                pocetBodu = bodoveHodnoceniC * pocetCviceni * pocetTydnu;

                if (pocetStitkuDatabaze == 1 && pocetStudentu <= velikostTridy)
                {
                    int id_zaznam = StringLibrary.NactiHodnotuIntDB("SELECT Id FROM Stitky WHERE (id_predmet = " + idPredmet.ToString() + " AND typ_stitku = 5)");
                    prikaz = "UPDATE Stitky SET pocet_studentu=" + pocetStudentu.ToString() + ", pocet_bodu=" + pocetBodu.ToString() + " WHERE Id=" + id_zaznam.ToString();
                    UpdateStitekDoDatabazePrednasky(prikaz);
                }
                else 
                {
                    int[] poleIndexuDB = new int[pocetStitkuDatabaze];
                    //////////////////// načtení indexů z DB
                    //SqlCommand cmd1 = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select Id from Stitky where (id_predmet = " + idPredmet.ToString() + " AND typ_stitku = 5)";
                    SqlDataReader data1 = cmd.ExecuteReader();
                    int j = 0;
                    while (data1.Read())
                    {
                        poleIndexuDB[j] = Convert.ToInt32(data1[j]);
                        j++;
                    }
                    data1.Close();
                    /////////////////
                    int pocetStitekNaZapis = 0;
                    int indexNaZapis = 0;
                    int pracovniPocetStudentu = pocetStudentu;                              //počet studentů celkem
                    Decimal cPS = Math.Ceiling((Decimal)pocetStudentu / velikostTridy); //počet štítku pro generování
                    Decimal cOS = Math.Ceiling((Decimal)pocetStudentu / (int)cPS);          //počet studentů v jednom štítku
                    int citacPocetStitku = (int)cPS;     //počet štítku pro generování
                    int citacObsahStitku = (int)cOS;   //počet studentů v jednom štítku
                    pocetPruchodu = pocetStitkuDatabaze;
                    if (pocetPruchodu < citacPocetStitku) { pocetPruchodu = citacPocetStitku; }

                    ////////////// cyklus

                    for (int i = 1; i <= pocetPruchodu; i++)
                    {
                        indexNaZapis = 0;
                        if (i <= pocetStitkuDatabaze) 
                        {
                           if (pracovniPocetStudentu > citacObsahStitku)
                            {
                                pocetStitekNaZapis = citacObsahStitku;
                                pracovniPocetStudentu = pracovniPocetStudentu - citacObsahStitku;
                            }
                           else
                            {
                                pocetStitekNaZapis = pracovniPocetStudentu;
                                pracovniPocetStudentu = 0;
                            }
                            indexNaZapis = poleIndexuDB[i - 1];
                            prikaz = "UPDATE Stitky SET pocet_studentu=" + pocetStudentu.ToString() + ", pocet_bodu=" + pocetBodu.ToString() + " WHERE Id=" + indexNaZapis.ToString();
                        }
                        else
                        {
                            poznamka = "Cvičení štítek č." + i.ToString();
                            prikaz = "INSERT INTO Stitky (stitek_cislo, id_zamestnanec, id_predmet, typ_stitku, pocet_studentu, pocet_hodin, pocet_tydnu, jazyk, pocet_bodu, poznamka) VALUES (" + i.ToString() + ", 0, " + idPredmet.ToString() + ", 5, " + pocetStudentu.ToString() + ", " + pocetCviceni.ToString() + ", " + pocetTydnu.ToString() + ", " + jazykVyuky.ToString() + ", " + pocetBodu.ToString() + ", '" + poznamka + "') WHERE Id=" + indexNaZapis.ToString();
                        }
                        UpdateStitekDoDatabazePrednasky(prikaz);


                    }
                    ////////////// konec cyklus

                        
                }
            }

            if (pocetSeminaru > 0)
            {
                pocetStitkuDatabaze = SpoctiPrvky("select COUNT(*) from Stitky where (id_predmet = " + idPredmet.ToString() + " AND typ_stitku = 6)");
                pocetBodu = bodoveHodnoceniS * pocetSeminaru * pocetTydnu;

                if (pocetStitkuDatabaze == 1 && pocetStudentu <= velikostTridy)
                {
                    int id_zaznam = StringLibrary.NactiHodnotuIntDB("SELECT Id FROM Stitky WHERE (id_predmet = " + idPredmet.ToString() + " AND typ_stitku = 6)");
                    prikaz = "UPDATE Stitky SET (pocet_studentu, pocet_bodu) VALUES (" + pocetStudentu + ", " + pocetBodu + ") WHERE Id=" + id_zaznam.ToString();
                    UpdateStitekDoDatabazePrednasky(prikaz);
                }
                else
                {
                    int[] poleIndexuDB1 = new int[pocetStitkuDatabaze];
                    //////////////////// načtení indexů z DB
                    //SqlCommand cmd1 = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select Id from Stitky where (id_predmet = " + idPredmet.ToString() + " AND typ_stitku = 6)";
                    SqlDataReader data1 = cmd.ExecuteReader();
                    int j = 0;
                    while (data1.Read())
                    {
                        poleIndexuDB1[j] = Convert.ToInt32(data1[j]);
                        j++;
                    }
                    data1.Close();
                    /////////////////
                    int pocetStitekNaZapis = 0;
                    int indexNaZapis = 0;
                    int pracovniPocetStudentu = pocetStudentu;                              //počet studentů celkem
                    Decimal cPS = Math.Ceiling((Decimal)pocetStudentu / velikostTridy); //počet štítku pro generování
                    Decimal cOS = Math.Ceiling((Decimal)pocetStudentu / (int)cPS);          //počet studentů v jednom štítku
                    int citacPocetStitku = (int)cPS;     //počet štítku pro generování
                    int citacObsahStitku = (int)cOS;   //počet studentů v jednom štítku
                    pocetPruchodu = pocetStitkuDatabaze;
                    if (pocetPruchodu < citacPocetStitku) { pocetPruchodu = citacPocetStitku; }

                    ////////////// cyklus

                    for (int i = 1; i <= pocetPruchodu; i++)
                    {
                        indexNaZapis = 0;
                        if (i <= pocetStitkuDatabaze)
                        {
                            if (pracovniPocetStudentu > citacObsahStitku)
                            {
                                pocetStitekNaZapis = citacObsahStitku;
                                pracovniPocetStudentu = pracovniPocetStudentu - citacObsahStitku;
                            }
                            else
                            {
                                pocetStitekNaZapis = pracovniPocetStudentu;
                                pracovniPocetStudentu = 0;
                            }
                            indexNaZapis = poleIndexuDB1[i - 1];
                            prikaz = "UPDATE Stitky SET pocet_studentu=" + pocetStudentu.ToString() + ", pocet_bodu=" + pocetBodu.ToString() + " WHERE Id=" + indexNaZapis.ToString();
                        }
                        else
                        {
                            poznamka = "Seminář štítek č." + i.ToString();
                            prikaz = "INSERT INTO Stitky (stitek_cislo, id_zamestnanec, id_predmet, typ_stitku, pocet_studentu, pocet_hodin, pocet_tydnu, jazyk, pocet_bodu, poznamka) VALUES (" + i.ToString() + ", 0, " + idPredmet.ToString() + ", 6, " + pocetStudentu.ToString() + ", " + pocetSeminaru.ToString() + ", " + pocetTydnu.ToString() + ", " + jazykVyuky.ToString() + ", " + pocetBodu.ToString() + ", '" + poznamka + "') WHERE Id=" + indexNaZapis.ToString();
                        }
                        UpdateStitekDoDatabazePrednasky(prikaz);


                    }
                    ////////////// konec cyklus


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
        private static void UpdateStitekDoDatabazePrednasky(string prikaz)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = prikaz;

            cmd.ExecuteNonQuery();
            con.Close();
        }
        internal static void PrepoctiStitkyZmenaPocetStudentu(int id_studenta, int pocetS)
        {
            int pocetStitkuOprava;
            pocetStitkuOprava = SpoctiPrvky("select COUNT(*) from Stitky where (id_predmet IN (select Id_predmet from rozvrh where Id_studenti = " + id_studenta.ToString() + "))");
            
            if (pocetStitkuOprava > 0)
            {

                int pocetPredmetuOprava;
                pocetPredmetuOprava = SpoctiPrvky("select COUNT(*) from Stitky where (id_predmet IN (select Id_predmet from rozvrh where Id_studenti = " + id_studenta.ToString() + ")) group by id_predmet");
                int[] polePredmetu = new int[pocetPredmetuOprava];
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select id_predmet from Stitky where (id_predmet IN (select Id_predmet from rozvrh where Id_studenti = " + id_studenta.ToString() + ")) group by id_predmet";
                SqlDataReader data1 = cmd.ExecuteReader();
                int j = 0;
                while (data1.Read())
                {
                    polePredmetu[j] = Convert.ToInt32(data1[j]);
                    j++;
                }
                data1.Close();
                foreach (int k in polePredmetu)
                {
                    StringLibrary.UpdateStitky(k);
                }

                MessageBox.Show("Přepočet štítků proveden! Záznam byl opraven", "Zadat jinou skupinu?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Záznam byl opraven", "Zadat jinou skupinu?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //MessageBox.Show("ID studenta: " + id_studenta.ToString() + "   Pocet stitku k opravě: " + pocetStitkuOprava.ToString(), "aa", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }
        internal static int SpoctiPrvky(string prikaz)
        {
            int pocet;
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = @prikaz;
            pocet = (int)cmd.ExecuteScalar();
            con.Close();
            return pocet;
        }
        internal static int NactiHodnotuIntDB(string prikaz1)
        {
            int hodnota1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = @prikaz1;
            hodnota1 = (int)cmd.ExecuteScalar();
            con.Close();
            return hodnota1;
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
        internal static void SmazatZaznam(string prikaz)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = prikaz;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        internal static void ZapisZaznam(string prikaz)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = prikaz;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        internal static float NactiPrimaVyuka(DataGridView dataPrimaVyuka, int idZamestnanec)
        {
            dataPrimaVyuka.Rows.Clear();
            float celkemBodu = 0;
            if (SpoctiPrvky("SELECT COUNT(*) FROM Stitky AS s LEFT JOIN Predmet AS p ON s.id_predmet=p.Id WHERE s.id_zamestnanec=" + idZamestnanec.ToString()) > 0)
            {
                float p_cz = float.Parse(NactiHodnotuGlobal(1));
                float c_cz = float.Parse(NactiHodnotuGlobal(2));
                float s_cz = float.Parse(NactiHodnotuGlobal(3));
                float p_ang = float.Parse(NactiHodnotuGlobal(4));
                float c_ang = float.Parse(NactiHodnotuGlobal(5));
                float s_ang = float.Parse(NactiHodnotuGlobal(6));
                /*float za_cz = float.Parse(NactiHodnotuGlobal(7));
                float kz_cz = float.Parse(NactiHodnotuGlobal(8));
                float zk_cz = float.Parse(NactiHodnotuGlobal(9));
                float za_ang = float.Parse(NactiHodnotuGlobal(10));
                float kz_ang = float.Parse(NactiHodnotuGlobal(11));
                float zk_ang = float.Parse(NactiHodnotuGlobal(12));*/


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT s.*,p.zakonceni,p.semestr FROM Stitky AS s LEFT JOIN Predmet AS p ON s.id_predmet=p.Id WHERE s.id_zamestnanec=" + idZamestnanec.ToString() + " ORDER BY s.id_predmet ASC,s.typ_stitku ASC,s.pocet_studentu DESC";
                SqlDataReader dataStitky = cmd.ExecuteReader();
                int pZS = 0;
                int pLS = 0;
                int pPT = 0;
                int pCT = 0;
                int pST = 0;
                int pPS = 0;
                int pCS = 0;
                int pSS = 0;
                float pPC = 0;
                float pCC = 0;
                float pSC = 0;
                //int pZA = 0;
                //int pKZ = 0;
                //int pZK = 0;
                //float pZAC = 0;
                //float pKZC = 0;
                //float pZKC = 0;
                int predmet = 0;
                string druh = "";
                //int zakonceni = 0;
                int semestr = 1;

                while (dataStitky.Read())
                {
                    if (predmet == 0)
                    {
                        predmet = int.Parse(dataStitky["id_predmet"].ToString());
                        //zakonceni = int.Parse(dataStitky["zakonceni"].ToString());
                        semestr = int.Parse(dataStitky["semestr"].ToString());
                    }
                    else
                    {
                        if (predmet != int.Parse(dataStitky["id_predmet"].ToString()))
                        {
                            dataPrimaVyuka.Rows.Add(predmet, druh, pZS.ToString(), pLS.ToString(), pPT.ToString(), pCT.ToString(), pST.ToString(), pPS.ToString(), pCS.ToString(), pSS.ToString(), Math.Round(pPC, 2).ToString(), Math.Round(pCC, 2).ToString(), Math.Round(pSC, 2).ToString());
                            //dataZkouseni.Rows.Add(predmet, pKZ.ToString(), pZA.ToString(), pZK.ToString(), "", Math.Round(pKZC, 2).ToString(), Math.Round(pZAC, 2).ToString(), Math.Round(pZKC, 2).ToString(),"");
                            pZS = 0;
                            pLS = 0;
                            pPT = 0;
                            pCT = 0;
                            pST = 0;
                            pPS = 0;
                            pCS = 0;
                            pSS = 0;
                            pPC = 0;
                            pCC = 0;
                            pSC = 0;
                            /*pZA = 0;
                            pKZ = 0;
                            pZK = 0;
                            pZAC = 0;
                            pKZC = 0;
                            pZKC = 0;*/

                            predmet = int.Parse(dataStitky["id_predmet"].ToString());
                            //zakonceni = int.Parse(dataStitky["zakonceni"].ToString());
                            semestr = int.Parse(dataStitky["semestr"].ToString());
                        }

                    }

                    if (semestr == 1) pZS = int.Parse(dataStitky["pocet_tydnu"].ToString());
                    if (semestr == 2) pLS = int.Parse(dataStitky["pocet_tydnu"].ToString());
                    if (int.Parse(dataStitky["jazyk"].ToString()) > 1) druh = "c";

                    if (int.Parse(dataStitky["typ_stitku"].ToString()) == 4)
                    { 
                        pPT = int.Parse(dataStitky["pocet_hodin"].ToString());
                        pPS++;
                        pPC += float.Parse(dataStitky["pocet_bodu"].ToString());
                        celkemBodu += float.Parse(dataStitky["pocet_bodu"].ToString());
                        /*pZK += int.Parse(dataStitky["pocet_studentu"].ToString());
                        if (int.Parse(dataStitky["jazyk"].ToString()) > 1)
                        {
                            pZKC += float.Parse(dataStitky["pocet_studentu"].ToString()) * zk_ang;
                        }
                        else
                        {
                            pZKC += float.Parse(dataStitky["pocet_studentu"].ToString()) * zk_cz;
                        }*/
                    }
                    if (int.Parse(dataStitky["typ_stitku"].ToString()) == 5)
                    {
                        pCT = int.Parse(dataStitky["pocet_hodin"].ToString());
                        pCS++;
                        pCC += float.Parse(dataStitky["pocet_bodu"].ToString());
                        celkemBodu += float.Parse(dataStitky["pocet_bodu"].ToString());
                        /*pZK += int.Parse(dataStitky["pocet_studentu"].ToString());
                        if (int.Parse(dataStitky["jazyk"].ToString()) > 1)
                        {
                            //pZKC += float.Parse(dataStitky["pocet_studentu"].ToString()) * zk_ang;
                        }
                        else
                        {
                            //pZKC += float.Parse(dataStitky["pocet_studentu"].ToString()) * zk_cz;
                        }*/
                    }
                    if (int.Parse(dataStitky["typ_stitku"].ToString()) == 6)
                    {
                        pST = int.Parse(dataStitky["pocet_hodin"].ToString());
                        pSS++;
                        pSC += float.Parse(dataStitky["pocet_bodu"].ToString());
                        celkemBodu += float.Parse(dataStitky["pocet_bodu"].ToString());
                    }
                }
                dataPrimaVyuka.Rows.Add(predmet, druh, pZS.ToString(), pLS.ToString(), pPT.ToString(), pCT.ToString(), pST.ToString(), pPS.ToString(), pCS.ToString(), pSS.ToString(), Math.Round(pPC,2).ToString(), Math.Round(pCC,2).ToString(), Math.Round(pSC,2).ToString());
                //dataZkouseni.Rows.Add(predmet, pKZ.ToString(), pZA.ToString(), pZK.ToString(), "", Math.Round(pKZC, 2).ToString(), Math.Round(pZAC, 2).ToString(), Math.Round(pZKC, 2).ToString(), "");
                con.Close();
            }
            return celkemBodu;
        }
        internal static void NactiZkouseni(DataGridView dataZkouseni, int idZamestnanec)
        {
            dataZkouseni.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT id_predmet FROM Stitky WHERE id_zamestnanec=" + idZamestnanec.ToString() + " GROUP BY id_predmet";
            SqlDataReader dataStitky = cmd.ExecuteReader();
            while (dataStitky.Read())
            {

                dataZkouseni.Rows.Add(dataStitky["id_predmet"]);
            }
            con.Close();

        }

    }
}