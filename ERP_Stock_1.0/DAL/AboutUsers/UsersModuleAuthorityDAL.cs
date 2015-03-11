using System;
using System.Text;
using System.Data;
using System.Data.Common;

using Tools;
using Model.AboutUsers;

namespace DAL.AboutUsers
{
    public class UsersModuleAuthorityDAL
    {
        DBHelper db = new DBHelper();

        public bool Insert(Trans t, UsersModuleAuthority entity)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.AppendFormat("insert UsersModuleAuthority ( ");
            sql.AppendFormat("  RoleID, ModuleName, FuncName, RunEnable ");
            sql.AppendFormat(" )");
            sql.AppendFormat("values( ");
            sql.AppendFormat("  @RoleID, @ModuleName, @FuncName, @RunEnable ");
            sql.AppendFormat(" ) ");
            DbCommand dbCommand = db.GetSqlStringCommond(sql.ToString());

            db.AddInParameter(dbCommand, "RoleID", DbType.String, entity.RoleID);
            db.AddInParameter(dbCommand, "ModuleName", DbType.DateTime, entity.ModuleName);
            db.AddInParameter(dbCommand, "FuncName", DbType.String, entity.FuncName);
            db.AddInParameter(dbCommand, "RunEnable", DbType.Boolean, entity.RunEnable);

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

        public bool Delete(Trans t, UsersModuleAuthority entity)
        {
            string sql = string.Format("delete UsersModuleAuthority where RoleID = '{0}' and ModuleName = '{1}' and FuncName = '{2}'", entity.RoleID, entity.ModuleName, entity.FuncName);

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

        public bool UpdateInfo(Trans t, UsersModuleAuthority entity, bool isRunEnable)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.AppendFormat("update UsersModuleAuthority set RunEnable = '{0}' where RoleID = '{1}' and ModuleName = '{2}' and FuncName = '{3}'", isRunEnable ,entity.RoleID, entity.ModuleName, entity.FuncName);

            return Update(t, sql.ToString());
        }

        public DataTable SelectMAByRoleID(Trans t, string roleId)
        {
            return SelectTable(t, "select * from UsersModuleAuthority where RoleID = " + roleId);
        }
    }
}
