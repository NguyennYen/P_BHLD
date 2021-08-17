using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_function_groupRepository
    {

    }
    public class se_function_groupRepository : RepositoryBase<se_function_group>, Iot_other_list_typeRepository
    {
        public se_function_groupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}


