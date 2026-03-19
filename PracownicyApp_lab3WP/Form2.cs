using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracownicyApp_lab3WP
{
    public partial class Form2 : Form
    {
        public String Imie;
        public String Nazwisko;
        public int Wiek;
        public String Stanowisko;

        public Form2()
        {

            InitializeComponent();
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            Imie = textBox1.Text;
            Nazwisko = textBox2.Text;
            Wiek = (int)numericUpDown1.Value;
            Stanowisko = comboBox1.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtImie(object sender, EventArgs e)
        {

        }

        private void txtNazwisko(object sender, EventArgs e)
        {

        }

        private void numWiek(object sender, EventArgs e)
        {

        }

        private void comboStanowisko(object sender, EventArgs e)
        {

        }
    }
}
