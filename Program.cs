using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; 

namespace CRMsales2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DLL.MySqlContext, Migrations.Configuration>());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            Log.LogListBox = mainForm.listBox1;
            Application.Run(mainForm);
           
        }
    }
}
