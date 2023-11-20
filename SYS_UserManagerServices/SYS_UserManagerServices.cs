using C_RESUME_DTO.CommonDTO;
using C_RESUME_Entity.SYS;
using C_RESUME_GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RESUME_SYS_UserManagerServices
{
    public class SYS_UserManagerServices: ISYS_UserManagerServices
    {
        private readonly DataContext db;
        private Generic_RepositoryServices<SYS_UserManager> UMDB;
        private Generic_RepositoryServices<dynamic> GEDB;
        public SYS_UserManagerServices(DataContext _datacontext, Generic_RepositoryServices<SYS_UserManager> UMDB, Generic_RepositoryServices<dynamic> GEDB)
        {
            this.db = _datacontext;
            this.GEDB = GEDB;
            this.UMDB = UMDB;
        }

        //public bool CreateSignUpData(SignDTO DTO)
        //{
        //    try
        //    {
                
        //    }
        //    catch 
        //    {
        //        return false;
        //    }
        //}
    }
}
