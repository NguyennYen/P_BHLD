using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_wardRepository
    {

    }
    public class hu_wardRepository : RepositoryBase<hu_ward>, Ihu_wardRepository
    {
        public hu_wardRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}

