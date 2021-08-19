using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protectionRepository : IRepository<hu_protection>
    {
        IEnumerable<hu_protection> GetAllByProtection(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_protectionRepository : RepositoryBase<hu_protection>, Ihu_protectionRepository
    {
        public hu_protectionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_protection> GetAllByProtection(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
