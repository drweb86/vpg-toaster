using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vpg_toaster.Tools.Toaster.Controller;
using vpg_toaster.Tools.Toaster.Model;

namespace vpg_toaster.Tools.Toaster.Commands
{
    class RescheduleTasksCmd
    {
        public void Execute(ToasterController controller)
        {
            controller.TearDown();
            foreach (var toast in controller.Model.Toasters)
            {
                var taskTicket = Guid.NewGuid();
                controller.ToastTasksTickets.Add(taskTicket);
                var task = new Task(async () => await ExecuteTask(controller, toast, taskTicket));
                task.Start();
            }
        }

        public async Task ExecuteTask(ToasterController controller, Toast toast, Guid asyncTicket)
        {
            bool enabled = (toast.EnabledByUser ?? toast.EnabledByDefault) == true;
            
            while (enabled && toast.IntervalBetweenNotifications.HasValue)
            {
                await Task.Delay(new TimeSpan(0, toast.IntervalBetweenNotifications.Value, 0));
                if (!controller.ToastTasksTickets.Contains(asyncTicket))
                    return;
                ShowNotification(controller, toast);
            }
        }

        private void ShowNotification(ToasterController controller, Toast toast)
        {
            controller.ProcessMessage(ToasterAspects.ShowNotification, toast.Name);
        }
    }
}
