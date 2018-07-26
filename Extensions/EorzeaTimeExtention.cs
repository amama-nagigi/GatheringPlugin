using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.GatheringPlugin.Extensions
{
    public static class EorzeaTimeExtention
    {
        private const double EORZEA_MULTIPLIER = 3600D / 175D;

        public static DateTime ToEorzeaTime(this DateTime date)
        {
            long epochTicks = date.ToUniversalTime().Ticks - (new DateTime(1970, 1, 1, 0, 0, 0).Ticks);

            long eorzeaTicks = (long)Math.Round(epochTicks * EORZEA_MULTIPLIER);

            return new DateTime(eorzeaTicks);
        }
    }
}
