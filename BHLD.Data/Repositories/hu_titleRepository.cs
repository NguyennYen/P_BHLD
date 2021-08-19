using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BHLD.Data.Repositories
{
    public interface Ihu_titleRepository : IRepository<hu_title>
    {
        IEnumerable<hu_title> GetAllByTitle(int tag, int pageIndex, int pageSize, out int totalRow);
    }
    public class hu_titleRepository : RepositoryBase<hu_title>, Ihu_titleRepository
    {
        public hu_titleRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<hu_title> GetAllByTitle(int tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.hu_Titles
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}
