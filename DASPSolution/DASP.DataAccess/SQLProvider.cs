using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Data.Common;

namespace DASP.DataAccess
{
    /// <summary>
    /// SQLPriv 的摘要说明。
    /// </summary>
    public class SQLProvider : IDbProvider
    {
        public SQLProvider()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region IDbProvider 成员

        public System.Data.IDbConnection CreateConnection()
        {
            // TODO:  添加 SQLPriv.CreateConnection 实现
            return null;
        }

        public string CreateParameterName(string name)
        {
            // TODO:  添加 SQLPriv.CreateParameterName 实现
            return null;
        }

        public System.Data.IDbDataParameter CreateParameter()
        {
            // TODO:  添加 SQLPriv.CreateParameter 实现
            return null;
        }

        private string _connectionString = "";
        public string ConnectionString
        {
            get
            {
                // TODO:  添加 SQLPriv.ConnectionString getter 实现
                return _connectionString;
            }
            set
            {
                _connectionString = value;
                // TODO:  添加 SQLPriv.ConnectionString setter 实现
            }
        }

        public string ExtractError(Exception e)
        {
            // TODO:  添加 SQLPriv.ExtractError 实现
            return null;
        }

        public System.Data.IDbDataAdapter CreateDataAdapter()
        {
            // TODO:  添加 SQLPriv.CreateDataAdapter 实现
            return null;
        }

        public bool IsDataAccessException(Exception e)
        {
            // TODO:  添加 SQLPriv.IsDataAccessException 实现
            return false;
        }

        public System.Data.IDbCommand CreateCommand()
        {
            // TODO:  添加 SQLPriv.CreateCommand 实现
            return null;
        }

        public object CreateCommandBuilder()
        {
            // TODO:  添加 SQLPriv.CreateCommandBuilder 实现
            return null;
        }

        public IDbMetadata DbMetadata
        {
            get
            {
                // TODO:  添加 SQLPriv.DbMetadata getter 实现
                return null;
            }
        }

        public string CreateParameterNameForCollection(string name)
        {
            // TODO:  添加 SQLPriv.CreateParameterNameForCollection  实现
            return null;
        }

        #endregion

    }

}
