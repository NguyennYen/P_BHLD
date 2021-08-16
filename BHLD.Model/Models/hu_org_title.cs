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
    [Table("hu_org_title")]
    public class hu_org_title : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //mã đơn vị
        
        public int org_id { get; set; }
        
        [ForeignKey("org_id")]
        public virtual hu_organization Hu_Organization { get; set; }

        //chức danh theo đơn vị

        public int title_id { get; set; }

        [ForeignKey("title_id")]
        public virtual hu_title Hu_Title
        {
            get; set;
        }
        [StringLength(1)]
        public string actfg { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }


    }
}
