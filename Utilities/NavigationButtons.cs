using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_Management_System
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color defaultForeColor;
        Color selectedColor;
        Color selectedForeColor;

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor, Color selectedForeColor, Color defaultForeColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
            this.selectedForeColor = selectedForeColor;
            this.defaultForeColor = defaultForeColor;
            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach(Button button in buttons)
            {
                button.BackColor = defaultColor;
                button.ForeColor = defaultForeColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach(Button button in buttons)
            {
                if (button == selectedButton )
                {
                    selectedButton.BackColor = selectedColor;
                    selectedButton.ForeColor = selectedForeColor;
                }
                else
                {
                    button.BackColor = defaultColor;
                    button.ForeColor = defaultForeColor;
                }
            }
        }
    }
}
