using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vpg_toaster.Tools.Toaster.Controller;

namespace vpg_toaster.Tools.Toaster.Commands
{
    class RescheduleTasksCmd
    {
        public void Execute(ToasterController controller)
        {
            controller.TearDown();
            foreach (var toast in controller.Model.Toasters)
            {
                controller.ToastTasks.Add(toast.Name, new Task(() => ExecuteTask()))
            }
        }

        public void ExecuteTask()
    }
}
