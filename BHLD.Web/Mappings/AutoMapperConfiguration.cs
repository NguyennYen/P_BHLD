using AutoMapper;
using BHLD.Model.Models;
using BHLD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BHLD.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<hu_title, HuTitleViewModel>();
                cfg.CreateMap<hu_district, HuDistrictViewModel>();
                cfg.CreateMap<hu_employee_cv, HuEmployeeCVViewModel>();
                cfg.CreateMap<hu_employee, HuEmployeeViewModel>();
                cfg.CreateMap<hu_nation, HuNationViewModel>();
                cfg.CreateMap<hu_organization, HuOrganizationViewModel>();
                cfg.CreateMap<hu_org_title, HuOrgTitleViewModel>();
                cfg.CreateMap<hu_protection_emp_setting, HuProtectionEmpSettingViewModel>();
                cfg.CreateMap<hu_protection_emp, HuProtectionEmpViewModel>();
                cfg.CreateMap<hu_protection_setting, HuProtectionSettingViewModel>();
                cfg.CreateMap<hu_protection_size, HuProtectionSizeViewModel>();
                cfg.CreateMap<hu_protection_title_setting, HuProtectionTitleSettingViewModel>();
                cfg.CreateMap<hu_protection, HuProtectionViewModel>();
                cfg.CreateMap<hu_province, HuProvinceViewModel>();
                cfg.CreateMap<hu_shoes_setting, HuShoesSettingViewModel>();
                cfg.CreateMap<hu_shoes_size, HuShoesSizeViewModel>();
                cfg.CreateMap<hu_title, HuTitleViewModel>();
                cfg.CreateMap<hu_ward, HuWardViewModel>();
                cfg.CreateMap<ot_other_list_type, OtherListTypeViewModel>();
                cfg.CreateMap<ot_other_list, OtherListViewModel>();
                cfg.CreateMap<se_function_group, SeFunctionGroupViewModel>();
                cfg.CreateMap<se_function, SeFunctionViewModel>();
                cfg.CreateMap<se_report, SeReportViewModel>();
                cfg.CreateMap<se_user_org_access, SeUserOrgAccessViewModel>();
                cfg.CreateMap<se_user_permission, SeUserPermissionViewModel>();
                cfg.CreateMap<se_user, SeUserViewModel>();
                cfg.CreateMap<se_user_report, SeUserReportViewModel>();
     
            });
         }

     }
}