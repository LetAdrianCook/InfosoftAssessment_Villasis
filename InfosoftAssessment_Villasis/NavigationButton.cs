using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfosoftAssessment_Villasis
{
    public class NavigationButtons
    {
        private List<Button> buttons; 
        private Color defaultColor; 
        private Color selectedColor; 

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
        }

        public void Highlight(Button selectedButton)
        {
            foreach (Button button in buttons)
            {
                if (button == selectedButton)
                {
                    button.BackColor = selectedColor; 
                    button.ForeColor = Color.Black; 
                }
                else
                {
                    button.BackColor = defaultColor; 
                    button.ForeColor = Color.White; 
                }
            }
        }
    }
}
