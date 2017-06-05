using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMsales2
{
    class Log
    {
        public static System.Windows.Forms.ListBox LogListBox;

       public  static void Write(string Message)
        {
            LogListBox.Items.Add(DateTime.Now.ToString() + ": " + Message);
        }
    }
}
