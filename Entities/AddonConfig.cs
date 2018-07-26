using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmamaNagigi.GatheringPlugin.Entities
{
    public class AddonConfig
    {
        public HashSet<int> CheckedItems { get; set; }
    }
}
