using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_employeeRepository : IRepository<hu_employee>
    {
        IEnumerable<hu_employee> GetAllByEmployee(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_employeeRepository : RepositoryBase<hu_employee>, Ihu_employeeRepository
    {
        public hu_employeeRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_employee> GetAllByEmployee(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
