using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.AboutUsers
{
    public class UsersModuleAuthority
    {
        public int RoleID { get; set; }
        public string ModuleName { get; set; }
        public string FuncName { get; set; }
        public bool RunEnable { get; set; }
    }
}
