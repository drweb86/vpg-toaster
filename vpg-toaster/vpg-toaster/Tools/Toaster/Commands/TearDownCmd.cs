using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vpg_toaster.Tools.Toaster.Controller;

namespace vpg_toaster.Tools.Toaster.Commands
{
    class TearDownCmd
    {
        internal void Execute(ToasterController controller)
        {
            foreach (var item in controller.ToastTasks)
            {
                item.Value.Dispose();
            }
            controller.ToastTasks.Clear();
        }
    }
}
