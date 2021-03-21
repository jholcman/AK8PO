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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'databaseUTBDataSet32.Stitky'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.stitkyTableAdapter.Fill(this.databaseUTBDataSet32.Stitky);

        }
    }
}
