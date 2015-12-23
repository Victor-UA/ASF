using ASF.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASF
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        static public bool OrdersAreChanged { get; set; } = true;
        static public bool CustomersAreChanged { get; set; } = true;
        static public bool EmployeesAreChanged { get; set; } = true;
        static public idocEmployee UserContext { get; set; }
    }
}
