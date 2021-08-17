using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_userRepository
    {

    }
    public class se_userRepository : RepositoryBase<se_user>, Ise_userRepository
    {
        public se_userRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
