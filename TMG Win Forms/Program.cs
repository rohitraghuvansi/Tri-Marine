using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StructureMap;

namespace TMG.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container ioc = new Container();
            BootStrapper bootStrapper = new BootStrapper(ioc);
            ApplicationContext appcontext = bootStrapper.GetAppContext();
            Application.Run(appcontext);
        }
    }
}
