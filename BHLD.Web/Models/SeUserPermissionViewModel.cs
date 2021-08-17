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
    public class SeUserPermissionViewModel
    {
         
        public int id ;

        public int user_id ;

        public int alllow_create;

        public int allow_modify ;

        public int allow_delete ;

        public int allow_print ;

        public int alllow_iport ;

        public int allow_export ;

        public int allow_special1 ;

        public int allow_special2 ;

        public int allow_special3 ;

        public int allow_special4 ;

        public int function_id;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;

    }
}
