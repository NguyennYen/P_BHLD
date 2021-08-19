using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Iot_other_listRepository : IRepository<ot_other_list>
    {
        IEnumerable<ot_other_list> GetAllByList(int tag, int page, int pageSize, out int totalRow);
    }
    public class ot_other_listRepository : RepositoryBase<ot_other_list>, Iot_other_listRepository
    {
        public ot_other_listRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<ot_other_list> GetAllByList(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}

