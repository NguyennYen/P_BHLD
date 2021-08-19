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
    [Table("se_user_permission")]
    public class se_user_permission:Auditable
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }

            public int user_id { get; set; }

            [ForeignKey("user_id")] 
            public virtual se_user fk_se_user { get; set; }

            public int alllow_create { get; set; }

            public int allow_modify { get; set; }

            public int allow_delete { get; set; }

            public int allow_print { get; set; }

            public int alllow_iport { get; set; }

            public int allow_export { get; set; }

            public int allow_special1 { get; set; }

            public int allow_special2 { get; set; }

            public int allow_special3 { get; set; }

            public int allow_special4 { get; set; }
            
            public int function_id { get; set; }

            [ForeignKey("function_id")]
            public virtual se_function fk_se_function { get; set; }
 
    }
}
