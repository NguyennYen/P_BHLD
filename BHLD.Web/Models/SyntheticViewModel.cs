using BHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  BHLD.Web.Models
{
    public class SyntheticViewModel
    {
        public int id;

        public int org_id;

        public int parent_id;

        public int famale;

        public int male;

        public int total;

        public int men_per_clothes;

        public int women_per_clothes;

        public int men_jacket;

        public int women_jacket;

        public int men_gile;

        public int woman_gile;

        public int shoes;

        public int boots;

        public int soap;

        public int canvas_bag;

        public int rain_clothes;

        public string created_by;

        public DateTime created_date;

        public string created_log;

        public DateTime modified_date;


    }
}
