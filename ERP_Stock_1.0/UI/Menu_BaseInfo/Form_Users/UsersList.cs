using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.AdvTree;

using BLL.AboutUsers;

namespace UI.Menu_BaseInfo.Form_Users
{
    public partial class frmUsersList : DevComponents.DotNetBar.OfficeForm
    {
        UsersBLL usersBll = new UsersBLL();

        UsersRoleBLL usersRoleBll = new UsersRoleBLL();

        public frmUsersList()
        {
            InitializeComponent();
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            InitializeControlsData();

            BindRoleList();

            List<UILibHelper.SystemMenu> item = UILibHelper.SystemLibHelper.GetSystemMenu();
        }

        void InitializeControlsData()
        {
            Node defaultNode = new Node() { Name = "0", Text = "Àq»{" };

            this.advTreeRoleList.Nodes.Add(defaultNode);
        }

        void BindRoleList()
        {
            DataTable resultDt = GetRoleList();

            if (null != resultDt)
            {
                foreach (DataRow dr in resultDt.Rows)
                {
                    advTreeRoleList.Nodes.Add(new Node() { Text = dr["RoleName"].ToString(), Name = dr["RoleID"].ToString() });
                }
            }
        }

        void BindUsersListByRoleId(string roleId)
        {
            DataTable resultDt = GetUsersListByRoleId(roleId);

            if (null != resultDt)
            {
                GridPanel panel = this.superGridControl1.PrimaryGrid;

                panel.DataSource = resultDt;
            }
        }

        DataTable GetRoleList()
        {
            return usersRoleBll.GetRoleList();
        }

        DataTable GetUsersListByRoleId(string roleId)
        {
            return usersBll.GetUsersByRole(roleId);
        }

        private void advTreeRoleList_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            AdvTree advTree = sender as AdvTree;

            if (null != advTree)
            {
                string roleId = advTree.SelectedNode.Name;

                BindUsersListByRoleId(roleId);
            }
        }

    }
}