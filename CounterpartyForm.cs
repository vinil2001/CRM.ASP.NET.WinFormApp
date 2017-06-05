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
using System.IO;
using CRMsales2;

namespace CRMsales2
{
    public partial class CounterpartyForm : Form
    {
        List<CounterpartyCompanies> Companies;
        List<ContactPerson> Contacts;
        CurrentLeadStatus CC = new CurrentLeadStatus();
        public CounterpartyForm()
        {
            InitializeComponent();
            Companies = CounterpartyCompanies.GetAllCompanies().ToList();
            dataGridView1.DataSource = Companies;
            comboBoxCountrapartyType.DataSource = CountraprtyType.GetAllTypes();
            comboBoxCountrapartyType.DisplayMember = "Name";
            comboBoxCountrapartyType.ValueMember = "Name";
            comboBoxOwnershipType.DataSource = TypeOfOwnership.GetAllOwnershipTypes();
            comboBoxOwnershipType.DisplayMember = "Name";
            comboBoxOwnershipType.ValueMember = "ID";
            dataGridView1.Columns["OwnershipTypeID"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Contacts"].Visible = false;
            dataGridView1.Columns["Name"].Width = 200;
            int SelectedID = Convert.ToInt32(dataGridView1.Rows[0].Cells["ID"].Value);
            dataGridView1.Columns["Name"].HeaderText = "Компания";
            dataGridView1.Columns["IPN"].Visible = false;
            dataGridView1.Columns["EDRPO"].Visible = false;
            dataGridView1.Columns["BankName"].Visible = false;
            dataGridView1.Columns["ACCNumb"].Visible = false;
            dataGridView1.Columns["MFO"].Visible = false;
            dataGridView1.Columns["PhoneFaxCity"].Visible = true;
            dataGridView1.Columns["PhoneFaxCity"].HeaderText = "Телефон/факс";
            dataGridView1.Columns["DirectorFIO"].Visible = false;
            if (dataGridView1.Rows[0].Cells["DirectorFIO"].Value != null)
                textBox9.Text = dataGridView1.Rows[0].Cells["DirectorFIO"].Value.ToString();
            dataGridView1.Columns["WebPage"].Visible = true;
            dataGridView1.Columns["WebPage"].HeaderText = "Сайт";
            dataGridView1.Columns["AdressDelivery"].Visible = true;
            dataGridView1.Columns["AdressDelivery"].HeaderText = "Адресс доставки";
            dataGridView1.Columns["AdressPost"].Visible = false;
            dataGridView1.Columns["AdressFact"].Visible = true;
            dataGridView1.Columns["AdressFact"].HeaderText = "Адресс фактический";
            dataGridView1.Columns["AndressLegal"].Visible = false;
            dataGridView1.Columns["DeliveryInfo"].Visible = false;
            dataGridView1.Columns["Discount"].Visible = false;
            dataGridView1.Columns["CountraprtyTypeName"].Visible = false;
            dataGridView1.Columns["Status"].Visible = true;
            dataGridView1.Columns["Comments"].Visible = false;
        }

        bool SelectedRow = false;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxOwnershipType.BackColor = Color.Empty;
            try
            {
                SelectedRow = true;
                int SelectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                Contacts = Companies.Where(a => a.ID == SelectedID).First().Contacts.ToList(); // ссылка на все
                 // контакты выбранной компании
                listBox1.Items.Clear();
                if (dataGridView1.SelectedRows.Count == 0) return;
                if (Contacts.Count == 0 && comboBoxFIOManager.DataSource != null)
                {
                    comboBoxFIOManager.SelectedText = "";
                    comboBoxFIOManager.DataSource = null;
                    comboBoxFIOManager.Text = "Информация о работниках данной компании отсутствует.";
                    comboBoxFIOManager.Enabled = false;
                    dataGridViewPhoneNumbers.DataSource = null;
                    textBoxInternalNumber.Text = "Информация отсутствует.";
                    //textBoxWorkE_mail.Text = "Информация отсутствует.";
                    //textBoxPersonalE_mail.Text = "Информация отсутствует.";
                    dataGridViewMessengers.DataSource = null;
                    dataGridViewSocialWEBLink.DataSource = null;
                }    
                else
                    if (Contacts.Count != 0)
                    {
                        comboBoxFIOManager.DataSource = Contacts;
                        comboBoxFIOManager.DisplayMember = "Name";
                        comboBoxFIOManager.ValueMember = "ID";
                        comboBoxFIOManager.Enabled = true;
                    }          
                if (dataGridView1.SelectedRows[0].Cells["DirectorFIO"].Value != null)
                    textBox9.Text = dataGridView1.SelectedRows[0].Cells["DirectorFIO"].Value.ToString();
                CounterpartyTextBox.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["CountraprtyTypeName"].Value.ToString() != null)
                    comboBoxCountrapartyType.Text = dataGridView1.SelectedRows[0].Cells["CountraprtyTypeName"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["Discount"].Value != null)
                    textBoxDiscount.Text = dataGridView1.SelectedRows[0].Cells["Discount"].Value.ToString();
                //if (dataGridView1.SelectedRows[0].Cells["Status"].Value != null)
                //   textBox1.Text = dataGridView1.SelectedRows[0].Cells["Status"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["OwnershipTypeID"].Value != null)
                    comboBoxOwnershipType.SelectedValue = dataGridView1.SelectedRows[0].Cells["OwnershipTypeID"].Value;
                if (dataGridView1.SelectedRows[0].Cells["OwnershipTypeID"].Value == null)
                    comboBoxOwnershipType.Text = "";
                if (comboBoxOwnershipType.Text == "") 
                {
                    DialogResult message = MessageBox.Show("Определить форму собственности клиента?", "Напоминание! Отсутствует форма собственности клиента.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    comboBoxOwnershipType.BackColor = Color.Red;                
                }
                if (dataGridView1.SelectedRows[0].Cells["Comments"].Value != null)
                    textBox24.Text = dataGridView1.SelectedRows[0].Cells["Comments"].Value.ToString();              
                if (dataGridView1.SelectedRows[0].Cells["IPN"].Value != null)
                    textBox4.Text = dataGridView1.SelectedRows[0].Cells["IPN"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["EDRPO"].Value != null)
                    textBox5.Text = dataGridView1.SelectedRows[0].Cells["EDRPO"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["BankName"].Value != null)
                    textBox6.Text = dataGridView1.SelectedRows[0].Cells["BankName"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["ACCNumb"].Value != null)
                    textBox7.Text = dataGridView1.SelectedRows[0].Cells["ACCNumb"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["MFO"].Value != null)
                    textBox8.Text = dataGridView1.SelectedRows[0].Cells["MFO"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["PhoneFaxCity"].Value != null)
                    listBox1.Items.Add(dataGridView1.SelectedRows[0].Cells["PhoneFaxCity"].Value.ToString());
                if (dataGridView1.SelectedRows[0].Cells["WebPage"].Value != null)
                    textBox10.Text = dataGridView1.SelectedRows[0].Cells["WebPage"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["AdressDelivery"].Value != null)
                    textBox11.Text = dataGridView1.SelectedRows[0].Cells["AdressDelivery"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["AdressPost"].Value != null)
                    textBox12.Text = dataGridView1.SelectedRows[0].Cells["AdressPost"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["AdressFact"].Value != null)
                    textBox18.Text = dataGridView1.SelectedRows[0].Cells["AdressFact"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["AndressLegal"].Value != null)
                    textBox19.Text = dataGridView1.SelectedRows[0].Cells["AndressLegal"].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells["DeliveryInfo"].Value != null)
                    textBoxDelivery.Text = dataGridView1.SelectedRows[0].Cells["DeliveryInfo"].Value.ToString();

            }
            catch (Exception ex)
            {
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CounterpartyAddForm CAF = new CounterpartyAddForm();
            CAF.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ContactPerson contact = comboBox4.SelectedValue as ContactPerson;
            //textBox2.Text = contact.InternalCytyNumberOfPhone;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlContext db = new MySqlContext();
            int SelectID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            CounterpartyCompanies SelectedCompany = db.dbCounterpartyCompanies.Include("Contacts").SingleOrDefault(p => p.ID == SelectID);
            db.SaveChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SelectedRow)
            {
                SelectedRow = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(CounterpartyTextBox.Text) == false)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = (from a in Companies where a.Name.Contains(CounterpartyTextBox.Text) select a).ToList();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Companies;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            // При измении текста запоминать информацию о внутр.телефоне, для выбранной компании
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int SelectedManagerID = comboBoxFIOManager.SelectedIndex;
            var Contact = Contacts.Where(a => a.ID == SelectedManagerID).First();
            textBoxInternalNumber.Text = Contact.InternalCytyNumberOfPhone;
            dataGridViewMessengers.DataSource = Contact.Messengers;
            dataGridViewMessengers.RowHeadersVisible = false;
            dataGridViewMessengers.Columns["ID"].Visible = false;
            dataGridViewMessengers.Columns["MessengerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMessengers.Columns["UserNumberOrLogo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMessengers.Columns["MessengerName"].HeaderText = "Название";
            dataGridViewMessengers.Columns["UserNumberOrLogo"].HeaderText = "Логин/номер";
            dataGridViewPhoneNumbers.DataSource = Contact.MobilePhones.ToList();
            dataGridViewPhoneNumbers.Columns["ID"].Visible = false;
            dataGridViewPhoneNumbers.RowHeadersVisible = false;
            dataGridViewPhoneNumbers.ColumnHeadersVisible = false;
            dataGridViewSocialWEBLink.DataSource = Contact.SocialNetworkLink.ToList();
            dataGridViewSocialWEBLink.Columns["ID"].Visible = false;
            dataGridViewSocialWEBLink.RowHeadersVisible = false;
            dataGridViewSocialWEBLink.ColumnHeadersVisible = false;
            dataGridViewEmails.DataSource = Contact.Emails.ToList();
            dataGridViewEmails.RowHeadersVisible = false;
            dataGridViewEmails.Columns["ID"].Visible = false;
            dataGridViewEmails.Columns["emailAdress"].HeaderText = "Адрес";
            dataGridViewEmails.Columns["commentForEmail"].HeaderText = "Комментарий";
            dataGridViewEmails.Columns["emailAdress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSocialWEBLink.DataSource = Contact.SocialNetworkLink.ToList();
            dataGridViewSocialWEBLink.Columns["Link"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddNewWorkerForm WF = new AddNewWorkerForm();
            WF.Show();
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (CC.StatusName.Count == 0) return;
            if (CC.StatusName.Contains(textBoxStatusName.Text))
                return;
            CC.StatusDataTime.Add(DateTime.Now.ToString());
            CC.StatusName.Add(textBoxStatusName.Text.ToString());
            textBoxLastChangesDataTime.Text = CC.StatusDataTime.Last().ToString();
        }
    }
}
