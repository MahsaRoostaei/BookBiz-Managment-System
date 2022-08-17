using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz_Managment_System;

namespace BookBiz_Managment_System.validation
{
    public class Validator
    {
    public static bool IsValidID(string input, int num)
    {

        int tempID;
        if ((input.Length != num) || !(Int32.TryParse(input, out tempID)))
        {
            MessageBox.Show("Invalid number, it must be " + num + " digit numbers");
            return false;
        }
        return true;

    }
    public static bool IsValidID(TextBox text, int num)
    {
        int tempID;
        if ((text.TextLength != num) || !((Int32.TryParse(text.Text, out tempID))))
        {
            MessageBox.Show("Invalid number, it must be " + num + " digit numbers");
            text.Clear();
            text.Focus();
            return false;
        }
        return true;
    }
    public static bool IsValidName(TextBox text)
    {
        for (int i = 0; i < text.TextLength; i++)
        {
            if (char.IsDigit(text.Text, i) || (char.IsWhiteSpace(text.Text, i)))
            {
                MessageBox.Show("Invalid Name,Please enter another name.", "INVALID NAME");
                text.Clear();
                text.Focus();
                return false;
            }

        }
        return true;

    }


   }
}
