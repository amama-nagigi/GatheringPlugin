using Advanced_Combat_Tracker;
using AmamaNagigi.GatheringPlugin.Entities;
using AmamaNagigi.GatheringPlugin.Extensions;
using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainbowMage.HtmlRenderer;

namespace AmamaNagigi.GatheringPlugin
{
    public class GatheringPluginOverlay : OverlayBase<GatheringPluginOverlayConfig>
    {
        private int lastHour = -1;
        private bool? lastVisible = null;

        private DateTime now;
        private bool visible = false;

        public GatheringPluginOverlay(GatheringPluginOverlayConfig config) : base(config, config.Name)
        {
            Overlay.Renderer.BrowserLoad += OnBrowserLoad;
            Navigate(config.Url);
        }

        private void OnBrowserLoad(object sender, BrowserLoadEventArgs e)
        {
            lastHour = -1;
            lastVisible = null;
        }

        private void ExecuteScript(string script)
        {
            if (Overlay != null && Overlay.Renderer != null && Overlay.Renderer.Browser != null)
            {
                // スクリプト実行
                Overlay.Renderer.Browser.GetMainFrame().ExecuteJavaScript(script, null, 0);
            }
        }

        protected override void Update()
        {
            if (CheckIsActReady())
            {
                // ギャザラーの場合のみ表示
                visible = FFXIVPluginHelper.IsGatherer();

                // 現在時刻を取得
                now = DateTime.Now.ToEorzeaTime();

                if (now.Hour != lastHour || visible != lastVisible)
                {
                    lastHour = now.Hour;
                    lastVisible = visible;
                    var updateScript = CreateEventDispatcherScript();
                    ExecuteScript(updateScript);
                }
            }
        }

        private string CreateEventDispatcherScript()
        {
            return "var ActXiv = " + this.CreateJsonData() + ";\n" +
                   "document.dispatchEvent(new CustomEvent('onOverlayDataUpdate', { detail: ActXiv }));";
        }

        internal string CreateJsonData()
        {
            // 現在時刻と2時間後のTimeSpanを作成
            var currentTime = new TimeSpan(now.Hour, now.Minute, 0);
            var soonTime = new TimeSpan((now.Hour + 2) % 24, now.Minute, 0);

            // 現在時刻のItemを作成
            var currentItems = this.GetTargetItem(currentTime);
            var currentJson = CreateJsonDataByItems(currentItems);

            // 現在時刻のItemのハッシュリスト作成
            var currentItemHashes = currentItems.Select(e => e.GetHashCode()).ToList();

            // 2時間後のItemを作成
            var soonItems = this.GetTargetItem(soonTime).Where(e => !currentItemHashes.Contains(e.GetHashCode())).ToList();
            var soonJson = CreateJsonDataByItems(soonItems);

            // Json作成
            var json = $@"{{""visible"":{(visible ? "true" : "false")},""items"":{{""current"":{currentJson},""soon"":{soonJson}}}}}";
            return json;
        }

        internal string CreateJsonDataByItems(List<ItemInfo> items)
        {
            // Itemを未知、伝説、刻限に仕分ける
            var unspoiled = items.Where(e => e.Type == "未知").Select(e => e.ToJson());
            var folklore = items.Where(e => e.Type == "伝説").Select(e => e.ToJson());
            var ephemeral = items.Where(e => e.Type == "刻限").Select(e => e.ToJson());

            // Json作成
            var json = $@"{{""count"":{items.Count},""unspoiled"":[{string.Join(",", unspoiled)}],""folklore"":[{string.Join(",", folklore)}],""ephemeral"":[{string.Join(",", ephemeral)}]}}";
            return json;
        }

        private List<ItemInfo> GetTargetItem(TimeSpan time)
        {
            // 現在時刻で表示すべき内容を取得
            var items = Items.List;
            var targetItems = items.Where(e => Config.AddonConfig.CheckedItems.Contains(e.GetHashCode())).Where(item => item.TimeFrom <= time && time < item.TimeTo).Select(e => (ItemInfo)e).ToList();

            return targetItems;
        }

        private static bool CheckIsActReady()
        {
            if (ActGlobals.oFormActMain != null &&
                ActGlobals.oFormActMain.ActiveZone != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
