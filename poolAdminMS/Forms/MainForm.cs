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
        private bool _isClickedCalendar;
        private bool _isClickedClients;
        private bool _isClickedTrainingGroups;
        
        public MainForm()
        {
            InitializeComponent();
            poolAdminSystem = new PoolAdminSystem();
            
        }

        
        private void calendarButton_Click(object sender, EventArgs e)
        {
            if (_isClickedCalendar)
                return;
            slidePanel.Location = calendarButton.Location;
            if (userControlPanel.Controls.Count > 0)
                userControlPanel.Controls.RemoveAt(0);
            _isClickedCalendar = true;
            _isClickedClients = false;
            _isClickedTrainingGroups = false;
            userControlPanel.Controls.Add(new CalendarDayLarge(poolAdminSystem));
            
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            if (_isClickedClients)
                return;
            slidePanel.Location = clientsButton.Location;
            if (userControlPanel.Controls.Count > 0)
                userControlPanel.Controls.RemoveAt(0);
            _isClickedCalendar = false;
            _isClickedClients = true;
            _isClickedTrainingGroups = false;
            userControlPanel.Controls.Add(new ClientsControl(poolAdminSystem));
        }

        private void trainingGroupsMenuButton_Click(object sender, EventArgs e)
        {
            if (_isClickedTrainingGroups)
                return;
            slidePanel.Location = trainingGroupsMenuButton.Location;
            if (userControlPanel.Controls.Count > 0)
                userControlPanel.Controls.RemoveAt(0);
            _isClickedCalendar = false;
            _isClickedClients = false;
            _isClickedTrainingGroups = true;
            userControlPanel.Controls.Add(new TrainingGroupsControl(poolAdminSystem));
        }
    }
}
