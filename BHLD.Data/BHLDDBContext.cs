using BHLD.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHLD.Data
{
    public class BHLDDbContext : DbContext
    {
        public BHLDDbContext() : base("BHLDConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<hu_district> hu_Districts { set; get; }
        public DbSet<hu_employee> hu_Employees { set; get; }
        public DbSet<hu_employee_cv> hu_Employee_Cvs { set; get; }
        public DbSet<hu_nation> hu_Nations { set; get; }
        public DbSet<hu_org_title> hu_Org_Titles { set; get; }

        public DbSet<hu_organization> hu_Organizations { set; get; }
        public DbSet<hu_protection> hu_Protections { set; get; }
        public DbSet<hu_protection_emp> hu_Protection_Emps { set; get; }
        public DbSet<hu_protection_emp_setting> hu_Protection_Emp_Settings { set; get; }
        public DbSet<hu_protection_setting> hu_Protection_Settings { set; get; }

        public DbSet<hu_protection_size> hu_Protection_Sizes { set; get; }
        public DbSet<hu_protection_title> hu_Protection_Titles { set; get; }
        public DbSet<hu_protection_title_setting> hu_Protection_Title_Settings { set; get; }
        public DbSet<hu_province> hu_Provinces { set; get; }
        public DbSet<hu_shoes_setting> hu_Shoes_Settings { set; get; }

        public DbSet<hu_shoes_size> hu_Shoes_Sizes { set; get; }
        public DbSet<hu_title> hu_Titles { set; get; }
        public DbSet<hu_ward> hu_Wards { set; get; }
        public DbSet<ot_other_list> ot_Other_Lists { set; get; }
        public DbSet<ot_other_list_type> ot_Other_List_Types { set; get; }

        public DbSet<se_function> se_Functions { set; get; }
        public DbSet<se_function_group> se_Function_Groups { set; get; }
        public DbSet<se_report> se_Reports { set; get; }
        public DbSet<se_user> se_Users { set; get; }
        public DbSet<se_user_org_access> se_User_Org_Accesses { set; get; }

        public DbSet<se_user_permission> se_User_Permissions { set; get; }
        public DbSet<se_user_report> se_User_Reports { set; get; }
        public DbSet<synthetic> synthetics { set; get; }
        public DbSet<Error> errors { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
