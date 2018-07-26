using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.GatheringPlugin.Entities
{
    public class ItemInfo
    {
        public string Job { get; set; }
        public string Type { get; set; }
        public string Zone { get; set; }
        public string Aetheryte { get; set; }
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return (Job + TimeFrom + Zone + Aetheryte + TimeFrom.ToString(@"hh\:mm") + TimeTo.ToString(@"hh\:mm") + Position + Name).GetHashCode();
        }

        public string ToJson()
        {
            return $@"{{""job"":""{Job}"",""zone"":""{Zone}"",""aetheryte"":""{Aetheryte}"",""from"":""{TimeFrom.ToString(@"hh\:mm")}"",""to"":""{TimeTo.ToString(@"hh\:mm")}"",""position"":""{Position}"",""name"":""{Name}""}}";
        }
    }
}
