using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.AboutUsers
{
    public class Users
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
