using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using vpg_toaster.Tools.Toaster.Model;

namespace vpg_toaster.Tools.Toaster.Services
{
    interface IToasterDataAccessService
    {
        IEnumerable<Toast> Load();
        void Save(IEnumerable<Toast> toasts);
    }

    class ToasterDataAccessService : IToasterDataAccessService
    {
        private string GetFileName()
        {
            return Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                "Data",
                "Notifications.json");
                
        }

        public IEnumerable<Toast> Load()
        {
            var data = File.ReadAllText(GetFileName());
            return JsonConvert.DeserializeObject<IEnumerable<Toast>>(data);
        }

        public void Save(IEnumerable<Toast> toasts)
        {
            var data = JsonConvert.SerializeObject(toasts);
            var file = GetFileName();
            File.Delete(file);
            File.WriteAllText(file, data);
        }
    }
}
