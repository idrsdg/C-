using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "1";
            dataGridView1.Rows[0].Cells[1].Value = "2";
            dataGridView1.Rows[1].Cells[0].Value = "3";
            dataGridView1.Rows[1].Cells[1].Value = "4";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[row].Cells[column].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "product ID";
            dataGridView1.Columns[1].Name = "product Name";
            dataGridView1.Columns[2].Name = "product Price";

            string[] row = new string[] { "1", "Z product 1", "1000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "C product 2", "2000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "F product 2", "3000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "4", "A product 2", "4000" };
            dataGridView1.Rows.Add(row);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Click Data";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
