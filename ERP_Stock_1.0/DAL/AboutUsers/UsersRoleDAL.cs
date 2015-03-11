using System;
using System.Text;
using System.Data;
using System.Data.Common;

using Tools;
using Model.AboutUsers;

namespace DAL.AboutUsers
{
    public class UsersRoleDAL
    {
        DBHelper db = new DBHelper();

        public bool Insert(Trans t, UsersRole entity)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.AppendFormat("insert UsersRole ( ");
            sql.AppendFormat("  RoleName ");
            sql.AppendFormat(" )");
            sql.AppendFormat("values( ");
            sql.AppendFormat("  @RoleName ");
            sql.AppendFormat(" ) ");
            DbCommand dbCommand = db.GetSqlStringCommond(sql.ToString());

            db.AddInParameter(dbCommand, "RoleName", DbType.String, entity.RoleName);

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

        public bool Delete(Trans t, UsersRole entity)
        {
            string sql = string.Format("delete UsersRole where RoleName = '{0}'", entity.RoleName);

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

        public bool UpdateRoleName(Trans t, UsersRole entity)
        {
            return Update(t, string.Format("update UsersRole set RoleName = '{0}' where RoleID = '{1}'", entity.RoleName, entity.RoleID));
        }

        public DataTable SelectRoleList(Trans t)
        {
            return SelectTable(t, "select * from UsersRole");
        }
    }
}
