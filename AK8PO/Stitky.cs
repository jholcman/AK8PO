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

        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }
    }
}
