using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_districtRepository : IRepository<hu_district>
    {
    }
    public class hu_districtRepository : RepositoryBase<hu_district>, Ihu_districtRepository
    {
        public hu_districtRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_district> GetAllByDistrict(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
