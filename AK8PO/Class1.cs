using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        public static String DatabazeRetezec()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\UTB\1. ročník LS\AK8PO - Pokročilé programování\Projek\AK8PO\AK8PO\DatabaseUTB.mdf'; Integrated Security = True";
        }

        public static void GenerujIdCombo(ComboBox c, string tableName, string columnName, int selectedValue)
        {

            SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
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

            SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
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

            SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
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
    }
}