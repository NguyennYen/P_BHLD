using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface IsyntheticRepository
    {

    }
    public class syntheticRepository : RepositoryBase<synthetic>, IsyntheticRepository
    {
        public syntheticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
