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
    public partial class AddEditEmployeeForm : Form
    {
        bool isEdit;
        Employee emp;
        ITrainingGroupsManager tgm;
        List<EmployeesPosition> currPositions;
        public AddEditEmployeeForm(ITrainingGroupsManager trainingGroupManager)
        {
            InitializeComponent();
            tgm = trainingGroupManager;
            emp = new Employee();
            updatePositionComboBoxDataSource();

        }
        public AddEditEmployeeForm(ITrainingGroupsManager trainingGroupManager, Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            isEdit = true;
            tgm = trainingGroupManager;
            updateFields();
        } 
    
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!checkFields()) return;
            emp.Name = nameTextBox.Text;
            emp.Surname = surnameTextBox.Text;
            emp.Phone = phoneTextBox.Text;
            emp.Secondname = secondNameTextBox.Text;
            emp.PositionId = currPositions[positionComboBox.SelectedIndex].Id;
                //tgm.GetEmpPosByName(positionComboBox.SelectedItem.ToString()).Id;
            if (isEdit)
                tgm.EditEmployee(emp);
            else
                tgm.AddEmployee(emp);

            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void updatePositionComboBoxDataSource()
        {
            currPositions = tgm.GetNewEmployeePositionList();
            foreach (EmployeesPosition ep in currPositions)
                positionComboBox.Items.Add(ep.PositionName);

        }
        private void updateFields()
        {
            updatePositionComboBoxDataSource();
            surnameTextBox.Text = emp.Surname;
            nameTextBox.Text = emp.Name;
            secondNameTextBox.Text = emp.Secondname;
            phoneTextBox.Text = emp.Phone;
            positionComboBox.SelectedIndex = currPositions.FindIndex(p => p.Id == emp.PositionId);

        }
        private bool checkFields()
        {
            surnameTextBox.Text = surnameTextBox.Text.Trim(' ');
            nameTextBox.Text = nameTextBox.Text.Trim(' ');
            secondNameTextBox.Text = secondNameTextBox.Text.Trim(' ');
            phoneTextBox.Text = phoneTextBox.Text.Trim(' ');
            if (positionComboBox.SelectedIndex < 0 || surnameTextBox.Text == "" || nameTextBox.Text == "" || secondNameTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля...");
                return false;
            }
            return true;
        }

    }
}
