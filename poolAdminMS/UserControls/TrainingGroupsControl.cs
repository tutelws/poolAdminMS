using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poolAdminMS.Interfaces;
using poolAdminMS.Forms;

namespace poolAdminMS.UserControls
{
    public partial class TrainingGroupsControl : UserControl
    {
        ITrainingGroupsManager trainingGroupsManager;
        private int currEmployeeId;
        public TrainingGroupsControl(ITrainingGroupsManager trainingGroupsManager)
        {
            InitializeComponent();
            this.trainingGroupsManager = trainingGroupsManager;
            UpdateEmployeeDataGrid();
            UpdateTrainingGroupDataGrid();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm f = new AddEditEmployeeForm(trainingGroupsManager);
            if (f.ShowDialog() == DialogResult.OK)
                UpdateEmployeeDataGrid();
        }



        private void UpdateEmployeeDataGrid()
        {
            employeesDataGrid.Rows.Clear();
            List<Employee> emp = trainingGroupsManager.GetNewEmployeeList();
            foreach (Employee e in emp)
            {
                employeesDataGrid.Rows.Add(
                    e.Id,
                    e.Surname,
                    e.Name,
                    e.Secondname,
                    trainingGroupsManager.GetPositionNameById((int)e.PositionId),
                    e.Phone);
            }
        }
        private void UpdateTrainingGroupDataGrid()
        {
            trainingGroupsDataGrid.Rows.Clear();
            currEmployeeId = -1;
            List<TrainingGroup> tg = trainingGroupsManager.GetNewTrainingGroupList();
            foreach (TrainingGroup t in tg)
            {
                Employee emp = trainingGroupsManager.GetEmpById((int)t.CoachId);
                trainingGroupsDataGrid.Rows.Add(
                    t.Id,
                    t.GroupName,
                    emp.Surname + ' ' + emp.Name + ' ' + emp.Secondname
                    );
            }
        }
        private void UpdateTrainingGroupDataGrid(int empId)
        {
            trainingGroupsDataGrid.Rows.Clear();
            currEmployeeId = -1;
            List<TrainingGroup> tg = trainingGroupsManager.GetNewTrainingGroupList();
            foreach (TrainingGroup t in tg)
            {
                if (t.CoachId != empId) continue;
                Employee emp = trainingGroupsManager.GetEmpById((int)t.CoachId);
                trainingGroupsDataGrid.Rows.Add(
                    t.Id,
                    t.GroupName,
                    emp.Surname + ' ' + emp.Name + ' ' + emp.Secondname
                    );
            }
        }
        private void addTrainingGroup_Click(object sender, EventArgs e)
        {
            AddEditTrainingGroupForm f = new AddEditTrainingGroupForm(trainingGroupsManager);
            if (f.ShowDialog() == DialogResult.OK)
            {
                UpdateTrainingGroupDataGrid();
            }
        }

        private void showAllGroups_Click(object sender, EventArgs e)
        {
            UpdateTrainingGroupDataGrid();
            UpdateEmployeeDataGrid();
        }

        private void trainingGroupsDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (trainingGroupsDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Группа не выбрана.");
                return;
            }
            int id = Convert.ToInt32(trainingGroupsDataGrid.SelectedRows[0].Cells[0].Value);
            AddEditTrainingGroupForm f = new AddEditTrainingGroupForm(trainingGroupsManager, trainingGroupsManager.GetTrainingGroupById(id));
            if (f.ShowDialog() == DialogResult.OK)
            {
                UpdateTrainingGroupDataGrid();
            }
        }

        private void editTrainingGroupButton_Click(object sender, EventArgs e)
        {
            if (trainingGroupsDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Группа не выбрана.");
                return;
            }
            int id = Convert.ToInt32(trainingGroupsDataGrid.SelectedRows[0].Cells[0].Value);
            AddEditTrainingGroupForm f = new AddEditTrainingGroupForm(trainingGroupsManager, trainingGroupsManager.GetTrainingGroupById(id));
            if (f.ShowDialog() == DialogResult.OK)
            {
                UpdateTrainingGroupDataGrid();
            }
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if(employeesDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сотрудник не выбран.");
                return;
            }
            AcceptDialogForm f = new AcceptDialogForm("Вы уверены что хотите удалить сотрудника (также будут удалены все тренеровочные группы которые вёл сотрудник)?");
            if (!(f.ShowDialog() == DialogResult.OK)) return;

            trainingGroupsManager.DeleteEmployeeById(Convert.ToInt32(employeesDataGrid.SelectedRows[0].Cells[0].Value));
            UpdateEmployeeDataGrid();
            UpdateTrainingGroupDataGrid();
        }

        private void deletetrainingGroup_Click(object sender, EventArgs e)
        {
            if (trainingGroupsDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Группа не выбрана.");
                return;
            }
            AcceptDialogForm f = new AcceptDialogForm("Вы уверены что хотите удалить тренеровочную группу?");
            if (!(f.ShowDialog() == DialogResult.OK)) return;

            trainingGroupsManager.DeleteTrainingGroupById(Convert.ToInt32(trainingGroupsDataGrid.SelectedRows[0].Cells[0].Value));
            UpdateTrainingGroupDataGrid();
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeesDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сотрудник не выбран.");
                return;
            }

            AddEditEmployeeForm f = new AddEditEmployeeForm(trainingGroupsManager, trainingGroupsManager.GetEmpById(
                Convert.ToInt32(employeesDataGrid.SelectedRows[0].Cells[0].Value)));
            if (f.ShowDialog() == DialogResult.OK)
                UpdateEmployeeDataGrid();
        }

        private void searchEmployeesBySurnameButton_Click(object sender, EventArgs e)
        {
            employeesDataGrid.Rows.Clear();
            List<Employee> emp = trainingGroupsManager.GetEmployeesBySurname(searchTextBox.Text);
            if (emp.Count < 1)
            {
                MessageBox.Show("Сотрудники не найдены.");
                return;
            }
            foreach (Employee em in emp)
            {
                employeesDataGrid.Rows.Add(
                    em.Id,
                    em.Surname,
                    em.Name,
                    em.Secondname,
                    trainingGroupsManager.GetPositionNameById((int)em.PositionId),
                    em.Phone);
            }
        }

        private void searchGroupsByNameButton_Click(object sender, EventArgs e)
        {
            trainingGroupsDataGrid.Rows.Clear();
            currEmployeeId = -1;
            List<TrainingGroup> tg = trainingGroupsManager.GetTrainingGroupByName(searchTextBox.Text);
            if (tg.Count < 1)
            {
                MessageBox.Show("Тренеровочные группы с таким названием не найдены.");
                return;
            }
            foreach (TrainingGroup t in tg)
            {
                Employee emp = trainingGroupsManager.GetEmpById((int)t.CoachId);
                trainingGroupsDataGrid.Rows.Add(
                    t.Id,
                    t.GroupName,
                    emp.Surname + ' ' + emp.Name + ' ' + emp.Secondname
                    );
            }
        }

        private void employeesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeesDataGrid.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(employeesDataGrid.SelectedRows[0].Cells[0].Value);
            UpdateTrainingGroupDataGrid(id);
        }
    }
}
