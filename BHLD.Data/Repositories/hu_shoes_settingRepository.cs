using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_shoes_settingRepository
    {

    }
    public class hu_shoes_settingRepository : RepositoryBase<hu_shoes_setting>, Ihu_shoes_settingRepository
    {
        public hu_shoes_settingRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
