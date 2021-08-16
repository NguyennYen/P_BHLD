using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protection_titleRepository
    {

    }
    public class hu_protection_titleRepository : RepositoryBase<hu_protection_title>, Ihu_protection_titleRepository
    {
        public hu_protection_titleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
