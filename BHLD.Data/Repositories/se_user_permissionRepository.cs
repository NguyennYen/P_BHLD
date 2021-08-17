using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_user_permissionRepository
    {

    }
    public class se_user_permissionRepository : RepositoryBase<se_user_permission>, Ise_user_permissionRepository
    {
        public se_user_permissionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
