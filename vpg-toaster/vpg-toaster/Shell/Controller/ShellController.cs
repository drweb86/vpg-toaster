using HDE.Platform.AspectOrientedFramework.WinForms;
using HDE.Platform.Logging;
using System.IO;
using vpg_toaster.Shell.Models;


namespace vpg_toaster.Shell.Controller
{
    public class ShellController : ShellBaseController<ShellModel, MainWindow>
    {
        #region Commands

        //public void Execute()
        //{
        //    new ExecuteShellCmd().Execute(this);
        //}

        #endregion

        protected override ILog CreateOpenLog()
        {
            var logsFolder = Path.Combine(
                Path.GetTempPath(),
                "HDE", "vpg_toaster");

            var log = new SimpleFileLog(logsFolder);
            log.Open();

            return log;
        }
    }
}
