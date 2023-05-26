using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QUAN_LY_CONG_TY_BAN_MAY_TINH.Validate
{
    class Validates
    {
        public static int sd = 0;
        public static bool checkEmpty(string info)
        {
            if (!info.ToString().Trim().Equals(""))
            {
                return true;
            }

            return false;
        }

        public static bool checkLength(string info, int length)
        {
            if (checkEmpty(info) && info.Length == length)
                return true;
            return false;
        }

        public static void HideMessage(Label label)
        {
            label.Hide();
        }

        public static bool checkMessage(string info ,Label label, string message)
        {
            if (checkEmpty(info))
                HideMessage(label);
            else
            {
                label.Text = message;
                label.Show();
                return false;
            }
            return true;
        }

        public static bool checkMessage(string info, Label label, string message , int length)
        {
            if (checkLength(info , length))
                HideMessage(label);
            else
            {
                label.Text = message;
                label.Show();
                return false;
            }
            return true;
        }
        
    }
}
