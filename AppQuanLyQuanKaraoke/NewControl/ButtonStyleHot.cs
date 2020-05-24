using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewControl
{
    public class ButtonStyleHot:Button
    {
        public ButtonStyleHot()
        {
            this.MouseHover += ButtonStyleHot_MouseHover;
            this.MouseLeave += ButtonStyleHot_MouseLeave;
            this.BackColor = Color.Azure;
        }

        void ButtonStyleHot_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
        }

        void ButtonStyleHot_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            
        }
    }
}
