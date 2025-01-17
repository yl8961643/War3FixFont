﻿using System.Windows.Forms;

namespace War3FixFont;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FixButton = new System.Windows.Forms.Button();
            this.EnableHotKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.BorderMaxWindowButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.EnableTimerFixCheckBox = new System.Windows.Forms.CheckBox();
            this.IntervalInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ManualButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowModeSelect = new System.Windows.Forms.ComboBox();
            this.WindowModeLabel = new System.Windows.Forms.Label();
            this.AutoWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.LockCursorCheckBox = new System.Windows.Forms.CheckBox();
            this.HotKeyInputBox = new War3FixFont.HotKeyInputBox();
            this.ShowMeHotKeyInputBox = new War3FixFont.HotKeyInputBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FixButton
            // 
            this.FixButton.Location = new System.Drawing.Point(12, 12);
            this.FixButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FixButton.Name = "FixButton";
            this.FixButton.Size = new System.Drawing.Size(75, 23);
            this.FixButton.TabIndex = 0;
            this.FixButton.Text = "修复一次";
            this.FixButton.UseVisualStyleBackColor = true;
            this.FixButton.Click += new System.EventHandler(this.FixButton_Click);
            // 
            // EnableHotKeyCheckBox
            // 
            this.EnableHotKeyCheckBox.AutoSize = true;
            this.EnableHotKeyCheckBox.Checked = true;
            this.EnableHotKeyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableHotKeyCheckBox.Location = new System.Drawing.Point(12, 108);
            this.EnableHotKeyCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnableHotKeyCheckBox.Name = "EnableHotKeyCheckBox";
            this.EnableHotKeyCheckBox.Size = new System.Drawing.Size(84, 16);
            this.EnableHotKeyCheckBox.TabIndex = 1;
            this.EnableHotKeyCheckBox.Text = "使用快捷键";
            this.EnableHotKeyCheckBox.UseVisualStyleBackColor = true;
            this.EnableHotKeyCheckBox.CheckedChanged += new System.EventHandler(this.EnableHotKeyCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "作者：Zonciu";
            // 
            // LinkLabel
            // 
            this.LinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(10, 238);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(227, 12);
            this.LinkLabel.TabIndex = 3;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "https://github.com/Zonciu/War3FixFont";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // BorderMaxWindowButton
            // 
            this.BorderMaxWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderMaxWindowButton.Location = new System.Drawing.Point(281, 39);
            this.BorderMaxWindowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorderMaxWindowButton.Name = "BorderMaxWindowButton";
            this.BorderMaxWindowButton.Size = new System.Drawing.Size(75, 23);
            this.BorderMaxWindowButton.TabIndex = 4;
            this.BorderMaxWindowButton.Text = "有边框全屏";
            this.BorderMaxWindowButton.UseVisualStyleBackColor = true;
            this.BorderMaxWindowButton.Click += new System.EventHandler(this.BorderMaxWindowButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenButton.Location = new System.Drawing.Point(281, 12);
            this.FullScreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(75, 23);
            this.FullScreenButton.TabIndex = 5;
            this.FullScreenButton.Text = "无边框全屏";
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.Location = new System.Drawing.Point(281, 238);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(75, 12);
            this.VersionLabel.TabIndex = 11;
            this.VersionLabel.Text = "vx.x";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnableTimerFixCheckBox
            // 
            this.EnableTimerFixCheckBox.AutoSize = true;
            this.EnableTimerFixCheckBox.Location = new System.Drawing.Point(12, 52);
            this.EnableTimerFixCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnableTimerFixCheckBox.Name = "EnableTimerFixCheckBox";
            this.EnableTimerFixCheckBox.Size = new System.Drawing.Size(72, 16);
            this.EnableTimerFixCheckBox.TabIndex = 15;
            this.EnableTimerFixCheckBox.Text = "定时修复";
            this.EnableTimerFixCheckBox.UseVisualStyleBackColor = true;
            this.EnableTimerFixCheckBox.CheckedChanged += new System.EventHandler(this.EnableTimerFixCheckBox_CheckedChanged);
            // 
            // IntervalInput
            // 
            this.IntervalInput.Location = new System.Drawing.Point(93, 50);
            this.IntervalInput.Margin = new System.Windows.Forms.Padding(0);
            this.IntervalInput.Name = "IntervalInput";
            this.IntervalInput.Size = new System.Drawing.Size(54, 21);
            this.IntervalInput.TabIndex = 16;
            this.IntervalInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.IntervalInput.ValueChanged += new System.EventHandler(this.IntervalInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "秒";
            // 
            // ManualButton
            // 
            this.ManualButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualButton.Location = new System.Drawing.Point(281, 207);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(75, 23);
            this.ManualButton.TabIndex = 19;
            this.ManualButton.Text = "使用说明";
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.PanelMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "魔兽3叠字修复";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowWindowMenuItem,
            this.ExitAppMenuItem});
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // ShowWindowMenuItem
            // 
            this.ShowWindowMenuItem.Name = "ShowWindowMenuItem";
            this.ShowWindowMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ShowWindowMenuItem.Text = "显示";
            this.ShowWindowMenuItem.Click += new System.EventHandler(this.ShowWindowMenuItem_Click);
            // 
            // ExitAppMenuItem
            // 
            this.ExitAppMenuItem.Name = "ExitAppMenuItem";
            this.ExitAppMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitAppMenuItem.Text = "退出";
            this.ExitAppMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // WindowModeSelect
            // 
            this.WindowModeSelect.FormattingEnabled = true;
            this.WindowModeSelect.Location = new System.Drawing.Point(69, 78);
            this.WindowModeSelect.Name = "WindowModeSelect";
            this.WindowModeSelect.Size = new System.Drawing.Size(121, 20);
            this.WindowModeSelect.TabIndex = 20;
            this.WindowModeSelect.SelectionChangeCommitted += new System.EventHandler(this.WindowModeSelect_SelectionChangeCommitted);
            // 
            // WindowModeLabel
            // 
            this.WindowModeLabel.AutoSize = true;
            this.WindowModeLabel.Location = new System.Drawing.Point(12, 82);
            this.WindowModeLabel.Name = "WindowModeLabel";
            this.WindowModeLabel.Size = new System.Drawing.Size(53, 12);
            this.WindowModeLabel.TabIndex = 21;
            this.WindowModeLabel.Text = "窗口模式";
            // 
            // AutoWindowCheckBox
            // 
            this.AutoWindowCheckBox.AutoSize = true;
            this.AutoWindowCheckBox.Location = new System.Drawing.Point(196, 80);
            this.AutoWindowCheckBox.Name = "AutoWindowCheckBox";
            this.AutoWindowCheckBox.Size = new System.Drawing.Size(96, 16);
            this.AutoWindowCheckBox.TabIndex = 22;
            this.AutoWindowCheckBox.Text = "自动设置窗口";
            this.AutoWindowCheckBox.UseVisualStyleBackColor = true;
            this.AutoWindowCheckBox.CheckedChanged += new System.EventHandler(this.AutoWindowCheckBox_CheckedChanged);
            // 
            // LockCursorCheckBox
            // 
            this.LockCursorCheckBox.AutoSize = true;
            this.LockCursorCheckBox.Location = new System.Drawing.Point(12, 138);
            this.LockCursorCheckBox.Name = "LockCursorCheckBox";
            this.LockCursorCheckBox.Size = new System.Drawing.Size(96, 16);
            this.LockCursorCheckBox.TabIndex = 23;
            this.LockCursorCheckBox.Text = "锁定鼠标范围";
            this.LockCursorCheckBox.UseVisualStyleBackColor = true;
            this.LockCursorCheckBox.CheckedChanged += new System.EventHandler(this.LockCursorCheckBox_CheckedChanged);
            // 
            // HotKeyInputBox
            // 
            this.HotKeyInputBox.Alt = false;
            this.HotKeyInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.HotKeyInputBox.Control = false;
            this.HotKeyInputBox.KeyCode = System.Windows.Forms.Keys.None;
            this.HotKeyInputBox.Location = new System.Drawing.Point(102, 106);
            this.HotKeyInputBox.Name = "HotKeyInputBox";
            this.HotKeyInputBox.Shift = false;
            this.HotKeyInputBox.ShortcutsEnabled = false;
            this.HotKeyInputBox.Size = new System.Drawing.Size(153, 21);
            this.HotKeyInputBox.TabIndex = 12;
            this.HotKeyInputBox.WordWrap = false;
            this.HotKeyInputBox.HotKeyChanged += new System.EventHandler(this.HotKeyInputBox_HotKeyChanged);
            // 
            // ShowMeHotKeyInputBox
            // 
            this.ShowMeHotKeyInputBox.Alt = false;
            this.ShowMeHotKeyInputBox.Control = false;
            this.ShowMeHotKeyInputBox.KeyCode = System.Windows.Forms.Keys.None;
            this.ShowMeHotKeyInputBox.Location = new System.Drawing.Point(83, 164);
            this.ShowMeHotKeyInputBox.Name = "ShowMeHotKeyInputBox";
            this.ShowMeHotKeyInputBox.Shift = false;
            this.ShowMeHotKeyInputBox.ShortcutsEnabled = false;
            this.ShowMeHotKeyInputBox.Size = new System.Drawing.Size(153, 21);
            this.ShowMeHotKeyInputBox.TabIndex = 24;
            this.ShowMeHotKeyInputBox.WordWrap = false;
            this.ShowMeHotKeyInputBox.HotKeyChanged += new System.EventHandler(this.ShowMeHotKeyInputBox_HotKeyChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "显示本窗口";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowMeHotKeyInputBox);
            this.Controls.Add(this.LockCursorCheckBox);
            this.Controls.Add(this.AutoWindowCheckBox);
            this.Controls.Add(this.WindowModeLabel);
            this.Controls.Add(this.WindowModeSelect);
            this.Controls.Add(this.ManualButton);
            this.Controls.Add(this.EnableTimerFixCheckBox);
            this.Controls.Add(this.IntervalInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HotKeyInputBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.BorderMaxWindowButton);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnableHotKeyCheckBox);
            this.Controls.Add(this.FixButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "魔兽争霸3叠字修复";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private War3FixFont.HotKeyInputBox HotKeyInputBox;
    private System.Windows.Forms.CheckBox EnableHotKeyCheckBox;

    #endregion

    private Button FixButton;
    private Label label1;
    private LinkLabel LinkLabel;
    private Button BorderMaxWindowButton;
    private Button FullScreenButton;
    private Label VersionLabel;
    private CheckBox EnableTimerFixCheckBox;
    private NumericUpDown IntervalInput;
    private Label label2;
    private Button ManualButton;
    private NotifyIcon NotifyIcon;
    private ContextMenuStrip PanelMenu;
    private ToolStripMenuItem ShowWindowMenuItem;
    private ToolStripMenuItem ExitAppMenuItem;
    private ComboBox WindowModeSelect;
    private Label WindowModeLabel;
    private CheckBox AutoWindowCheckBox;
    private CheckBox LockCursorCheckBox;
    private HotKeyInputBox ShowMeHotKeyInputBox;
    private Label label3;
}