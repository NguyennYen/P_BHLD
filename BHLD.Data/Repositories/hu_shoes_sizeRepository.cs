using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_shoes_sizeRepository : IRepository<hu_shoes_size>
    {
        IEnumerable<hu_shoes_size> GetAllByShoesSize(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_shoes_sizeRepository : RepositoryBase<hu_shoes_size>, Ihu_shoes_sizeRepository
    {
        public hu_shoes_sizeRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_shoes_size> GetAllByShoesSize(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
