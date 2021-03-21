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
            vstup01.Text = StringLibrary.NactiHodnotuGlobal(1);
            vstup02.Text = StringLibrary.NactiHodnotuGlobal(2);
            vstup03.Text = StringLibrary.NactiHodnotuGlobal(3);
            vstup04.Text = StringLibrary.NactiHodnotuGlobal(4);
            vstup05.Text = StringLibrary.NactiHodnotuGlobal(5);
            vstup06.Text = StringLibrary.NactiHodnotuGlobal(6);
            vstup07.Text = StringLibrary.NactiHodnotuGlobal(7);
            vstup08.Text = StringLibrary.NactiHodnotuGlobal(8);
            vstup09.Text = StringLibrary.NactiHodnotuGlobal(9);
            vstup10.Text = StringLibrary.NactiHodnotuGlobal(10);
            vstup11.Text = StringLibrary.NactiHodnotuGlobal(11);
            vstup12.Text = StringLibrary.NactiHodnotuGlobal(12);
          }
        private void UpdateValues(object sender, EventArgs e)
        {
            StringLibrary.UlozHodnotuGlobal(1, float.Parse(vstup01.Text));
            StringLibrary.UlozHodnotuGlobal(2, float.Parse(vstup02.Text));
            StringLibrary.UlozHodnotuGlobal(3, float.Parse(vstup03.Text));
            StringLibrary.UlozHodnotuGlobal(4, float.Parse(vstup04.Text));
            StringLibrary.UlozHodnotuGlobal(5, float.Parse(vstup05.Text));
            StringLibrary.UlozHodnotuGlobal(6, float.Parse(vstup06.Text));
            StringLibrary.UlozHodnotuGlobal(7, float.Parse(vstup07.Text));
            StringLibrary.UlozHodnotuGlobal(8, float.Parse(vstup08.Text));
            StringLibrary.UlozHodnotuGlobal(9, float.Parse(vstup09.Text));
            StringLibrary.UlozHodnotuGlobal(10, float.Parse(vstup10.Text));
            StringLibrary.UlozHodnotuGlobal(11, float.Parse(vstup11.Text));
            StringLibrary.UlozHodnotuGlobal(12, float.Parse(vstup12.Text));
            LoadValues();
        }

    }
}
