using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protection_empRepository
    {

    }
    public class hu_protection_empRepository : RepositoryBase<hu_protection_emp>, Ihu_protection_empRepository
    {
        public hu_protection_empRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
