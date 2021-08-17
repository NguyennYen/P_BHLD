using BHLD.Data.Infrastructure;
using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Repositories
{
    public interface Ise_functionRepository
    {

    }
    public class se_functionRepository : RepositoryBase<se_function_group>, Ise_functionRepository
    {
        public se_functionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public void Add(se_function post)
        {
            throw new NotImplementedException();
        }

        public void Update(se_function post)
        {
            throw new NotImplementedException();
        }
    }
}


