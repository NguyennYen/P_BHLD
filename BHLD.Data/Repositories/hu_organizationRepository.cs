using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_organizationRepository
    {
    }
    public class hu_organizationRepository : RepositoryBase<hu_organization>, Ihu_organizationRepository
    {
        public hu_organizationRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
