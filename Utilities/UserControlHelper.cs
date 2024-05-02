using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System
{
    public class UserControlHelper
    {
        public static Panel FindContainingPanel(Control control)
        {
            Control parent = control.Parent;

            while (parent != null)
            {
                if (parent is Panel && parent.Controls.Contains(control))
                {
                    return (Panel)parent;
                }

                parent = parent.Parent;
            }

            return null;
        }
    }
}
