using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_titleRepository
    {

    }
    public class hu_titleRepository : RepositoryBase<hu_title>
    {
        public hu_titleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
