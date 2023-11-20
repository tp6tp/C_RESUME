using C_RESUME_Entity.SYS;
using C_RESUME_Extension;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RESUME_GenericRepository
{
    public class DataContext : DbContext
    {
        public DataContext() : base(DBConnString.GetDBConnString())
        {
            Database.SetInitializer<DataContext>(null);
            (this as System.Data.Entity.Infrastructure.IObjectContextAdapter).ObjectContext.CommandTimeout = 60;
        }
        public DbSet<SYS_UserManager> SYS_UserManager { get; set; }
    }
}
