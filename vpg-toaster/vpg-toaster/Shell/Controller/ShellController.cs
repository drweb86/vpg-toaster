using HDE.Platform.AspectOrientedFramework;
using HDE.Platform.AspectOrientedFramework.WinForms;
using HDE.Platform.Logging;
using System;
using System.IO;
using vpg_toaster.Shell.Commands;
using vpg_toaster.Shell.Models;


namespace vpg_toaster.Shell.Controller
{
    public class ShellController : ShellBaseController<ShellModel>
    {
        private readonly UIFactory _uiFactory = new UIFactory();

        public ShellController()
        {
            _uiFactory.Register<IMainFormView, MainWindow>();
        }

        #region Commands

        public void Execute()
        {
            new ExecuteShellCmd().Execute(this);
        }

        #endregion

        public IMainFormView CreateShell()
        {
            var type = _uiFactory.Get(typeof(IMainFormView));
            var result = Activator.CreateInstance(type);
            return (IMainFormView)result;
        }

        protected override ILog CreateOpenLog()
        {
            var logsFolder = Path.Combine(
                Path.GetTempPath(),
                "HDE", "vpg_toaster");

            var log = new SimpleFileLog(logsFolder);
            log.Open();

            return log;
        }

        public void LoadSettings(IMainFormView view)
        {
            Configure(view);
        }

        internal void TearDown()
        {
            TearDownTools();
        }
    }
}
