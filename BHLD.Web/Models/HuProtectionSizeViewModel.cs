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
    public class HuProtectionSizeViewModel
    {

        public int id;

        public string code ;

        //Tên size bảo hộ 
        //eg: S, M ,L ,...
        public string size_name ;

        public string remark;

        public string actflg ;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;
    }
}
