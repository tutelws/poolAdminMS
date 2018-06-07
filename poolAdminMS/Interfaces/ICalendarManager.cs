using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace poolAdminMS.Interfaces
{
    public interface ICalendarManager
    {
        List<TrainingGroup> GetNewTrainingGroupList();
        List<DayTimeSet> GetNewDayTimeSetList();

        TrainingGroup GetTrainingGroupByComboBoxIndex(int ind);
        Color GetTrainingGroupColorByComboBoxIndex(int ind);
        void SetTimeRowsOnDay(DateTime date);
    }
}
