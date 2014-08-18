using System;
using System.Windows.Forms;
using System.Threading;
namespace SystemTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.Sleep(1000*60);
            Application.Run(new MainWindow());
        }
    }
}
