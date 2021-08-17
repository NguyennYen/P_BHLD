using BHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Model.Models
{
    [Table("hu_employee_cv")]
    public class hu_employee_cv : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual hu_employee fk_hu_employee { get; set; }

        public int gender { get; set; }

        public DateTime? birthdate { get; set; }

        public int id_no { get; set; }//số cmtnd

        public DateTime id_date { get; set; }//ngày cấp

        [StringLength(255)]
        public string id_place { get; set; }//nơi cấp

        [StringLength(255)]
        public string per_address { get; set; }//địa chỉ thường trú

        [StringLength(255)]
        public string per_nation { get; set; }//quốc gia

        [StringLength(255)]
        public string per_province { get; set; } //tỉnh thành

        [StringLength(255)]
        public string per_district { get; set; }//huyện

        [StringLength(255)]
        public string per_ward { get; set; }//xã 

        [StringLength(255)]
        public string nav_address { get; set; }//địa chỉ tạm trú

        [StringLength(255)]
        public string nav_nation { get; set; } //quốc gia

        [StringLength(255)]
        public string nav_province { get; set; }//tỉnh thành

        [StringLength(255)]
        public string nav_district { get; set; }//huyện

        [StringLength(255)]
        public string nav_ward { get; set; }//xã

        [StringLength(255)]
        public string email { get; set;}

       
    }
}
