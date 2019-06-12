using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HDE.Platform.AspectOrientedFramework;
using HDE.Platform.Logging;
using vpg_toaster.Tools.Toaster.Commands;
using vpg_toaster.Tools.Toaster.Model;

namespace vpg_toaster.Tools.Toaster.Controller
{
    class ToasterController : BaseController<ToasterModel>
    {
        public readonly Dictionary<string, Task> ToastTasks = new Dictionary<string, Task>();

        public ToasterController(ILog log, ToasterTool tool)
        {
            _log = log;
            _tool = tool;
        }

        private ILog _log;
        private ToasterTool _tool;
        protected override ILog CreateOpenLog()
        {
            return _log;
        }

        internal void TearDown()
        {
            new TearDownCmd().Execute(this);
        }

        internal void RescheduleTasks()
        {
            new RescheduleTasksCmd().Execute(this);
        }

        internal void ProcessMessage(string subject, object[] body)
        {
            _tool.ApplyChange(subject, body);
        }

        internal void LoadSettings()
        {
            new LoadSettingsCmd().Execute(this);
        }

        internal void ToastEnabled(string toast, bool enabled)
        {
            new ToastEnabledCmd().Execute(this, toast, enabled);
        }
    }
}
