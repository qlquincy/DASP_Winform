namespace DASPClient
{
    partial class MainFrm
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
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.menuStripTool = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fanPosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tansiferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanelContent = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.linkLblChangePwd = new System.Windows.Forms.LinkLabel();
            this.linkLblExit = new System.Windows.Forms.LinkLabel();
            this.tableLayPanelMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeftColumn = new System.Windows.Forms.Panel();
            this.lblDisplayLoginInfo = new ZControls.ZLabelControl();
            this.cmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTool.SuspendLayout();
            this.tableLayPanelMiddle.SuspendLayout();
            this.panelLeftColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTool
            // 
            this.menuStripTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.saToolStripMenuItem,
            this.tansiferToolStripMenuItem,
            this.cmpToolStripMenuItem});
            this.menuStripTool.Location = new System.Drawing.Point(0, 0);
            this.menuStripTool.Name = "menuStripTool";
            this.menuStripTool.Size = new System.Drawing.Size(920, 25);
            this.menuStripTool.TabIndex = 0;
            this.menuStripTool.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.ShowShortcutKeys = false;
            this.userToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.userToolStripMenuItem.Text = "用户管理";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.UserToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.tunnelToolStripMenuItem,
            this.fanPosToolStripMenuItem,
            this.dataAToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.dataToolStripMenuItem.Text = "数据整理";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.projectToolStripMenuItem.Text = "合同管理";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // tunnelToolStripMenuItem
            // 
            this.tunnelToolStripMenuItem.Name = "tunnelToolStripMenuItem";
            this.tunnelToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tunnelToolStripMenuItem.Text = "隧道管理";
            this.tunnelToolStripMenuItem.Click += new System.EventHandler(this.tunnelToolStripMenuItem_Click);
            // 
            // fanPosToolStripMenuItem
            // 
            this.fanPosToolStripMenuItem.Name = "fanPosToolStripMenuItem";
            this.fanPosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fanPosToolStripMenuItem.Text = "风机位置管理";
            this.fanPosToolStripMenuItem.Click += new System.EventHandler(this.fanPosToolStripMenuItem_Click);
            // 
            // dataAToolStripMenuItem
            // 
            this.dataAToolStripMenuItem.Name = "dataAToolStripMenuItem";
            this.dataAToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dataAToolStripMenuItem.Text = "数据采集";
            this.dataAToolStripMenuItem.Click += new System.EventHandler(this.dataAToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.timerToolStripMenuItem.Text = "时域分析";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.saToolStripMenuItem.Text = "自谱分析";
            this.saToolStripMenuItem.Click += new System.EventHandler(this.saToolStripMenuItem_Click);
            // 
            // tansiferToolStripMenuItem
            // 
            this.tansiferToolStripMenuItem.Name = "tansiferToolStripMenuItem";
            this.tansiferToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.tansiferToolStripMenuItem.Text = "传递函数";
            this.tansiferToolStripMenuItem.Click += new System.EventHandler(this.tansiferToolStripMenuItem_Click);
            // 
            // dockPanelContent
            // 
            this.dockPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelContent.Location = new System.Drawing.Point(0, 25);
            this.dockPanelContent.Name = "dockPanelContent";
            this.dockPanelContent.Size = new System.Drawing.Size(920, 643);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("微软雅黑", 9F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("微软雅黑", 9F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockPanelContent.Skin = dockPanelSkin1;
            this.dockPanelContent.TabIndex = 2;
            // 
            // linkLblChangePwd
            // 
            this.linkLblChangePwd.AutoSize = true;
            this.linkLblChangePwd.LinkColor = System.Drawing.Color.White;
            this.linkLblChangePwd.Location = new System.Drawing.Point(9, 29);
            this.linkLblChangePwd.Name = "linkLblChangePwd";
            this.linkLblChangePwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLblChangePwd.Size = new System.Drawing.Size(53, 12);
            this.linkLblChangePwd.TabIndex = 0;
            this.linkLblChangePwd.TabStop = true;
            this.linkLblChangePwd.Text = "修改密码";
            this.linkLblChangePwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLblChangePwd.Click += new System.EventHandler(this.linkLblChangePwd_Click);
            // 
            // linkLblExit
            // 
            this.linkLblExit.AutoSize = true;
            this.linkLblExit.LinkColor = System.Drawing.Color.White;
            this.linkLblExit.Location = new System.Drawing.Point(68, 29);
            this.linkLblExit.Name = "linkLblExit";
            this.linkLblExit.Size = new System.Drawing.Size(53, 12);
            this.linkLblExit.TabIndex = 1;
            this.linkLblExit.TabStop = true;
            this.linkLblExit.Text = "退出系统";
            this.linkLblExit.Click += new System.EventHandler(this.linkLblExit_Click);
            // 
            // tableLayPanelMiddle
            // 
            this.tableLayPanelMiddle.ColumnCount = 2;
            this.tableLayPanelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanelMiddle.Controls.Add(this.panelLeftColumn, 0, 0);
            this.tableLayPanelMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayPanelMiddle.Location = new System.Drawing.Point(0, 25);
            this.tableLayPanelMiddle.Name = "tableLayPanelMiddle";
            this.tableLayPanelMiddle.RowCount = 1;
            this.tableLayPanelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanelMiddle.Size = new System.Drawing.Size(920, 58);
            this.tableLayPanelMiddle.TabIndex = 2;
            // 
            // panelLeftColumn
            // 
            this.panelLeftColumn.Controls.Add(this.lblDisplayLoginInfo);
            this.panelLeftColumn.Controls.Add(this.linkLblChangePwd);
            this.panelLeftColumn.Controls.Add(this.linkLblExit);
            this.panelLeftColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftColumn.Location = new System.Drawing.Point(3, 3);
            this.panelLeftColumn.Name = "panelLeftColumn";
            this.panelLeftColumn.Size = new System.Drawing.Size(454, 52);
            this.panelLeftColumn.TabIndex = 0;
            // 
            // lblDisplayLoginInfo
            // 
            this.lblDisplayLoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayLoginInfo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.lblDisplayLoginInfo.ForeColor = System.Drawing.Color.White;
            this.lblDisplayLoginInfo.Location = new System.Drawing.Point(9, 6);
            this.lblDisplayLoginInfo.Name = "lblDisplayLoginInfo";
            this.lblDisplayLoginInfo.Size = new System.Drawing.Size(134, 20);
            this.lblDisplayLoginInfo.TabIndex = 2;
            this.lblDisplayLoginInfo.Text = "当前登录用户为：{0}";
            // 
            // cmpToolStripMenuItem
            // 
            this.cmpToolStripMenuItem.Name = "cmpToolStripMenuItem";
            this.cmpToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.cmpToolStripMenuItem.Text = "比较分析";
            this.cmpToolStripMenuItem.Click += new System.EventHandler(this.cmpToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 668);
            this.Controls.Add(this.tableLayPanelMiddle);
            this.Controls.Add(this.dockPanelContent);
            this.Controls.Add(this.menuStripTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripTool;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主控台";
            this.menuStripTool.ResumeLayout(false);
            this.menuStripTool.PerformLayout();
            this.tableLayPanelMiddle.ResumeLayout(false);
            this.panelLeftColumn.ResumeLayout(false);
            this.panelLeftColumn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTool;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tansiferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tunnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanPosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelContent;
        private System.Windows.Forms.LinkLabel linkLblChangePwd;
        private System.Windows.Forms.LinkLabel linkLblExit;
        private System.Windows.Forms.TableLayoutPanel tableLayPanelMiddle;
        private System.Windows.Forms.Panel panelLeftColumn;
        private ZControls.ZLabelControl lblDisplayLoginInfo;
        private System.Windows.Forms.ToolStripMenuItem cmpToolStripMenuItem;


    }
}