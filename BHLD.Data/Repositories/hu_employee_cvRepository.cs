using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_employee_cvRepository : IRepository<hu_employee_cv>
    {
        IEnumerable<hu_employee_cv> GetAllByEmployee(int tag, int page, int pageSize, out int totalRow);
    }
    public class hu_employee_cvRepository : RepositoryBase<hu_employee_cv>, Ihu_employee_cvRepository
    {
        public hu_employee_cvRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_employee_cv> GetAllByEmployee(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
