using System;
using System.Data;

using Tools;
using Model.AboutUsers;
using DAL.AboutUsers;

namespace BLL.AboutUsers
{
    public class UsersBLL
    {
        UsersDAL userDal = new UsersDAL();

        // 登入
        public bool Login(Users entity)
        {
            return userDal.SelectUserIsExist(null, entity);
        }

        // 注冊
        public bool Register(Users entity)
        {
            return userDal.Insert(null, entity);
        }

        // 更新資料
        public bool UpdateInfo(Users entity)
        {
            return userDal.UpdateInfo(null, entity);
        }

        // 更改密碼
        public bool ModifyPassword(Users entity)
        {
            return userDal.UpdatePassword(null, entity);
        }

        // 設定授權角色
        public bool SetRole(Users entity)
        {
            return userDal.UpdateRole(null, entity);
        }

        // 取消授權角色
        public bool SetRoleIsNull(Users entity)
        {
            return userDal.UpdateRoleIsNull(null, entity);
        }

        // 審核注冊通過
        public bool PassRegister(Users entity)
        {
            return userDal.UpdatePass(t:null, entity:entity, isEnable:true);
        }

        // 禁止用戶登入
        public bool BanUserLogin(Users entity)
        {
            return userDal.UpdatePass(t: null, entity:entity, isEnable: false);
        }

        // 刪除用戶
        public bool DeleteUser(Users entity)
        {
            return userDal.Delete(null, entity);
        }

        // 獲取用戶列表
        public DataTable GetUsers()
        {
            return userDal.SelectUsersList(null);
        }

        // 根據角色獲取用戶列表
        public DataTable GetUsersByRole(string roleId)
        {
            return userDal.SelectUsersListByRole(null, roleId);
        }
    }
}
