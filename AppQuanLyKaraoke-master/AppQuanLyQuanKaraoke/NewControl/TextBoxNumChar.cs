using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewControl
{
    public class TextBoxNumChar:TextBox
    {
        ErrorProvider error = new ErrorProvider();
        public TextBoxNumChar()
        {
            this.KeyPress += TextBoxNumChar_KeyPress;
            this.Leave += TextBoxNumChar_Leave;
            this.Click += TextBoxNumChar_Click;         
        }

        private void TextBoxNumChar_Click(object sender, EventArgs e)
        {
            this.Clear();

        }

        void TextBoxNumChar_Leave(object sender, EventArgs e)
        {
            if (this.Text.ToString().Trim() == "")
            {
                error.SetError(this, "Không được để trống");
            }
            else
            {
                error.Clear();
            }
        }

        void TextBoxNumChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            

        }
      

    }
}
