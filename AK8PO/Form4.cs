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

namespace AK8PO
{
    public partial class Rozvrhy : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\UTB\1. ročník LS\AK8PO - Pokročilé programování\Projek\AK8PO\AK8PO\DatabaseUTB.mdf'; Integrated Security = True");
        public Rozvrhy()
        {
            InitializeComponent();
        }

        private void ZpetNaHlavni(object sender, EventArgs e)
        {
            Close();
        }
    }
}
