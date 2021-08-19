using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {

        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime? created_date { get; set; }

        [StringLength(255)]
        public string created_log { get; set; }

        public DateTime? modified_date { get; set; }
        public bool status { set; get; }

    }
}
