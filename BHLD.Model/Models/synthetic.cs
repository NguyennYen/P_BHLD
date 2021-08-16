using BHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  BHLD.Model.Models
{
    [Table("synthetic")]
    public class synthetic :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        
        public int org_id { get; set; }

        [ForeignKey("org_id")]
        public virtual hu_organization fk_hu_organization { get; set; }

        public int parent_id { get; set; }

        [ForeignKey("parent_id")]
        public virtual hu_organization fk_hu_organization1 { get; set; }

        public virtual IEnumerable<hu_organization> Hu_Organizations { get; set; }

        public int famale { get; set; }

        public int male { get; set; }

        public int total { get; set; }

        public int men_per_clothes { get; set; }

        public int women_per_clothes { get; set; }

        public int men_jacket { get; set; }

        public int women_jacket { get; set; }

        public int men_gile { get; set; }

        public int woman_gile { get; set; }

        public int shoes { get; set; }

        public int boots { get; set; }

        public int soap { get; set; }

        public int canvas_bag { get; set; }

        public int rain_clothes { get; set; }


    }
}
