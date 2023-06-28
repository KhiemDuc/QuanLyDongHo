using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp.MyClass
{
    public class MyValidateAllControl
    {
        public static void SetTextBoxEventTextChanged(Control.ControlCollection controls, EventHandler validation)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.TextChanged += validation;
                }
                else if (control.Controls.Count > 0)
                {
                    SetTextBoxEventTextChanged(control.Controls, validation);
                }
            }

        }
    }
}
