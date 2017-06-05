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
using CRMsales2.DLL;

namespace CRMsales2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
          //  var connString = "Server = mysql313.1gb.ua; Database=gbua_orestnew;Uid=gbua_orestnew;Pwd=my_password";
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            //MySqlContext db = new MySqlContext();
            //ContactPerson contact = new ContactPerson();
            //contact.Name = "asdasdasdsa";

            //CounterpartyCompanies company = db.dbCounterpartyCompanies.Where(a => a.ID == 942).First();
            //company.Contacts = new List<ContactPerson>();
            //company.Contacts.Add(contact);
            //db.SaveChanges();

          



        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm PF = new ProductForm();
            PF.MdiParent = this;
          
            PF.Show();
        }

        private void синхронизацияКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportAgent.GetImportedAgentList();
            
            
        }

        private void синхронизацияТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportGoods.getImportedProductList();
            

        }

      

        private void создатьНовогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterpartyAddForm CAF = new CounterpartyAddForm();
            CAF.ShowDialog();

        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterpartyForm CounterparForm = new CounterpartyForm();
            CounterparForm.MdiParent = this;
            CounterparForm.Show();
        }

        private void типКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterpartyTypeForm CounterpartyTypeF = new CounterpartyTypeForm();
            CounterpartyTypeF.MdiParent = this;
            CounterpartyTypeF.Show();
        }

        private void формыСобственностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfOwnershipForm TypeOfOwnershipF = new TypeOfOwnershipForm();
            TypeOfOwnershipF.MdiParent = this;
            TypeOfOwnershipF.Show();
        }

        private void расчетСтоимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcMenueForm MenueCalcF = new CalcMenueForm();
            MenueCalcF.MdiParent = this;
            MenueCalcF.Show();
        }

        private void синхронизацияЕдизмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportUnits.GetAll();
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitsForm MenueUnitF = new UnitsForm();
            MenueUnitF.MdiParent = this;
            MenueUnitF.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
