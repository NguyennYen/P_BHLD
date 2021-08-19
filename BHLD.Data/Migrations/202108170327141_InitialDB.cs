namespace BHLD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.hu_district",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        district_name = c.String(nullable: false, maxLength: 255),
                        province_id = c.Int(nullable: false),
                        remark = c.String(maxLength: 1023),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_province", t => t.province_id, cascadeDelete: true)
                .Index(t => t.province_id);
            
            CreateTable(
                "dbo.hu_province",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        province_name = c.String(nullable: false, maxLength: 255),
                        nation_id = c.Int(nullable: false),
                        remark = c.String(maxLength: 1023),
                        actflg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_nation", t => t.nation_id, cascadeDelete: true)
                .Index(t => t.nation_id);
            
            CreateTable(
                "dbo.hu_nation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        nation_name = c.String(nullable: false, maxLength: 255),
                        remark = c.String(maxLength: 1023),
                        actflg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hu_employee_cv",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employee_id = c.Int(nullable: false),
                        gender = c.Int(nullable: false),
                        birthdate = c.DateTime(),
                        id_no = c.Int(nullable: false),
                        id_date = c.DateTime(nullable: false),
                        id_place = c.String(maxLength: 255),
                        per_address = c.String(maxLength: 255),
                        per_nation = c.String(maxLength: 255),
                        per_province = c.String(maxLength: 255),
                        per_district = c.String(maxLength: 255),
                        per_ward = c.String(maxLength: 255),
                        nav_address = c.String(maxLength: 255),
                        nav_nation = c.String(maxLength: 255),
                        nav_province = c.String(maxLength: 255),
                        nav_district = c.String(maxLength: 255),
                        nav_ward = c.String(maxLength: 255),
                        email = c.String(maxLength: 255),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_employee", t => t.employee_id, cascadeDelete: true)
                .Index(t => t.employee_id);
            
            CreateTable(
                "dbo.hu_employee",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employee_code = c.Int(nullable: false),
                        fullname = c.String(nullable: false, maxLength: 255),
                        org_id = c.Int(nullable: false),
                        title_id = c.Int(nullable: false),
                        join_date = c.DateTime(nullable: false),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_organization", t => t.org_id, cascadeDelete: true)
                .ForeignKey("dbo.hu_title", t => t.title_id, cascadeDelete: true)
                .Index(t => t.org_id)
                .Index(t => t.title_id);
            
            CreateTable(
                "dbo.hu_organization",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        name_vn = c.String(nullable: false, maxLength: 255),
                        parent_id = c.Int(nullable: false),
                        level_id = c.Int(nullable: false),
                        dissolve_date = c.DateTime(nullable: false),
                        foundation_date = c.DateTime(nullable: false),
                        address = c.String(),
                        org_no = c.Int(nullable: false),
                        remark = c.String(maxLength: 1023),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hu_title",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        title_name = c.String(nullable: false, maxLength: 255),
                        remark = c.String(maxLength: 1023),
                        actflg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hu_org_title",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        org_id = c.Int(nullable: false),
                        title_id = c.Int(nullable: false),
                        actfg = c.String(maxLength: 1),
                        remark = c.String(maxLength: 1023),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_organization", t => t.org_id, cascadeDelete: true)
                .ForeignKey("dbo.hu_title", t => t.title_id, cascadeDelete: true)
                .Index(t => t.org_id)
                .Index(t => t.title_id);
            
            CreateTable(
                "dbo.hu_protection_emp_setting",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        id_emp = c.Int(nullable: false),
                        bhld_list_id = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_protection_emp", t => t.id_emp, cascadeDelete: true)
                .ForeignKey("dbo.hu_title", t => t.bhld_list_id, cascadeDelete: true)
                .Index(t => t.id_emp)
                .Index(t => t.bhld_list_id);
            
            CreateTable(
                "dbo.hu_protection_emp",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employee_id = c.Int(nullable: false),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_employee", t => t.employee_id, cascadeDelete: true)
                .Index(t => t.employee_id);
            
            CreateTable(
                "dbo.hu_protection_setting",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        gender = c.Int(nullable: false),
                        belly = c.Int(nullable: false),
                        butt = c.Int(nullable: false),
                        belt = c.Int(nullable: false),
                        chest = c.Int(nullable: false),
                        shoulder = c.Int(nullable: false),
                        size_id = c.Int(nullable: false),
                        remark = c.String(maxLength: 1023),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_protection_size", t => t.size_id, cascadeDelete: true)
                .Index(t => t.size_id);
            
            CreateTable(
                "dbo.hu_protection_size",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        size_name = c.String(nullable: false, maxLength: 255),
                        remark = c.String(maxLength: 1023),
                        actflg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hu_protection_title_setting",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        bhld_title_id = c.Int(nullable: false),
                        bhld_list_id = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                        effect_date = c.DateTime(),
                        expire_date = c.DateTime(),
                        actfg = c.String(maxLength: 1),
                        remark = c.String(maxLength: 1023),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_protection_setting", t => t.bhld_title_id, cascadeDelete: true)
                .ForeignKey("dbo.hu_protection_title", t => t.bhld_list_id, cascadeDelete: true)
                .Index(t => t.bhld_title_id)
                .Index(t => t.bhld_list_id);
            
            CreateTable(
                "dbo.hu_protection_title",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        type_id = c.Int(nullable: false),
                        title_id = c.Int(nullable: false),
                        effect_date = c.DateTime(nullable: false),
                        expire_date = c.DateTime(nullable: false),
                        remark = c.String(maxLength: 1023),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_title", t => t.title_id, cascadeDelete: true)
                .Index(t => t.title_id);
            
            CreateTable(
                "dbo.hu_protection",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        protection_name = c.String(nullable: false, maxLength: 255),
                        remark = c.String(maxLength: 1023),
                        actflg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hu_shoes_setting",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        gender = c.Int(nullable: false),
                        size_from = c.Int(nullable: false),
                        size_to = c.Int(nullable: false),
                        size_id = c.Int(nullable: false),
                        remark = c.String(maxLength: 1023),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_shoes_size", t => t.size_id, cascadeDelete: true)
                .Index(t => t.size_id);
            
            CreateTable(
                "dbo.hu_shoes_size",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        size_name = c.String(nullable: false, maxLength: 255),
                        remark = c.String(maxLength: 1023),
                        actflg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hu_ward",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        ward_name = c.String(nullable: false, maxLength: 255),
                        district_id = c.Int(nullable: false),
                        remark = c.String(maxLength: 1023),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_district", t => t.district_id, cascadeDelete: true)
                .Index(t => t.district_id);
            
            CreateTable(
                "dbo.ot_other_list_type",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        name = c.String(nullable: false, maxLength: 255),
                        remark = c.String(maxLength: 1023),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ot_other_list",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        name = c.String(nullable: false, maxLength: 255),
                        type_id = c.Int(nullable: false),
                        remark = c.String(maxLength: 1023),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ot_other_list_type", t => t.type_id, cascadeDelete: true)
                .Index(t => t.type_id);
            
            CreateTable(
                "dbo.se_function_group",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 255),
                        remark = c.String(maxLength: 1023),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.se_function",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 255),
                        group_id = c.Int(nullable: false),
                        fid = c.Int(nullable: false),
                        chang_pass = c.String(maxLength: 255),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.se_function_group", t => t.group_id, cascadeDelete: true)
                .Index(t => t.group_id);
            
            CreateTable(
                "dbo.se_report",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        name = c.String(maxLength: 255),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.se_user_org_access",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        org_id = c.Int(nullable: false),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_organization", t => t.org_id, cascadeDelete: true)
                .ForeignKey("dbo.se_user", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.org_id);
            
            CreateTable(
                "dbo.se_user",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_name = c.String(nullable: false, maxLength: 255),
                        password = c.String(nullable: false, maxLength: 255),
                        email = c.String(maxLength: 255),
                        effect_date = c.DateTime(nullable: false),
                        expore_date = c.DateTime(nullable: false),
                        chang_pass = c.String(maxLength: 255),
                        actfg = c.String(maxLength: 1),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.se_user_permission",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        alllow_create = c.Int(nullable: false),
                        allow_modify = c.Int(nullable: false),
                        allow_delete = c.Int(nullable: false),
                        allow_print = c.Int(nullable: false),
                        alllow_iport = c.Int(nullable: false),
                        allow_export = c.Int(nullable: false),
                        allow_special1 = c.Int(nullable: false),
                        allow_special2 = c.Int(nullable: false),
                        allow_special3 = c.Int(nullable: false),
                        allow_special4 = c.Int(nullable: false),
                        function_id = c.Int(nullable: false),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.se_function", t => t.function_id, cascadeDelete: true)
                .ForeignKey("dbo.se_user", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.function_id);
            
            CreateTable(
                "dbo.se_user_report",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        se_report_id = c.Int(nullable: false),
                        created_by = c.String(maxLength: 255),
                        created_date = c.DateTime(),
                        created_log = c.String(maxLength: 255),
                        modified_date = c.DateTime(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.se_user", t => t.user_id, cascadeDelete: true)
                .ForeignKey("dbo.se_report", t => t.se_report_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.se_report_id);
            
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
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.hu_organization", t => t.org_id, cascadeDelete: true)
                .Index(t => t.org_id)
                .Index(t => t.parent_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.synthetic", "parent_id", "dbo.hu_organization");
            DropForeignKey("dbo.synthetic", "org_id", "dbo.hu_organization");
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
            DropForeignKey("dbo.hu_protection_title_setting", "bhld_list_id", "dbo.hu_protection_title");
            DropForeignKey("dbo.hu_protection_title", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_protection_title_setting", "bhld_title_id", "dbo.hu_protection_setting");
            DropForeignKey("dbo.hu_protection_setting", "size_id", "dbo.hu_protection_size");
            DropForeignKey("dbo.hu_protection_emp_setting", "bhld_list_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_protection_emp_setting", "id_emp", "dbo.hu_protection_emp");
            DropForeignKey("dbo.hu_protection_emp", "employee_id", "dbo.hu_employee");
            DropForeignKey("dbo.hu_org_title", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_org_title", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.hu_employee_cv", "employee_id", "dbo.hu_employee");
            DropForeignKey("dbo.hu_employee", "title_id", "dbo.hu_title");
            DropForeignKey("dbo.hu_employee", "org_id", "dbo.hu_organization");
            DropForeignKey("dbo.hu_district", "province_id", "dbo.hu_province");
            DropForeignKey("dbo.hu_province", "nation_id", "dbo.hu_nation");
            DropIndex("dbo.synthetic", new[] { "parent_id" });
            DropIndex("dbo.synthetic", new[] { "org_id" });
            DropIndex("dbo.se_user_report", new[] { "se_report_id" });
            DropIndex("dbo.se_user_report", new[] { "user_id" });
            DropIndex("dbo.se_user_permission", new[] { "function_id" });
            DropIndex("dbo.se_user_permission", new[] { "user_id" });
            DropIndex("dbo.se_user_org_access", new[] { "org_id" });
            DropIndex("dbo.se_user_org_access", new[] { "user_id" });
            DropIndex("dbo.se_function", new[] { "group_id" });
            DropIndex("dbo.ot_other_list", new[] { "type_id" });
            DropIndex("dbo.hu_ward", new[] { "district_id" });
            DropIndex("dbo.hu_shoes_setting", new[] { "size_id" });
            DropIndex("dbo.hu_protection_title", new[] { "title_id" });
            DropIndex("dbo.hu_protection_title_setting", new[] { "bhld_list_id" });
            DropIndex("dbo.hu_protection_title_setting", new[] { "bhld_title_id" });
            DropIndex("dbo.hu_protection_setting", new[] { "size_id" });
            DropIndex("dbo.hu_protection_emp", new[] { "employee_id" });
            DropIndex("dbo.hu_protection_emp_setting", new[] { "bhld_list_id" });
            DropIndex("dbo.hu_protection_emp_setting", new[] { "id_emp" });
            DropIndex("dbo.hu_org_title", new[] { "title_id" });
            DropIndex("dbo.hu_org_title", new[] { "org_id" });
            DropIndex("dbo.hu_employee", new[] { "title_id" });
            DropIndex("dbo.hu_employee", new[] { "org_id" });
            DropIndex("dbo.hu_employee_cv", new[] { "employee_id" });
            DropIndex("dbo.hu_province", new[] { "nation_id" });
            DropIndex("dbo.hu_district", new[] { "province_id" });
            DropTable("dbo.synthetic");
            DropTable("dbo.se_user_report");
            DropTable("dbo.se_user_permission");
            DropTable("dbo.se_user");
            DropTable("dbo.se_user_org_access");
            DropTable("dbo.se_report");
            DropTable("dbo.se_function");
            DropTable("dbo.se_function_group");
            DropTable("dbo.ot_other_list");
            DropTable("dbo.ot_other_list_type");
            DropTable("dbo.hu_ward");
            DropTable("dbo.hu_shoes_size");
            DropTable("dbo.hu_shoes_setting");
            DropTable("dbo.hu_protection");
            DropTable("dbo.hu_protection_title");
            DropTable("dbo.hu_protection_title_setting");
            DropTable("dbo.hu_protection_size");
            DropTable("dbo.hu_protection_setting");
            DropTable("dbo.hu_protection_emp");
            DropTable("dbo.hu_protection_emp_setting");
            DropTable("dbo.hu_org_title");
            DropTable("dbo.hu_title");
            DropTable("dbo.hu_organization");
            DropTable("dbo.hu_employee");
            DropTable("dbo.hu_employee_cv");
            DropTable("dbo.hu_nation");
            DropTable("dbo.hu_province");
            DropTable("dbo.hu_district");
            DropTable("dbo.Errors");
        }
    }
}
