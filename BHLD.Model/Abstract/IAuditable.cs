using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Model.Abstract
{
    public interface IAuditable
    {

        string created_by { get; set; }

        DateTime? created_date { get; set; }

        string created_log { get; set; }


        DateTime? modified_date { get; set; }

    }
}
