﻿using System;
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
            this.BackColor = Color.FromArgb(72, 176, 219);
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.FromArgb(34, 36, 49);
            //this.Click +=ButtonStyleHot_Click;
        }

        //void ButtonStyleHot_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Bạn có muốn thoát không ");
        //}

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
