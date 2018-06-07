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

namespace poolAdminMS.UserControls
{
    public partial class CalendarDayLarge : UserControl
    {
        private ICalendarManager calendarManager;
        public CalendarDayLarge(ICalendarManager calendarManager)
        { 
            InitializeComponent();
            this.calendarManager = calendarManager;
            createGrid();
            UpdateGrid();
        }
        private void createGrid()
        {
            List<TrainingGroup> trainingGroups = calendarManager.GetNewTrainingGroupList();
            DataGridViewTextBoxColumn tbColumn = new DataGridViewTextBoxColumn();
            tbColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tbColumn.ReadOnly = true;
            tbColumn.Name = "Время";
            dayTimeTableDataGrid.Columns.Add(tbColumn);
            for (int i = 1; i < 7; i++)
            {
                DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
                cmbColumn.FlatStyle = FlatStyle.Flat;
                cmbColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                foreach (TrainingGroup t in trainingGroups)
                {
                    cmbColumn.Items.Add(t.GroupName);
                }
                cmbColumn.Name = "Дорожка №" + (i);
                dayTimeTableDataGrid.Columns.Add(cmbColumn);
            }
            
            
        }
        private void UpdateGrid()
        {
            dayTimeTableDataGrid.Rows.Clear();
            List<DayTimeSet> currDayTimeSet = calendarManager.GetNewDayTimeSetList();
            foreach(DayTimeSet dts in currDayTimeSet)
            {
                dayTimeTableDataGrid.Rows.Add(dts.StartTime.ToString() + " - " + dts.EndTime.ToString());
            }
        }

        private void addTimeButton_Click(object sender, EventArgs e)
        {

        }

        private void dayTimeTableDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewComboBoxCell cbc = dayTimeTableDataGrid[e.ColumnIndex, e.RowIndex] as DataGridViewComboBoxCell;
            if (cbc == null) return;
            
            int ind = cbc.Items.IndexOf(cbc.Value.ToString());

            dayTimeTableDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = calendarManager.GetTrainingGroupColorByComboBoxIndex(ind);

        }
    }
}
