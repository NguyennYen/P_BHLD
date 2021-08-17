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
    public class HuWardViewModel
    {
        public int id;

        public string code;

        public string ward_name ;


        //mã quận huyện
        //[ForeignKey("province_id")]
        public int district_id;

        public string remark;

        public string actfg;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;


    }
}
