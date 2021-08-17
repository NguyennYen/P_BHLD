using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_nationRepository
    {
    }
    public class hu_nationRepository : RepositoryBase<hu_nation>, Ihu_nationRepository
    {
        public hu_nationRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
