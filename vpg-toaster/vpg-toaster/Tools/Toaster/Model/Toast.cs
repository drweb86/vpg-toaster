using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpg_toaster.Tools.Toaster.Model
{
    public class Toast
    {
        public string Name { get; set; }
        public int? IntervalBetweenNotifications { get; set; }
        public bool? EnabledByUser { get; set; }
        public bool? EnabledByDefault { get; set; }
    }
}
