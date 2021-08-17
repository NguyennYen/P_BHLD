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
    public class SeUserOrgAccessViewModel
    {
        public int id ;

        public int user_id ;

        public int org_id; //khóa ngoại với bảng đơn vị

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;


    }
}
