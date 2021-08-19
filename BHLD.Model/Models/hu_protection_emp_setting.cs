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
    [Table("hu_protection_emp_setting")]
    public class hu_protection_emp_setting :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_emp { get; set; }

        [ForeignKey("id_emp")]
        public virtual hu_protection_emp fk_hu_protection_emp { get; set; }

        public int bhld_list_id { get; set; }

        [ForeignKey("bhld_list_id")]
        public virtual hu_title Hu_Title { get;set;}

        public int amount{ get; set; }

    }
}
