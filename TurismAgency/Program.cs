using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", @"Data Source=C:\\Users\\Denis\\RiderProjects\\MPP\\MPP\\turism2.db;Version=3;New=True;Compress=True;");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(props));
        }
    }
}