using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protection_titleRepository : IRepository<hu_protection_title>
    {
        IEnumerable<hu_protection_title> GetAllByProtectionTitle(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_protection_titleRepository : RepositoryBase<hu_protection_title>, Ihu_protection_titleRepository
    {
        public hu_protection_titleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_protection_title> GetAllByProtectionTitle(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
