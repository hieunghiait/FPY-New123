using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPY.Utils
{
    public static  class validationNumber
    {
       
            public static void isValidNumber(string value)
                {
            if (string.IsNullOrEmpty(value))
            {
                        MessageBox.Show("Please enter a valid number");
                    }
                    else
            {
                        int number;
                        if (!int.TryParse(value, out number))
                {
                            MessageBox.Show("Please enter a valid number");
                        }
                    }
                }
    }
}
