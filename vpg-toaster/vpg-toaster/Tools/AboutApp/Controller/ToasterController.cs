using System;
using HDE.Platform.AspectOrientedFramework;
using HDE.Platform.Logging;
using vpg_toaster.Tools.AboutApp.Model;

namespace vpg_toaster.Tools.AboutApp.Controller
{
    class AboutAppController : BaseController<AboutAppModel>
    {
        public AboutAppController(ILog log)
        {
            _log = log;
        }

        private ILog _log;
        protected override ILog CreateOpenLog()
        {
            return _log;
        }

        internal void ProcessMessage(string subject, object[] body)
        {
        }
    }
}
