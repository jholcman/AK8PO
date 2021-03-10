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
    public partial class Global : Form
    {
        SqlConnection con = new SqlConnection(StringLibrary.DatabazeRetezec());
        public Global()
        {
            InitializeComponent();
            LoadValues();
        }

        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadValues()
        {
            con.Open();
            vstup01.Text = NactiHodnotu(1);
            vstup02.Text = NactiHodnotu(2);
            vstup03.Text = NactiHodnotu(3);
            vstup04.Text = NactiHodnotu(4);
            vstup05.Text = NactiHodnotu(5);
            vstup06.Text = NactiHodnotu(6);
            vstup07.Text = NactiHodnotu(7);
            vstup08.Text = NactiHodnotu(8);
            vstup09.Text = NactiHodnotu(9);
            vstup10.Text = NactiHodnotu(10);
            vstup11.Text = NactiHodnotu(11);
            vstup12.Text = NactiHodnotu(12);
 
            con.Close();
        }
        public String NactiHodnotu(int a)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Global WHERE Id=@VstupID", con);

            cmd.Parameters.AddWithValue("@VstupID", a);
            SqlDataReader data = cmd.ExecuteReader();
            String b;
            data.Read();
            b = data["hodnota"].ToString();
            data.Close();
            return b;
        }
        private void UpdateValues(object sender, EventArgs e)
        {
            con.Open();

            UlozHodnotu(1, float.Parse(vstup01.Text));
            UlozHodnotu(2, float.Parse(vstup02.Text));
            UlozHodnotu(3, float.Parse(vstup03.Text));
            UlozHodnotu(4, float.Parse(vstup04.Text));
            UlozHodnotu(5, float.Parse(vstup05.Text));
            UlozHodnotu(6, float.Parse(vstup06.Text));
            UlozHodnotu(7, float.Parse(vstup07.Text));
            UlozHodnotu(8, float.Parse(vstup08.Text));
            UlozHodnotu(9, float.Parse(vstup09.Text));
            UlozHodnotu(10, float.Parse(vstup10.Text));
            UlozHodnotu(11, float.Parse(vstup11.Text));
            UlozHodnotu(12, float.Parse(vstup12.Text));

            con.Close();
            LoadValues();
        }
        public void UlozHodnotu(int a, float b)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Global SET hodnota=@VstupHodnota WHERE Id = @VstupID", con);
            cmd.Parameters.AddWithValue("@VstupID", a);
            cmd.Parameters.AddWithValue("@VstupHodnota", Math.Round(b,2));
            cmd.ExecuteNonQuery();
        }

    }
}
