using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHLD.Web.Models
{
    public class HuDistrictViewModel
    {
        public int id;

        public string code;

        public string district_name;

        public int province_id;

        public string remark;

        public string created_by;

        public DateTime? created_date;

        public string created_log;

        public DateTime? modified_date;

        public bool status;

    }
}