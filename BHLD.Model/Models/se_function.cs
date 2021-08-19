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
    [Table("se_function")]
    public class se_function: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public int group_id { get; set; }

        [ForeignKey("group_id")]
        public virtual se_function_group Se_Function_Group{ get; set; }

        public int fid { get; set; }

        [StringLength(255)]
        public string chang_pass { get; set; }

        //public virtual IEnumerable<se_function_group> Se_Function_Groups { get; set; }

    }
}
