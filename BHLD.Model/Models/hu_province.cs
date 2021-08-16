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
    [Table("hu_province")]
    public class hu_province : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string province_name { get; set; }

        //Mã quốc gia
       
        public int nation_id { get; set; }

        [ForeignKey("nation_id")]
        public virtual hu_nation hu_nation{ get; set; }

        [StringLength(1023)]
        public string remark { get; set; }

        [StringLength(1)]
        public string actflg { get; set; }

        public virtual IEnumerable<hu_district> hu_districts { get; set; }
    }
}
