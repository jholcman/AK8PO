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
            StringLibrary.GenerujIdCombo(comboBox1, "Jazyk", "Jazyk_text", 2);
            // StringLibrary.Generuj(comboBox1, StringLibrary.JazykRetezec(), 0);
        }

        private void Zmena(object sender, EventArgs e)
        {
            prvni.Text = comboBox1.SelectedValue.ToString();
            druhy.Text = comboBox1.SelectedItem.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
