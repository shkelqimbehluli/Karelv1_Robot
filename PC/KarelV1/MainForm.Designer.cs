﻿namespace KarelV1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPorts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMQTT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnectToMqtt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisconnectFromMqtt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRunProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResumeProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStopProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSonar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveDiagram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAsCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAsXML = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearUltrasonic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearInfrared = new System.Windows.Forms.ToolStripMenuItem();
            this.speachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statBar = new System.Windows.Forms.StatusStrip();
            this.lblIsConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblControls = new System.Windows.Forms.TableLayoutPanel();
            this.txtState = new System.Windows.Forms.TextBox();
            this.gpbControls = new System.Windows.Forms.GroupBox();
            this.tbPhase = new System.Windows.Forms.TextBox();
            this.tbDistande = new System.Windows.Forms.TextBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.tcRobotFunctions = new System.Windows.Forms.TabControl();
            this.tbpSonar = new System.Windows.Forms.TabPage();
            this.tlpSonar = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSonar = new System.Windows.Forms.Panel();
            this.cbMetric = new System.Windows.Forms.ComboBox();
            this.lblDegreeSensor = new System.Windows.Forms.Label();
            this.tbSensorPosition = new System.Windows.Forms.TextBox();
            this.btnGetUltrasonic = new System.Windows.Forms.Button();
            this.crtUltrasinicSensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpProgram = new System.Windows.Forms.TabPage();
            this.tlpMainProgram = new System.Windows.Forms.TableLayoutPanel();
            this.tlpProgram = new System.Windows.Forms.TableLayoutPanel();
            this.pbTerrain = new System.Windows.Forms.PictureBox();
            this.pnlTrajectory = new System.Windows.Forms.Panel();
            this.btnReadSonar = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnResumeProgram = new System.Windows.Forms.Button();
            this.btnStopProgram = new System.Windows.Forms.Button();
            this.btnRunProgram = new System.Windows.Forms.Button();
            this.gbTrajectoryMode = new System.Windows.Forms.GroupBox();
            this.rbDefinePoints = new System.Windows.Forms.RadioButton();
            this.rbRecord = new System.Windows.Forms.RadioButton();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepsPerSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.statBar.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tblControls.SuspendLayout();
            this.gpbControls.SuspendLayout();
            this.tcRobotFunctions.SuspendLayout();
            this.tbpSonar.SuspendLayout();
            this.tlpSonar.SuspendLayout();
            this.pnlSonar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtUltrasinicSensor)).BeginInit();
            this.tbpProgram.SuspendLayout();
            this.tlpMainProgram.SuspendLayout();
            this.tlpProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTerrain)).BeginInit();
            this.pnlTrajectory.SuspendLayout();
            this.gbTrajectoryMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiConnection,
            this.programToolStripMenuItem,
            this.tsmiSonar,
            this.speachToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1335, 28);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "File";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(161, 26);
            this.tsmiSettings.Text = "Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiExit.Size = new System.Drawing.Size(161, 26);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiConnection
            // 
            this.tsmiConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPorts,
            this.tsmiMQTT,
            this.tsSeparator1,
            this.tsmiReset});
            this.tsmiConnection.Name = "tsmiConnection";
            this.tsmiConnection.Size = new System.Drawing.Size(96, 24);
            this.tsmiConnection.Text = "Connection";
            this.tsmiConnection.Click += new System.EventHandler(this.tsmiConnection_Click);
            // 
            // tsmiPorts
            // 
            this.tsmiPorts.Name = "tsmiPorts";
            this.tsmiPorts.Size = new System.Drawing.Size(123, 26);
            this.tsmiPorts.Text = "Ports";
            // 
            // tsmiMQTT
            // 
            this.tsmiMQTT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnectToMqtt,
            this.tsmiDisconnectFromMqtt});
            this.tsmiMQTT.Name = "tsmiMQTT";
            this.tsmiMQTT.Size = new System.Drawing.Size(123, 26);
            this.tsmiMQTT.Text = "MQTT";
            // 
            // tsmiConnectToMqtt
            // 
            this.tsmiConnectToMqtt.Name = "tsmiConnectToMqtt";
            this.tsmiConnectToMqtt.Size = new System.Drawing.Size(157, 26);
            this.tsmiConnectToMqtt.Text = "Connect";
            this.tsmiConnectToMqtt.Click += new System.EventHandler(this.tsmiConnectToMqtt_Click);
            // 
            // tsmiDisconnectFromMqtt
            // 
            this.tsmiDisconnectFromMqtt.Name = "tsmiDisconnectFromMqtt";
            this.tsmiDisconnectFromMqtt.Size = new System.Drawing.Size(157, 26);
            this.tsmiDisconnectFromMqtt.Text = "Disconnect";
            this.tsmiDisconnectFromMqtt.Click += new System.EventHandler(this.tsmiDisconnectFromMqtt_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(123, 26);
            this.tsmiReset.Text = "Reset";
            this.tsmiReset.Click += new System.EventHandler(this.tsmiReset_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveProgram,
            this.tsmiLoadProgram,
            this.toolStripSeparator2,
            this.tsmiRunProgram,
            this.tsmiResumeProgram,
            this.tsmiStopProgram});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // tsmiSaveProgram
            // 
            this.tsmiSaveProgram.Name = "tsmiSaveProgram";
            this.tsmiSaveProgram.Size = new System.Drawing.Size(136, 26);
            this.tsmiSaveProgram.Text = "Save";
            this.tsmiSaveProgram.Click += new System.EventHandler(this.tsmiSaveProgram_Click);
            // 
            // tsmiLoadProgram
            // 
            this.tsmiLoadProgram.Name = "tsmiLoadProgram";
            this.tsmiLoadProgram.Size = new System.Drawing.Size(136, 26);
            this.tsmiLoadProgram.Text = "Load";
            this.tsmiLoadProgram.Click += new System.EventHandler(this.tsmiLoadProgram_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiRunProgram
            // 
            this.tsmiRunProgram.Name = "tsmiRunProgram";
            this.tsmiRunProgram.Size = new System.Drawing.Size(136, 26);
            this.tsmiRunProgram.Text = "Run";
            this.tsmiRunProgram.Click += new System.EventHandler(this.tsmiRunProgram_Click);
            // 
            // tsmiResumeProgram
            // 
            this.tsmiResumeProgram.Name = "tsmiResumeProgram";
            this.tsmiResumeProgram.Size = new System.Drawing.Size(136, 26);
            this.tsmiResumeProgram.Text = "Resume";
            this.tsmiResumeProgram.Click += new System.EventHandler(this.tsmiResumeProgram_Click);
            // 
            // tsmiStopProgram
            // 
            this.tsmiStopProgram.Name = "tsmiStopProgram";
            this.tsmiStopProgram.Size = new System.Drawing.Size(136, 26);
            this.tsmiStopProgram.Text = "Stop";
            this.tsmiStopProgram.Click += new System.EventHandler(this.tsmiStopProgram_Click);
            // 
            // tsmiSonar
            // 
            this.tsmiSonar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveDiagram,
            this.clearToolStripMenuItem});
            this.tsmiSonar.Name = "tsmiSonar";
            this.tsmiSonar.Size = new System.Drawing.Size(59, 24);
            this.tsmiSonar.Text = "Sonar";
            // 
            // tsmiSaveDiagram
            // 
            this.tsmiSaveDiagram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAsCSV,
            this.tsmiAsXML});
            this.tsmiSaveDiagram.Name = "tsmiSaveDiagram";
            this.tsmiSaveDiagram.Size = new System.Drawing.Size(118, 26);
            this.tsmiSaveDiagram.Text = "Save";
            // 
            // tsmiAsCSV
            // 
            this.tsmiAsCSV.Name = "tsmiAsCSV";
            this.tsmiAsCSV.Size = new System.Drawing.Size(113, 26);
            this.tsmiAsCSV.Text = "CSV";
            this.tsmiAsCSV.Click += new System.EventHandler(this.tsmiAsCSV_Click);
            // 
            // tsmiAsXML
            // 
            this.tsmiAsXML.Name = "tsmiAsXML";
            this.tsmiAsXML.Size = new System.Drawing.Size(113, 26);
            this.tsmiAsXML.Text = "XML";
            this.tsmiAsXML.Click += new System.EventHandler(this.tsmiAsXML_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearAll,
            this.tsmiClearUltrasonic,
            this.tsmiClearInfrared});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // tsmiClearAll
            // 
            this.tsmiClearAll.Name = "tsmiClearAll";
            this.tsmiClearAll.Size = new System.Drawing.Size(145, 26);
            this.tsmiClearAll.Text = "All";
            this.tsmiClearAll.Click += new System.EventHandler(this.tsmiClearAll_Click);
            // 
            // tsmiClearUltrasonic
            // 
            this.tsmiClearUltrasonic.Name = "tsmiClearUltrasonic";
            this.tsmiClearUltrasonic.Size = new System.Drawing.Size(145, 26);
            this.tsmiClearUltrasonic.Text = "Ultasonic";
            // 
            // tsmiClearInfrared
            // 
            this.tsmiClearInfrared.Name = "tsmiClearInfrared";
            this.tsmiClearInfrared.Size = new System.Drawing.Size(145, 26);
            this.tsmiClearInfrared.Text = "Infrared";
            // 
            // speachToolStripMenuItem
            // 
            this.speachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.talkToolStripMenuItem1});
            this.speachToolStripMenuItem.Name = "speachToolStripMenuItem";
            this.speachToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.speachToolStripMenuItem.Text = "Speach";
            // 
            // talkToolStripMenuItem1
            // 
            this.talkToolStripMenuItem1.Name = "talkToolStripMenuItem1";
            this.talkToolStripMenuItem1.Size = new System.Drawing.Size(109, 26);
            this.talkToolStripMenuItem1.Text = "Talk";
            this.talkToolStripMenuItem1.Click += new System.EventHandler(this.talkToolStripMenuItem1_Click);
            // 
            // statBar
            // 
            this.statBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblIsConnected});
            this.statBar.Location = new System.Drawing.Point(0, 637);
            this.statBar.Name = "statBar";
            this.statBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statBar.Size = new System.Drawing.Size(1335, 25);
            this.statBar.TabIndex = 12;
            this.statBar.Text = "statusStrip1";
            // 
            // lblIsConnected
            // 
            this.lblIsConnected.Name = "lblIsConnected";
            this.lblIsConnected.Size = new System.Drawing.Size(119, 20);
            this.lblIsConnected.Text = "Connected: False";
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblControls, 0, 0);
            this.tblMain.Controls.Add(this.tcRobotFunctions, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 28);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1335, 609);
            this.tblMain.TabIndex = 14;
            // 
            // tblControls
            // 
            this.tblControls.ColumnCount = 1;
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tblControls.Controls.Add(this.txtState, 0, 1);
            this.tblControls.Controls.Add(this.gpbControls, 0, 0);
            this.tblControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblControls.Location = new System.Drawing.Point(4, 4);
            this.tblControls.Margin = new System.Windows.Forms.Padding(4);
            this.tblControls.Name = "tblControls";
            this.tblControls.RowCount = 2;
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControls.Size = new System.Drawing.Size(322, 601);
            this.tblControls.TabIndex = 0;
            // 
            // txtState
            // 
            this.txtState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtState.Location = new System.Drawing.Point(4, 334);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtState.Size = new System.Drawing.Size(322, 263);
            this.txtState.TabIndex = 7;
            // 
            // gpbControls
            // 
            this.gpbControls.Controls.Add(this.tbPhase);
            this.gpbControls.Controls.Add(this.tbDistande);
            this.gpbControls.Controls.Add(this.lblPhase);
            this.gpbControls.Controls.Add(this.lblDistance);
            this.gpbControls.Controls.Add(this.btnRight);
            this.gpbControls.Controls.Add(this.btnStop);
            this.gpbControls.Controls.Add(this.btnBackward);
            this.gpbControls.Controls.Add(this.btnLeft);
            this.gpbControls.Controls.Add(this.btnForward);
            this.gpbControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpbControls.Location = new System.Drawing.Point(4, 4);
            this.gpbControls.Margin = new System.Windows.Forms.Padding(4);
            this.gpbControls.Name = "gpbControls";
            this.gpbControls.Padding = new System.Windows.Forms.Padding(4);
            this.gpbControls.Size = new System.Drawing.Size(322, 322);
            this.gpbControls.TabIndex = 0;
            this.gpbControls.TabStop = false;
            this.gpbControls.Text = "Controls";
            // 
            // tbPhase
            // 
            this.tbPhase.Location = new System.Drawing.Point(250, 55);
            this.tbPhase.Name = "tbPhase";
            this.tbPhase.Size = new System.Drawing.Size(65, 26);
            this.tbPhase.TabIndex = 22;
            this.tbPhase.Text = "90";
            // 
            // tbDistande
            // 
            this.tbDistande.Location = new System.Drawing.Point(250, 23);
            this.tbDistande.Name = "tbDistande";
            this.tbDistande.Size = new System.Drawing.Size(65, 26);
            this.tbDistande.TabIndex = 21;
            this.tbDistande.Text = "10";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(218, 58);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(27, 20);
            this.lblPhase.TabIndex = 20;
            this.lblPhase.Text = "P:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(218, 26);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(29, 20);
            this.lblDistance.TabIndex = 19;
            this.lblDistance.Text = "D:";
            // 
            // btnRight
            // 
            this.btnRight.Image = global::KarelV1.Images.ArrowRight;
            this.btnRight.Location = new System.Drawing.Point(219, 121);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(97, 90);
            this.btnRight.TabIndex = 18;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::KarelV1.Images.Stop;
            this.btnStop.Location = new System.Drawing.Point(113, 121);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 90);
            this.btnStop.TabIndex = 17;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Image = global::KarelV1.Images.ArrowDown;
            this.btnBackward.Location = new System.Drawing.Point(113, 218);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(97, 90);
            this.btnBackward.TabIndex = 16;
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::KarelV1.Images.ArrowLeft;
            this.btnLeft.Location = new System.Drawing.Point(8, 121);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(97, 90);
            this.btnLeft.TabIndex = 15;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = global::KarelV1.Images.ArrowUp;
            this.btnForward.Location = new System.Drawing.Point(113, 23);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(97, 90);
            this.btnForward.TabIndex = 14;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // tcRobotFunctions
            // 
            this.tcRobotFunctions.Controls.Add(this.tbpSonar);
            this.tcRobotFunctions.Controls.Add(this.tbpProgram);
            this.tcRobotFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcRobotFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcRobotFunctions.Location = new System.Drawing.Point(334, 4);
            this.tcRobotFunctions.Margin = new System.Windows.Forms.Padding(4);
            this.tcRobotFunctions.Name = "tcRobotFunctions";
            this.tcRobotFunctions.SelectedIndex = 0;
            this.tcRobotFunctions.Size = new System.Drawing.Size(997, 601);
            this.tcRobotFunctions.TabIndex = 1;
            // 
            // tbpSonar
            // 
            this.tbpSonar.Controls.Add(this.tlpSonar);
            this.tbpSonar.Location = new System.Drawing.Point(4, 29);
            this.tbpSonar.Margin = new System.Windows.Forms.Padding(4);
            this.tbpSonar.Name = "tbpSonar";
            this.tbpSonar.Padding = new System.Windows.Forms.Padding(4);
            this.tbpSonar.Size = new System.Drawing.Size(989, 568);
            this.tbpSonar.TabIndex = 0;
            this.tbpSonar.Text = "Sonar";
            this.tbpSonar.UseVisualStyleBackColor = true;
            // 
            // tlpSonar
            // 
            this.tlpSonar.ColumnCount = 2;
            this.tlpSonar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSonar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpSonar.Controls.Add(this.pnlSonar, 1, 0);
            this.tlpSonar.Controls.Add(this.crtUltrasinicSensor, 0, 0);
            this.tlpSonar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSonar.Location = new System.Drawing.Point(4, 4);
            this.tlpSonar.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSonar.Name = "tlpSonar";
            this.tlpSonar.RowCount = 1;
            this.tlpSonar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSonar.Size = new System.Drawing.Size(981, 560);
            this.tlpSonar.TabIndex = 12;
            // 
            // pnlSonar
            // 
            this.pnlSonar.Controls.Add(this.cbMetric);
            this.pnlSonar.Controls.Add(this.lblDegreeSensor);
            this.pnlSonar.Controls.Add(this.tbSensorPosition);
            this.pnlSonar.Controls.Add(this.btnGetUltrasonic);
            this.pnlSonar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSonar.Location = new System.Drawing.Point(865, 4);
            this.pnlSonar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSonar.Name = "pnlSonar";
            this.pnlSonar.Size = new System.Drawing.Size(112, 552);
            this.pnlSonar.TabIndex = 13;
            // 
            // cbMetric
            // 
            this.cbMetric.FormattingEnabled = true;
            this.cbMetric.Location = new System.Drawing.Point(3, 134);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(98, 28);
            this.cbMetric.TabIndex = 27;
            // 
            // lblDegreeSensor
            // 
            this.lblDegreeSensor.AutoSize = true;
            this.lblDegreeSensor.Location = new System.Drawing.Point(50, 104);
            this.lblDegreeSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDegreeSensor.Name = "lblDegreeSensor";
            this.lblDegreeSensor.Size = new System.Drawing.Size(51, 20);
            this.lblDegreeSensor.TabIndex = 26;
            this.lblDegreeSensor.Text = "[deg]";
            // 
            // tbSensorPosition
            // 
            this.tbSensorPosition.Location = new System.Drawing.Point(4, 101);
            this.tbSensorPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tbSensorPosition.Name = "tbSensorPosition";
            this.tbSensorPosition.Size = new System.Drawing.Size(38, 26);
            this.tbSensorPosition.TabIndex = 25;
            this.tbSensorPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSensorPosition_KeyPress);
            // 
            // btnGetUltrasonic
            // 
            this.btnGetUltrasonic.Image = global::KarelV1.Images.Sensor2;
            this.btnGetUltrasonic.Location = new System.Drawing.Point(4, 4);
            this.btnGetUltrasonic.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetUltrasonic.Name = "btnGetUltrasonic";
            this.btnGetUltrasonic.Size = new System.Drawing.Size(97, 90);
            this.btnGetUltrasonic.TabIndex = 24;
            this.btnGetUltrasonic.UseVisualStyleBackColor = true;
            this.btnGetUltrasonic.Click += new System.EventHandler(this.btnGetUltrasonic_Click);
            // 
            // crtUltrasinicSensor
            // 
            this.crtUltrasinicSensor.BackColor = System.Drawing.Color.Transparent;
            this.crtUltrasinicSensor.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.crtUltrasinicSensor.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Name = "ChartArea1";
            this.crtUltrasinicSensor.ChartAreas.Add(chartArea1);
            this.crtUltrasinicSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.crtUltrasinicSensor.Legends.Add(legend1);
            this.crtUltrasinicSensor.Location = new System.Drawing.Point(3, 3);
            this.crtUltrasinicSensor.Name = "crtUltrasinicSensor";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series1.BackSecondaryColor = System.Drawing.Color.Black;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.Name = "Ultrasonic Sensor";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series2.Legend = "Legend1";
            series2.Name = "Infrared";
            this.crtUltrasinicSensor.Series.Add(series1);
            this.crtUltrasinicSensor.Series.Add(series2);
            this.crtUltrasinicSensor.Size = new System.Drawing.Size(855, 554);
            this.crtUltrasinicSensor.TabIndex = 14;
            this.crtUltrasinicSensor.Text = "Sonar";
            // 
            // tbpProgram
            // 
            this.tbpProgram.BackColor = System.Drawing.SystemColors.Control;
            this.tbpProgram.Controls.Add(this.tlpMainProgram);
            this.tbpProgram.Location = new System.Drawing.Point(4, 29);
            this.tbpProgram.Name = "tbpProgram";
            this.tbpProgram.Size = new System.Drawing.Size(989, 568);
            this.tbpProgram.TabIndex = 3;
            this.tbpProgram.Text = "Program";
            // 
            // tlpMainProgram
            // 
            this.tlpMainProgram.ColumnCount = 1;
            this.tlpMainProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainProgram.Controls.Add(this.tlpProgram, 0, 0);
            this.tlpMainProgram.Controls.Add(this.dgvPositions, 0, 1);
            this.tlpMainProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainProgram.Location = new System.Drawing.Point(0, 0);
            this.tlpMainProgram.Name = "tlpMainProgram";
            this.tlpMainProgram.RowCount = 2;
            this.tlpMainProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpMainProgram.Size = new System.Drawing.Size(989, 568);
            this.tlpMainProgram.TabIndex = 1;
            // 
            // tlpProgram
            // 
            this.tlpProgram.ColumnCount = 2;
            this.tlpProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tlpProgram.Controls.Add(this.pbTerrain, 0, 0);
            this.tlpProgram.Controls.Add(this.pnlTrajectory, 1, 0);
            this.tlpProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProgram.Location = new System.Drawing.Point(3, 3);
            this.tlpProgram.Name = "tlpProgram";
            this.tlpProgram.RowCount = 1;
            this.tlpProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgram.Size = new System.Drawing.Size(983, 444);
            this.tlpProgram.TabIndex = 1;
            // 
            // pbTerrain
            // 
            this.pbTerrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTerrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTerrain.Location = new System.Drawing.Point(3, 3);
            this.pbTerrain.Name = "pbTerrain";
            this.pbTerrain.Size = new System.Drawing.Size(749, 438);
            this.pbTerrain.TabIndex = 0;
            this.pbTerrain.TabStop = false;
            // 
            // pnlTrajectory
            // 
            this.pnlTrajectory.Controls.Add(this.btnReadSonar);
            this.pnlTrajectory.Controls.Add(this.btnCapture);
            this.pnlTrajectory.Controls.Add(this.btnResumeProgram);
            this.pnlTrajectory.Controls.Add(this.btnStopProgram);
            this.pnlTrajectory.Controls.Add(this.btnRunProgram);
            this.pnlTrajectory.Controls.Add(this.gbTrajectoryMode);
            this.pnlTrajectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrajectory.Location = new System.Drawing.Point(758, 3);
            this.pnlTrajectory.Name = "pnlTrajectory";
            this.pnlTrajectory.Size = new System.Drawing.Size(222, 438);
            this.pnlTrajectory.TabIndex = 1;
            // 
            // btnReadSonar
            // 
            this.btnReadSonar.Image = global::KarelV1.Images.Sensor2;
            this.btnReadSonar.Location = new System.Drawing.Point(113, 208);
            this.btnReadSonar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadSonar.Name = "btnReadSonar";
            this.btnReadSonar.Size = new System.Drawing.Size(97, 90);
            this.btnReadSonar.TabIndex = 25;
            this.btnReadSonar.UseVisualStyleBackColor = true;
            this.btnReadSonar.Click += new System.EventHandler(this.btnReadSonar_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Image = global::KarelV1.Images.Capture;
            this.btnCapture.Location = new System.Drawing.Point(113, 110);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(97, 90);
            this.btnCapture.TabIndex = 20;
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnResumeProgram
            // 
            this.btnResumeProgram.Location = new System.Drawing.Point(9, 173);
            this.btnResumeProgram.Name = "btnResumeProgram";
            this.btnResumeProgram.Size = new System.Drawing.Size(97, 58);
            this.btnResumeProgram.TabIndex = 4;
            this.btnResumeProgram.Text = "Resume";
            this.btnResumeProgram.UseVisualStyleBackColor = true;
            this.btnResumeProgram.Click += new System.EventHandler(this.btnResumeProgram_Click);
            // 
            // btnStopProgram
            // 
            this.btnStopProgram.Location = new System.Drawing.Point(9, 237);
            this.btnStopProgram.Name = "btnStopProgram";
            this.btnStopProgram.Size = new System.Drawing.Size(97, 58);
            this.btnStopProgram.TabIndex = 3;
            this.btnStopProgram.Text = "Stop";
            this.btnStopProgram.UseVisualStyleBackColor = true;
            this.btnStopProgram.Click += new System.EventHandler(this.btnStopProgram_Click);
            // 
            // btnRunProgram
            // 
            this.btnRunProgram.Location = new System.Drawing.Point(9, 109);
            this.btnRunProgram.Name = "btnRunProgram";
            this.btnRunProgram.Size = new System.Drawing.Size(97, 58);
            this.btnRunProgram.TabIndex = 2;
            this.btnRunProgram.Text = "Run";
            this.btnRunProgram.UseVisualStyleBackColor = true;
            this.btnRunProgram.Click += new System.EventHandler(this.btnRunProgram_Click);
            // 
            // gbTrajectoryMode
            // 
            this.gbTrajectoryMode.Controls.Add(this.rbDefinePoints);
            this.gbTrajectoryMode.Controls.Add(this.rbRecord);
            this.gbTrajectoryMode.Location = new System.Drawing.Point(3, 5);
            this.gbTrajectoryMode.Name = "gbTrajectoryMode";
            this.gbTrajectoryMode.Size = new System.Drawing.Size(216, 98);
            this.gbTrajectoryMode.TabIndex = 1;
            this.gbTrajectoryMode.TabStop = false;
            this.gbTrajectoryMode.Text = "Modes";
            // 
            // rbDefinePoints
            // 
            this.rbDefinePoints.AutoSize = true;
            this.rbDefinePoints.Location = new System.Drawing.Point(6, 25);
            this.rbDefinePoints.Name = "rbDefinePoints";
            this.rbDefinePoints.Size = new System.Drawing.Size(144, 24);
            this.rbDefinePoints.TabIndex = 1;
            this.rbDefinePoints.TabStop = true;
            this.rbDefinePoints.Text = "Define Points";
            this.rbDefinePoints.UseVisualStyleBackColor = true;
            this.rbDefinePoints.CheckedChanged += new System.EventHandler(this.rbDefinePoints_CheckedChanged);
            // 
            // rbRecord
            // 
            this.rbRecord.AutoSize = true;
            this.rbRecord.Location = new System.Drawing.Point(6, 55);
            this.rbRecord.Name = "rbRecord";
            this.rbRecord.Size = new System.Drawing.Size(152, 24);
            this.rbRecord.TabIndex = 0;
            this.rbRecord.TabStop = true;
            this.rbRecord.Text = "Record Motion";
            this.rbRecord.UseVisualStyleBackColor = true;
            this.rbRecord.CheckedChanged += new System.EventHandler(this.rbRecord_CheckedChanged);
            // 
            // dgvPositions
            // 
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Alpha,
            this.Distance,
            this.StepsPerSeconds,
            this.XPos,
            this.YPos});
            this.dgvPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPositions.Location = new System.Drawing.Point(3, 453);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.RowTemplate.Height = 24;
            this.dgvPositions.Size = new System.Drawing.Size(983, 112);
            this.dgvPositions.TabIndex = 2;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            // 
            // Alpha
            // 
            this.Alpha.HeaderText = "Alpha";
            this.Alpha.Name = "Alpha";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            // 
            // StepsPerSeconds
            // 
            this.StepsPerSeconds.HeaderText = "Steps Per Seconds";
            this.StepsPerSeconds.Name = "StepsPerSeconds";
            this.StepsPerSeconds.Width = 200;
            // 
            // XPos
            // 
            this.XPos.HeaderText = "XPos";
            this.XPos.Name = "XPos";
            // 
            // YPos
            // 
            this.YPos.HeaderText = "YPos";
            this.YPos.Name = "YPos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 662);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.statBar);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "KarelV1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statBar.ResumeLayout(false);
            this.statBar.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblControls.ResumeLayout(false);
            this.tblControls.PerformLayout();
            this.gpbControls.ResumeLayout(false);
            this.gpbControls.PerformLayout();
            this.tcRobotFunctions.ResumeLayout(false);
            this.tbpSonar.ResumeLayout(false);
            this.tlpSonar.ResumeLayout(false);
            this.pnlSonar.ResumeLayout(false);
            this.pnlSonar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtUltrasinicSensor)).EndInit();
            this.tbpProgram.ResumeLayout(false);
            this.tlpMainProgram.ResumeLayout(false);
            this.tlpProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTerrain)).EndInit();
            this.pnlTrajectory.ResumeLayout(false);
            this.gbTrajectoryMode.ResumeLayout(false);
            this.gbTrajectoryMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnection;
        private System.Windows.Forms.ToolStripMenuItem tsmiPorts;
        private System.Windows.Forms.StatusStrip statBar;
        private System.Windows.Forms.ToolStripStatusLabel lblIsConnected;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblControls;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.GroupBox gpbControls;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TabControl tcRobotFunctions;
        private System.Windows.Forms.TabPage tbpSonar;
        private System.Windows.Forms.TableLayoutPanel tlpSonar;
        private System.Windows.Forms.Panel pnlSonar;
        private System.Windows.Forms.Label lblDegreeSensor;
        private System.Windows.Forms.TextBox tbSensorPosition;
        private System.Windows.Forms.Button btnGetUltrasonic;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtUltrasinicSensor;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ComboBox cbMetric;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMQTT;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem speachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnectToMqtt;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisconnectFromMqtt;
        private System.Windows.Forms.ToolStripMenuItem tsmiSonar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveDiagram;
        private System.Windows.Forms.ToolStripMenuItem tsmiAsCSV;
        private System.Windows.Forms.ToolStripMenuItem tsmiAsXML;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearUltrasonic;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearInfrared;
        private System.Windows.Forms.TabPage tbpProgram;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveProgram;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadProgram;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiRunProgram;
        private System.Windows.Forms.ToolStripMenuItem tsmiResumeProgram;
        private System.Windows.Forms.ToolStripMenuItem tsmiStopProgram;
        private System.Windows.Forms.TextBox tbPhase;
        private System.Windows.Forms.TextBox tbDistande;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TableLayoutPanel tlpMainProgram;
        private System.Windows.Forms.TableLayoutPanel tlpProgram;
        private System.Windows.Forms.PictureBox pbTerrain;
        private System.Windows.Forms.Panel pnlTrajectory;
        private System.Windows.Forms.Button btnReadSonar;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnResumeProgram;
        private System.Windows.Forms.Button btnStopProgram;
        private System.Windows.Forms.Button btnRunProgram;
        private System.Windows.Forms.GroupBox gbTrajectoryMode;
        private System.Windows.Forms.RadioButton rbDefinePoints;
        private System.Windows.Forms.RadioButton rbRecord;
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepsPerSeconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn XPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn YPos;
    }
}

