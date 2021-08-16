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
    [Table("hu_employee")]
    public class hu_employee : Auditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set;}

        public int employee_code { get; set; }

        [Required]
        [StringLength(255)]
        public string fullname { get; set; }

        public int org_id { get; set; }

        [ForeignKey("org_id")]
        public virtual hu_organization fk_hu_organization { get; set; } //khóa ngoại với bảng đơn vị

        public int title_id { get; set; }

        [ForeignKey("title_id")]
        public virtual hu_title fk_hu_title { get; set; } //khóa ngoại với bảng chức danh

        public DateTime join_date { get; set; }

        [StringLength(1)]
        public string actfg { get; set; }

        public virtual IEnumerable<hu_employee_cv> Hu_Employee_Cvs { get; set; }

    }
}
