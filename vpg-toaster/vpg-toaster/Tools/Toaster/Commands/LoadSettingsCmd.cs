using vpg_toaster.Tools.Toaster.Controller;
using vpg_toaster.Tools.Toaster.Services;

namespace vpg_toaster.Tools.Toaster.Commands
{
    class LoadSettingsCmd
    {
        internal void Execute(ToasterController controller)
        {
            IToasterDataAccessService service = new ToasterDataAccessService();
            controller.Model.Toasters = service.Load();
            controller.ProcessMessage(ToasterAspects.Loaded, null);

            controller.RescheduleTasks();
        }
    }
}
