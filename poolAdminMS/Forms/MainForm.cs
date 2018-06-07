using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poolAdminMS.SystemClasses;
using poolAdminMS.UserControls;

namespace poolAdminMS
{
    public partial class MainForm : Form
    {
        PoolAdminSystem poolAdminSystem;
        public MainForm()
        {
            InitializeComponent();
            using (poolDBEntities context = new poolDBEntities())
            {
                var trans = from C in context.Clients
                            select new
                            {
                                Surname = C.Surname,
                                Name = C.Name,
                                Phone = C.Phone

                            };
                //clientsDataGrid.DataSource = trans.ToList();
                
            }
            poolAdminSystem = new PoolAdminSystem();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            slidePanel.Location = calendarButton.Location;
            if (userControlPanel.Controls.Count > 0)
                userControlPanel.Controls.RemoveAt(0);
            //userControlPanel.Controls.Add(new calendarMonthControl());
            userControlPanel.Controls.Add(new CalendarDayLarge(poolAdminSystem));
            
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            slidePanel.Location = clientsButton.Location;
            if (userControlPanel.Controls.Count > 0)
                userControlPanel.Controls.RemoveAt(0);
            userControlPanel.Controls.Add(new ClientsControl(poolAdminSystem));
        }

        private void trainingGroupsMenuButton_Click(object sender, EventArgs e)
        {
            slidePanel.Location = trainingGroupsMenuButton.Location;
            if (userControlPanel.Controls.Count > 0)
                userControlPanel.Controls.RemoveAt(0);
            userControlPanel.Controls.Add(new TrainingGroupsControl(poolAdminSystem));
        }
    }
}
