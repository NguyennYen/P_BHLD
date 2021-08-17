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
    [Table("hu_shoes_setting")]
    public class hu_shoes_setting : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int gender { get; set; }

        //size bàn chân từ
        public int size_from { get; set; }
        
        //size bàn chân đến
        public int size_to { get; set; }
        
        //shoes size 
        public int size_id { get; set; }

        [ForeignKey("size_id")]
        public virtual hu_shoes_size Hu_Shoes_Size { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }

        [StringLength(1)]
        public string actfg { get; set; }

    }
}
