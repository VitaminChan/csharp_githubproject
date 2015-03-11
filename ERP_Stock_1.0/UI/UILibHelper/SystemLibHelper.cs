using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UILibHelper
{
    static class SystemLibHelper
    {
        static List<SystemMenu> SystemMenu = new List<SystemMenu>();

        public static List<SystemMenu> GetSystemMenu()
        {
            return SystemMenu;
        }

        public static void SetSystemMenu(SystemMenu entity)
        {
            SystemMenu.Add(entity);
        }
    }

    public class SystemMenu
    {
        public string ModuleName { get; set; }
        public bool IsMainMenu { get; set; }
        public List<SystemMenu> SubMenus { get; set; }
    }
}
