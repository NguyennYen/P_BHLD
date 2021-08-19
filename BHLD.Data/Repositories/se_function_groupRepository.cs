using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_function_groupRepository : IRepository<se_function_group>
    {
        IEnumerable<se_function_group> GetAllByFunctionGroup(int tag, int page, int pageSize, out int totalRow);
    }
    public class se_function_groupRepository : RepositoryBase<se_function_group>, Ise_function_groupRepository
    {
        public se_function_groupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<se_function_group> GetAllByFunctionGroup(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}


