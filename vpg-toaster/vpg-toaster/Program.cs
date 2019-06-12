using System;
using vpg_toaster.Shell.Controller;

namespace vpg_toaster
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var controller = new ShellController())
            {
                try
                {
                    controller.Run();
                }
                catch (Exception unhandledException)
                {
                    controller.Log.Error(unhandledException);
                }
            }
        }
    }
}
