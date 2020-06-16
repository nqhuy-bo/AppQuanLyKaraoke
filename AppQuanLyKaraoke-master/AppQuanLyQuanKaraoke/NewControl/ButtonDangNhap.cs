using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NewControl
{
    public class ButtonDangNhap:Button
    {
        public ButtonDangNhap()
        {
            this.MouseHover += ButtonStyleHot_MouseHover;
            this.MouseLeave += ButtonStyleHot_MouseLeave;

            this.BackColor = Color.FromArgb(72, 176, 219);
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.FromArgb(34, 36, 49);
        }
        void ButtonStyleHot_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(72, 176, 219);
        }

        void ButtonStyleHot_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(140, 212, 43);

        }
    }
}
