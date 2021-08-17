using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ihu_provinceRepository
    {
    }
    public class hu_provinceRepository : RepositoryBase<hu_province>, Ihu_provinceRepository
    {
        public hu_provinceRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
