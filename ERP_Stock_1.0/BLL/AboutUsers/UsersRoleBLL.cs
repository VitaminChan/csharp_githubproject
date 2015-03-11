using System;
using System.Data;

using Model.AboutUsers;
using DAL.AboutUsers;
using Tools;

namespace BLL.AboutUsers
{
    public class UsersRoleBLL
    {
        UsersRoleDAL usersRoleDal = new UsersRoleDAL();

        // 新增角色
        public bool AddRole(UsersRole entity)
        {
            return usersRoleDal.Insert(null, entity);
        }

        // 修改角色名稱
        public bool ModifyRoleName(UsersRole entity)
        {
            return usersRoleDal.UpdateRoleName(null, entity);
        }

        // 獲取角色列表
        public DataTable GetRoleList()
        {
            return usersRoleDal.SelectRoleList(null);
        }

        // 刪除角色及其所屬權限, 並將所屬用戶之角色設為空
        public bool DeleteRole(UsersRole entity)
        {
            using (Trans t = new Trans())
            {
                try
                {
                    // delete UsersModuleAuthority

                    // delete UsersRole
                    if (!usersRoleDal.Delete(t, entity))
                    {
                        throw new Exception();
                    }

                    // update Users set Role = null
                    if (!new UsersDAL().UpdateRoleIsNull(t, new Users(){RoleID = "1"}))
                    {
                        throw new Exception();
                    }

                    t.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    t.RollBack();
                    return false;
                    throw ex;
                }
            }
        }

    }
}
