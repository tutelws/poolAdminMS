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
        public static string EMPTY_CELL_DEFAULT_VALUE = "Свободно";

        private DateTime currDate;
        private ICalendarManager calendarManager;

        private DateTime CurrDate
        {
            set
            {
                currDate = value;
                dayLable.Text = currDate.ToShortDateString();
            }
        }

        public CalendarDayLarge(ICalendarManager calendarManager)
        {
            InitializeComponent();
            this.calendarManager = calendarManager;
            createGrid();
            CurrDate = DateTime.Now;
            dateTimePicker1.Value = currDate;
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
                cmbColumn.Items.Add(EMPTY_CELL_DEFAULT_VALUE);
                cmbColumn.DefaultCellStyle.NullValue = EMPTY_CELL_DEFAULT_VALUE;
                cmbColumn.Name = "Дорожка №" + (i);
                dayTimeTableDataGrid.Columns.Add(cmbColumn);
            }


        }
        private void UpdateGrid()
        {
            dayTimeTableDataGrid.Rows.Clear();
            List<DayTimeSet> currDayTimeSet = calendarManager.GetNewDayTimeSetList();
            foreach (DayTimeSet dts in currDayTimeSet)
            {
                dayTimeTableDataGrid.Rows.Add(dts.StartTime.ToString() + " - " + dts.EndTime.ToString());
            }

            List<CalendarTimeRow> currCalendarTimeRows = calendarManager.GetNewCalendarTimeRowsByDate(currDate);
            foreach (CalendarTimeRow ctr in currCalendarTimeRows)
            {
                DataGridViewRow currRow = dayTimeTableDataGrid.Rows[calendarManager.DayTimeSetIdToIndex((int)ctr.TimeId)];

                DataGridViewComboBoxCell cbc = currRow.Cells[1] as DataGridViewComboBoxCell;
                cbc.Value = calendarManager.GetComboBoxValueByTrainingGroupId(ctr.Lane1);
                cbc = currRow.Cells[2] as DataGridViewComboBoxCell;
                cbc.Value = calendarManager.GetComboBoxValueByTrainingGroupId(ctr.Lane2);
                cbc = currRow.Cells[3] as DataGridViewComboBoxCell;
                cbc.Value = calendarManager.GetComboBoxValueByTrainingGroupId(ctr.Lane3);
                cbc = currRow.Cells[4] as DataGridViewComboBoxCell;
                cbc.Value = calendarManager.GetComboBoxValueByTrainingGroupId(ctr.Lane4);
                cbc = currRow.Cells[5] as DataGridViewComboBoxCell;
                cbc.Value = calendarManager.GetComboBoxValueByTrainingGroupId(ctr.Lane5);
                cbc = currRow.Cells[6] as DataGridViewComboBoxCell;
                cbc.Value = calendarManager.GetComboBoxValueByTrainingGroupId(ctr.Lane6);

            }
        }
        private void ChangeDay(int dayDelta)
        {
            if (dayDelta == 0)
                return;
            CurrDate = currDate.AddDays(dayDelta);
            dateTimePicker1.Value = currDate;
            UpdateGrid();
        }

        private void dayTimeTableDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell cbc = dayTimeTableDataGrid[e.ColumnIndex, e.RowIndex] as DataGridViewComboBoxCell;
            if (cbc == null) return;
            if (cbc.Value != null)
            {
                int ind = cbc.Items.IndexOf(cbc.Value.ToString());
                cbc.Style.BackColor = calendarManager.GetTrainingGroupColorByComboBoxIndex(ind);
            }
            else
                cbc.Style.BackColor = Color.White;
            calendarManager.SaveCalendarDataGridViewCmbCellChanges(currDate, cbc);
        }

        private void monButton_Click(object sender, EventArgs e)
        {
            ChangeDay(DayOfWeek.Monday - currDate.DayOfWeek);
        }

        private void tueButton_Click(object sender, EventArgs e)
        {
            ChangeDay(DayOfWeek.Tuesday - currDate.DayOfWeek);
        }

        private void wenButton_Click(object sender, EventArgs e)
        {
            ChangeDay(DayOfWeek.Wednesday - currDate.DayOfWeek);
        }

        private void thuButton_Click(object sender, EventArgs e)
        {
            ChangeDay(DayOfWeek.Thursday - currDate.DayOfWeek);
        }

        private void friButton_Click(object sender, EventArgs e)
        {
            ChangeDay(DayOfWeek.Friday - currDate.DayOfWeek);
        }

        private void satButton_Click(object sender, EventArgs e)
        {
            ChangeDay(DayOfWeek.Saturday - currDate.DayOfWeek);
        }

        private void sunButton_Click(object sender, EventArgs e)
        {
            ChangeDay(DayOfWeek.Sunday - currDate.DayOfWeek);
        }

        private void nextWeek_Click(object sender, EventArgs e)
        {
            ChangeDay(7);
        }

        private void previousWeek_Click(object sender, EventArgs e)
        {
            ChangeDay(-7);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CurrDate = dateTimePicker1.Value;
            UpdateGrid();
        }
    }
}
