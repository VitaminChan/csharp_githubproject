using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace UI.Menu_BaseInfo.Form_Users
{
    public partial class UsersList : DevComponents.DotNetBar.OfficeForm
    {
        public UsersList()
        {
            InitializeComponent();

            this.superGridControl1.PrimaryGrid.DataSource = usersA;
        }

        List<Users> usersA = new List<Users>()
        {
            new Users(){UserName = "a"},
            new Users(){UserName = "b"},
            new Users(){UserName = "c"},
            new Users(){UserName = "d"},
            new Users(){UserName = "e"},
        };
        List<Users> usersB = new List<Users>()
        {
            new Users(){UserName = "h"},
            new Users(){UserName = "i"},
            new Users(){UserName = "j"}
        };

        private void advTree1_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            DevComponents.AdvTree.AdvTree advTree = sender as DevComponents.AdvTree.AdvTree;

            if (null != advTree)
            {
                if (advTree.SelectedNode.Text.Equals("±ÄÁÊ¥DºÞ"))
                {
                    this.superGridControl1.PrimaryGrid.DataSource = null;
                    this.superGridControl1.PrimaryGrid.DataSource = usersA;
                }
                else
                {
                    this.superGridControl1.PrimaryGrid.DataSource = null;
                    this.superGridControl1.PrimaryGrid.DataSource = usersB;
                }
            }
        }
    }

    class Users
    {
        public string LoginCode { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string LastLoginTime { get; set; }
        public string RegisterTime { get; set; }
        public string LoginStatus { get; set; }
        public string IsEnable { get; set; }
        public string RoleID { get; set; }
    }
}