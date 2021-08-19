using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_nationRepository : IRepository<hu_nation>
    {
        IEnumerable<hu_nation> GetAllByDistrict(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_nationRepository : RepositoryBase<hu_nation>, Ihu_nationRepository
    {
        public hu_nationRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_nation> GetAllByDistrict(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
