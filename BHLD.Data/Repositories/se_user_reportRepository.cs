using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_user_reportRepository : IRepository<se_user_report>
    {
        IEnumerable<se_user_report> GetAllByUserReport(int tag, int page, int pageSize, out int totalRow);
    }
    public class se_user_reportRepository : RepositoryBase<se_user_report>, Ise_user_reportRepository
    {
        public se_user_reportRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<se_user_report> GetAllByUserReport(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
