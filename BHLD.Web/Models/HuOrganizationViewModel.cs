using BHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Web.Models
{
    public class HuOrganizationViewModel
    {

        public int id;

        public string code;

        public string name_vn;

        public int parent_id;

        public int level_id ;

        public DateTime dissolve_date;

        public DateTime foundation_date;

        public string  address;
        
        public int org_no;

        public string remark;

        public string actfg ;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;
    }
}
