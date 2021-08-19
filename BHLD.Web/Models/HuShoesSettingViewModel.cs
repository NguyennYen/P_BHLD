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
    public class HuShoesSettingViewModel
    {

        public int id;

        public int gender;

        //size bàn chân từ
        public int size_from;
        
        //size bàn chân đến
        public int size_to;
        
        //shoes size 
        public int size_id ;

        public string remark ;

        public string actfg ;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;

    }
}
