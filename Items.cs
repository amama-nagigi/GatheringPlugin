using AmamaNagigi.GatheringPlugin.Entities;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.GatheringPlugin
{
    public static class Items
    {
        public const string CSV_FILENAME = "items.csv";

        public static List<ItemInfoWithCheck> List { get; set; }

        static Items()
        {
            var items = new List<ItemInfo>();

            string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (var parser = new TextFieldParser(Path.Combine(location, CSV_FILENAME)))
            {
                while (!parser.EndOfData)
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // フィールドを読込
                    string[] row = parser.ReadFields();
                    var item = new ItemInfo();
                    item.Job = row[0];
                    item.Type = row[1];
                    item.Zone = row[2];
                    item.Aetheryte = row[3];
                    item.Position = row[6];
                    item.Name = row[7];

                    // 時刻変換
                    var timeFrom = ((string)row[4]).Split(':');
                    var timeTo = ((string)row[5]).Split(':');
                    item.TimeFrom = new TimeSpan(int.Parse(timeFrom[0]), int.Parse(timeFrom[1]), 0);
                    item.TimeTo = new TimeSpan(int.Parse(timeTo[0]), int.Parse(timeTo[1]), 0);

                    // To時刻が0:00だった場合は一日後に補正する
                    if (item.TimeTo.Hours == 0) item.TimeTo.Add(new TimeSpan(1, 0, 0, 0));
                    items.Add(item);
                }
            }

            List = items.Select(e => new ItemInfoWithCheck(e)).ToList();
        }

    }
}
