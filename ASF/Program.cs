using ASF.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            fMainForm = new MainForm();
            Application.Run(fMainForm);
        }
        private static MainForm fMainForm { get; set; }
        public static bool OrdersAreChanged
        {
            get
            {
                return _OrdersAreChanged;
            }
            set
            {
                _OrdersAreChanged = value;
                //fMainForm.OrdersRepaint();
            }
        }
        private static bool _OrdersAreChanged = true;
        public static bool CustomersAreChanged
        {
            get
            {
                return _CustomersAreChanged;
            }
            set
            {
                _CustomersAreChanged = value;
                //fMainForm.CustomersRepaint();
            }
        }
        private static bool _CustomersAreChanged = true;
        public static bool EmployeesAreChanged
        {
            get
            {
                return _EmployeesAreChanged;
            }
         
            set
            {
                _EmployeesAreChanged = value;
                //fMainForm.EmployeesRepaint();
            }
        }
        private static bool _EmployeesAreChanged = true;
        public static void RefreshEmployee(idocEmployee Employee)
        {
            fMainForm.RefreshEmployee(Employee);
        }
        public static idocEmployee UserContext { get; set; }
    }
}
