using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK8PO
{
    public partial class Hlavni: Form
    {
        public Hlavni()
        {
            InitializeComponent();
        }

        private void KonecProgramu(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Zamestnanci_Click(object sender, EventArgs e)
        {
            Zamestnanci zamestnanec = new Zamestnanci();
            this.Hide();
            zamestnanec.ShowDialog();

            this.Show();
        }

        private void Studenti_Click(object sender, EventArgs e)
        {
            Studenti student = new Studenti();
            this.Hide();
            student.ShowDialog();

            this.Show();

        }

        private void Predmety_Click(object sender, EventArgs e)
        {
            Predmet predmet = new Predmet();
            this.Hide();
            predmet.ShowDialog();

            this.Show();
        }

        private void Rozvrhy_Click(object sender, EventArgs e)
        {
            Rozvrhy rozvrh = new Rozvrhy();
            this.Hide();
            rozvrh.ShowDialog();

            this.Show();

        }

        private void Body_Click(object sender, EventArgs e)
        {
            Global body = new Global();
            this.Hide();
            body.ShowDialog();

            this.Show();

        }

        private void Stitky_Click(object sender, EventArgs e)
        {
            Stitky stitky = new Stitky();
            this.Hide();
            stitky.ShowDialog();

            this.Show();


        }

        private void Test_Click(object sender, EventArgs e)
        {

            Form5 test = new Form5();
            this.Hide();
            test.ShowDialog();

            this.Show();

        }

        private void Kapacita_Click(object sender, EventArgs e)
        {
            Kapacita kapacita = new Kapacita();
            this.Hide();
            kapacita.ShowDialog();

            this.Show();

        }
    }
}
