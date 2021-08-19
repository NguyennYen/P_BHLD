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
    [Table("hu_organization")]
    public class hu_organization : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string name_vn { get; set; }

        public int parent_id { get; set; }

        public int level_id { get; set; }

        public DateTime dissolve_date { get; set; }

        public DateTime foundation_date { get; set; }

        public string  address { get; set; }
        
        //sort by display order
        public int org_no { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }

        [StringLength(1)]
        public string actfg { get; set; }
    }
}
