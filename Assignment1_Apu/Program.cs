using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Apu
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
            // In order to get exception errors in english, hate Swedish exception messages.
#if DEBUG
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
#endif
            Application.Run(new FormMain());
        }
    }
}
