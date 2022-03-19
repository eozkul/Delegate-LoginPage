using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.ADONET.LoginPage.Extensions
{
    public static class FormExtension
    {
        public static DialogResult Switch(this Form from, Form to)
        {
            from.Hide();
            return to.ShowDialog();
        }
    }
}
