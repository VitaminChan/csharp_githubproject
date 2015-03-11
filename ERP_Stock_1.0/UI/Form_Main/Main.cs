using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

using UI.UILibHelper;
namespace UI.Form_Main
{
    public partial class frmMain : DevComponents.DotNetBar.OfficeForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        //左右布局效果
        private void OpenForm(Form form, string caption)
        {
            bool IsOpened = false;

            foreach (SuperTabItem tabitem in NavTabControl.Tabs)
            {
                if (tabitem.Name == caption)
                {
                    NavTabControl.SelectedTab = tabitem;
                    IsOpened = true;
                    break;
                }
            }

            if (!IsOpened)
            {
                SuperTabItem superTabItem   = NavTabControl.CreateTab(caption);
                superTabItem.Name           = caption;
                superTabItem.Text           = caption;

                Panel panel                 = new Panel();
                panel.Padding               = new System.Windows.Forms.Padding(5);
                panel.Dock                  = DockStyle.Fill;
                panel.BackColor             = Color.White;
                panel.BorderStyle           = BorderStyle.FixedSingle;

                form.TopLevel               = false;
                form.Visible                = true;
                form.Dock                   = DockStyle.Fill;
                form.FormBorderStyle        = FormBorderStyle.None;
                form.Parent                 = panel;

                superTabItem.AttachedControl.Controls.Add(panel);

                this.NavTabControl.SelectedTab = superTabItem;
            }

        }

        private void 用戶資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_BaseInfo.Form_Users.frmUsersList frmUsersList = new Menu_BaseInfo.Form_Users.frmUsersList();
            OpenForm(frmUsersList, sender.ToString());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeUI();
            InitializeMenuSetting();
        }

        public void InitializeMenuSetting()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                SystemMenu entity = new SystemMenu()
                {
                    IsMainMenu = true,
                    ModuleName = item.Text,
                    SubMenus = new List<SystemMenu>()
                };

                for(int index = 0; index < item.DropDownItems.Count; index++)
                {
                    ToolStripMenuItem subItem = item.DropDownItems[index] as ToolStripMenuItem;

                    if (null != subItem)
                    {
                        //SetMainMenuAuthority();

                        entity.SubMenus.Add(new SystemMenu() { IsMainMenu = false, ModuleName = subItem.Text });
                    }
                }

                SaveMenuList(entity);
            }
        }

        public void SetMainMenuAuthority(ToolStripMenuItem item, bool isRunEnabel)
        {
            item.Enabled = isRunEnabel;
        }

        public void SaveMenuList(SystemMenu entity)
        {
            SystemLibHelper.SetSystemMenu(entity);
        }

        public void InitializeUI()
        {
        }

        private void 基本資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}