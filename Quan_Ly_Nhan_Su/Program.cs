using Quan_Ly_Nhan_Su.Forms;
using Quan_Ly_Nhan_Su.Reports;

namespace Quan_Ly_Nhan_Su
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new fromThongKeNhanVien());
        }
    }
}