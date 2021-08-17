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
    [Table("ot_other_list")]
    public class ot_other_list: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }


        //Tên size ủng/boots size
        //eg: 36,37,38,...
        [Required]
        [StringLength(255)]
        public string name { get; set; }


        //tham chiếu phần other_list_type

        public int type_id { get; set; }

        [ForeignKey("type_id")]
        public virtual ot_other_list_type Ot_Other_List_Type { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }

        [StringLength(1)]
        public string actfg { get; set; }

    }
}
