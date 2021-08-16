using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_user_org_accessRepository
    {

    }
    public class se_user_org_accessRepository : RepositoryBase<se_user_org_access>, Ise_user_org_accessRepository
    {
        public se_user_org_accessRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
