using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BHLDDbContext dbContext;

        public BHLDDbContext Init()
        {
            return dbContext ?? (dbContext = new BHLDDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
