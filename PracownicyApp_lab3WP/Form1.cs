using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PracownicyApp_lab3WP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Imie", "Imię");
            dataGridView1.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("Wiek", "Wiek");
            dataGridView1.Columns.Add("Stanowisko", "Stanowisko");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        int id = 1;
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(id, form.Imie, form.Nazwisko, form.Wiek, form.Stanowisko);
                id++;
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnZapis_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "CSV|*.csv";

            if (s.ShowDialog() == DialogResult.OK)
            {
                string text = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        text += string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "")) + Environment.NewLine;
                    }
                }
                File.WriteAllText(s.FileName, text);
            }
        }
        private void btnOdczyt_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "CSV|*.csv";

            if (o.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();

                var lines = File.ReadAllLines(o.FileName);
                foreach (var line in lines)
                {
                    var values = line.Split(',');
                    dataGridView1.Rows.Add(values);
                }
            }
        }
    }
}

