﻿namespace MultiMiner.Win
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deviceStatsTimer = new System.Windows.Forms.Timer(this.components);
            this.coinStatsTimer = new System.Windows.Forms.Timer(this.components);
            this.startupMiningCountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.startupMiningPanel = new System.Windows.Forms.Panel();
            this.cancelStartupMiningButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.crashRecoveryTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.coinsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.strategiesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedMenuItem = new System.Windows.Forms.ToolStripDropDownButton();
            this.detectDevicesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSwitchItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dummyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.apiMonitorButton = new System.Windows.Forms.ToolStripMenuItem();
            this.processLogButton = new System.Windows.Forms.ToolStripMenuItem();
            this.historyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopModeButton = new System.Windows.Forms.ToolStripButton();
            this.saveSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backendLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.strategiesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.strategyCountdownLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sha256RateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.scryptRateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.deviceTotalLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.coinStatsCountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.footerPanel = new System.Windows.Forms.Panel();
            this.coinStatsLabel = new System.Windows.Forms.Label();
            this.coinChooseSuffixLabel = new System.Windows.Forms.Label();
            this.coinChooseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.coinChoosePrefixLabel = new System.Windows.Forms.Label();
            this.advancedAreaContainer = new System.Windows.Forms.SplitContainer();
            this.deviceGridView = new System.Windows.Forms.DataGridView();
            this.enabledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.difficultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intensityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advancedTabControl = new System.Windows.Forms.TabControl();
            this.apiMonitorPage = new System.Windows.Forms.TabPage();
            this.apiLogGridView = new System.Windows.Forms.DataGridView();
            this.CoinName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processLogPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executablePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logLaunchArgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyPage = new System.Windows.Forms.TabPage();
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptedShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logProcessCloseArgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeApiButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileMinerTimer = new System.Windows.Forms.Timer(this.components);
            this.updateCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.idleTimer = new System.Windows.Forms.Timer(this.components);
            this.restartTimer = new System.Windows.Forms.Timer(this.components);
            this.minerSummaryTimer = new System.Windows.Forms.Timer(this.components);
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apiLogEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startupMiningPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.advancedAreaContainer.Panel1.SuspendLayout();
            this.advancedAreaContainer.Panel2.SuspendLayout();
            this.advancedAreaContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.advancedTabControl.SuspendLayout();
            this.apiMonitorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apiLogGridView)).BeginInit();
            this.processLogPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLaunchArgsBindingSource)).BeginInit();
            this.historyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logProcessCloseArgsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.notifyIconMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apiLogEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceStatsTimer
            // 
            this.deviceStatsTimer.Interval = 5000;
            this.deviceStatsTimer.Tick += new System.EventHandler(this.statsTimer_Tick);
            // 
            // coinStatsTimer
            // 
            this.coinStatsTimer.Enabled = true;
            this.coinStatsTimer.Interval = 900000;
            this.coinStatsTimer.Tick += new System.EventHandler(this.coinStatsTimer_Tick);
            // 
            // startupMiningCountdownTimer
            // 
            this.startupMiningCountdownTimer.Interval = 1000;
            this.startupMiningCountdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // startupMiningPanel
            // 
            this.startupMiningPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startupMiningPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startupMiningPanel.Controls.Add(this.cancelStartupMiningButton);
            this.startupMiningPanel.Controls.Add(this.countdownLabel);
            this.startupMiningPanel.Location = new System.Drawing.Point(384, 226);
            this.startupMiningPanel.Name = "startupMiningPanel";
            this.startupMiningPanel.Size = new System.Drawing.Size(319, 37);
            this.startupMiningPanel.TabIndex = 6;
            this.startupMiningPanel.Visible = false;
            // 
            // cancelStartupMiningButton
            // 
            this.cancelStartupMiningButton.Location = new System.Drawing.Point(231, 6);
            this.cancelStartupMiningButton.Name = "cancelStartupMiningButton";
            this.cancelStartupMiningButton.Size = new System.Drawing.Size(75, 23);
            this.cancelStartupMiningButton.TabIndex = 5;
            this.cancelStartupMiningButton.Text = "Cancel";
            this.cancelStartupMiningButton.UseVisualStyleBackColor = true;
            this.cancelStartupMiningButton.Click += new System.EventHandler(this.cancelStartupMiningButton_Click);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Location = new System.Drawing.Point(5, 11);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(220, 13);
            this.countdownLabel.TabIndex = 0;
            this.countdownLabel.Text = "Mining will start automatically in 45 seconds...";
            // 
            // crashRecoveryTimer
            // 
            this.crashRecoveryTimer.Interval = 30000;
            this.crashRecoveryTimer.Tick += new System.EventHandler(this.crashRecoveryTimer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startButton,
            this.stopButton,
            this.toolStripSeparator3,
            this.settingsButton,
            this.advancedMenuItem,
            this.desktopModeButton,
            this.saveSeparator,
            this.saveButton,
            this.cancelButton,
            this.aboutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1087, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(51, 22);
            this.startButton.Text = "Start";
            this.startButton.ToolTipText = "Start mining";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(51, 22);
            this.stopButton.Text = "Stop";
            this.stopButton.ToolTipText = "Stop mining";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // settingsButton
            // 
            this.settingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coinsButton,
            this.strategiesButton});
            this.settingsButton.Image = global::MultiMiner.Win.Properties.Resources.application_option;
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(81, 22);
            this.settingsButton.Text = "Settings";
            this.settingsButton.ToolTipText = "Configure application settings";
            this.settingsButton.ButtonClick += new System.EventHandler(this.settingsButton_ButtonClick);
            // 
            // coinsButton
            // 
            this.coinsButton.Image = global::MultiMiner.Win.Properties.Resources.application_gear;
            this.coinsButton.Name = "coinsButton";
            this.coinsButton.Size = new System.Drawing.Size(125, 22);
            this.coinsButton.Text = "Coins";
            this.coinsButton.ToolTipText = "Configure coins and pools";
            this.coinsButton.Click += new System.EventHandler(this.coinsButton_Click_1);
            // 
            // strategiesButton
            // 
            this.strategiesButton.Image = global::MultiMiner.Win.Properties.Resources.settings_options;
            this.strategiesButton.Name = "strategiesButton";
            this.strategiesButton.Size = new System.Drawing.Size(125, 22);
            this.strategiesButton.Text = "Strategies";
            this.strategiesButton.ToolTipText = "Configure profitability strategies";
            this.strategiesButton.Click += new System.EventHandler(this.strategiesButton_Click_1);
            // 
            // advancedMenuItem
            // 
            this.advancedMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detectDevicesButton,
            this.quickSwitchItem,
            this.toolStripSeparator5,
            this.apiMonitorButton,
            this.processLogButton,
            this.historyButton});
            this.advancedMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("advancedMenuItem.Image")));
            this.advancedMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.advancedMenuItem.Name = "advancedMenuItem";
            this.advancedMenuItem.Size = new System.Drawing.Size(89, 22);
            this.advancedMenuItem.Text = "Advanced";
            this.advancedMenuItem.ToolTipText = "Advanced tools";
            this.advancedMenuItem.DropDownOpening += new System.EventHandler(this.advancedMenuItem_DropDownOpening);
            // 
            // detectDevicesButton
            // 
            this.detectDevicesButton.Image = global::MultiMiner.Win.Properties.Resources.computer_find;
            this.detectDevicesButton.Name = "detectDevicesButton";
            this.detectDevicesButton.Size = new System.Drawing.Size(151, 22);
            this.detectDevicesButton.Text = "Detect Devices";
            this.detectDevicesButton.ToolTipText = "Scan for mining capable devices";
            this.detectDevicesButton.Click += new System.EventHandler(this.detectDevicesButton_Click);
            // 
            // quickSwitchItem
            // 
            this.quickSwitchItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dummyToolStripMenuItem});
            this.quickSwitchItem.Image = global::MultiMiner.Win.Properties.Resources.list_arrow_right;
            this.quickSwitchItem.Name = "quickSwitchItem";
            this.quickSwitchItem.Size = new System.Drawing.Size(151, 22);
            this.quickSwitchItem.Text = "Quick Switch";
            this.quickSwitchItem.ToolTipText = "Switch all devices to a coin";
            this.quickSwitchItem.DropDownOpening += new System.EventHandler(this.quickSwitchItem_DropDownOpening);
            // 
            // dummyToolStripMenuItem
            // 
            this.dummyToolStripMenuItem.Name = "dummyToolStripMenuItem";
            this.dummyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dummyToolStripMenuItem.Text = "Dummy";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // apiMonitorButton
            // 
            this.apiMonitorButton.Image = global::MultiMiner.Win.Properties.Resources.network_application;
            this.apiMonitorButton.Name = "apiMonitorButton";
            this.apiMonitorButton.Size = new System.Drawing.Size(151, 22);
            this.apiMonitorButton.Text = "API Monitor";
            this.apiMonitorButton.ToolTipText = "Display a log of RPC API calls";
            this.apiMonitorButton.Click += new System.EventHandler(this.apiMonitorButton_Click);
            // 
            // processLogButton
            // 
            this.processLogButton.Image = global::MultiMiner.Win.Properties.Resources.window_text;
            this.processLogButton.Name = "processLogButton";
            this.processLogButton.Size = new System.Drawing.Size(151, 22);
            this.processLogButton.Text = "Process Log";
            this.processLogButton.ToolTipText = "Display a log of processes launched";
            this.processLogButton.Click += new System.EventHandler(this.processLogButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Image = global::MultiMiner.Win.Properties.Resources.history;
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(151, 22);
            this.historyButton.Text = "History";
            this.historyButton.ToolTipText = "Display a history of coins mined";
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // desktopModeButton
            // 
            this.desktopModeButton.CheckOnClick = true;
            this.desktopModeButton.Image = ((System.Drawing.Image)(resources.GetObject("desktopModeButton.Image")));
            this.desktopModeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.desktopModeButton.Name = "desktopModeButton";
            this.desktopModeButton.Size = new System.Drawing.Size(104, 22);
            this.desktopModeButton.Text = "Desktop Mode";
            this.desktopModeButton.ToolTipText = "Toggle overriding user-defined intensity settings";
            this.desktopModeButton.Click += new System.EventHandler(this.desktopModeButton_Click);
            // 
            // saveSeparator
            // 
            this.saveSeparator.Name = "saveSeparator";
            this.saveSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(51, 22);
            this.saveButton.Text = "Save";
            this.saveButton.ToolTipText = "Save changes";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 22);
            this.cancelButton.Text = "Cancel";
            this.cancelButton.ToolTipText = "Cancel changes";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutButton.Image = global::MultiMiner.Win.Properties.Resources.application_info;
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(60, 22);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backendLabel,
            this.strategiesLabel,
            this.strategyCountdownLabel,
            this.sha256RateLabel,
            this.scryptRateLabel,
            this.deviceTotalLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // backendLabel
            // 
            this.backendLabel.AutoSize = false;
            this.backendLabel.Name = "backendLabel";
            this.backendLabel.Size = new System.Drawing.Size(120, 17);
            this.backendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // strategiesLabel
            // 
            this.strategiesLabel.AutoSize = false;
            this.strategiesLabel.Name = "strategiesLabel";
            this.strategiesLabel.Size = new System.Drawing.Size(125, 17);
            this.strategiesLabel.Text = "Strategies: enabled";
            this.strategiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // strategyCountdownLabel
            // 
            this.strategyCountdownLabel.AutoSize = false;
            this.strategyCountdownLabel.Name = "strategyCountdownLabel";
            this.strategyCountdownLabel.Size = new System.Drawing.Size(180, 17);
            this.strategyCountdownLabel.Text = "Time until strategy check: 60s";
            this.strategyCountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sha256RateLabel
            // 
            this.sha256RateLabel.Name = "sha256RateLabel";
            this.sha256RateLabel.Size = new System.Drawing.Size(457, 17);
            this.sha256RateLabel.Spring = true;
            this.sha256RateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scryptRateLabel
            // 
            this.scryptRateLabel.AutoSize = false;
            this.scryptRateLabel.Name = "scryptRateLabel";
            this.scryptRateLabel.Size = new System.Drawing.Size(110, 17);
            this.scryptRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deviceTotalLabel
            // 
            this.deviceTotalLabel.AutoSize = false;
            this.deviceTotalLabel.Name = "deviceTotalLabel";
            this.deviceTotalLabel.Size = new System.Drawing.Size(80, 17);
            this.deviceTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coinStatsCountdownTimer
            // 
            this.coinStatsCountdownTimer.Interval = 60000;
            this.coinStatsCountdownTimer.Tick += new System.EventHandler(this.coinStatsCountdownTimer_Tick);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.footerPanel.Controls.Add(this.coinStatsLabel);
            this.footerPanel.Controls.Add(this.coinChooseSuffixLabel);
            this.footerPanel.Controls.Add(this.coinChooseLinkLabel);
            this.footerPanel.Controls.Add(this.coinChoosePrefixLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 429);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1087, 37);
            this.footerPanel.TabIndex = 9;
            // 
            // coinStatsLabel
            // 
            this.coinStatsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coinStatsLabel.Location = new System.Drawing.Point(1819, 13);
            this.coinStatsLabel.Name = "coinStatsLabel";
            this.coinStatsLabel.Size = new System.Drawing.Size(200, 23);
            this.coinStatsLabel.TabIndex = 3;
            this.coinStatsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // coinChooseSuffixLabel
            // 
            this.coinChooseSuffixLabel.AutoSize = true;
            this.coinChooseSuffixLabel.Location = new System.Drawing.Point(454, 13);
            this.coinChooseSuffixLabel.Name = "coinChooseSuffixLabel";
            this.coinChooseSuffixLabel.Size = new System.Drawing.Size(27, 13);
            this.coinChooseSuffixLabel.TabIndex = 2;
            this.coinChooseSuffixLabel.Text = "API.";
            // 
            // coinChooseLinkLabel
            // 
            this.coinChooseLinkLabel.AutoSize = true;
            this.coinChooseLinkLabel.Location = new System.Drawing.Point(343, 13);
            this.coinChooseLinkLabel.Name = "coinChooseLinkLabel";
            this.coinChooseLinkLabel.Size = new System.Drawing.Size(87, 13);
            this.coinChooseLinkLabel.TabIndex = 1;
            this.coinChooseLinkLabel.TabStop = true;
            this.coinChooseLinkLabel.Text = "CoinChoose.com";
            this.coinChooseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.coinChooseLink_LinkClicked);
            // 
            // coinChoosePrefixLabel
            // 
            this.coinChoosePrefixLabel.AutoSize = true;
            this.coinChoosePrefixLabel.Location = new System.Drawing.Point(3, 13);
            this.coinChoosePrefixLabel.Name = "coinChoosePrefixLabel";
            this.coinChoosePrefixLabel.Size = new System.Drawing.Size(318, 13);
            this.coinChoosePrefixLabel.TabIndex = 0;
            this.coinChoosePrefixLabel.Text = "Crypto-currency pricing and profitability information powered by the";
            // 
            // advancedAreaContainer
            // 
            this.advancedAreaContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedAreaContainer.Location = new System.Drawing.Point(0, 25);
            this.advancedAreaContainer.Name = "advancedAreaContainer";
            this.advancedAreaContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // advancedAreaContainer.Panel1
            // 
            this.advancedAreaContainer.Panel1.Controls.Add(this.deviceGridView);
            // 
            // advancedAreaContainer.Panel2
            // 
            this.advancedAreaContainer.Panel2.Controls.Add(this.advancedTabControl);
            this.advancedAreaContainer.Panel2.Controls.Add(this.panel2);
            this.advancedAreaContainer.Size = new System.Drawing.Size(1087, 404);
            this.advancedAreaContainer.SplitterDistance = 270;
            this.advancedAreaContainer.TabIndex = 10;
            this.advancedAreaContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.advancedAreaContainer_SplitterMoved);
            // 
            // deviceGridView
            // 
            this.deviceGridView.AllowUserToAddRows = false;
            this.deviceGridView.AllowUserToDeleteRows = false;
            this.deviceGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.deviceGridView.AutoGenerateColumns = false;
            this.deviceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deviceGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.deviceGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.deviceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kindDataGridViewTextBoxColumn,
            this.nameColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.enabledColumn,
            this.coinColumn,
            this.difficultyColumn,
            this.priceColumn,
            this.profitabilityColumn,
            this.poolColumn,
            this.temperatureColumn,
            this.hashRateColumn,
            this.acceptedColumn,
            this.rejectedColumn,
            this.errorsColumn,
            this.utilityColumn,
            this.intensityColumn});
            this.deviceGridView.DataSource = this.deviceBindingSource;
            this.deviceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceGridView.Location = new System.Drawing.Point(0, 0);
            this.deviceGridView.Name = "deviceGridView";
            this.deviceGridView.RowHeadersVisible = false;
            this.deviceGridView.Size = new System.Drawing.Size(1087, 270);
            this.deviceGridView.TabIndex = 1;
            this.deviceGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.deviceGridView_CellFormatting);
            this.deviceGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.deviceGridView_CellValueChanged);
            this.deviceGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.deviceGridView_CurrentCellDirtyStateChanged);
            // 
            // enabledColumn
            // 
            this.enabledColumn.FillWeight = 75F;
            this.enabledColumn.HeaderText = "Enable";
            this.enabledColumn.Name = "enabledColumn";
            this.enabledColumn.ToolTipText = "Toggle mining for device";
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Identifier";
            this.kindDataGridViewTextBoxColumn.FillWeight = 90F;
            this.kindDataGridViewTextBoxColumn.HeaderText = "Identifier";
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            this.kindDataGridViewTextBoxColumn.ReadOnly = true;
            this.kindDataGridViewTextBoxColumn.ToolTipText = "Device identifier";
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.FillWeight = 200F;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 85;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.ToolTipText = "Device name";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Driver";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 90F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Driver";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.ToolTipText = "Device driver";
            // 
            // coinColumn
            // 
            this.coinColumn.FillWeight = 150F;
            this.coinColumn.HeaderText = "Coin";
            this.coinColumn.Items.AddRange(new object[] {
            "Configure Coins"});
            this.coinColumn.MinimumWidth = 85;
            this.coinColumn.Name = "coinColumn";
            this.coinColumn.ToolTipText = "Current coin";
            // 
            // difficultyColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.difficultyColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.difficultyColumn.HeaderText = "Difficulty";
            this.difficultyColumn.Name = "difficultyColumn";
            this.difficultyColumn.ReadOnly = true;
            this.difficultyColumn.ToolTipText = "Difficulty returned by CoinChoose.com";
            // 
            // priceColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.priceColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.ToolTipText = "Price returned by CoinChoose.com";
            // 
            // profitabilityColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0\'%\'";
            this.profitabilityColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.profitabilityColumn.HeaderText = "Profitability";
            this.profitabilityColumn.Name = "profitabilityColumn";
            this.profitabilityColumn.ReadOnly = true;
            this.profitabilityColumn.ToolTipText = "Profitability of coin compared to Bitcoin";
            // 
            // poolColumn
            // 
            this.poolColumn.FillWeight = 120F;
            this.poolColumn.HeaderText = "Pool";
            this.poolColumn.Name = "poolColumn";
            this.poolColumn.ReadOnly = true;
            // 
            // temperatureColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.temperatureColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.temperatureColumn.FillWeight = 70F;
            this.temperatureColumn.HeaderText = "Temp";
            this.temperatureColumn.Name = "temperatureColumn";
            this.temperatureColumn.ReadOnly = true;
            // 
            // hashRateColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.hashRateColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.hashRateColumn.FillWeight = 95F;
            this.hashRateColumn.HeaderText = "Hashrate";
            this.hashRateColumn.Name = "hashRateColumn";
            this.hashRateColumn.ReadOnly = true;
            this.hashRateColumn.ToolTipText = "Average device hashrate";
            // 
            // acceptedColumn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.acceptedColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.acceptedColumn.HeaderText = "Accepted";
            this.acceptedColumn.Name = "acceptedColumn";
            this.acceptedColumn.ReadOnly = true;
            this.acceptedColumn.ToolTipText = "Accepted shares";
            // 
            // rejectedColumn
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.rejectedColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.rejectedColumn.HeaderText = "Rejected";
            this.rejectedColumn.Name = "rejectedColumn";
            this.rejectedColumn.ReadOnly = true;
            this.rejectedColumn.ToolTipText = "Rejected shares";
            // 
            // errorsColumn
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.errorsColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.errorsColumn.FillWeight = 70F;
            this.errorsColumn.HeaderText = "Errors";
            this.errorsColumn.Name = "errorsColumn";
            this.errorsColumn.ReadOnly = true;
            this.errorsColumn.ToolTipText = "Hardware errors";
            // 
            // utilityColumn
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.utilityColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.utilityColumn.FillWeight = 75F;
            this.utilityColumn.HeaderText = "Utility";
            this.utilityColumn.Name = "utilityColumn";
            this.utilityColumn.ReadOnly = true;
            this.utilityColumn.ToolTipText = "Ratio of accepted and rejected shares per minute";
            // 
            // intensityColumn
            // 
            this.intensityColumn.FillWeight = 95F;
            this.intensityColumn.HeaderText = "Intensity";
            this.intensityColumn.Name = "intensityColumn";
            this.intensityColumn.ReadOnly = true;
            this.intensityColumn.ToolTipText = "Device intensity";
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(Xgminer.Device);
            // 
            // advancedTabControl
            // 
            this.advancedTabControl.Controls.Add(this.apiMonitorPage);
            this.advancedTabControl.Controls.Add(this.processLogPage);
            this.advancedTabControl.Controls.Add(this.historyPage);
            this.advancedTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedTabControl.ImageList = this.imageList1;
            this.advancedTabControl.Location = new System.Drawing.Point(0, 28);
            this.advancedTabControl.Name = "advancedTabControl";
            this.advancedTabControl.SelectedIndex = 0;
            this.advancedTabControl.Size = new System.Drawing.Size(1087, 102);
            this.advancedTabControl.TabIndex = 15;
            // 
            // apiMonitorPage
            // 
            this.apiMonitorPage.Controls.Add(this.apiLogGridView);
            this.apiMonitorPage.ImageIndex = 0;
            this.apiMonitorPage.Location = new System.Drawing.Point(4, 23);
            this.apiMonitorPage.Name = "apiMonitorPage";
            this.apiMonitorPage.Padding = new System.Windows.Forms.Padding(3);
            this.apiMonitorPage.Size = new System.Drawing.Size(1079, 75);
            this.apiMonitorPage.TabIndex = 0;
            this.apiMonitorPage.Text = "API Monitor";
            this.apiMonitorPage.UseVisualStyleBackColor = true;
            // 
            // apiLogGridView
            // 
            this.apiLogGridView.AllowUserToAddRows = false;
            this.apiLogGridView.AllowUserToDeleteRows = false;
            this.apiLogGridView.AllowUserToOrderColumns = true;
            this.apiLogGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.apiLogGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.apiLogGridView.AutoGenerateColumns = false;
            this.apiLogGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.apiLogGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.apiLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apiLogGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.CoinName,
            this.requestDataGridViewTextBoxColumn,
            this.responseDataGridViewTextBoxColumn});
            this.apiLogGridView.DataSource = this.apiLogEntryBindingSource;
            this.apiLogGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apiLogGridView.Location = new System.Drawing.Point(3, 3);
            this.apiLogGridView.Name = "apiLogGridView";
            this.apiLogGridView.RowHeadersVisible = false;
            this.apiLogGridView.Size = new System.Drawing.Size(1073, 69);
            this.apiLogGridView.TabIndex = 13;
            // 
            // CoinName
            // 
            this.CoinName.DataPropertyName = "CoinName";
            this.CoinName.HeaderText = "Coin Name";
            this.CoinName.Name = "CoinName";
            this.CoinName.ReadOnly = true;
            // 
            // processLogPage
            // 
            this.processLogPage.Controls.Add(this.dataGridView1);
            this.processLogPage.ImageIndex = 1;
            this.processLogPage.Location = new System.Drawing.Point(4, 23);
            this.processLogPage.Name = "processLogPage";
            this.processLogPage.Padding = new System.Windows.Forms.Padding(3);
            this.processLogPage.Size = new System.Drawing.Size(1079, 75);
            this.processLogPage.TabIndex = 1;
            this.processLogPage.Text = "Process Log";
            this.processLogPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.executablePathDataGridViewTextBoxColumn,
            this.argumentsDataGridViewTextBoxColumn,
            this.Reason});
            this.dataGridView1.DataSource = this.logLaunchArgsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 69);
            this.dataGridView1.TabIndex = 14;
            // 
            // dateTimeDataGridViewTextBoxColumn1
            // 
            this.dateTimeDataGridViewTextBoxColumn1.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn1.HeaderText = "Date/Time";
            this.dateTimeDataGridViewTextBoxColumn1.Name = "dateTimeDataGridViewTextBoxColumn1";
            this.dateTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CoinName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Coin Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // executablePathDataGridViewTextBoxColumn
            // 
            this.executablePathDataGridViewTextBoxColumn.DataPropertyName = "ExecutablePath";
            this.executablePathDataGridViewTextBoxColumn.HeaderText = "Executable Path";
            this.executablePathDataGridViewTextBoxColumn.Name = "executablePathDataGridViewTextBoxColumn";
            this.executablePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.executablePathDataGridViewTextBoxColumn.Width = 250;
            // 
            // argumentsDataGridViewTextBoxColumn
            // 
            this.argumentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.argumentsDataGridViewTextBoxColumn.DataPropertyName = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.HeaderText = "Arguments";
            this.argumentsDataGridViewTextBoxColumn.Name = "argumentsDataGridViewTextBoxColumn";
            this.argumentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // logLaunchArgsBindingSource
            // 
            this.logLaunchArgsBindingSource.DataSource = typeof(Xgminer.LogLaunchArgs);
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.historyGridView);
            this.historyPage.ImageIndex = 2;
            this.historyPage.Location = new System.Drawing.Point(4, 23);
            this.historyPage.Name = "historyPage";
            this.historyPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyPage.Size = new System.Drawing.Size(1079, 75);
            this.historyPage.TabIndex = 2;
            this.historyPage.Text = "History";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // historyGridView
            // 
            this.historyGridView.AllowUserToAddRows = false;
            this.historyGridView.AllowUserToDeleteRows = false;
            this.historyGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.historyGridView.AutoGenerateColumns = false;
            this.historyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.historyGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.startPriceColumn,
            this.endPriceColumn,
            this.AcceptedShares,
            this.durationColumn,
            this.devicesColumn});
            this.historyGridView.DataSource = this.logProcessCloseArgsBindingSource;
            this.historyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyGridView.Location = new System.Drawing.Point(3, 3);
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.ReadOnly = true;
            this.historyGridView.RowHeadersVisible = false;
            this.historyGridView.Size = new System.Drawing.Size(1073, 69);
            this.historyGridView.TabIndex = 0;
            this.historyGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.historyGridView_RowsAdded);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Start Date/Time";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "End Date/Time";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CoinName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Coin Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CoinSymbol";
            this.dataGridViewTextBoxColumn11.FillWeight = 80F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Coin Symbol";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // startPriceColumn
            // 
            this.startPriceColumn.DataPropertyName = "StartPrice";
            this.startPriceColumn.HeaderText = "Start Price";
            this.startPriceColumn.Name = "startPriceColumn";
            this.startPriceColumn.ReadOnly = true;
            // 
            // endPriceColumn
            // 
            this.endPriceColumn.DataPropertyName = "EndPrice";
            this.endPriceColumn.HeaderText = "End Price";
            this.endPriceColumn.Name = "endPriceColumn";
            this.endPriceColumn.ReadOnly = true;
            // 
            // AcceptedShares
            // 
            this.AcceptedShares.DataPropertyName = "AcceptedShares";
            this.AcceptedShares.FillWeight = 85F;
            this.AcceptedShares.HeaderText = "Accepted Shares";
            this.AcceptedShares.Name = "AcceptedShares";
            this.AcceptedShares.ReadOnly = true;
            // 
            // durationColumn
            // 
            this.durationColumn.HeaderText = "Duration";
            this.durationColumn.Name = "durationColumn";
            this.durationColumn.ReadOnly = true;
            // 
            // devicesColumn
            // 
            this.devicesColumn.FillWeight = 120F;
            this.devicesColumn.HeaderText = "Devices";
            this.devicesColumn.Name = "devicesColumn";
            this.devicesColumn.ReadOnly = true;
            // 
            // logProcessCloseArgsBindingSource
            // 
            this.logProcessCloseArgsBindingSource.DataSource = typeof(MultiMiner.Engine.LogProcessCloseArgs);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "network_application.png");
            this.imageList1.Images.SetKeyName(1, "window_text.png");
            this.imageList1.Images.SetKeyName(2, "history.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeApiButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 28);
            this.panel2.TabIndex = 14;
            // 
            // closeApiButton
            // 
            this.closeApiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeApiButton.Location = new System.Drawing.Point(1059, 1);
            this.closeApiButton.Name = "closeApiButton";
            this.closeApiButton.Size = new System.Drawing.Size(25, 23);
            this.closeApiButton.TabIndex = 0;
            this.closeApiButton.Text = "X";
            this.closeApiButton.UseVisualStyleBackColor = true;
            this.closeApiButton.Click += new System.EventHandler(this.closeApiButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifyIconMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MultiMiner - Stopped";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // notifyIconMenuStrip
            // 
            this.notifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenuItem,
            this.stopMenuItem,
            this.toolStripSeparator4,
            this.showAppMenuItem,
            this.quitAppMenuItem});
            this.notifyIconMenuStrip.Name = "contextMenuStrip1";
            this.notifyIconMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.notifyIconMenuStrip.Size = new System.Drawing.Size(104, 98);
            // 
            // startMenuItem
            // 
            this.startMenuItem.Image = global::MultiMiner.Win.Properties.Resources.computer_control_play;
            this.startMenuItem.Name = "startMenuItem";
            this.startMenuItem.Size = new System.Drawing.Size(103, 22);
            this.startMenuItem.Text = "Start";
            this.startMenuItem.Click += new System.EventHandler(this.startMenuItem_Click);
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Image = global::MultiMiner.Win.Properties.Resources.computer_control_stop;
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(103, 22);
            this.stopMenuItem.Text = "Stop";
            this.stopMenuItem.Click += new System.EventHandler(this.stopMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(100, 6);
            // 
            // showAppMenuItem
            // 
            this.showAppMenuItem.Image = global::MultiMiner.Win.Properties.Resources.application;
            this.showAppMenuItem.Name = "showAppMenuItem";
            this.showAppMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showAppMenuItem.Text = "Show";
            this.showAppMenuItem.Click += new System.EventHandler(this.showAppMenuItem_Click);
            // 
            // quitAppMenuItem
            // 
            this.quitAppMenuItem.Image = global::MultiMiner.Win.Properties.Resources.application_delete;
            this.quitAppMenuItem.Name = "quitAppMenuItem";
            this.quitAppMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitAppMenuItem.Text = "Quit";
            this.quitAppMenuItem.Click += new System.EventHandler(this.quitAppMenuItem_Click);
            // 
            // mobileMinerTimer
            // 
            this.mobileMinerTimer.Enabled = true;
            this.mobileMinerTimer.Interval = 15000;
            this.mobileMinerTimer.Tick += new System.EventHandler(this.mobileMinerTimer_Tick);
            // 
            // updateCheckTimer
            // 
            this.updateCheckTimer.Interval = 3600000;
            this.updateCheckTimer.Tick += new System.EventHandler(this.updateCheckTimer_Tick);
            // 
            // idleTimer
            // 
            this.idleTimer.Interval = 10000;
            this.idleTimer.Tick += new System.EventHandler(this.idleTimer_Tick);
            // 
            // restartTimer
            // 
            this.restartTimer.Tick += new System.EventHandler(this.restartTimer_Tick);
            // 
            // minerSummaryTimer
            // 
            this.minerSummaryTimer.Interval = 60000;
            this.minerSummaryTimer.Tick += new System.EventHandler(this.minerSummaryTimer_Tick);
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date/Time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestDataGridViewTextBoxColumn
            // 
            this.requestDataGridViewTextBoxColumn.DataPropertyName = "Request";
            this.requestDataGridViewTextBoxColumn.HeaderText = "Request";
            this.requestDataGridViewTextBoxColumn.Name = "requestDataGridViewTextBoxColumn";
            this.requestDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestDataGridViewTextBoxColumn.Width = 125;
            // 
            // responseDataGridViewTextBoxColumn
            // 
            this.responseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
            this.responseDataGridViewTextBoxColumn.HeaderText = "Response";
            this.responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
            this.responseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apiLogEntryBindingSource
            // 
            this.apiLogEntryBindingSource.DataSource = typeof(MultiMiner.Win.ApiLogEntry);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 488);
            this.Controls.Add(this.startupMiningPanel);
            this.Controls.Add(this.advancedAreaContainer);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MultiMiner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.startupMiningPanel.ResumeLayout(false);
            this.startupMiningPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.advancedAreaContainer.Panel1.ResumeLayout(false);
            this.advancedAreaContainer.Panel2.ResumeLayout(false);
            this.advancedAreaContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.advancedTabControl.ResumeLayout(false);
            this.apiMonitorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apiLogGridView)).EndInit();
            this.processLogPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLaunchArgsBindingSource)).EndInit();
            this.historyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logProcessCloseArgsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.notifyIconMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apiLogEntryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.Timer deviceStatsTimer;
        private System.Windows.Forms.Timer coinStatsTimer;
        private System.Windows.Forms.Timer startupMiningCountdownTimer;
        private System.Windows.Forms.Panel startupMiningPanel;
        private System.Windows.Forms.Button cancelStartupMiningButton;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Timer crashRecoveryTimer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripSeparator saveSeparator;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sha256RateLabel;
        private System.Windows.Forms.ToolStripStatusLabel scryptRateLabel;
        private System.Windows.Forms.ToolStripStatusLabel backendLabel;
        private System.Windows.Forms.ToolStripStatusLabel strategiesLabel;
        private System.Windows.Forms.ToolStripStatusLabel strategyCountdownLabel;
        private System.Windows.Forms.Timer coinStatsCountdownTimer;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label coinChooseSuffixLabel;
        private System.Windows.Forms.LinkLabel coinChooseLinkLabel;
        private System.Windows.Forms.Label coinChoosePrefixLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label coinStatsLabel;
        private System.Windows.Forms.SplitContainer advancedAreaContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeApiButton;
        private System.Windows.Forms.BindingSource apiLogEntryBindingSource;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showAppMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitAppMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem startMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
        private System.Windows.Forms.ToolStripButton desktopModeButton;
        private System.Windows.Forms.Timer mobileMinerTimer;
        private System.Windows.Forms.ToolStripDropDownButton advancedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apiMonitorButton;
        private System.Windows.Forms.ToolStripMenuItem detectDevicesButton;
        private System.Windows.Forms.ToolStripMenuItem processLogButton;
        private System.Windows.Forms.TabControl advancedTabControl;
        private System.Windows.Forms.TabPage apiMonitorPage;
        private System.Windows.Forms.DataGridView apiLogGridView;
        private System.Windows.Forms.TabPage processLogPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource logLaunchArgsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem historyButton;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.BindingSource logProcessCloseArgsBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coinNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coinSymbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoinName;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn executablePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.ToolStripMenuItem quickSwitchItem;
        private System.Windows.Forms.ToolStripMenuItem dummyToolStripMenuItem;
        private System.Windows.Forms.Timer updateCheckTimer;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.ToolStripStatusLabel deviceTotalLabel;
        private System.Windows.Forms.Timer idleTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripSplitButton settingsButton;
        private System.Windows.Forms.ToolStripMenuItem coinsButton;
        private System.Windows.Forms.ToolStripMenuItem strategiesButton;
        private System.Windows.Forms.DataGridView deviceGridView;
        private System.Windows.Forms.Timer restartTimer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn coinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitabilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intensityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptedShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicesColumn;
        private System.Windows.Forms.Timer minerSummaryTimer;
    }
}

