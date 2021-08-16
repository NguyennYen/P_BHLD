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

    public class HuShoesSizeViewModel
    {
        public int id;

        public string code ;

        //tên size giày
        //eg: 36,37,38,...

        public string size_name ;

        public string remark ;

        public string actflg ;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;
    }
}
