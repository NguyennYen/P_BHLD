using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_userRepository : IRepository<se_user>
    {
        IEnumerable<se_user> GetAllByUser(int tag, int page, int pageSize, out int totalRow);
    }
    public class Se_userRepository : RepositoryBase<se_user>, Ise_userRepository
    {
        public Se_userRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<se_user> GetAllByUser(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
