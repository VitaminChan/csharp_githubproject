using System;
using System.Data;

using Tools;
using Model.AboutUsers;
using DAL.AboutUsers;

namespace BLL.AboutUsers
{
    public class UsersModuleAuthorityBLL
    {
        UsersModuleAuthorityDAL usersMADal = new UsersModuleAuthorityDAL();

        // 新增權限
        public bool AddModuleAuthority(UsersModuleAuthority entity)
        {
            return usersMADal.Insert(null, entity);
        }

        // 修改權限是否可執行
        public bool ModifyMAIsRunEnable(UsersModuleAuthority entity, bool isRunEnable)
        {
            return usersMADal.UpdateInfo(null, entity, isRunEnable);
        }

        // 刪除權限
        public bool DeleteMA(UsersModuleAuthority entity)
        {
            return usersMADal.Delete(null, entity);
        }

        // 根據角色獲取權限列表
        public DataTable GetMAListByRoleID(string roleId)
        {
            return usersMADal.SelectMAByRoleID(null, roleId);
        }

    }
}
