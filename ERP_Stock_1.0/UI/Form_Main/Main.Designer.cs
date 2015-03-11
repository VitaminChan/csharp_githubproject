namespace UI.Form_Main
{
    partial class frmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.基本資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用戶資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客戶資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供應商資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.進貨作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增採購單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.採購單列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.新增進貨單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.進貨單列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷售作業ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增報價單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.報價單列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.新增銷售單據ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銷售單列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.未付單據ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月結報表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.盤點報表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系統設置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色及權限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.NavTabControl = new DevComponents.DotNetBar.SuperTabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavTabControl)).BeginInit();
            this.NavTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本資料ToolStripMenuItem,
            this.進貨作業ToolStripMenuItem,
            this.銷售作業ToolStripMenuItem,
            this.月結報表ToolStripMenuItem,
            this.系統設置ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(772, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // 基本資料ToolStripMenuItem
            // 
            this.基本資料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用戶資料ToolStripMenuItem,
            this.客戶資料ToolStripMenuItem,
            this.供應商資料ToolStripMenuItem,
            this.商品資料ToolStripMenuItem});
            this.基本資料ToolStripMenuItem.Name = "基本資料ToolStripMenuItem";
            this.基本資料ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.基本資料ToolStripMenuItem.Text = "基本資料";
            this.基本資料ToolStripMenuItem.Click += new System.EventHandler(this.基本資料ToolStripMenuItem_Click);
            // 
            // 用戶資料ToolStripMenuItem
            // 
            this.用戶資料ToolStripMenuItem.Name = "用戶資料ToolStripMenuItem";
            this.用戶資料ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.用戶資料ToolStripMenuItem.Text = "用戶資料";
            this.用戶資料ToolStripMenuItem.Click += new System.EventHandler(this.用戶資料ToolStripMenuItem_Click);
            // 
            // 客戶資料ToolStripMenuItem
            // 
            this.客戶資料ToolStripMenuItem.Name = "客戶資料ToolStripMenuItem";
            this.客戶資料ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.客戶資料ToolStripMenuItem.Text = "客戶資料";
            // 
            // 供應商資料ToolStripMenuItem
            // 
            this.供應商資料ToolStripMenuItem.Name = "供應商資料ToolStripMenuItem";
            this.供應商資料ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.供應商資料ToolStripMenuItem.Text = "供應商資料";
            // 
            // 商品資料ToolStripMenuItem
            // 
            this.商品資料ToolStripMenuItem.Name = "商品資料ToolStripMenuItem";
            this.商品資料ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.商品資料ToolStripMenuItem.Text = "商品資料";
            // 
            // 進貨作業ToolStripMenuItem
            // 
            this.進貨作業ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增採購單ToolStripMenuItem,
            this.採購單列表ToolStripMenuItem,
            this.toolStripSeparator1,
            this.新增進貨單ToolStripMenuItem,
            this.進貨單列表ToolStripMenuItem});
            this.進貨作業ToolStripMenuItem.Name = "進貨作業ToolStripMenuItem";
            this.進貨作業ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.進貨作業ToolStripMenuItem.Text = "進貨作業";
            // 
            // 新增採購單ToolStripMenuItem
            // 
            this.新增採購單ToolStripMenuItem.Name = "新增採購單ToolStripMenuItem";
            this.新增採購單ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新增採購單ToolStripMenuItem.Text = "新增採購單";
            // 
            // 採購單列表ToolStripMenuItem
            // 
            this.採購單列表ToolStripMenuItem.Name = "採購單列表ToolStripMenuItem";
            this.採購單列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.採購單列表ToolStripMenuItem.Text = "採購單列表";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // 新增進貨單ToolStripMenuItem
            // 
            this.新增進貨單ToolStripMenuItem.Name = "新增進貨單ToolStripMenuItem";
            this.新增進貨單ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新增進貨單ToolStripMenuItem.Text = "新增進貨單";
            // 
            // 進貨單列表ToolStripMenuItem
            // 
            this.進貨單列表ToolStripMenuItem.Name = "進貨單列表ToolStripMenuItem";
            this.進貨單列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.進貨單列表ToolStripMenuItem.Text = "進貨單列表";
            // 
            // 銷售作業ToolStripMenuItem
            // 
            this.銷售作業ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增報價單ToolStripMenuItem,
            this.報價單列表ToolStripMenuItem,
            this.toolStripSeparator3,
            this.新增銷售單據ToolStripMenuItem,
            this.銷售單列表ToolStripMenuItem,
            this.toolStripSeparator2,
            this.未付單據ToolStripMenuItem});
            this.銷售作業ToolStripMenuItem.Name = "銷售作業ToolStripMenuItem";
            this.銷售作業ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.銷售作業ToolStripMenuItem.Text = "銷售作業";
            // 
            // 新增報價單ToolStripMenuItem
            // 
            this.新增報價單ToolStripMenuItem.Name = "新增報價單ToolStripMenuItem";
            this.新增報價單ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新增報價單ToolStripMenuItem.Text = "新增報價單";
            // 
            // 報價單列表ToolStripMenuItem
            // 
            this.報價單列表ToolStripMenuItem.Name = "報價單列表ToolStripMenuItem";
            this.報價單列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.報價單列表ToolStripMenuItem.Text = "報價單列表";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // 新增銷售單據ToolStripMenuItem
            // 
            this.新增銷售單據ToolStripMenuItem.Name = "新增銷售單據ToolStripMenuItem";
            this.新增銷售單據ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新增銷售單據ToolStripMenuItem.Text = "新增銷售單";
            // 
            // 銷售單列表ToolStripMenuItem
            // 
            this.銷售單列表ToolStripMenuItem.Name = "銷售單列表ToolStripMenuItem";
            this.銷售單列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.銷售單列表ToolStripMenuItem.Text = "銷售單列表";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // 未付單據ToolStripMenuItem
            // 
            this.未付單據ToolStripMenuItem.Name = "未付單據ToolStripMenuItem";
            this.未付單據ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.未付單據ToolStripMenuItem.Text = "未付單據";
            // 
            // 月結報表ToolStripMenuItem
            // 
            this.月結報表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.盤點報表ToolStripMenuItem});
            this.月結報表ToolStripMenuItem.Name = "月結報表ToolStripMenuItem";
            this.月結報表ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.月結報表ToolStripMenuItem.Text = "月結報表";
            // 
            // 盤點報表ToolStripMenuItem
            // 
            this.盤點報表ToolStripMenuItem.Name = "盤點報表ToolStripMenuItem";
            this.盤點報表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.盤點報表ToolStripMenuItem.Text = "盤點報表";
            // 
            // 系統設置ToolStripMenuItem
            // 
            this.系統設置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.角色及權限管理ToolStripMenuItem});
            this.系統設置ToolStripMenuItem.Name = "系統設置ToolStripMenuItem";
            this.系統設置ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.系統設置ToolStripMenuItem.Text = "系統設置";
            // 
            // 角色及權限管理ToolStripMenuItem
            // 
            this.角色及權限管理ToolStripMenuItem.Name = "角色及權限管理ToolStripMenuItem";
            this.角色及權限管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.角色及權限管理ToolStripMenuItem.Text = "角色及權限管理";
            // 
            // superTabItem1
            // 
            this.superTabItem1.CloseButtonVisible = false;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "主頁";
            // 
            // NavTabControl
            // 
            this.NavTabControl.BackColor = System.Drawing.Color.White;
            this.NavTabControl.CloseButtonOnTabsVisible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.NavTabControl.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.NavTabControl.ControlBox.MenuBox.Name = "";
            this.NavTabControl.ControlBox.Name = "";
            this.NavTabControl.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.NavTabControl.ControlBox.MenuBox,
            this.NavTabControl.ControlBox.CloseBox});
            this.NavTabControl.Controls.Add(this.superTabControlPanel1);
            this.NavTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavTabControl.ForeColor = System.Drawing.Color.Black;
            this.NavTabControl.Location = new System.Drawing.Point(0, 24);
            this.NavTabControl.Name = "NavTabControl";
            this.NavTabControl.ReorderTabsEnabled = true;
            this.NavTabControl.SelectedTabFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.NavTabControl.SelectedTabIndex = 0;
            this.NavTabControl.Size = new System.Drawing.Size(772, 508);
            this.NavTabControl.TabFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NavTabControl.TabIndex = 1;
            this.NavTabControl.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem2});
            this.NavTabControl.Text = "superTabControl1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel1;
            this.superTabItem2.CloseButtonVisible = false;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "主頁";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(772, 480);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.superTabItem2;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(772, 554);
            this.Controls.Add(this.NavTabControl);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavTabControl)).EndInit();
            this.NavTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 基本資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客戶資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供應商資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系統設置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色及權限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用戶資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 進貨作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增採購單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 採購單列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 進貨單列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增進貨單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷售作業ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增銷售單據ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銷售單列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 未付單據ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增報價單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 報價單列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 月結報表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 盤點報表ToolStripMenuItem;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControl NavTabControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;

    }
}