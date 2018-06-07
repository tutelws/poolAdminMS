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
    public partial class CalendarDayMini : UserControl
    {
        int currDayNum = 0;
        public CalendarDayMini(int currDayNum)
        {
            InitializeComponent();
            this.currDayNum = currDayNum;
            SetData();
        }
        private void SetData()
        {
            if (currDayNum < 10)
                dayNumLable.Text = "0" + currDayNum;
            else
                dayNumLable.Text = currDayNum.ToString();
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
