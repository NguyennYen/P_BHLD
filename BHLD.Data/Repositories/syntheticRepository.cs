using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface IsyntheticRepository : IRepository<synthetic>
    {
        IEnumerable<synthetic> GetAllBySynthetic(int tag, int page, int pageSize, out int totalRow);
    }
    public class syntheticRepository : RepositoryBase<synthetic>, IsyntheticRepository
    {
        public syntheticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<synthetic> GetAllBySynthetic(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
