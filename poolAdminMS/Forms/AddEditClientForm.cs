using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poolAdminMS.Interfaces;

namespace poolAdminMS.Forms
{
    public partial class AddEditClientForm : Form
    {
        IClientManager clientManager;
        Client client;
        public AddEditClientForm(IClientManager clientManager)
        {
            InitializeComponent();
            this.clientManager = clientManager;
        }
        public AddEditClientForm(IClientManager clientManager, Client client)
        {
            InitializeComponent();
            this.client = client;
            this.clientManager = clientManager;
            nameTextBox.Text = client.Name;
            surnameTextBox.Text = client.Surname;
            secondNameTextBox.Text = client.Secondname;
            phoneTextBox.Text = client.Phone;
            manRadioButton.Checked = (bool)client.Gender;
            womanRadioButton.Checked = !(bool)client.Gender;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!CheckFields()) return;
            bool isEdit = (client != null) ? true : false;
            if (!isEdit) client = new Client();

            client.Name = nameTextBox.Text;
            client.Surname = surnameTextBox.Text;
            client.Secondname = secondNameTextBox.Text;
            client.Phone = phoneTextBox.Text;
            client.Gender = (manRadioButton.Checked) ? true : false;
            if (isEdit) clientManager.EditClient(client);
            else
                clientManager.AddClient(client);



            DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool CheckFields()
        {
            surnameTextBox.Text = surnameTextBox.Text.Trim(' ');
            nameTextBox.Text = nameTextBox.Text.Trim(' ');
            secondNameTextBox.Text = secondNameTextBox.Text.Trim(' ');
            phoneTextBox.Text = phoneTextBox.Text.Trim(' ');
            if (surnameTextBox.Text == "" || nameTextBox.Text == "" || secondNameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Заполните все данные");
                return false;
            }
            return true;
               
        }
    }
}
