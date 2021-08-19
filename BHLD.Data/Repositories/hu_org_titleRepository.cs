using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_org_titleRepository : IRepository<hu_org_title>
    {
        IEnumerable<hu_org_title> GetAllByOrgTitle(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_org_titleRepository : RepositoryBase<hu_org_title>, Ihu_org_titleRepository
    {
        public hu_org_titleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_org_title> GetAllByOrgTitle(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
