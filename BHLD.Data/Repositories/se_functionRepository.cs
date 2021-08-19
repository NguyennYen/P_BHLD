using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_functionRepository : IRepository<se_function>
    {
        IEnumerable<se_function> GetAllByFunction(int tag, int page, int pageSize, out int totalRow);
    }
    public class se_functionRepository : RepositoryBase<se_function>, Ise_functionRepository
    {
        public se_functionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<se_function> GetAllByFunction(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}


