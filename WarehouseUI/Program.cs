using System;
using System.Windows.Forms;
using WarehouseUI.Forms;

namespace WarehouseUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WarehouseUI.Forms.frmMain());

        }
    }
}