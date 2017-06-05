using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMsales2.DLL;

namespace CRMsales2
{
    public partial class TypeOfOwnershipForm : Form
    {
        public TypeOfOwnershipForm()
        {
            InitializeComponent();
            RefreshTable();

        }
        private void AddNewCouterpartyType_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TypeOfOwnership.AddTypeOfOwnership(textBox1.Text);
                textBox1.Text = "";
                RefreshTable();
            }
        }

        private void RefreshTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TypeOfOwnership.GetAllOwnershipTypes();
           //dataGridView1.Columns[0].Visible = false;
        }

        private void DelleteTypeOfOwnership_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Удаление форм собственности", "Удалить выбранную форму собственности?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                TypeOfOwnership.DeleteTypeOfOwnership(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                RefreshTable();
            }
        }
        private void EditeTypeOfOwnership_Click(object sender, EventArgs e)
        {
            TypeOfOwnership.EditTypeOfOwnership(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), textBox1.Text);
            RefreshTable();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
        }
    }
}
