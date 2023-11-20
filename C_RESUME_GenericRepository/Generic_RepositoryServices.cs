using C_RESUME_Extension;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RESUME_GenericRepository
{
    public class Generic_RepositoryServices<TEntity> : DBConnString, IGeneric_RepositoryServices<TEntity>, IDisposable where TEntity : class
    {
        private DataContext? _datacontext;
        public Generic_RepositoryServices(DataContext datacontext)
        {
            this._datacontext = datacontext;
        }


        public TEntity? Get(string sql, object parameters)
        {
            TEntity? info;
            using (var cn = new SqlConnection(GetDBConnString()))
            {
                info = cn.QueryFirstOrDefault<TEntity?>(sql, parameters);
            }
            return info;
        }

        public IQueryable<TResult> GetAlls<TResult>(string sql, object parameters) where TResult : class
        {
            IQueryable<TResult> info;
            using (var cn = new SqlConnection(GetDBConnString()))
            {
                info = cn.Query<TResult>(sql, parameters).AsQueryable();
            }
            return info;
        }
        public IQueryable<TResult> GetAlls<TResult>(string sql) where TResult : class
        {
            IQueryable<TResult> info;
            using (var cn = new SqlConnection(GetDBConnString()))
            {
                info = cn.Query<TResult>(sql).AsQueryable();
            }
            return info;
        }


        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(this._datacontext != null)
                {
                    this._datacontext.Dispose();
                    this._datacontext = null;
                }
            }
        }
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        
    }
}
