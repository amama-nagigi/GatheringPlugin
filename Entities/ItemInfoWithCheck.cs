using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.GatheringPlugin.Entities
{
    public class ItemInfoWithCheck : ItemInfo
    {
        public bool IsChecked { get; set; }

        public ItemInfoWithCheck(ItemInfo info) : base()
        {
            Aetheryte = info.Aetheryte;
            Job = info.Job;
            Name = info.Name;
            Position = info.Position;
            TimeFrom = info.TimeFrom;
            TimeTo = info.TimeTo;
            Type = info.Type;
            Zone = info.Zone;
            IsChecked = false;
        }
    }
}
