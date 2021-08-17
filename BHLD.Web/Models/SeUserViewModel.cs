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
 
    public class SeUserViewModel

    {
        public int id;

        public string user_name;

        public string password;

        public string email;

        public DateTime effect_date;

        public DateTime expore_date;

        public string chang_pass;

        public string actfg;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;
    }
}
