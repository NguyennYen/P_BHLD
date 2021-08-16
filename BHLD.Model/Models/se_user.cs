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
    [Table("se_user")]
    public class se_user :Auditable

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string user_name { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public DateTime effect_date { get; set; }

        public DateTime expore_date { get; set; }

        [StringLength(255)]
        public string chang_pass { get; set; }

        [StringLength(1)]
        public string actfg { get; set; }
    }
}
