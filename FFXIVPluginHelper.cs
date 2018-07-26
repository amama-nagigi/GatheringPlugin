using Advanced_Combat_Tracker;
using FFXIV_ACT_Plugin.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.GatheringPlugin
{
    public static class FFXIVPluginHelper
    {
        public static bool IsGatherer()
        {
            try
            {
                IActPluginV1 plugin = null;

                foreach (var item in ActGlobals.oFormActMain.ActPlugins)
                {
                    if (item.pluginFile.Name.ToUpper() == "FFXIV_ACT_Plugin.dll".ToUpper() &&
                    item.lblPluginStatus.Text.ToUpper() == "FFXIV Plugin Started.".ToUpper())
                    {
                        plugin = item.pluginObj;
                        break;
                    }
                }

                FieldInfo fi;

                fi = plugin.GetType().GetField("_Memory", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
                var pluginMemory = fi.GetValue(plugin);

                fi = pluginMemory.GetType().GetField("_config", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
                var pluginConfig = fi.GetValue(pluginMemory);

                fi = pluginConfig.GetType().GetField("ScanCombatants", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
                dynamic pluginScancombat = fi.GetValue(pluginConfig);

                dynamic playerData = pluginScancombat.GetPlayerData();

                var gatherId = new List<int>() { 16, 17}; // 採掘 or 園芸
                return gatherId.Contains(playerData.JobID);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
