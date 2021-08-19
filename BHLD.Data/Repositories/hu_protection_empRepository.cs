using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protection_empRepository : IRepository<hu_protection_emp>
    {
        IEnumerable<hu_protection_emp> GetAllByProtection(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_protection_empRepository : RepositoryBase<hu_protection_emp>, Ihu_protection_empRepository
    {
        public hu_protection_empRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_protection_emp> GetAllByProtection(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
