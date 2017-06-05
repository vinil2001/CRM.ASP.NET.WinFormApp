using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMsales2.BLL.Calculation;

namespace CRMsales2.DLL
{
    public partial class CalcMenueForm : Form
    {
        public CalcMenueForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCalculationForm CalcF = new CreateCalculationForm();
            CalcF.Show();
            Calculation newCalc = new Calculation();
            newCalc.AddNewCalculation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultofUserChoose = MessageBox.Show("Вы действительно хотите удалить выделеную калькуляцию?", "Удаление калькуляции", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultofUserChoose == DialogResult.Yes)
            {
                string removedCalcName =  dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                Calculation tempCalcVar = new Calculation();
                tempCalcVar.RemoveCalculation(removedCalcName);
            }
        }
    }
}
