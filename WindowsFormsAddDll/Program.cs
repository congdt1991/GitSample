using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibCaculator;

namespace WindowsFormsAddDll
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
            Application.Run(new Form1());

            var ac = new AddClass();
            long ll = ac.AddLong(1, 2);
            MutiplyClass MC = new MutiplyClass();
            long l = MC.MultiplyLong(2, 3);
            int a = 2;
        }
    }
}
