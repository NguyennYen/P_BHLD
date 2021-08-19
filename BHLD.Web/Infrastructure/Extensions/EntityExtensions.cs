using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHLD.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateHuTitle(this hu_title hu_title, Models.HuTitleViewModel hutitleVM)
        {
            hu_title.id = hutitleVM.id;
            hu_title.code = hutitleVM.code;
            hu_title.title_name = hutitleVM.title_name;
            hu_title.remark = hutitleVM.remark;
            hu_title.actflg = hutitleVM.actflg;
            hu_title.created_by = hutitleVM.created_by;
            hu_title.created_date = hutitleVM.created_date;
            hu_title.created_log = hutitleVM.created_log;
        }
        public static void UpdateHuDistrict(this hu_district hu_District,Models.HuDistrictViewModel huDistrictViewModel)
        {
            hu_District.id=huDistrictViewModel.id;
            hu_District.district_name=huDistrictViewModel.district_name;
            hu_District.province_id=huDistrictViewModel.province_id;
            hu_District.remark=huDistrictViewModel.remark;
            hu_District.created_by=huDistrictViewModel.created_by;
            hu_District.created_date=huDistrictViewModel.created_date;
            hu_District.created_log=huDistrictViewModel.created_log;
            hu_District.modified_date=huDistrictViewModel.modified_date;
            hu_District.status=huDistrictViewModel.status;
        }
        
    }
}