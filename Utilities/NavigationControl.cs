using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System
{
    public class NavigationControl
    {
        List<UserControl> userControlList  = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                // set every userControl's dock style to fill so that it will occupy the space inside the panel
                userControlList[i].Dock = DockStyle.Fill;
                // add all the UserControl inside the panel
                panel.Controls.Add(userControlList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < userControlList.Count())
            {
                // Create a new instance of the user control
                var userControl = Activator.CreateInstance(userControlList[index].GetType());

                // Replace the old user control with the new one
                var oldUserControl = userControlList[index];
                panel.Controls.Remove(oldUserControl);
                userControlList[index] = userControl as UserControl;
                panel.Controls.Add(userControlList[index]);

                // Set the dock style to fill so that it will occupy the space inside the panel
                userControlList[index].Dock = DockStyle.Fill;
                // Bring the user control to front
                userControlList[index].BringToFront();
            }
        }
    }
}
