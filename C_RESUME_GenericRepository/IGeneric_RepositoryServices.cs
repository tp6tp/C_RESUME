using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace C_RESUME_GenericRepository
{
    public interface IGeneric_RepositoryServices<TEntity> : IDisposable where TEntity : class
    {
        TEntity? Get(string sql, object parameters);
        IQueryable<TResult> GetAlls<TResult>(string sql, object parameters) where TResult : class;
        IQueryable<TResult> GetAlls<TResult>(string sql) where TResult : class;
    }
}
