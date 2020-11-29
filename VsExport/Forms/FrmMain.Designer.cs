namespace VsExport
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemIvc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotifyMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MenuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.MenuItemWindow,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemIvc,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem1.Text = "&Файл";
            // 
            // MenuItemIvc
            // 
            this.MenuItemIvc.Name = "MenuItemIvc";
            this.MenuItemIvc.Size = new System.Drawing.Size(212, 22);
            this.MenuItemIvc.Text = "Взаимодействие с Буфером";
            this.MenuItemIvc.Click += new System.EventHandler(this.MenuItemIvc_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(209, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem1.Text = "Выход";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // MenuItemWindow
            // 
            this.MenuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCascade,
            this.MenuItemTileHorizontal,
            this.MenuItemTileVertical,
            this.MenuItemCloseWindow,
            this.MenuItemCloseAll});
            this.MenuItemWindow.Name = "MenuItemWindow";
            this.MenuItemWindow.Size = new System.Drawing.Size(45, 20);
            this.MenuItemWindow.Text = "Окна";
            // 
            // MenuItemCascade
            // 
            this.MenuItemCascade.Name = "MenuItemCascade";
            this.MenuItemCascade.Size = new System.Drawing.Size(154, 22);
            this.MenuItemCascade.Text = "Каскадом";
            this.MenuItemCascade.Click += new System.EventHandler(this.MenuItemCascade_Click);
            // 
            // MenuItemTileHorizontal
            // 
            this.MenuItemTileHorizontal.Name = "MenuItemTileHorizontal";
            this.MenuItemTileHorizontal.Size = new System.Drawing.Size(154, 22);
            this.MenuItemTileHorizontal.Text = "По горизонтали";
            this.MenuItemTileHorizontal.Click += new System.EventHandler(this.MenuItemTileHorizontal_Click);
            // 
            // MenuItemTileVertical
            // 
            this.MenuItemTileVertical.Name = "MenuItemTileVertical";
            this.MenuItemTileVertical.Size = new System.Drawing.Size(154, 22);
            this.MenuItemTileVertical.Text = "По вертикали";
            this.MenuItemTileVertical.Click += new System.EventHandler(this.MenuItemTileVertical_Click);
            // 
            // MenuItemCloseWindow
            // 
            this.MenuItemCloseWindow.Name = "MenuItemCloseWindow";
            this.MenuItemCloseWindow.Size = new System.Drawing.Size(154, 22);
            this.MenuItemCloseWindow.Text = "Закрыть";
            this.MenuItemCloseWindow.Click += new System.EventHandler(this.MenuItemCloseWindow_Click);
            // 
            // MenuItemCloseAll
            // 
            this.MenuItemCloseAll.Name = "MenuItemCloseAll";
            this.MenuItemCloseAll.Size = new System.Drawing.Size(154, 22);
            this.MenuItemCloseAll.Text = "Закрыть все";
            this.MenuItemCloseAll.Click += new System.EventHandler(this.MenuItemCloseAll_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelp,
            this.toolStripSeparator11,
            this.MenuItemAbout});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.helpToolStripMenuItem1.Text = "&Помощь";
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(138, 22);
            this.MenuItemHelp.Text = "Справка";
            this.MenuItemHelp.Click += new System.EventHandler(this.MenuItemHelp_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(135, 6);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(138, 22);
            this.MenuItemAbout.Text = "О программе";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelUser,
            this.StatusLabelServer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelUser
            // 
            this.StatusLabelUser.AutoSize = false;
            this.StatusLabelUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StatusLabelUser.Name = "StatusLabelUser";
            this.StatusLabelUser.Size = new System.Drawing.Size(200, 17);
            this.StatusLabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabelServer
            // 
            this.StatusLabelServer.AutoSize = false;
            this.StatusLabelServer.Name = "StatusLabelServer";
            this.StatusLabelServer.Size = new System.Drawing.Size(150, 17);
            this.StatusLabelServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MenuNotifyIcon
            // 
            this.MenuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyMenuItemClose});
            this.MenuNotifyIcon.Name = "MenuNotifyIcon";
            this.MenuNotifyIcon.Size = new System.Drawing.Size(108, 26);
            // 
            // NotifyMenuItemClose
            // 
            this.NotifyMenuItemClose.Name = "NotifyMenuItemClose";
            this.NotifyMenuItemClose.Size = new System.Drawing.Size(107, 22);
            this.NotifyMenuItemClose.Text = "Выход";
            this.NotifyMenuItemClose.Click += new System.EventHandler(this.NotifyMenuItemClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 389);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ \"Экспорта - импорта данных\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MenuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUser;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelServer;
        private System.Windows.Forms.ToolStripMenuItem MenuItemIvc;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTileVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCloseWindow;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCloseAll;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem NotifyMenuItemClose;
    }
}

