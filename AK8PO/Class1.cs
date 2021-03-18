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
    }
}