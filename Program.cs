using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Exercise_1A
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            #region Question 1

            var Student1 = new Student();
            var Student2 = new Student(1, "nafis");
            var Student3 = new Student(3, "nafis","283 pharmacy avenue");

            Console.WriteLine(Student1);
            Console.WriteLine(Student2);
            Console.WriteLine(Student3);


            #endregion
        }
    }
}