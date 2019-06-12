using System;
using HDE.Platform.AspectOrientedFramework;
using HDE.Platform.Logging;
using vpg_toaster.Tools.Toaster.Model;

namespace vpg_toaster.Tools.Toaster.Controller
{
    class ToasterController : BaseController<ToasterModel>
    {
        public ToasterController(ILog log)
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
