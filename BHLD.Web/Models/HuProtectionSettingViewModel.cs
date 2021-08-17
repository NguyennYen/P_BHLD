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
    public class HuProtectionSettingViewModel
    { 
        public int id ;

        //giới tính
        public int gender ;

        //vòng bụng
        public int belly;

        //vòng mông
        public int butt ;

        //đai quần
        public int belt ;

        //vòng ngực
        public int chest ;

        //rộng vai
        public int shoulder ;

        //size of Protection Gear
        
        public int size_id ;

        public string remark ;

        public string actfg;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;

    }

}
