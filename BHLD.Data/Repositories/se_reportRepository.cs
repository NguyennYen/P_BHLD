using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_reportRepository : IRepository<se_report>
    {
        IEnumerable<se_report> GetAllByReport(int tag, int page, int pageSize, out int totalRow);
    }
    public class se_reportRepository : RepositoryBase<se_report>, Ise_reportRepository
    {
        public se_reportRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<se_report> GetAllByReport(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}


