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
    public class OtherListViewModel
    {

        public int id;

        public string code ;

        //Tên size ủng/boots size
        //eg: 36,37,38,...
        public string name ;


        //tham chiếu phần other_list_type

        public int type_id ;

        [StringLength(1023)]
        public string remark;

        public string actfg ;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;

    }
}
