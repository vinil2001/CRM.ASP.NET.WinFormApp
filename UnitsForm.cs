using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMsales2.BLL;

namespace CRMsales2
{
    public partial class UnitsForm : Form
    {
        public UnitsForm()
        {
            InitializeComponent();
            RefreshUnit();
        }
        
        public void RefreshUnit()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Unit.GetAll();
            dataGridView1.Columns[0].Visible = false;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows[0].Cells[1].Value == null)
            {
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows[0].Cells[1].Value != null )
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                
            }
        }

        private void AddNewCouterpartyType_Click(object sender, EventArgs e)
        {
            Unit.Add(textBox1.Text);
            RefreshUnit();
        }

        private void DelleteCounterpartyType_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Удалить выбранную единицу измерения?", "Удаление.Удалить выбранную единицу измерения?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Unit tempUnt = new Unit { ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) };
                Unit.Delete(tempUnt);
                RefreshUnit();
            }
        }
        private void EditeCounterpartyType_Click(object sender, EventArgs e)
        {
            Unit tempUnt = new Unit {ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Name = textBox1.Text };
            Unit.Edit(tempUnt);
            RefreshUnit();
        }
    }
}
