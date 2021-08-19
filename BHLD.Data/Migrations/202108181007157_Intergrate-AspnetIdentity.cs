namespace BHLD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntergrateAspnetIdentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.synthetic", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.synthetic", "parent_id", "dbo.hu_organization");
            DropForeignKey("dbo.hu_district", "province_id", "dbo.hu_province");
            DropForeignKey("dbo.hu_province", "nation_id", "dbo.hu_nation");
            DropForeignKey("dbo.hu_employee_cv", "employee_id", "dbo.hu_employee");
            DropForeignKey("dbo.hu_employee", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.hu_employee", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_org_title", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.hu_org_title", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_protection_emp_setting", "id_emp", "dbo.hu_protection_emp");
            DropForeignKey("dbo.hu_protection_emp_setting", "bhld_list_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_protection_emp", "employee_id", "dbo.hu_employee");
            DropForeignKey("dbo.hu_protection_setting", "size_id", "dbo.hu_protection_size");
            DropForeignKey("dbo.hu_protection_title_setting", "bhld_title_id", "dbo.hu_protection_setting");
            DropForeignKey("dbo.hu_protection_title_setting", "bhld_list_id", "dbo.hu_protection_title");
            DropForeignKey("dbo.hu_protection_title", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_shoes_setting", "size_id", "dbo.hu_shoes_size");
            DropForeignKey("dbo.hu_ward", "district_id", "dbo.hu_district");
            DropForeignKey("dbo.ot_other_list", "type_id", "dbo.ot_other_list_type");
            DropForeignKey("dbo.se_function", "group_id", "dbo.se_function_group");
            DropForeignKey("dbo.se_user_org_access", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.se_user_org_access", "user_id", "dbo.se_user");
            DropForeignKey("dbo.se_user_permission", "function_id", "dbo.se_function");
            DropForeignKey("dbo.se_user_permission", "user_id", "dbo.se_user");
            DropForeignKey("dbo.se_user_report", "user_id", "dbo.se_user");
            DropForeignKey("dbo.se_user_report", "se_report_id", "dbo.se_report");
            CreateTable(
                "dbo.ApplicationGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ApplicationUserGroups",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.GroupId })
                .ForeignKey("dbo.ApplicationGroups", t => t.GroupId)
                .ForeignKey("dbo.ApplicationUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(maxLength: 256),
                        Address = c.String(maxLength: 256),
                        BirthDay = c.DateTime(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApplicationUserClaims",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.ApplicationRoles", t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id);
            
            CreateTable(
                "dbo.ApplicationRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddForeignKey("dbo.hu_district", "province_id", "dbo.hu_province", "id");
            AddForeignKey("dbo.hu_province", "nation_id", "dbo.hu_nation", "id");
            AddForeignKey("dbo.hu_employee_cv", "employee_id", "dbo.hu_employee", "id");
            AddForeignKey("dbo.hu_employee", "org_id", "dbo.hu_organization", "id");
            AddForeignKey("dbo.hu_employee", "title_id", "dbo.hu_title", "id");
            AddForeignKey("dbo.hu_org_title", "org_id", "dbo.hu_organization", "id");
            AddForeignKey("dbo.hu_org_title", "title_id", "dbo.hu_title", "id");
            AddForeignKey("dbo.hu_protection_emp_setting", "id_emp", "dbo.hu_protection_emp", "id");
            AddForeignKey("dbo.hu_protection_emp_setting", "bhld_list_id", "dbo.hu_title", "id");
            AddForeignKey("dbo.hu_protection_emp", "employee_id", "dbo.hu_employee", "id");
            AddForeignKey("dbo.hu_protection_setting", "size_id", "dbo.hu_protection_size", "id");
            AddForeignKey("dbo.hu_protection_title_setting", "bhld_title_id", "dbo.hu_protection_setting", "id");
            AddForeignKey("dbo.hu_protection_title_setting", "bhld_list_id", "dbo.hu_protection_title", "id");
            AddForeignKey("dbo.hu_protection_title", "title_id", "dbo.hu_title", "id");
            AddForeignKey("dbo.hu_shoes_setting", "size_id", "dbo.hu_shoes_size", "id");
            AddForeignKey("dbo.hu_ward", "district_id", "dbo.hu_district", "id");
            AddForeignKey("dbo.ot_other_list", "type_id", "dbo.ot_other_list_type", "id");
            AddForeignKey("dbo.se_function", "group_id", "dbo.se_function_group", "id");
            AddForeignKey("dbo.se_user_org_access", "org_id", "dbo.hu_organization", "id");
            AddForeignKey("dbo.se_user_org_access", "user_id", "dbo.se_user", "id");
            AddForeignKey("dbo.se_user_permission", "function_id", "dbo.se_function", "id");
            AddForeignKey("dbo.se_user_permission", "user_id", "dbo.se_user", "id");
            AddForeignKey("dbo.se_user_report", "user_id", "dbo.se_user", "id");
            AddForeignKey("dbo.se_user_report", "se_report_id", "dbo.se_report", "id");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.synthetic",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        org_id = c.Int(nullable: false),
                        parent_id = c.Int(nullable: false),
                        famale = c.Int(nullable: false),
                        male = c.Int(nullable: false),
                        total = c.Int(nullable: false),
                        men_per_clothes = c.Int(nullable: false),
                        women_per_clothes = c.Int(nullable: false),
                        men_jacket = c.Int(nullable: false),
                        women_jacket = c.Int(nullable: false),
                        men_gile = c.Int(nullable: false),
                        woman_gile = c.Int(nullable: false),
                        shoes = c.Int(nullable: false),
                        boots = c.Int(nullable: false),
                        soap = c.Int(nullable: false),
                        canvas_bag = c.Int(nullable: false),
                        rain_clothes = c.Int(nullable: false),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropForeignKey("dbo.se_user_report", "se_report_id", "dbo.se_report");
            DropForeignKey("dbo.se_user_report", "user_id", "dbo.se_user");
            DropForeignKey("dbo.se_user_permission", "user_id", "dbo.se_user");
            DropForeignKey("dbo.se_user_permission", "function_id", "dbo.se_function");
            DropForeignKey("dbo.se_user_org_access", "user_id", "dbo.se_user");
            DropForeignKey("dbo.se_user_org_access", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.se_function", "group_id", "dbo.se_function_group");
            DropForeignKey("dbo.ot_other_list", "type_id", "dbo.ot_other_list_type");
            DropForeignKey("dbo.hu_ward", "district_id", "dbo.hu_district");
            DropForeignKey("dbo.hu_shoes_setting", "size_id", "dbo.hu_shoes_size");
            DropForeignKey("dbo.hu_protection_title", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_protection_title_setting", "bhld_list_id", "dbo.hu_protection_title");
            DropForeignKey("dbo.hu_protection_title_setting", "bhld_title_id", "dbo.hu_protection_setting");
            DropForeignKey("dbo.hu_protection_setting", "size_id", "dbo.hu_protection_size");
            DropForeignKey("dbo.hu_protection_emp", "employee_id", "dbo.hu_employee");
            DropForeignKey("dbo.hu_protection_emp_setting", "bhld_list_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_protection_emp_setting", "id_emp", "dbo.hu_protection_emp");
            DropForeignKey("dbo.hu_org_title", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_org_title", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.hu_employee", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_employee", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.hu_employee_cv", "employee_id", "dbo.hu_employee");
            DropForeignKey("dbo.hu_province", "nation_id", "dbo.hu_nation");
            DropForeignKey("dbo.hu_district", "province_id", "dbo.hu_province");
            DropForeignKey("dbo.ApplicationUserRoles", "IdentityRole_Id", "dbo.ApplicationRoles");
            DropForeignKey("dbo.ApplicationUserGroups", "UserId", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserGroups", "GroupId", "dbo.ApplicationGroups");
            DropIndex("dbo.ApplicationUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.ApplicationUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUserGroups", new[] { "GroupId" });
            DropIndex("dbo.ApplicationUserGroups", new[] { "UserId" });
            DropTable("dbo.ApplicationRoles");
            DropTable("dbo.ApplicationUserRoles");
            DropTable("dbo.ApplicationUserLogins");
            DropTable("dbo.ApplicationUserClaims");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.ApplicationUserGroups");
            DropTable("dbo.ApplicationGroups");
            AddForeignKey("dbo.se_user_report", "se_report_id", "dbo.se_report", "id", cascadeDelete: true);
            AddForeignKey("dbo.se_user_report", "user_id", "dbo.se_user", "id", cascadeDelete: true);
            AddForeignKey("dbo.se_user_permission", "user_id", "dbo.se_user", "id", cascadeDelete: true);
            AddForeignKey("dbo.se_user_permission", "function_id", "dbo.se_function", "id", cascadeDelete: true);
            AddForeignKey("dbo.se_user_org_access", "user_id", "dbo.se_user", "id", cascadeDelete: true);
            AddForeignKey("dbo.se_user_org_access", "org_id", "dbo.hu_organization", "id", cascadeDelete: true);
            AddForeignKey("dbo.se_function", "group_id", "dbo.se_function_group", "id", cascadeDelete: true);
            AddForeignKey("dbo.ot_other_list", "type_id", "dbo.ot_other_list_type", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_ward", "district_id", "dbo.hu_district", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_shoes_setting", "size_id", "dbo.hu_shoes_size", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_protection_title", "title_id", "dbo.hu_title", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_protection_title_setting", "bhld_list_id", "dbo.hu_protection_title", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_protection_title_setting", "bhld_title_id", "dbo.hu_protection_setting", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_protection_setting", "size_id", "dbo.hu_protection_size", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_protection_emp", "employee_id", "dbo.hu_employee", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_protection_emp_setting", "bhld_list_id", "dbo.hu_title", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_protection_emp_setting", "id_emp", "dbo.hu_protection_emp", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_org_title", "title_id", "dbo.hu_title", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_org_title", "org_id", "dbo.hu_organization", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_employee", "title_id", "dbo.hu_title", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_employee", "org_id", "dbo.hu_organization", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_employee_cv", "employee_id", "dbo.hu_employee", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_province", "nation_id", "dbo.hu_nation", "id", cascadeDelete: true);
            AddForeignKey("dbo.hu_district", "province_id", "dbo.hu_province", "id", cascadeDelete: true);
        }
    }
}
