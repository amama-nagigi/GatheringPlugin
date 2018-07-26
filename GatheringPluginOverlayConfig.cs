using AmamaNagigi.GatheringPlugin.Entities;
using Microsoft.VisualBasic.FileIO;
using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.GatheringPlugin
{
    public class GatheringPluginOverlayConfig : OverlayConfigBase
    {
        public override Type OverlayType => typeof(GatheringPluginOverlay);

        public AddonConfig AddonConfig { get; set; }

        private GatheringPluginOverlayConfig() : base(null)
        {
            Initialize();
        }

        public GatheringPluginOverlayConfig(string name) : base(name)
        {
            Initialize();
        }

        /// <summary>
        /// 初期値の設定
        /// </summary>
        private void Initialize()
        {
            Url = GetDefaultUrl();

            AddonConfig = new AddonConfig();
            AddonConfig.CheckedItems = new HashSet<int>();

            // とりあえず全チェック
            foreach (var item in Items.List)
            {
                AddonConfig.CheckedItems.Add(item.GetHashCode());
            }
        }

        /// <summary>
        /// HTMLパスの初期値を取得
        /// </summary>
        /// <returns></returns>
        private string GetDefaultUrl()
        {
            return new Uri(System.IO.Path.Combine(GatheringPlugin.ResourceDirectory, "gathering.html")).ToString();
        }
    }
}
