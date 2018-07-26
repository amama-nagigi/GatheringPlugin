using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.GatheringPlugin
{
    public class GatheringPlugin : IOverlayAddon
    {
        public string Name => "Gathering";

        public string Description => "View current gatherable items.";

        public Type OverlayType => typeof(GatheringPluginOverlay);

        public Type OverlayConfigType => typeof(GatheringPluginOverlayConfig);

        public Type OverlayConfigControlType => typeof(GatheringPluginOverlayConfigPanel);

        public IOverlay CreateOverlayInstance(IOverlayConfig config)
        {
            return new GatheringPluginOverlay((GatheringPluginOverlayConfig)config);
        }

        public IOverlayConfig CreateOverlayConfigInstance(string name)
        {
            return new GatheringPluginOverlayConfig(name);
        }

        public System.Windows.Forms.Control CreateOverlayConfigControlInstance(IOverlay overlay)
        {
            return new GatheringPluginOverlayConfigPanel((GatheringPluginOverlay)overlay);
        }

        public void Dispose()
        {

        }

        public static string ResourceDirectory { get; set; }

        /// <summary>
        /// コンストラクタ
        /// (EnmityPluginよりコピーさせていただきました。)
        /// </summary>
        public GatheringPlugin()
        {
            Assembly asm = Assembly.GetCallingAssembly();
            if (asm.Location == null || asm.Location == "")
            {
                // 場所がわからないなら自分の場所にする
                asm = Assembly.GetExecutingAssembly();
            }
            ResourceDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(asm.Location), "resources");
        }
    }
}
