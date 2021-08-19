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
    [Table("hu_protection_title_setting")]
    public class hu_protection_title_setting:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int bhld_title_id { get; set; }

        [ForeignKey("bhld_title_id")]
        public virtual hu_protection_setting fk_hu_protection_setting { get; set; }

        public int bhld_list_id { get; set; }

        [ForeignKey("bhld_list_id")]
        public virtual hu_protection_title fk_hu_protection_title { get; set; }

        public int amount { get; set; }
      
        public DateTime? effect_date { get; set; }
       
        public DateTime? expire_date { get; set; }

        [StringLength(1)]
        public string actfg { get; set; }
        
        [StringLength(1023)]
        public string remark { get; set; }

    }
}
