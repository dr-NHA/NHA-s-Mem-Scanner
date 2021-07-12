
namespace NHA_Memory_Tools.NHA_MainForm
{
    partial class NHA_MemoryMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHA_MemoryMain));
            this.TabHandler = new System.Windows.Forms.TabControl();
            this.ScannedAddressHolder = new System.Windows.Forms.Panel();
            this.AddressListX = new System.Windows.Forms.ListBox();
            this.AddressList = new System.Windows.Forms.Panel();
            this.ScanOptionsPanel = new System.Windows.Forms.Panel();
            this.ScanCompletion = new System.Windows.Forms.Label();
            this.CheckConnection = new System.Windows.Forms.Button();
            this.NHA_ProcessInfo = new System.Windows.Forms.TextBox();
            this.OpenProcessPanel = new System.Windows.Forms.Panel();
            this.RefreshAddressListX = new System.Windows.Forms.Button();
            this.ChangedUnchangedCollection = new System.Windows.Forms.Panel();
            this.ChangedValue = new System.Windows.Forms.Button();
            this.UnchangedValue = new System.Windows.Forms.Button();
            this.ScanMainPanel = new System.Windows.Forms.Panel();
            this.ScanValuePanel = new System.Windows.Forms.Panel();
            this.ScanValueTitle = new System.Windows.Forms.Label();
            this.ScanValue = new System.Windows.Forms.TextBox();
            this.ScanTypePanel = new System.Windows.Forms.Panel();
            this.ScanTypeTitle = new System.Windows.Forms.Label();
            this.ScanValueType = new System.Windows.Forms.ComboBox();
            this.ScanOptionsMain = new System.Windows.Forms.Panel();
            this.NextScan = new System.Windows.Forms.Button();
            this.ScanStart = new System.Windows.Forms.Button();
            this.OpenProcessTB_Centerer = new System.Windows.Forms.Panel();
            this.ScanAsHex = new System.Windows.Forms.TextBox();
            this.ScanSettingsRanging = new System.Windows.Forms.Panel();
            this.ScanRegionSizing = new System.Windows.Forms.Panel();
            this.RegionSizeMax = new System.Windows.Forms.NumericUpDown();
            this.RegionSizeMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ScanMemoryRange = new System.Windows.Forms.Panel();
            this.ScanRegionSizeHigh = new System.Windows.Forms.TextBox();
            this.ScanRegionSizeLow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedAddressButton = new System.Windows.Forms.Panel();
            this.PeekInfo = new System.Windows.Forms.Button();
            this.AddToAddressList = new System.Windows.Forms.Button();
            this.SelectedInfoPanel = new System.Windows.Forms.Panel();
            this.SelectedInfoTitle = new System.Windows.Forms.Panel();
            this.SelectedInfo = new System.Windows.Forms.Label();
            this.SelectedAddressPanel = new System.Windows.Forms.Panel();
            this.SelectedInfoAddress = new System.Windows.Forms.TextBox();
            this.SelectedAddressTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SelectedInfoBase = new System.Windows.Forms.TextBox();
            this.SelectedBaseTitle = new System.Windows.Forms.Label();
            this.SelectedRegionSizePanel = new System.Windows.Forms.Panel();
            this.SelectedRegionSize = new System.Windows.Forms.TextBox();
            this.SelectedRegionSizeTitle = new System.Windows.Forms.Label();
            this.ScannedAddressHolder.SuspendLayout();
            this.ScanOptionsPanel.SuspendLayout();
            this.OpenProcessPanel.SuspendLayout();
            this.ChangedUnchangedCollection.SuspendLayout();
            this.ScanMainPanel.SuspendLayout();
            this.ScanValuePanel.SuspendLayout();
            this.ScanTypePanel.SuspendLayout();
            this.ScanOptionsMain.SuspendLayout();
            this.ScanSettingsRanging.SuspendLayout();
            this.ScanRegionSizing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegionSizeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionSizeMin)).BeginInit();
            this.ScanMemoryRange.SuspendLayout();
            this.SelectedAddressButton.SuspendLayout();
            this.SelectedInfoPanel.SuspendLayout();
            this.SelectedInfoTitle.SuspendLayout();
            this.SelectedAddressPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SelectedRegionSizePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabHandler
            // 
            this.TabHandler.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabHandler.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabHandler.HotTrack = true;
            this.TabHandler.Location = new System.Drawing.Point(0, 0);
            this.TabHandler.Name = "TabHandler";
            this.TabHandler.SelectedIndex = 0;
            this.TabHandler.Size = new System.Drawing.Size(531, 18);
            this.TabHandler.TabIndex = 0;
            this.TabHandler.SelectedIndexChanged += new System.EventHandler(this.TabHandler_SelectedIndexChanged);
            // 
            // ScannedAddressHolder
            // 
            this.ScannedAddressHolder.AutoScroll = true;
            this.ScannedAddressHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScannedAddressHolder.Controls.Add(this.AddressListX);
            this.ScannedAddressHolder.Controls.Add(this.RefreshAddressListX);
            this.ScannedAddressHolder.Controls.Add(this.SelectedAddressButton);
            this.ScannedAddressHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScannedAddressHolder.Location = new System.Drawing.Point(0, 45);
            this.ScannedAddressHolder.Name = "ScannedAddressHolder";
            this.ScannedAddressHolder.Size = new System.Drawing.Size(265, 336);
            this.ScannedAddressHolder.TabIndex = 1;
            // 
            // AddressListX
            // 
            this.AddressListX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressListX.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressListX.FormattingEnabled = true;
            this.AddressListX.HorizontalScrollbar = true;
            this.AddressListX.ItemHeight = 11;
            this.AddressListX.Items.AddRange(new object[] {
            "NHA",
            "IS",
            "A",
            "GOD",
            "KING!",
            "LESS",
            "THAN",
            "24H",
            "FOR ",
            "THIS!"});
            this.AddressListX.Location = new System.Drawing.Point(0, 23);
            this.AddressListX.Name = "AddressListX";
            this.AddressListX.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.AddressListX.Size = new System.Drawing.Size(263, 263);
            this.AddressListX.TabIndex = 6;
            // 
            // AddressList
            // 
            this.AddressList.AutoSize = true;
            this.AddressList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddressList.Location = new System.Drawing.Point(0, 381);
            this.AddressList.Name = "AddressList";
            this.AddressList.Size = new System.Drawing.Size(531, 0);
            this.AddressList.TabIndex = 2;
            this.AddressList.SizeChanged += new System.EventHandler(this.AddressList_SizeChanged);
            // 
            // ScanOptionsPanel
            // 
            this.ScanOptionsPanel.Controls.Add(this.SelectedInfoPanel);
            this.ScanOptionsPanel.Controls.Add(this.ScanOptionsMain);
            this.ScanOptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScanOptionsPanel.Location = new System.Drawing.Point(265, 58);
            this.ScanOptionsPanel.Name = "ScanOptionsPanel";
            this.ScanOptionsPanel.Size = new System.Drawing.Size(266, 323);
            this.ScanOptionsPanel.TabIndex = 3;
            // 
            // ScanCompletion
            // 
            this.ScanCompletion.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanCompletion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanCompletion.Location = new System.Drawing.Point(265, 45);
            this.ScanCompletion.Name = "ScanCompletion";
            this.ScanCompletion.Size = new System.Drawing.Size(266, 13);
            this.ScanCompletion.TabIndex = 4;
            this.ScanCompletion.Text = "Scan Not Started!";
            this.ScanCompletion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckConnection
            // 
            this.CheckConnection.Dock = System.Windows.Forms.DockStyle.Left;
            this.CheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckConnection.Location = new System.Drawing.Point(0, 0);
            this.CheckConnection.Name = "CheckConnection";
            this.CheckConnection.Size = new System.Drawing.Size(141, 27);
            this.CheckConnection.TabIndex = 0;
            this.CheckConnection.Text = "Open Process";
            this.CheckConnection.UseVisualStyleBackColor = true;
            this.CheckConnection.Click += new System.EventHandler(this.CheckConnection_Click);
            // 
            // NHA_ProcessInfo
            // 
            this.NHA_ProcessInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NHA_ProcessInfo.Location = new System.Drawing.Point(141, 4);
            this.NHA_ProcessInfo.Name = "NHA_ProcessInfo";
            this.NHA_ProcessInfo.Size = new System.Drawing.Size(390, 20);
            this.NHA_ProcessInfo.TabIndex = 1;
            // 
            // OpenProcessPanel
            // 
            this.OpenProcessPanel.Controls.Add(this.NHA_ProcessInfo);
            this.OpenProcessPanel.Controls.Add(this.OpenProcessTB_Centerer);
            this.OpenProcessPanel.Controls.Add(this.CheckConnection);
            this.OpenProcessPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenProcessPanel.Location = new System.Drawing.Point(0, 18);
            this.OpenProcessPanel.Name = "OpenProcessPanel";
            this.OpenProcessPanel.Size = new System.Drawing.Size(531, 27);
            this.OpenProcessPanel.TabIndex = 5;
            // 
            // RefreshAddressListX
            // 
            this.RefreshAddressListX.Dock = System.Windows.Forms.DockStyle.Top;
            this.RefreshAddressListX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshAddressListX.Location = new System.Drawing.Point(0, 0);
            this.RefreshAddressListX.Name = "RefreshAddressListX";
            this.RefreshAddressListX.Size = new System.Drawing.Size(263, 23);
            this.RefreshAddressListX.TabIndex = 7;
            this.RefreshAddressListX.Text = "Refresh Values";
            this.RefreshAddressListX.UseVisualStyleBackColor = true;
            this.RefreshAddressListX.Click += new System.EventHandler(this.RefreshAddressListX_Click);
            // 
            // ChangedUnchangedCollection
            // 
            this.ChangedUnchangedCollection.Controls.Add(this.ScanSettingsRanging);
            this.ChangedUnchangedCollection.Controls.Add(this.UnchangedValue);
            this.ChangedUnchangedCollection.Controls.Add(this.ChangedValue);
            this.ChangedUnchangedCollection.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangedUnchangedCollection.Location = new System.Drawing.Point(147, 0);
            this.ChangedUnchangedCollection.Name = "ChangedUnchangedCollection";
            this.ChangedUnchangedCollection.Size = new System.Drawing.Size(119, 167);
            this.ChangedUnchangedCollection.TabIndex = 4;
            this.ChangedUnchangedCollection.Paint += new System.Windows.Forms.PaintEventHandler(this.ChangedUnchangedCollection_Paint);
            // 
            // ChangedValue
            // 
            this.ChangedValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangedValue.Location = new System.Drawing.Point(3, 23);
            this.ChangedValue.Name = "ChangedValue";
            this.ChangedValue.Size = new System.Drawing.Size(110, 23);
            this.ChangedValue.TabIndex = 3;
            this.ChangedValue.Text = "Changed Value";
            this.ChangedValue.UseVisualStyleBackColor = true;
            // 
            // UnchangedValue
            // 
            this.UnchangedValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnchangedValue.Location = new System.Drawing.Point(3, 0);
            this.UnchangedValue.Name = "UnchangedValue";
            this.UnchangedValue.Size = new System.Drawing.Size(110, 23);
            this.UnchangedValue.TabIndex = 2;
            this.UnchangedValue.Text = "Unchanged Value";
            this.UnchangedValue.UseVisualStyleBackColor = true;
            this.UnchangedValue.Click += new System.EventHandler(this.UnchangedValue_Click);
            // 
            // ScanMainPanel
            // 
            this.ScanMainPanel.Controls.Add(this.ScanStart);
            this.ScanMainPanel.Controls.Add(this.NextScan);
            this.ScanMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanMainPanel.Location = new System.Drawing.Point(0, 0);
            this.ScanMainPanel.Name = "ScanMainPanel";
            this.ScanMainPanel.Size = new System.Drawing.Size(147, 27);
            this.ScanMainPanel.TabIndex = 9;
            // 
            // ScanValuePanel
            // 
            this.ScanValuePanel.Controls.Add(this.ScanAsHex);
            this.ScanValuePanel.Controls.Add(this.ScanValue);
            this.ScanValuePanel.Controls.Add(this.ScanValueTitle);
            this.ScanValuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanValuePanel.Location = new System.Drawing.Point(0, 27);
            this.ScanValuePanel.Name = "ScanValuePanel";
            this.ScanValuePanel.Size = new System.Drawing.Size(147, 59);
            this.ScanValuePanel.TabIndex = 6;
            this.ScanValuePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ScanValuePanel_Paint);
            // 
            // ScanValueTitle
            // 
            this.ScanValueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanValueTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanValueTitle.Location = new System.Drawing.Point(0, 0);
            this.ScanValueTitle.Name = "ScanValueTitle";
            this.ScanValueTitle.Size = new System.Drawing.Size(147, 15);
            this.ScanValueTitle.TabIndex = 5;
            this.ScanValueTitle.Text = "Scan Value:";
            this.ScanValueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScanValue
            // 
            this.ScanValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanValue.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanValue.Location = new System.Drawing.Point(0, 15);
            this.ScanValue.Name = "ScanValue";
            this.ScanValue.Size = new System.Drawing.Size(147, 18);
            this.ScanValue.TabIndex = 5;
            this.ScanValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanValue_KeyDown);
            // 
            // ScanTypePanel
            // 
            this.ScanTypePanel.Controls.Add(this.ScanValueType);
            this.ScanTypePanel.Controls.Add(this.ScanTypeTitle);
            this.ScanTypePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanTypePanel.Location = new System.Drawing.Point(0, 86);
            this.ScanTypePanel.Name = "ScanTypePanel";
            this.ScanTypePanel.Size = new System.Drawing.Size(147, 38);
            this.ScanTypePanel.TabIndex = 8;
            this.ScanTypePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ScanTypePanel_Paint);
            // 
            // ScanTypeTitle
            // 
            this.ScanTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanTypeTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanTypeTitle.Location = new System.Drawing.Point(0, 0);
            this.ScanTypeTitle.Name = "ScanTypeTitle";
            this.ScanTypeTitle.Size = new System.Drawing.Size(147, 14);
            this.ScanTypeTitle.TabIndex = 5;
            this.ScanTypeTitle.Text = "Scan Type:";
            this.ScanTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScanTypeTitle.Click += new System.EventHandler(this.ScanTypeTitle_Click);
            // 
            // ScanValueType
            // 
            this.ScanValueType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ScanValueType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ScanValueType.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanValueType.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanValueType.FormattingEnabled = true;
            this.ScanValueType.Location = new System.Drawing.Point(0, 14);
            this.ScanValueType.Name = "ScanValueType";
            this.ScanValueType.Size = new System.Drawing.Size(147, 19);
            this.ScanValueType.TabIndex = 7;
            this.ScanValueType.SelectedIndexChanged += new System.EventHandler(this.ScanValueType_SelectedIndexChanged);
            this.ScanValueType.TextChanged += new System.EventHandler(this.ScanValueType_TextChanged);
            // 
            // ScanOptionsMain
            // 
            this.ScanOptionsMain.Controls.Add(this.ScanTypePanel);
            this.ScanOptionsMain.Controls.Add(this.ScanValuePanel);
            this.ScanOptionsMain.Controls.Add(this.ScanMainPanel);
            this.ScanOptionsMain.Controls.Add(this.ChangedUnchangedCollection);
            this.ScanOptionsMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanOptionsMain.Location = new System.Drawing.Point(0, 0);
            this.ScanOptionsMain.Name = "ScanOptionsMain";
            this.ScanOptionsMain.Size = new System.Drawing.Size(266, 167);
            this.ScanOptionsMain.TabIndex = 9;
            // 
            // NextScan
            // 
            this.NextScan.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextScan.Location = new System.Drawing.Point(72, 0);
            this.NextScan.Name = "NextScan";
            this.NextScan.Size = new System.Drawing.Size(75, 27);
            this.NextScan.TabIndex = 2;
            this.NextScan.Text = "Next Scan";
            this.NextScan.UseVisualStyleBackColor = true;
            this.NextScan.Click += new System.EventHandler(this.NextScan_Click);
            // 
            // ScanStart
            // 
            this.ScanStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScanStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanStart.Location = new System.Drawing.Point(0, 0);
            this.ScanStart.Name = "ScanStart";
            this.ScanStart.Size = new System.Drawing.Size(64, 27);
            this.ScanStart.TabIndex = 3;
            this.ScanStart.Text = "First Scan";
            this.ScanStart.UseVisualStyleBackColor = true;
            this.ScanStart.Click += new System.EventHandler(this.ScanStart_Click);
            // 
            // OpenProcessTB_Centerer
            // 
            this.OpenProcessTB_Centerer.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenProcessTB_Centerer.Location = new System.Drawing.Point(141, 0);
            this.OpenProcessTB_Centerer.Name = "OpenProcessTB_Centerer";
            this.OpenProcessTB_Centerer.Size = new System.Drawing.Size(390, 4);
            this.OpenProcessTB_Centerer.TabIndex = 2;
            // 
            // ScanAsHex
            // 
            this.ScanAsHex.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanAsHex.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanAsHex.Location = new System.Drawing.Point(0, 33);
            this.ScanAsHex.Name = "ScanAsHex";
            this.ScanAsHex.ReadOnly = true;
            this.ScanAsHex.Size = new System.Drawing.Size(147, 18);
            this.ScanAsHex.TabIndex = 4;
            // 
            // ScanSettingsRanging
            // 
            this.ScanSettingsRanging.AutoScroll = true;
            this.ScanSettingsRanging.Controls.Add(this.ScanMemoryRange);
            this.ScanSettingsRanging.Controls.Add(this.ScanRegionSizing);
            this.ScanSettingsRanging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ScanSettingsRanging.Location = new System.Drawing.Point(0, 52);
            this.ScanSettingsRanging.Name = "ScanSettingsRanging";
            this.ScanSettingsRanging.Size = new System.Drawing.Size(119, 115);
            this.ScanSettingsRanging.TabIndex = 9;
            // 
            // ScanRegionSizing
            // 
            this.ScanRegionSizing.Controls.Add(this.RegionSizeMax);
            this.ScanRegionSizing.Controls.Add(this.RegionSizeMin);
            this.ScanRegionSizing.Controls.Add(this.label2);
            this.ScanRegionSizing.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanRegionSizing.Location = new System.Drawing.Point(0, 0);
            this.ScanRegionSizing.Name = "ScanRegionSizing";
            this.ScanRegionSizing.Size = new System.Drawing.Size(119, 51);
            this.ScanRegionSizing.TabIndex = 9;
            // 
            // RegionSizeMax
            // 
            this.RegionSizeMax.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegionSizeMax.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionSizeMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RegionSizeMax.Location = new System.Drawing.Point(0, 30);
            this.RegionSizeMax.Maximum = new decimal(new int[] {
            1000000001,
            0,
            0,
            0});
            this.RegionSizeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RegionSizeMax.Name = "RegionSizeMax";
            this.RegionSizeMax.Size = new System.Drawing.Size(119, 18);
            this.RegionSizeMax.TabIndex = 7;
            this.RegionSizeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegionSizeMax.Value = new decimal(new int[] {
            1000000001,
            0,
            0,
            0});
            // 
            // RegionSizeMin
            // 
            this.RegionSizeMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegionSizeMin.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionSizeMin.Location = new System.Drawing.Point(0, 12);
            this.RegionSizeMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.RegionSizeMin.Name = "RegionSizeMin";
            this.RegionSizeMin.Size = new System.Drawing.Size(119, 18);
            this.RegionSizeMin.TabIndex = 6;
            this.RegionSizeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scan Region Sizing:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScanMemoryRange
            // 
            this.ScanMemoryRange.Controls.Add(this.ScanRegionSizeHigh);
            this.ScanMemoryRange.Controls.Add(this.ScanRegionSizeLow);
            this.ScanMemoryRange.Controls.Add(this.label1);
            this.ScanMemoryRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanMemoryRange.Location = new System.Drawing.Point(0, 51);
            this.ScanMemoryRange.Name = "ScanMemoryRange";
            this.ScanMemoryRange.Size = new System.Drawing.Size(119, 51);
            this.ScanMemoryRange.TabIndex = 10;
            // 
            // ScanRegionSizeHigh
            // 
            this.ScanRegionSizeHigh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanRegionSizeHigh.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRegionSizeHigh.Location = new System.Drawing.Point(0, 33);
            this.ScanRegionSizeHigh.Name = "ScanRegionSizeHigh";
            this.ScanRegionSizeHigh.Size = new System.Drawing.Size(119, 18);
            this.ScanRegionSizeHigh.TabIndex = 6;
            this.ScanRegionSizeHigh.Text = "00007fffffffffff";
            this.ScanRegionSizeHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScanRegionSizeLow
            // 
            this.ScanRegionSizeLow.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanRegionSizeLow.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanRegionSizeLow.Location = new System.Drawing.Point(0, 15);
            this.ScanRegionSizeLow.Name = "ScanRegionSizeLow";
            this.ScanRegionSizeLow.Size = new System.Drawing.Size(119, 18);
            this.ScanRegionSizeLow.TabIndex = 5;
            this.ScanRegionSizeLow.Text = "0000000000000000";
            this.ScanRegionSizeLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scan Address Range:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedAddressButton
            // 
            this.SelectedAddressButton.Controls.Add(this.PeekInfo);
            this.SelectedAddressButton.Controls.Add(this.AddToAddressList);
            this.SelectedAddressButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedAddressButton.Location = new System.Drawing.Point(0, 286);
            this.SelectedAddressButton.Name = "SelectedAddressButton";
            this.SelectedAddressButton.Size = new System.Drawing.Size(263, 48);
            this.SelectedAddressButton.TabIndex = 10;
            // 
            // PeekInfo
            // 
            this.PeekInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PeekInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeekInfo.Location = new System.Drawing.Point(0, 2);
            this.PeekInfo.Name = "PeekInfo";
            this.PeekInfo.Size = new System.Drawing.Size(263, 23);
            this.PeekInfo.TabIndex = 13;
            this.PeekInfo.Text = "Peek First Selected Info";
            this.PeekInfo.UseVisualStyleBackColor = true;
            this.PeekInfo.Click += new System.EventHandler(this.PeekInfo_Click);
            // 
            // AddToAddressList
            // 
            this.AddToAddressList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddToAddressList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToAddressList.Location = new System.Drawing.Point(0, 25);
            this.AddToAddressList.Name = "AddToAddressList";
            this.AddToAddressList.Size = new System.Drawing.Size(263, 23);
            this.AddToAddressList.TabIndex = 12;
            this.AddToAddressList.Text = "Add To Address List";
            this.AddToAddressList.UseVisualStyleBackColor = true;
            // 
            // SelectedInfoPanel
            // 
            this.SelectedInfoPanel.Controls.Add(this.SelectedRegionSizePanel);
            this.SelectedInfoPanel.Controls.Add(this.panel5);
            this.SelectedInfoPanel.Controls.Add(this.SelectedAddressPanel);
            this.SelectedInfoPanel.Controls.Add(this.SelectedInfoTitle);
            this.SelectedInfoPanel.Location = new System.Drawing.Point(5, 173);
            this.SelectedInfoPanel.Name = "SelectedInfoPanel";
            this.SelectedInfoPanel.Size = new System.Drawing.Size(119, 124);
            this.SelectedInfoPanel.TabIndex = 12;
            // 
            // SelectedInfoTitle
            // 
            this.SelectedInfoTitle.Controls.Add(this.SelectedInfo);
            this.SelectedInfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedInfoTitle.Location = new System.Drawing.Point(0, 0);
            this.SelectedInfoTitle.Name = "SelectedInfoTitle";
            this.SelectedInfoTitle.Size = new System.Drawing.Size(119, 25);
            this.SelectedInfoTitle.TabIndex = 12;
            // 
            // SelectedInfo
            // 
            this.SelectedInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedInfo.Location = new System.Drawing.Point(0, 0);
            this.SelectedInfo.Name = "SelectedInfo";
            this.SelectedInfo.Size = new System.Drawing.Size(119, 15);
            this.SelectedInfo.TabIndex = 5;
            this.SelectedInfo.Text = "SelectedInfo";
            this.SelectedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedAddressPanel
            // 
            this.SelectedAddressPanel.Controls.Add(this.SelectedInfoAddress);
            this.SelectedAddressPanel.Controls.Add(this.SelectedAddressTitle);
            this.SelectedAddressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedAddressPanel.Location = new System.Drawing.Point(0, 25);
            this.SelectedAddressPanel.Name = "SelectedAddressPanel";
            this.SelectedAddressPanel.Size = new System.Drawing.Size(119, 29);
            this.SelectedAddressPanel.TabIndex = 14;
            // 
            // SelectedInfoAddress
            // 
            this.SelectedInfoAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedInfoAddress.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedInfoAddress.Location = new System.Drawing.Point(0, 13);
            this.SelectedInfoAddress.Name = "SelectedInfoAddress";
            this.SelectedInfoAddress.Size = new System.Drawing.Size(119, 18);
            this.SelectedInfoAddress.TabIndex = 7;
            this.SelectedInfoAddress.Text = "00007fffffffffff";
            this.SelectedInfoAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectedAddressTitle
            // 
            this.SelectedAddressTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedAddressTitle.Location = new System.Drawing.Point(0, 0);
            this.SelectedAddressTitle.Name = "SelectedAddressTitle";
            this.SelectedAddressTitle.Size = new System.Drawing.Size(119, 13);
            this.SelectedAddressTitle.TabIndex = 8;
            this.SelectedAddressTitle.Text = "Selected Address:";
            this.SelectedAddressTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SelectedInfoBase);
            this.panel5.Controls.Add(this.SelectedBaseTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 29);
            this.panel5.TabIndex = 15;
            // 
            // SelectedInfoBase
            // 
            this.SelectedInfoBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedInfoBase.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedInfoBase.Location = new System.Drawing.Point(0, 13);
            this.SelectedInfoBase.Name = "SelectedInfoBase";
            this.SelectedInfoBase.Size = new System.Drawing.Size(119, 18);
            this.SelectedInfoBase.TabIndex = 7;
            this.SelectedInfoBase.Text = "00007fffffffffff";
            this.SelectedInfoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectedBaseTitle
            // 
            this.SelectedBaseTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedBaseTitle.Location = new System.Drawing.Point(0, 0);
            this.SelectedBaseTitle.Name = "SelectedBaseTitle";
            this.SelectedBaseTitle.Size = new System.Drawing.Size(119, 13);
            this.SelectedBaseTitle.TabIndex = 8;
            this.SelectedBaseTitle.Text = "Selected Base:";
            this.SelectedBaseTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectedRegionSizePanel
            // 
            this.SelectedRegionSizePanel.Controls.Add(this.SelectedRegionSize);
            this.SelectedRegionSizePanel.Controls.Add(this.SelectedRegionSizeTitle);
            this.SelectedRegionSizePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedRegionSizePanel.Location = new System.Drawing.Point(0, 83);
            this.SelectedRegionSizePanel.Name = "SelectedRegionSizePanel";
            this.SelectedRegionSizePanel.Size = new System.Drawing.Size(119, 29);
            this.SelectedRegionSizePanel.TabIndex = 16;
            // 
            // SelectedRegionSize
            // 
            this.SelectedRegionSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedRegionSize.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRegionSize.Location = new System.Drawing.Point(0, 13);
            this.SelectedRegionSize.Name = "SelectedRegionSize";
            this.SelectedRegionSize.Size = new System.Drawing.Size(119, 18);
            this.SelectedRegionSize.TabIndex = 7;
            this.SelectedRegionSize.Text = "00000001";
            this.SelectedRegionSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectedRegionSizeTitle
            // 
            this.SelectedRegionSizeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedRegionSizeTitle.Location = new System.Drawing.Point(0, 0);
            this.SelectedRegionSizeTitle.Name = "SelectedRegionSizeTitle";
            this.SelectedRegionSizeTitle.Size = new System.Drawing.Size(119, 13);
            this.SelectedRegionSizeTitle.TabIndex = 8;
            this.SelectedRegionSizeTitle.Text = "Selected Region Size:";
            this.SelectedRegionSizeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NHA_MemoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 381);
            this.Controls.Add(this.ScanOptionsPanel);
            this.Controls.Add(this.ScanCompletion);
            this.Controls.Add(this.ScannedAddressHolder);
            this.Controls.Add(this.AddressList);
            this.Controls.Add(this.OpenProcessPanel);
            this.Controls.Add(this.TabHandler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 420);
            this.Name = "NHA_MemoryMain";
            this.Text = "NHA\'s Not\'a Knock\'off";
            this.Load += new System.EventHandler(this.NHA_MemoryMain_Load);
            this.ScannedAddressHolder.ResumeLayout(false);
            this.ScanOptionsPanel.ResumeLayout(false);
            this.OpenProcessPanel.ResumeLayout(false);
            this.OpenProcessPanel.PerformLayout();
            this.ChangedUnchangedCollection.ResumeLayout(false);
            this.ScanMainPanel.ResumeLayout(false);
            this.ScanValuePanel.ResumeLayout(false);
            this.ScanValuePanel.PerformLayout();
            this.ScanTypePanel.ResumeLayout(false);
            this.ScanOptionsMain.ResumeLayout(false);
            this.ScanSettingsRanging.ResumeLayout(false);
            this.ScanRegionSizing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegionSizeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionSizeMin)).EndInit();
            this.ScanMemoryRange.ResumeLayout(false);
            this.ScanMemoryRange.PerformLayout();
            this.SelectedAddressButton.ResumeLayout(false);
            this.SelectedInfoPanel.ResumeLayout(false);
            this.SelectedInfoTitle.ResumeLayout(false);
            this.SelectedAddressPanel.ResumeLayout(false);
            this.SelectedAddressPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.SelectedRegionSizePanel.ResumeLayout(false);
            this.SelectedRegionSizePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl TabHandler;
        public System.Windows.Forms.Panel ScannedAddressHolder;
        public System.Windows.Forms.Panel AddressList;
        private System.Windows.Forms.Panel ScanOptionsPanel;
        public System.Windows.Forms.Label ScanCompletion;
        private System.Windows.Forms.Button CheckConnection;
        private System.Windows.Forms.TextBox NHA_ProcessInfo;
        private System.Windows.Forms.Panel OpenProcessPanel;
        private System.Windows.Forms.ListBox AddressListX;
        private System.Windows.Forms.Button RefreshAddressListX;
        private System.Windows.Forms.Panel ScanOptionsMain;
        private System.Windows.Forms.Panel ScanTypePanel;
        private System.Windows.Forms.ComboBox ScanValueType;
        public System.Windows.Forms.Label ScanTypeTitle;
        private System.Windows.Forms.Panel ScanValuePanel;
        private System.Windows.Forms.TextBox ScanValue;
        public System.Windows.Forms.Label ScanValueTitle;
        private System.Windows.Forms.Panel ScanMainPanel;
        private System.Windows.Forms.Button ScanStart;
        private System.Windows.Forms.Button NextScan;
        private System.Windows.Forms.Panel ChangedUnchangedCollection;
        private System.Windows.Forms.Button UnchangedValue;
        private System.Windows.Forms.Button ChangedValue;
        private System.Windows.Forms.Panel OpenProcessTB_Centerer;
        private System.Windows.Forms.TextBox ScanAsHex;
        private System.Windows.Forms.Panel ScanSettingsRanging;
        public System.Windows.Forms.Panel ScanMemoryRange;
        private System.Windows.Forms.TextBox ScanRegionSizeHigh;
        private System.Windows.Forms.TextBox ScanRegionSizeLow;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel ScanRegionSizing;
        public System.Windows.Forms.NumericUpDown RegionSizeMax;
        public System.Windows.Forms.NumericUpDown RegionSizeMin;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SelectedAddressButton;
        private System.Windows.Forms.Button PeekInfo;
        private System.Windows.Forms.Button AddToAddressList;
        private System.Windows.Forms.Panel SelectedInfoPanel;
        private System.Windows.Forms.Panel SelectedRegionSizePanel;
        private System.Windows.Forms.TextBox SelectedRegionSize;
        private System.Windows.Forms.Label SelectedRegionSizeTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox SelectedInfoBase;
        private System.Windows.Forms.Label SelectedBaseTitle;
        private System.Windows.Forms.Panel SelectedAddressPanel;
        private System.Windows.Forms.TextBox SelectedInfoAddress;
        private System.Windows.Forms.Label SelectedAddressTitle;
        public System.Windows.Forms.Panel SelectedInfoTitle;
        public System.Windows.Forms.Label SelectedInfo;
    }
}