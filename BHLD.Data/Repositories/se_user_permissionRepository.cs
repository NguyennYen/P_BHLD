using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_user_permissionRepository : IRepository<se_user_permission>
    {
        IEnumerable<se_user_permission> GetAllByUserPermiss(int tag, int page, int pageSize, out int totalRow);
    }
    public class se_user_permissionRepository : RepositoryBase<se_user_permission>, Ise_user_permissionRepository
    {
        public se_user_permissionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<se_user_permission> GetAllByUserPermiss(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}
