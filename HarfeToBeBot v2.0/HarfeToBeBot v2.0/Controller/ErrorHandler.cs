using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HarfeToBeBot_v2._0.Controller
{
    static class ErrorHandler
    {
        public static TextBox TextBoxErrors;

        public static void SetError(string source, string error)
        {
            TextBoxErrors.Invoke((MethodInvoker)delegate
            {
                TextBoxErrors.AppendText($"{source}:\n\t{error}\n\t{DateTime.Now}\n");
            });
            
        }
    }
}
