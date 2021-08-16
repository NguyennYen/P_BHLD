using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_protection_emp_settingRepository
    {
    }
    public class hu_protection_emp_settingRepository : RepositoryBase<hu_protection_emp_setting>, Ihu_protection_emp_settingRepository
    {
        public hu_protection_emp_settingRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
