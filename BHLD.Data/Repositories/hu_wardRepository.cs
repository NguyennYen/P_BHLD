using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_wardRepository : IRepository<hu_ward>
    {
        IEnumerable<hu_ward> GetAllByWard(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_wardRepository : RepositoryBase<hu_ward>, Ihu_wardRepository
    {
        public hu_wardRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_ward> GetAllByWard(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}

