using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewControl
{
    public class TextBoxPassword:TextBoxNumChar
    {
        public TextBoxPassword()
        {
            this.UseSystemPasswordChar = true;

        }
    }
}
