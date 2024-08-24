using System;
using System.Windows.Forms;

namespace NUnit_46_LeVanTan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NUnit_46_Chuoi());
        }
    }
}
