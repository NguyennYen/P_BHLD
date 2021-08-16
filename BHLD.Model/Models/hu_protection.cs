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
    [Table("hu_protection")]
    public class hu_protection : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //Mã bảo hộ
        [Required]
        [StringLength(50)]
        public string code { get; set; }

        //Tên bảo hộ
        [Required]
        [StringLength(255)]
        public string protection_name { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }

        [StringLength(1)]
        public string actflg
        {
            get; set;
        }
    }
}
