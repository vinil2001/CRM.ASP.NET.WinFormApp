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
    public partial class CounterpartyTypeForm : Form
    {
        public CounterpartyTypeForm()
        {
            InitializeComponent();
            RefreshTable();
    }
        private void RefreshTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CountraprtyType.GetAllTypes();
            dataGridView1.Columns[0].Visible = false;
        }
        private void AddNewCouterpartyType_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                CountraprtyType.AddCounterpartyType(textBox1.Text);
                textBox1.Text = "";

                RefreshTable();
            }
        }
        private void DelleteCounterpartyType_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Удаление типа.", "Удалить выбранный тип корагента?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                //CountraprtyType.DeleteCounterpartyType(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                CountraprtyType DeletedType = new CountraprtyType();
                DeletedType.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //DeletedType.Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
               
                CountraprtyType.DeleteCounterpartyType(DeletedType);
                RefreshTable();
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString() != null)
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
            else
                textBox1.Text = "";
        }
        private void EditeCounterpartyType_Click(object sender, EventArgs e)
        {
            //CountraprtyType.EditCounterpartyType(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), textBox1.Text/*dataGridView1.SelectedRows[0].Cells[1].Value.ToString()*/);
            CountraprtyType EditedType = new CountraprtyType();
            EditedType.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            EditedType.Name = textBox1.Text.ToString();
            CountraprtyType.EditCounterpartyType(EditedType);
            RefreshTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
        }
    }
}
