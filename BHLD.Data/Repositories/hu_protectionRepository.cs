using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protectionRepository
    {

    }
    public class hu_protectionRepository : RepositoryBase<hu_protection>, Ihu_protectionRepository
    {
        public hu_protectionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
