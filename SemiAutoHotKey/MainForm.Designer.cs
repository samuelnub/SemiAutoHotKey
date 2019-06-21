namespace SemiAutoHotKey
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
            this.InputTypeLabel = new System.Windows.Forms.Label();
            this.TimelineLabel = new System.Windows.Forms.Label();
            this.UpTimelineButton = new System.Windows.Forms.Button();
            this.DownTimelineButton = new System.Windows.Forms.Button();
            this.RemoveTimelineButton = new System.Windows.Forms.Button();
            this.IntervalInput = new System.Windows.Forms.NumericUpDown();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ControlButton = new System.Windows.Forms.Button();
            this.InputTypeTabs = new System.Windows.Forms.TabControl();
            this.KeyCodeInputTab = new System.Windows.Forms.TabPage();
            this.HardwareKeyCodeTabCombo = new System.Windows.Forms.ComboBox();
            this.HardwareKeyCodeTabLabel = new System.Windows.Forms.Label();
            this.HardwareKeyCodeTabCheck = new System.Windows.Forms.CheckBox();
            this.SplitKeyCodeTabCheck = new System.Windows.Forms.CheckBox();
            this.KeyCodeTabLabel = new System.Windows.Forms.Label();
            this.KeyCodeTabCombo = new System.Windows.Forms.ComboBox();
            this.MouseInputTab = new System.Windows.Forms.TabPage();
            this.XIDMouseTabLabel = new System.Windows.Forms.Label();
            this.XIDMouseTabInput = new System.Windows.Forms.NumericUpDown();
            this.ScrollVertMouseTabInput = new System.Windows.Forms.NumericUpDown();
            this.ScrollHorMouseTabInput = new System.Windows.Forms.NumericUpDown();
            this.ScrollMouseTabLabel = new System.Windows.Forms.Label();
            this.MouseClickMouseTabCombo = new System.Windows.Forms.ComboBox();
            this.MouseClickMouseTabLabel = new System.Windows.Forms.Label();
            this.AbsoluteMouseTabCheck = new System.Windows.Forms.CheckBox();
            this.MoveYMouseTabInput = new System.Windows.Forms.NumericUpDown();
            this.MoveXMouseTabInput = new System.Windows.Forms.NumericUpDown();
            this.MoveMouseMouseTabLabel = new System.Windows.Forms.Label();
            this.StringInputTab = new System.Windows.Forms.TabPage();
            this.StringTabLabel = new System.Windows.Forms.Label();
            this.StringTabInput = new System.Windows.Forms.TextBox();
            this.DelayInputTab = new System.Windows.Forms.TabPage();
            this.DelayTabInput = new System.Windows.Forms.NumericUpDown();
            this.DelayTabLabel = new System.Windows.Forms.Label();
            this.AddInputButton = new System.Windows.Forms.Button();
            this.TimelineList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).BeginInit();
            this.statusGroup.SuspendLayout();
            this.InputTypeTabs.SuspendLayout();
            this.KeyCodeInputTab.SuspendLayout();
            this.MouseInputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XIDMouseTabInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollVertMouseTabInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollHorMouseTabInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveYMouseTabInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveXMouseTabInput)).BeginInit();
            this.StringInputTab.SuspendLayout();
            this.DelayInputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTabInput)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTypeLabel
            // 
            this.InputTypeLabel.AutoSize = true;
            this.InputTypeLabel.Location = new System.Drawing.Point(12, 12);
            this.InputTypeLabel.Name = "InputTypeLabel";
            this.InputTypeLabel.Size = new System.Drawing.Size(92, 13);
            this.InputTypeLabel.TabIndex = 1;
            this.InputTypeLabel.Text = "Input Type to Add";
            // 
            // TimelineLabel
            // 
            this.TimelineLabel.AutoSize = true;
            this.TimelineLabel.Location = new System.Drawing.Point(10, 180);
            this.TimelineLabel.Name = "TimelineLabel";
            this.TimelineLabel.Size = new System.Drawing.Size(165, 13);
            this.TimelineLabel.TabIndex = 4;
            this.TimelineLabel.Text = "Timeline (Executes every interval)";
            // 
            // UpTimelineButton
            // 
            this.UpTimelineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpTimelineButton.Location = new System.Drawing.Point(13, 300);
            this.UpTimelineButton.Name = "UpTimelineButton";
            this.UpTimelineButton.Size = new System.Drawing.Size(75, 23);
            this.UpTimelineButton.TabIndex = 5;
            this.UpTimelineButton.Text = "Move up";
            this.UpTimelineButton.UseVisualStyleBackColor = true;
            this.UpTimelineButton.Click += new System.EventHandler(this.UpTimelineButton_Click);
            // 
            // DownTimelineButton
            // 
            this.DownTimelineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownTimelineButton.Location = new System.Drawing.Point(95, 300);
            this.DownTimelineButton.Name = "DownTimelineButton";
            this.DownTimelineButton.Size = new System.Drawing.Size(75, 23);
            this.DownTimelineButton.TabIndex = 6;
            this.DownTimelineButton.Text = "Move down";
            this.DownTimelineButton.UseVisualStyleBackColor = true;
            this.DownTimelineButton.Click += new System.EventHandler(this.DownTimelineButton_Click);
            // 
            // RemoveTimelineButton
            // 
            this.RemoveTimelineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTimelineButton.Location = new System.Drawing.Point(197, 300);
            this.RemoveTimelineButton.Name = "RemoveTimelineButton";
            this.RemoveTimelineButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveTimelineButton.TabIndex = 7;
            this.RemoveTimelineButton.Text = "Remove";
            this.RemoveTimelineButton.UseVisualStyleBackColor = true;
            this.RemoveTimelineButton.Click += new System.EventHandler(this.RemoveTimelineButton_Click);
            // 
            // IntervalInput
            // 
            this.IntervalInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntervalInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.IntervalInput.Location = new System.Drawing.Point(13, 356);
            this.IntervalInput.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.IntervalInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.IntervalInput.Name = "IntervalInput";
            this.IntervalInput.Size = new System.Drawing.Size(107, 20);
            this.IntervalInput.TabIndex = 8;
            this.IntervalInput.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(13, 337);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(107, 13);
            this.IntervalLabel.TabIndex = 9;
            this.IntervalLabel.Text = "Interval (milliseconds)";
            // 
            // ControlLabel
            // 
            this.ControlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Location = new System.Drawing.Point(144, 337);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(128, 13);
            this.ControlLabel.TabIndex = 10;
            this.ControlLabel.Text = "Toggle Start/Stop Control";
            // 
            // statusGroup
            // 
            this.statusGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusGroup.Controls.Add(this.StatusLabel);
            this.statusGroup.Location = new System.Drawing.Point(13, 383);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(259, 66);
            this.statusGroup.TabIndex = 12;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(6, 25);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(94, 29);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Inactive";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlButton
            // 
            this.ControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlButton.Location = new System.Drawing.Point(126, 353);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(146, 23);
            this.ControlButton.TabIndex = 13;
            this.ControlButton.Text = "Click to Set";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // InputTypeTabs
            // 
            this.InputTypeTabs.Controls.Add(this.KeyCodeInputTab);
            this.InputTypeTabs.Controls.Add(this.MouseInputTab);
            this.InputTypeTabs.Controls.Add(this.StringInputTab);
            this.InputTypeTabs.Controls.Add(this.DelayInputTab);
            this.InputTypeTabs.Location = new System.Drawing.Point(13, 28);
            this.InputTypeTabs.Name = "InputTypeTabs";
            this.InputTypeTabs.SelectedIndex = 0;
            this.InputTypeTabs.Size = new System.Drawing.Size(259, 124);
            this.InputTypeTabs.TabIndex = 15;
            // 
            // KeyCodeInputTab
            // 
            this.KeyCodeInputTab.Controls.Add(this.HardwareKeyCodeTabCombo);
            this.KeyCodeInputTab.Controls.Add(this.HardwareKeyCodeTabLabel);
            this.KeyCodeInputTab.Controls.Add(this.HardwareKeyCodeTabCheck);
            this.KeyCodeInputTab.Controls.Add(this.SplitKeyCodeTabCheck);
            this.KeyCodeInputTab.Controls.Add(this.KeyCodeTabLabel);
            this.KeyCodeInputTab.Controls.Add(this.KeyCodeTabCombo);
            this.KeyCodeInputTab.Location = new System.Drawing.Point(4, 22);
            this.KeyCodeInputTab.Name = "KeyCodeInputTab";
            this.KeyCodeInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.KeyCodeInputTab.Size = new System.Drawing.Size(251, 98);
            this.KeyCodeInputTab.TabIndex = 0;
            this.KeyCodeInputTab.Text = "KeyCode";
            this.KeyCodeInputTab.UseVisualStyleBackColor = true;
            // 
            // HardwareKeyCodeTabCombo
            // 
            this.HardwareKeyCodeTabCombo.Enabled = false;
            this.HardwareKeyCodeTabCombo.FormattingEnabled = true;
            this.HardwareKeyCodeTabCombo.Location = new System.Drawing.Point(119, 73);
            this.HardwareKeyCodeTabCombo.Name = "HardwareKeyCodeTabCombo";
            this.HardwareKeyCodeTabCombo.Size = new System.Drawing.Size(121, 21);
            this.HardwareKeyCodeTabCombo.TabIndex = 5;
            // 
            // HardwareKeyCodeTabLabel
            // 
            this.HardwareKeyCodeTabLabel.AutoSize = true;
            this.HardwareKeyCodeTabLabel.Location = new System.Drawing.Point(4, 76);
            this.HardwareKeyCodeTabLabel.Name = "HardwareKeyCodeTabLabel";
            this.HardwareKeyCodeTabLabel.Size = new System.Drawing.Size(109, 13);
            this.HardwareKeyCodeTabLabel.TabIndex = 4;
            this.HardwareKeyCodeTabLabel.Text = "Hardware Scan Code";
            // 
            // HardwareKeyCodeTabCheck
            // 
            this.HardwareKeyCodeTabCheck.AutoSize = true;
            this.HardwareKeyCodeTabCheck.Location = new System.Drawing.Point(7, 56);
            this.HardwareKeyCodeTabCheck.Name = "HardwareKeyCodeTabCheck";
            this.HardwareKeyCodeTabCheck.Size = new System.Drawing.Size(158, 17);
            this.HardwareKeyCodeTabCheck.TabIndex = 3;
            this.HardwareKeyCodeTabCheck.Text = "Use Hardware Input instead";
            this.HardwareKeyCodeTabCheck.UseVisualStyleBackColor = true;
            this.HardwareKeyCodeTabCheck.CheckedChanged += new System.EventHandler(this.HardwareKeyCodeTabCheck_CheckedChanged);
            // 
            // SplitKeyCodeTabCheck
            // 
            this.SplitKeyCodeTabCheck.AutoSize = true;
            this.SplitKeyCodeTabCheck.Location = new System.Drawing.Point(7, 33);
            this.SplitKeyCodeTabCheck.Name = "SplitKeyCodeTabCheck";
            this.SplitKeyCodeTabCheck.Size = new System.Drawing.Size(216, 17);
            this.SplitKeyCodeTabCheck.TabIndex = 2;
            this.SplitKeyCodeTabCheck.Text = "Split into separate Key Up/Down events";
            this.SplitKeyCodeTabCheck.UseVisualStyleBackColor = true;
            // 
            // KeyCodeTabLabel
            // 
            this.KeyCodeTabLabel.AutoSize = true;
            this.KeyCodeTabLabel.Location = new System.Drawing.Point(6, 9);
            this.KeyCodeTabLabel.Name = "KeyCodeTabLabel";
            this.KeyCodeTabLabel.Size = new System.Drawing.Size(85, 13);
            this.KeyCodeTabLabel.TabIndex = 1;
            this.KeyCodeTabLabel.Text = "Virtual Key Code";
            // 
            // KeyCodeTabCombo
            // 
            this.KeyCodeTabCombo.FormattingEnabled = true;
            this.KeyCodeTabCombo.Location = new System.Drawing.Point(97, 6);
            this.KeyCodeTabCombo.Name = "KeyCodeTabCombo";
            this.KeyCodeTabCombo.Size = new System.Drawing.Size(121, 21);
            this.KeyCodeTabCombo.TabIndex = 0;
            // 
            // MouseInputTab
            // 
            this.MouseInputTab.Controls.Add(this.XIDMouseTabLabel);
            this.MouseInputTab.Controls.Add(this.XIDMouseTabInput);
            this.MouseInputTab.Controls.Add(this.ScrollVertMouseTabInput);
            this.MouseInputTab.Controls.Add(this.ScrollHorMouseTabInput);
            this.MouseInputTab.Controls.Add(this.ScrollMouseTabLabel);
            this.MouseInputTab.Controls.Add(this.MouseClickMouseTabCombo);
            this.MouseInputTab.Controls.Add(this.MouseClickMouseTabLabel);
            this.MouseInputTab.Controls.Add(this.AbsoluteMouseTabCheck);
            this.MouseInputTab.Controls.Add(this.MoveYMouseTabInput);
            this.MouseInputTab.Controls.Add(this.MoveXMouseTabInput);
            this.MouseInputTab.Controls.Add(this.MoveMouseMouseTabLabel);
            this.MouseInputTab.Location = new System.Drawing.Point(4, 22);
            this.MouseInputTab.Name = "MouseInputTab";
            this.MouseInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.MouseInputTab.Size = new System.Drawing.Size(251, 98);
            this.MouseInputTab.TabIndex = 1;
            this.MouseInputTab.Text = "Mouse";
            this.MouseInputTab.UseVisualStyleBackColor = true;
            // 
            // XIDMouseTabLabel
            // 
            this.XIDMouseTabLabel.AutoSize = true;
            this.XIDMouseTabLabel.Location = new System.Drawing.Point(177, 68);
            this.XIDMouseTabLabel.Name = "XIDMouseTabLabel";
            this.XIDMouseTabLabel.Size = new System.Drawing.Size(28, 13);
            this.XIDMouseTabLabel.TabIndex = 11;
            this.XIDMouseTabLabel.Text = "X ID";
            // 
            // XIDMouseTabInput
            // 
            this.XIDMouseTabInput.Location = new System.Drawing.Point(209, 65);
            this.XIDMouseTabInput.Name = "XIDMouseTabInput";
            this.XIDMouseTabInput.Size = new System.Drawing.Size(31, 20);
            this.XIDMouseTabInput.TabIndex = 10;
            // 
            // ScrollVertMouseTabInput
            // 
            this.ScrollVertMouseTabInput.Location = new System.Drawing.Point(193, 41);
            this.ScrollVertMouseTabInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ScrollVertMouseTabInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ScrollVertMouseTabInput.Name = "ScrollVertMouseTabInput";
            this.ScrollVertMouseTabInput.Size = new System.Drawing.Size(47, 20);
            this.ScrollVertMouseTabInput.TabIndex = 9;
            // 
            // ScrollHorMouseTabInput
            // 
            this.ScrollHorMouseTabInput.Location = new System.Drawing.Point(140, 41);
            this.ScrollHorMouseTabInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ScrollHorMouseTabInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ScrollHorMouseTabInput.Name = "ScrollHorMouseTabInput";
            this.ScrollHorMouseTabInput.Size = new System.Drawing.Size(47, 20);
            this.ScrollHorMouseTabInput.TabIndex = 8;
            // 
            // ScrollMouseTabLabel
            // 
            this.ScrollMouseTabLabel.AutoSize = true;
            this.ScrollMouseTabLabel.Location = new System.Drawing.Point(6, 43);
            this.ScrollMouseTabLabel.Name = "ScrollMouseTabLabel";
            this.ScrollMouseTabLabel.Size = new System.Drawing.Size(129, 13);
            this.ScrollMouseTabLabel.TabIndex = 7;
            this.ScrollMouseTabLabel.Text = "Scroll (Horizontal/Vertical)";
            // 
            // MouseClickMouseTabCombo
            // 
            this.MouseClickMouseTabCombo.FormattingEnabled = true;
            this.MouseClickMouseTabCombo.Location = new System.Drawing.Point(64, 65);
            this.MouseClickMouseTabCombo.Name = "MouseClickMouseTabCombo";
            this.MouseClickMouseTabCombo.Size = new System.Drawing.Size(107, 21);
            this.MouseClickMouseTabCombo.TabIndex = 6;
            // 
            // MouseClickMouseTabLabel
            // 
            this.MouseClickMouseTabLabel.AutoSize = true;
            this.MouseClickMouseTabLabel.Location = new System.Drawing.Point(7, 68);
            this.MouseClickMouseTabLabel.Name = "MouseClickMouseTabLabel";
            this.MouseClickMouseTabLabel.Size = new System.Drawing.Size(57, 13);
            this.MouseClickMouseTabLabel.TabIndex = 5;
            this.MouseClickMouseTabLabel.Text = "Click Type";
            // 
            // AbsoluteMouseTabCheck
            // 
            this.AbsoluteMouseTabCheck.AutoSize = true;
            this.AbsoluteMouseTabCheck.Location = new System.Drawing.Point(9, 23);
            this.AbsoluteMouseTabCheck.Name = "AbsoluteMouseTabCheck";
            this.AbsoluteMouseTabCheck.Size = new System.Drawing.Size(67, 17);
            this.AbsoluteMouseTabCheck.TabIndex = 4;
            this.AbsoluteMouseTabCheck.Text = "Absolute";
            this.AbsoluteMouseTabCheck.UseVisualStyleBackColor = true;
            // 
            // MoveYMouseTabInput
            // 
            this.MoveYMouseTabInput.Location = new System.Drawing.Point(174, 6);
            this.MoveYMouseTabInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MoveYMouseTabInput.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.MoveYMouseTabInput.Name = "MoveYMouseTabInput";
            this.MoveYMouseTabInput.Size = new System.Drawing.Size(66, 20);
            this.MoveYMouseTabInput.TabIndex = 2;
            // 
            // MoveXMouseTabInput
            // 
            this.MoveXMouseTabInput.Location = new System.Drawing.Point(102, 6);
            this.MoveXMouseTabInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MoveXMouseTabInput.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.MoveXMouseTabInput.Name = "MoveXMouseTabInput";
            this.MoveXMouseTabInput.Size = new System.Drawing.Size(66, 20);
            this.MoveXMouseTabInput.TabIndex = 1;
            // 
            // MoveMouseMouseTabLabel
            // 
            this.MoveMouseMouseTabLabel.AutoSize = true;
            this.MoveMouseMouseTabLabel.Location = new System.Drawing.Point(7, 7);
            this.MoveMouseMouseTabLabel.Name = "MoveMouseMouseTabLabel";
            this.MoveMouseMouseTabLabel.Size = new System.Drawing.Size(93, 13);
            this.MoveMouseMouseTabLabel.TabIndex = 0;
            this.MoveMouseMouseTabLabel.Text = "Move Mouse (x/y)";
            // 
            // StringInputTab
            // 
            this.StringInputTab.Controls.Add(this.StringTabLabel);
            this.StringInputTab.Controls.Add(this.StringTabInput);
            this.StringInputTab.Location = new System.Drawing.Point(4, 22);
            this.StringInputTab.Name = "StringInputTab";
            this.StringInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.StringInputTab.Size = new System.Drawing.Size(251, 98);
            this.StringInputTab.TabIndex = 2;
            this.StringInputTab.Text = "String";
            this.StringInputTab.UseVisualStyleBackColor = true;
            // 
            // StringTabLabel
            // 
            this.StringTabLabel.AutoSize = true;
            this.StringTabLabel.Location = new System.Drawing.Point(6, 10);
            this.StringTabLabel.Name = "StringTabLabel";
            this.StringTabLabel.Size = new System.Drawing.Size(50, 13);
            this.StringTabLabel.TabIndex = 1;
            this.StringTabLabel.Text = "Message";
            // 
            // StringTabInput
            // 
            this.StringTabInput.Location = new System.Drawing.Point(58, 7);
            this.StringTabInput.Name = "StringTabInput";
            this.StringTabInput.Size = new System.Drawing.Size(187, 20);
            this.StringTabInput.TabIndex = 0;
            this.StringTabInput.Text = "Hello There";
            // 
            // DelayInputTab
            // 
            this.DelayInputTab.Controls.Add(this.DelayTabInput);
            this.DelayInputTab.Controls.Add(this.DelayTabLabel);
            this.DelayInputTab.Location = new System.Drawing.Point(4, 22);
            this.DelayInputTab.Name = "DelayInputTab";
            this.DelayInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.DelayInputTab.Size = new System.Drawing.Size(251, 98);
            this.DelayInputTab.TabIndex = 3;
            this.DelayInputTab.Text = "Delay";
            this.DelayInputTab.UseVisualStyleBackColor = true;
            // 
            // DelayTabInput
            // 
            this.DelayTabInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DelayTabInput.Location = new System.Drawing.Point(6, 28);
            this.DelayTabInput.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.DelayTabInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DelayTabInput.Name = "DelayTabInput";
            this.DelayTabInput.Size = new System.Drawing.Size(120, 20);
            this.DelayTabInput.TabIndex = 1;
            this.DelayTabInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DelayTabLabel
            // 
            this.DelayTabLabel.AutoSize = true;
            this.DelayTabLabel.Location = new System.Drawing.Point(3, 12);
            this.DelayTabLabel.Name = "DelayTabLabel";
            this.DelayTabLabel.Size = new System.Drawing.Size(212, 13);
            this.DelayTabLabel.TabIndex = 0;
            this.DelayTabLabel.Text = "Amount (milliseconds) (Adds to interval time)";
            // 
            // AddInputButton
            // 
            this.AddInputButton.Location = new System.Drawing.Point(197, 154);
            this.AddInputButton.Name = "AddInputButton";
            this.AddInputButton.Size = new System.Drawing.Size(75, 23);
            this.AddInputButton.TabIndex = 16;
            this.AddInputButton.Text = "Add";
            this.AddInputButton.UseVisualStyleBackColor = true;
            this.AddInputButton.Click += new System.EventHandler(this.AddInputButton_Click);
            // 
            // TimelineList
            // 
            this.TimelineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimelineList.FormattingEnabled = true;
            this.TimelineList.HorizontalScrollbar = true;
            this.TimelineList.Location = new System.Drawing.Point(12, 199);
            this.TimelineList.Name = "TimelineList";
            this.TimelineList.Size = new System.Drawing.Size(260, 95);
            this.TimelineList.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.TimelineList);
            this.Controls.Add(this.AddInputButton);
            this.Controls.Add(this.InputTypeTabs);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.statusGroup);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.IntervalInput);
            this.Controls.Add(this.RemoveTimelineButton);
            this.Controls.Add(this.DownTimelineButton);
            this.Controls.Add(this.UpTimelineButton);
            this.Controls.Add(this.TimelineLabel);
            this.Controls.Add(this.InputTypeLabel);
            this.Name = "MainForm";
            this.Text = "Semi-Auto HotKey";
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).EndInit();
            this.statusGroup.ResumeLayout(false);
            this.statusGroup.PerformLayout();
            this.InputTypeTabs.ResumeLayout(false);
            this.KeyCodeInputTab.ResumeLayout(false);
            this.KeyCodeInputTab.PerformLayout();
            this.MouseInputTab.ResumeLayout(false);
            this.MouseInputTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XIDMouseTabInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollVertMouseTabInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollHorMouseTabInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveYMouseTabInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveXMouseTabInput)).EndInit();
            this.StringInputTab.ResumeLayout(false);
            this.StringInputTab.PerformLayout();
            this.DelayInputTab.ResumeLayout(false);
            this.DelayInputTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTabInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InputTypeLabel;
        private System.Windows.Forms.Label TimelineLabel;
        private System.Windows.Forms.Button UpTimelineButton;
        private System.Windows.Forms.Button DownTimelineButton;
        private System.Windows.Forms.Button RemoveTimelineButton;
        private System.Windows.Forms.NumericUpDown IntervalInput;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.TabControl InputTypeTabs;
        private System.Windows.Forms.TabPage KeyCodeInputTab;
        private System.Windows.Forms.TabPage MouseInputTab;
        private System.Windows.Forms.Button AddInputButton;
        private System.Windows.Forms.TabPage StringInputTab;
        private System.Windows.Forms.Label KeyCodeTabLabel;
        private System.Windows.Forms.ComboBox KeyCodeTabCombo;
        private System.Windows.Forms.TabPage DelayInputTab;
        private System.Windows.Forms.Label MoveMouseMouseTabLabel;
        private System.Windows.Forms.ComboBox MouseClickMouseTabCombo;
        private System.Windows.Forms.Label MouseClickMouseTabLabel;
        private System.Windows.Forms.CheckBox AbsoluteMouseTabCheck;
        private System.Windows.Forms.NumericUpDown MoveYMouseTabInput;
        private System.Windows.Forms.NumericUpDown MoveXMouseTabInput;
        private System.Windows.Forms.Label StringTabLabel;
        private System.Windows.Forms.TextBox StringTabInput;
        private System.Windows.Forms.NumericUpDown DelayTabInput;
        private System.Windows.Forms.Label DelayTabLabel;
        private System.Windows.Forms.CheckBox SplitKeyCodeTabCheck;
        private System.Windows.Forms.NumericUpDown ScrollHorMouseTabInput;
        private System.Windows.Forms.Label ScrollMouseTabLabel;
        private System.Windows.Forms.NumericUpDown ScrollVertMouseTabInput;
        private System.Windows.Forms.ListBox TimelineList;
        private System.Windows.Forms.Label XIDMouseTabLabel;
        private System.Windows.Forms.NumericUpDown XIDMouseTabInput;
        private System.Windows.Forms.CheckBox HardwareKeyCodeTabCheck;
        private System.Windows.Forms.Label HardwareKeyCodeTabLabel;
        private System.Windows.Forms.ComboBox HardwareKeyCodeTabCombo;
    }
}

