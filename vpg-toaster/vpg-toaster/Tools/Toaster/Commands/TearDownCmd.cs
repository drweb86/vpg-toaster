using vpg_toaster.Tools.Toaster.Controller;

namespace vpg_toaster.Tools.Toaster.Commands
{
    class TearDownCmd
    {
        internal void Execute(ToasterController controller)
        {
            controller.ToastTasksTickets.Clear();
        }
    }
}
