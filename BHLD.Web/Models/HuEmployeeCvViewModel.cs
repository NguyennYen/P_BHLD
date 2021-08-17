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
   
    public class HuEmployeeCVViewModel
    {

        public int id;

        public int employee_id ;

        public int gender;

        public DateTime? birthdate;

        public int id_no;//số cmtnd

        public DateTime id_date ;//ngày cấp

        public string id_place;//nơi cấp
  
        public string per_address ;//địa chỉ thường trú

        public string per_nation;//quốc gia
        
        public string per_province ; //tỉnh thành

        public string per_district;//huyện

        public string per_ward ;//xã 

        public string nav_address ;//địa chỉ tạm trú

        public string nav_nation ; //quốc gia

        public string nav_province ;//tỉnh thành

        public string nav_district;//huyện

        public string nav_ward ;//xã

        public string email;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;


    }
}
