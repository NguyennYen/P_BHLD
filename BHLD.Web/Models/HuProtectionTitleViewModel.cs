﻿using BHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Web.Models
{
    public class HuProtectionTitleViewModel { 

        public int id ;
        
        //tham chiếu phần other_list_type
       
        public int type_id;

        public int title_id;

        public DateTime effect_date;

        public DateTime expire_date;

        public string remark ;

        public string actfg;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;

    }
}
