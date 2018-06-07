using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poolAdminMS.UserControls
{
    public partial class calendarMonthControl : UserControl
    {
        public calendarMonthControl()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
                tableLayoutCalendar.Controls.Add(new CalendarDayMini(i + 1));
        }
        private void SendDate(int dayNum)
        {

        }
    }
}
