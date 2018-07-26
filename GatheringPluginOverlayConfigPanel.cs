using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AmamaNagigi.GatheringPlugin.Extensions;
using AmamaNagigi.GatheringPlugin.Entities;
using System.Text;

namespace AmamaNagigi.GatheringPlugin
{
    public partial class GatheringPluginOverlayConfigPanel : UserControl
    {
        private GatheringPluginOverlay overlay;

        public GatheringPluginOverlayConfigPanel(GatheringPluginOverlay overlay)
        {
            InitializeComponent();

            this.overlay = overlay;
            gatheringPluginOverlayConfigBindingSource.DataSource = this.overlay.Config;

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewItems.DataSource = Items.List;
            foreach (var item in dataGridViewItems.Rows)
            {
                var row = (DataGridViewRow)item;
                if (overlay.Config.AddonConfig.CheckedItems.Contains(row.DataBoundItem.GetHashCode()))
                {
                    row.Cells[0].Value = true;
                }
            }
        }

        private void dataGridViewItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            var cell = dataGridViewItems.CurrentCell;

            if (cell.ColumnIndex == 0)
            {
                // セルの値を取得
                var value = (bool)cell.Value;

                // セルの行にバインドされたアイテムのハッシュを取得
                var hash = cell.OwningRow.DataBoundItem.GetHashCode();

                if (value)
                {
                    overlay.Config.AddonConfig.CheckedItems.Add(hash);
                }
                else
                {
                    overlay.Config.AddonConfig.CheckedItems.Remove(hash);
                }
            }
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.textBoxUrl.Text = new Uri(ofd.FileName).ToString();
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            overlay.Overlay.Renderer.Reload();
        }

        private void buttonDevTool_Click(object sender, EventArgs e)
        {
            if (overlay.Overlay != null && overlay.Overlay.Renderer != null && overlay.Overlay.Renderer.Browser != null)
            {
                overlay.Overlay.Renderer.showDevTools();
            }
        }
    }
}
