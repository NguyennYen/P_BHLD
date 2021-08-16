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
    [Table("hu_protection_size")]
    public class hu_protection_size : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //Mã size
        [Required]
        [StringLength(50)]
        public string code { get; set; }

        //Tên size bảo hộ 
        //eg: S, M ,L ,...
        [Required]
        [StringLength(255)]
        public string size_name { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }

        [StringLength(1)]
        public string actflg { get; set; }
    }
}
