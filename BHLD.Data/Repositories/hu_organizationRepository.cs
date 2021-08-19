using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_organizationRepository : IRepository<hu_organization>
    {
        IEnumerable<hu_organization> GetAllByOrg(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_organizationRepository : RepositoryBase<hu_organization>, Ihu_organizationRepository
    {
        public hu_organizationRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_organization> GetAllByOrg(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
