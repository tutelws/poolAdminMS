using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace poolAdminMS.Interfaces
{
    public interface ICalendarManager
    {
        List<CalendarTimeRow> GetNewCalendarTimeRowsByDate(DateTime currDate);
        List<TrainingGroup> GetNewTrainingGroupList();
        List<DayTimeSet> GetNewDayTimeSetList();

        int DayTimeSetIndexToId(int index);
        int DayTimeSetIdToIndex(int id);
        string GetComboBoxValueByTrainingGroupId(int? id);
        TrainingGroup GetTrainingGroupByComboBoxIndex(int ind);
        Color GetTrainingGroupColorByComboBoxIndex(int ind);
        void SetTimeRowsOnDay(DateTime date);

        
        void SaveCalendarTimeRows(DataGridView dgv, DateTime currDate);
        void SaveCalendarDataGridViewCmbCellChanges(DateTime currDate, DataGridViewComboBoxCell cmbCell);
    }
}
