using HDE.Platform.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using vpg_toaster.Shell.Controller;

namespace vpg_toaster
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var controller = new ShellController())
            {
                AppDomain.CurrentDomain.UnhandledException += (s, e) => ReportIssue(controller.Log, e.ExceptionObject);
                Application.ThreadException += (s, e) => ReportIssue(controller.Log, e.Exception);

                try
                {
                    controller.Execute();
                }
                catch (Exception unhandledException)
                {
                    controller.Log.Error(unhandledException);
                }
            }
        }

        private static void ReportIssue(ILog log, object unhandledException)
        {
            var typedExc = unhandledException as Exception;
            if (typedExc != null)
            {
                log.Error(typedExc);
                MessageBox.Show(typedExc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
