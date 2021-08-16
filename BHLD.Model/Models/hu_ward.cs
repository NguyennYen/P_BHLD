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
    [Table("hu_ward")]
    public class hu_ward : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string ward_name { get; set; }


        //mã quận huyện
        //[ForeignKey("province_id")]
        public int district_id { get; set; }

        [ForeignKey("district_id")]
        public virtual hu_district hu_district { get; set; }


        [StringLength(1023)]
        public string remark { get; set; }
         
        [StringLength(1)]
        public string actfg { get; set; }

    
    }
}
