using HDE.Platform.AspectOrientedFramework;
using HDE.Platform.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vpg_toaster.Model;

namespace vpg_toaster.Controller
{
    class AppController: BaseController<AppModel>
    {
        protected override ILog CreateOpenLog()
        {
            var logsFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "HDE.vpg_toaster", "1.0", "logs");
            var log = new SimpleFileLog(logsFolder);
            log.Open();
            return log;
        }

        internal void LoadNotifications()
        {
            throw new NotImplementedException();
        }
    }
}
