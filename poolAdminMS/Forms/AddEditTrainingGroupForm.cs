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
    public partial class AddEditTrainingGroupForm : Form
    {
        private bool isEdit;
        private TrainingGroup currGroup;
        private ITrainingGroupsManager tgm;
        private List<Employee> coachList;
        public AddEditTrainingGroupForm(ITrainingGroupsManager tgm)
        {
            InitializeComponent();
            isEdit = false;
            this.tgm = tgm;
            currGroup = new TrainingGroup();
            updateComboBoxDataSource();
        }
        public AddEditTrainingGroupForm(ITrainingGroupsManager tgm, TrainingGroup currGroup)
        {
            InitializeComponent();
            isEdit = true;
            this.currGroup = currGroup;
            this.tgm = tgm;
            updateFields();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!checkFields()) return;

            currGroup.CoachId = coachList[coachFioComboBox.SelectedIndex].Id;
            currGroup.GroupName = groupNameTextBox.Text;
            currGroup.Color = new byte[4];
            currGroup.Color[0] = colorPickerPanel.BackColor.A;
            currGroup.Color[1] = colorPickerPanel.BackColor.R;
            currGroup.Color[2] = colorPickerPanel.BackColor.G;
            currGroup.Color[3] = colorPickerPanel.BackColor.B;
            if (!isEdit)
                tgm.AddTrainingGroup(currGroup);
            else
                tgm.EditTrainingGroup(currGroup);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool checkFields()
        {
            groupNameTextBox.Text = groupNameTextBox.Text.Trim(' ');
            if (groupNameTextBox.Text == "" || coachFioComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля...");
                return false;
            }
            return true;
        }
        private void updateComboBoxDataSource()
        {
            coachList = tgm.GetNewEmployeeListByPositionId(1, 2);
            foreach (Employee e in coachList)
                coachFioComboBox.Items.Add(e.Surname + " " + e.Name + " " + e.Secondname);
        }
        private void updateFields()
        {
            groupNameTextBox.Text = currGroup.GroupName;
            updateComboBoxDataSource();
            coachFioComboBox.SelectedIndex = coachList.FindIndex(c => c.Id == currGroup.CoachId);
            if (currGroup.Color != null && currGroup.Color.Length == 4)
                colorPickerPanel.BackColor = Color.FromArgb(currGroup.Color[0], currGroup.Color[1], currGroup.Color[2], currGroup.Color[3]);
        }

        private void colorPickerPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPickerPanel.BackColor = colorDialog1.Color;
            }
        }
    }
}
