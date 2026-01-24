using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBiblioteka
{

    public partial class Form1 : Form
    {
        int index;
        string plik = "biblioteka.txt";
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            PoleDoSzukania.Enabled = false;

            dataTable.Columns.Add("Tytul");
            dataTable.Columns.Add("Autor");
            dataTable.Columns.Add("Rok");
            dataTable.Columns.Add("Strony");
            dataTable.Columns.Add("Kategoria");

            string[] wczytaj = File.ReadAllLines(plik);
            for (int i = 0; i < wczytaj.Length; i++)
            {
                string[] wiersz = wczytaj[i].Split(',');
                if (wiersz.Length == 5)
                {
                    dataTable.Rows.Add(wiersz[0], wiersz[1], wiersz[2], wiersz[3], wiersz[4]);
                }

            }

            TabelaGridView.DataSource = dataTable;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WyjdzButton_Click(object sender, EventArgs e)
        {
            DialogResult OpcjeWyjdz;

            OpcjeWyjdz = MessageBox.Show("Czy napewno chcesz wyjść?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (OpcjeWyjdz == DialogResult.Yes) {
                Application.Exit();
            }

        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(TytulText.Text, AutorText.Text, RokText.Text, StronyText.Text, KategoriaText.Text);
        }

        private void UsunButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in TabelaGridView.SelectedRows)
            {
                TabelaGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void EdytujButton_Click(object sender, EventArgs e)
        {
            DataRow updateitem = dataTable.Rows[index];
            updateitem["Tytul"] = TytulText.Text;
            updateitem["Autor"] = AutorText.Text;
            updateitem["Rok"] = RokText.Text;
            updateitem["Strony"] = StronyText.Text;
            updateitem["Kategoria"] = KategoriaText.Text;
        }

        private void TabelaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataRow row = dataTable.Rows[index];

            TytulText.Text = row["Tytul"].ToString();
            AutorText.Text = row["Autor"].ToString();
            RokText.Text = row["Rok"].ToString();
            StronyText.Text = row["Strony"].ToString();
            KategoriaText.Text = row["Kategoria"].ToString();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {

            File.WriteAllText(plik, string.Empty);

            for (int i = 0; i < dataTable.Rows.Count; i++) 
            {
                for (int j = 0; j < dataTable.Columns.Count; j++) 
                {
                    if (j < dataTable.Columns.Count - 1)
                    {
                        File.AppendAllText(plik, TabelaGridView.Rows[i].Cells[j].Value.ToString() + ",");
                    }

                    else
                    {
                        File.AppendAllText(plik, TabelaGridView.Rows[i].Cells[j].Value.ToString() + "\n");
                    }
                }
            }
        }

        private void PoleDoSzukania_TextChanged(object sender, EventArgs e)
        {
            if (AutorLookUp.Checked)
            {
                dataTable.DefaultView.RowFilter = $"Autor LIKE '%{PoleDoSzukania.Text}%'";
            }

            else if (TytulLookUp.Checked)
            {
                dataTable.DefaultView.RowFilter = $"Tytul LIKE '%{PoleDoSzukania.Text}%'";
            }

        }

        private void AutorLookUp_CheckedChanged(object sender, EventArgs e)
        {
            PoleDoSzukania.Enabled = true;
        }

        private void TytulLookUp_CheckedChanged(object sender, EventArgs e)
        {
            PoleDoSzukania.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // powinien to być tytulSort, a nie radioButton1
        {
            this.TabelaGridView.Sort(this.TabelaGridView.Columns["Tytul"], ListSortDirection.Ascending);
        }

        private void rokWydaniaSort_CheckedChanged(object sender, EventArgs e)
        {
            this.TabelaGridView.Sort(this.TabelaGridView.Columns["Rok"], ListSortDirection.Ascending);
        }

        private void RokText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PoleDoSzukania_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void RokText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            {
                e.Handled = true;
            }
        }

        private void StronyText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            {
                e.Handled = true;
            }
        }

        private void AutorText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\D+"))
            {
                e.Handled = true;
            }
        }
    }
}
