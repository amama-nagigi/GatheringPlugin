namespace AmamaNagigi.GatheringPlugin
{
    partial class GatheringPluginOverlayConfigPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.gatheringPluginOverlayConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxClickThru = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aetheryteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInfoWithCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonReference = new System.Windows.Forms.Button();
            this.checkBoxLocked = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDevTool = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gatheringPluginOverlayConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfoWithCheckBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxVisible, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxClickThru, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewItems, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxLocked, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "移動とリサイズを制限する";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "クリックを透過させる";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "オーバーレイを表示する";
            // 
            // checkBoxVisible
            // 
            this.checkBoxVisible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxVisible.AutoSize = true;
            this.checkBoxVisible.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gatheringPluginOverlayConfigBindingSource, "IsVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxVisible.Location = new System.Drawing.Point(134, 3);
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVisible.TabIndex = 3;
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            // 
            // gatheringPluginOverlayConfigBindingSource
            // 
            this.gatheringPluginOverlayConfigBindingSource.DataSource = typeof(AmamaNagigi.GatheringPlugin.GatheringPluginOverlayConfig);
            // 
            // checkBoxClickThru
            // 
            this.checkBoxClickThru.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxClickThru.AutoSize = true;
            this.checkBoxClickThru.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gatheringPluginOverlayConfigBindingSource, "IsClickThru", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxClickThru.Location = new System.Drawing.Point(134, 23);
            this.checkBoxClickThru.Name = "checkBoxClickThru";
            this.checkBoxClickThru.Size = new System.Drawing.Size(15, 14);
            this.checkBoxClickThru.TabIndex = 14;
            this.checkBoxClickThru.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "アイテム詳細";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.AutoGenerateColumns = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnChecked,
            this.nameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn,
            this.aetheryteDataGridViewTextBoxColumn,
            this.timeFromDataGridViewTextBoxColumn,
            this.timeToDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridViewItems.DataSource = this.itemInfoWithCheckBindingSource;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.Location = new System.Drawing.Point(134, 98);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowTemplate.Height = 21;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(712, 201);
            this.dataGridViewItems.TabIndex = 19;
            this.dataGridViewItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewItems_CurrentCellDirtyStateChanged);
            // 
            // ColumnChecked
            // 
            this.ColumnChecked.DataPropertyName = "IsChecked";
            this.ColumnChecked.FalseValue = false;
            this.ColumnChecked.HeaderText = "";
            this.ColumnChecked.Name = "ColumnChecked";
            this.ColumnChecked.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnChecked.TrueValue = true;
            this.ColumnChecked.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Zone";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aetheryteDataGridViewTextBoxColumn
            // 
            this.aetheryteDataGridViewTextBoxColumn.DataPropertyName = "Aetheryte";
            this.aetheryteDataGridViewTextBoxColumn.HeaderText = "Aetheryte";
            this.aetheryteDataGridViewTextBoxColumn.Name = "aetheryteDataGridViewTextBoxColumn";
            this.aetheryteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeFromDataGridViewTextBoxColumn
            // 
            this.timeFromDataGridViewTextBoxColumn.DataPropertyName = "TimeFrom";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.timeFromDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeFromDataGridViewTextBoxColumn.HeaderText = "TimeFrom";
            this.timeFromDataGridViewTextBoxColumn.Name = "timeFromDataGridViewTextBoxColumn";
            this.timeFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeToDataGridViewTextBoxColumn
            // 
            this.timeToDataGridViewTextBoxColumn.DataPropertyName = "TimeTo";
            dataGridViewCellStyle2.Format = "t";
            this.timeToDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.timeToDataGridViewTextBoxColumn.HeaderText = "TimeTo";
            this.timeToDataGridViewTextBoxColumn.Name = "timeToDataGridViewTextBoxColumn";
            this.timeToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemInfoWithCheckBindingSource
            // 
            this.itemInfoWithCheckBindingSource.DataSource = typeof(AmamaNagigi.GatheringPlugin.Entities.ItemInfoWithCheck);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "HTMLファイルパス";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.textBoxUrl);
            this.flowLayoutPanel1.Controls.Add(this.buttonReference);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(134, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(712, 29);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gatheringPluginOverlayConfigBindingSource, "Url", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUrl.Location = new System.Drawing.Point(3, 5);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(379, 19);
            this.textBoxUrl.TabIndex = 0;
            // 
            // buttonReference
            // 
            this.buttonReference.Location = new System.Drawing.Point(388, 3);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(75, 23);
            this.buttonReference.TabIndex = 1;
            this.buttonReference.Text = "参照";
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // checkBoxLocked
            // 
            this.checkBoxLocked.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxLocked.AutoSize = true;
            this.checkBoxLocked.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gatheringPluginOverlayConfigBindingSource, "IsLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLocked.Location = new System.Drawing.Point(134, 43);
            this.checkBoxLocked.Name = "checkBoxLocked";
            this.checkBoxLocked.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLocked.TabIndex = 16;
            this.checkBoxLocked.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDevTool);
            this.panel2.Controls.Add(this.buttonReload);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(134, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 132);
            this.panel2.TabIndex = 24;
            // 
            // buttonDevTool
            // 
            this.buttonDevTool.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDevTool.Location = new System.Drawing.Point(147, 41);
            this.buttonDevTool.Name = "buttonDevTool";
            this.buttonDevTool.Size = new System.Drawing.Size(206, 51);
            this.buttonDevTool.TabIndex = 2;
            this.buttonDevTool.Text = "Devツール表示";
            this.buttonDevTool.UseVisualStyleBackColor = true;
            this.buttonDevTool.Click += new System.EventHandler(this.buttonDevTool_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReload.Location = new System.Drawing.Point(359, 41);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(206, 51);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "オーバーレイをリロード";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "機能";
            // 
            // GatheringPluginOverlayConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GatheringPluginOverlayConfigPanel";
            this.Size = new System.Drawing.Size(849, 440);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gatheringPluginOverlayConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfoWithCheckBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxClickThru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxLocked;
        private System.Windows.Forms.BindingSource gatheringPluginOverlayConfigBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.BindingSource itemInfoWithCheckBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aetheryteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDevTool;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label label7;
    }
}
