using System;
using System.Text;
using System.Data;
using System.Data.Common;

using Tools;
using Model.AboutUsers;

namespace DAL.AboutUsers
{
    public class UsersDAL
    {
        DBHelper db = new DBHelper();

        public bool Insert(Trans t, Users entity)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.AppendFormat("insert Users ( ");
            sql.AppendFormat("  LoginCode, UserName, NickName, Password, RegisterTime ");
            sql.AppendFormat(" )");
            sql.AppendFormat("values( ");
            sql.AppendFormat("  @LoginCode, @UserName, @NickName, @Password, @RegisterTime ");
            sql.AppendFormat(" ) ");
            DbCommand dbCommand = db.GetSqlStringCommond(sql.ToString());

            db.AddInParameter(dbCommand, "LoginCode",       DbType.String,      entity.LoginCode);
            db.AddInParameter(dbCommand, "UserName",        DbType.DateTime,    entity.UserName);
            db.AddInParameter(dbCommand, "NickName",        DbType.String,      entity.NickName);
            db.AddInParameter(dbCommand, "Password",        DbType.String,      entity.Password);
            db.AddInParameter(dbCommand, "RegisterTime",    DbType.String,      DateTime.Now);

            if (null != t)
            {
                return db.ExecuteNonQuery(dbCommand, t) > 0;
            }
            else
            {
                return db.ExecuteNonQuery(dbCommand) > 0;
            }
        }

        private bool Update(Trans t, string sql)
        {
            
            DbCommand dbCommand = db.GetSqlStringCommond(sql);

            if (null != t)
            {
                return db.ExecuteNonQuery(dbCommand, t) > 0;
            }
            else
            {
                return db.ExecuteNonQuery(dbCommand) > 0;
            }
        }

        public bool Delete(Trans t, Users entity)
        {
            string sql = string.Format("delete Users where LoginCode = '{0}'", entity.LoginCode);

            DbCommand dbCommand = db.GetSqlStringCommond(sql);

            if (null != t)
            {
                return db.ExecuteNonQuery(dbCommand, t) > 0;
            }
            else
            {
                return db.ExecuteNonQuery(dbCommand) > 0;
            }
        }

        private DataTable SelectTable(Trans t, string sql)
        {
            DbCommand dbCommand = db.GetSqlStringCommond(sql);

            if (null != t)
            {
                return db.ExecuteDataTable(dbCommand, t);
            }
            else
            {
                return db.ExecuteDataTable(dbCommand);
            }
        }

        private bool SelectFlag(Trans t, string sql)
        {
            DbCommand dbCommand = db.GetSqlStringCommond(sql);

            if (null != t)
            {
                return Convert.ToBoolean(db.ExecuteScalar(dbCommand, t));
            }
            else
            {
                return Convert.ToBoolean(db.ExecuteScalar(dbCommand));
            }
        }

        public bool UpdateInfo(Trans t, Users entity)
        {
            StringBuilder sql = new StringBuilder(150);
            sql.AppendFormat("update Users set UserName = '{0}', NickName = '{1}' where LoginCode = '{2}'", entity.UserName, entity.NickName, entity.LoginCode);

            return Update(t, sql.ToString());
        }

        public bool UpdatePassword(Trans t, Users entity)
        {
            StringBuilder sql = new StringBuilder(150);
            sql.AppendFormat("update Users set Password = '{0}' where LoginCode = '{1}'", entity.Password, entity.LoginCode);

            return Update(t, sql.ToString());
        }

        public bool UpdateRole(Trans t, Users entity)
        {
            StringBuilder sql = new StringBuilder(150);
            sql.AppendFormat("update Users set RoleID = '{0}' where LoginCode = '{1}'", entity.RoleID, entity.LoginCode);

            return Update(t, sql.ToString());
        }

        public bool UpdateRoleIsNull(Trans t, Users entity)
        {
            StringBuilder sql = new StringBuilder(150);
            sql.AppendFormat("update Users set RoleID = null where RoleID = '{0}'", entity.RoleID);

            return Update(t, sql.ToString());
        }

        public bool UpdatePass(Trans t, Users entity, bool isEnable)
        {
            StringBuilder sql = new StringBuilder(150);
            sql.AppendFormat("update Users set IsEnable = '{0}' where LoginCode = '{1}'", isEnable, entity.LoginCode);

            return Update(t, sql.ToString());
        }

        public bool SelectUserIsExist(Trans t, Users entity)
        {
            StringBuilder sql = new StringBuilder(150);
            sql.AppendFormat("select count(LoginCode) from Users where LoginCode = '{0}' and Password = '{1}'", entity.LoginCode, entity.Password);
            return SelectFlag(t, sql.ToString()); 
        }

        public DataTable SelectUsersList(Trans t)
        {
            return SelectTable(t, "select * from Users");
        }

        public DataTable SelectUsersListByRole(Trans t, string roleId)
        {
            return SelectTable(t, "select * from Users where RoleID = " + roleId);
        }
    }
}
