using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_org_titleRepository
    {
    }
    public class hu_org_titleRepository : RepositoryBase<hu_org_title>, Ihu_org_titleRepository
    {
        public hu_org_titleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
