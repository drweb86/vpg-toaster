using System.Linq;
using vpg_toaster.Tools.Toaster.Controller;
using vpg_toaster.Tools.Toaster.Services;

namespace vpg_toaster.Tools.Toaster.Commands
{
    class ToastEnabledCmd
    {
        internal void Execute(ToasterController controller, string toast, bool enabled)
        {
            var theToast = controller.Model.Toasters.Single(z => z.Name == toast);
            theToast.EnabledByUser = enabled;

            IToasterDataAccessService service = new ToasterDataAccessService();
            service.Save(controller.Model.Toasters);

            controller.RescheduleTasks();
        }
    }
}
