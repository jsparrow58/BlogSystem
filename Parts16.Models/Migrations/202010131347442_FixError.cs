namespace Parts16.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixError : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Copyrights", newName: "Copyright");
            RenameTable(name: "dbo.Seos", newName: "Seo");
            AddColumn("dbo.Admins", "Role_Id", c => c.Guid());
            AddColumn("dbo.Copyright", "Telephone", c => c.String());
            AddColumn("dbo.Menus", "Parent_Id", c => c.Guid());
            AddColumn("dbo.AdminPermissions", "Menu_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.AdminPermissions", "Role_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Roles", "Title", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Seo", "Keyword", c => c.String());
            AddColumn("dbo.Seo", "Menu_Id", c => c.Guid());
            AddColumn("dbo.WebMenus", "Parent_Id", c => c.Guid());
            CreateIndex("dbo.Admins", "Role_Id");
            CreateIndex("dbo.Menus", "Parent_Id");
            CreateIndex("dbo.AdminPermissions", "Menu_Id");
            CreateIndex("dbo.AdminPermissions", "Role_Id");
            CreateIndex("dbo.Seo", "Menu_Id");
            CreateIndex("dbo.WebMenus", "Parent_Id");
            AddForeignKey("dbo.Admins", "Role_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.Menus", "Parent_Id", "dbo.Menus", "Id");
            AddForeignKey("dbo.AdminPermissions", "Menu_Id", "dbo.Menus", "Id");
            AddForeignKey("dbo.AdminPermissions", "Role_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.WebMenus", "Parent_Id", "dbo.WebMenus", "Id");
            AddForeignKey("dbo.Seo", "Menu_Id", "dbo.WebMenus", "Id");
            DropColumn("dbo.Admins", "RoleId");
            DropColumn("dbo.Copyright", "Telphone");
            DropColumn("dbo.Menus", "Parentid");
            DropColumn("dbo.AdminPermissions", "RoleId");
            DropColumn("dbo.AdminPermissions", "MenuId");
            DropColumn("dbo.Roles", "Titile");
            DropColumn("dbo.Seo", "Keyworkd");
            DropColumn("dbo.Seo", "WebMenuId");
            DropColumn("dbo.WebMenus", "Parentid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WebMenus", "Parentid", c => c.Guid(nullable: false));
            AddColumn("dbo.Seo", "WebMenuId", c => c.Guid(nullable: false));
            AddColumn("dbo.Seo", "Keyworkd", c => c.String());
            AddColumn("dbo.Roles", "Titile", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AdminPermissions", "MenuId", c => c.Guid(nullable: false));
            AddColumn("dbo.AdminPermissions", "RoleId", c => c.Guid(nullable: false));
            AddColumn("dbo.Menus", "Parentid", c => c.Guid(nullable: false));
            AddColumn("dbo.Copyright", "Telphone", c => c.String());
            AddColumn("dbo.Admins", "RoleId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Seo", "Menu_Id", "dbo.WebMenus");
            DropForeignKey("dbo.WebMenus", "Parent_Id", "dbo.WebMenus");
            DropForeignKey("dbo.AdminPermissions", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.AdminPermissions", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Menus", "Parent_Id", "dbo.Menus");
            DropForeignKey("dbo.Admins", "Role_Id", "dbo.Roles");
            DropIndex("dbo.WebMenus", new[] { "Parent_Id" });
            DropIndex("dbo.Seo", new[] { "Menu_Id" });
            DropIndex("dbo.AdminPermissions", new[] { "Role_Id" });
            DropIndex("dbo.AdminPermissions", new[] { "Menu_Id" });
            DropIndex("dbo.Menus", new[] { "Parent_Id" });
            DropIndex("dbo.Admins", new[] { "Role_Id" });
            DropColumn("dbo.WebMenus", "Parent_Id");
            DropColumn("dbo.Seo", "Menu_Id");
            DropColumn("dbo.Seo", "Keyword");
            DropColumn("dbo.Roles", "Title");
            DropColumn("dbo.AdminPermissions", "Role_Id");
            DropColumn("dbo.AdminPermissions", "Menu_Id");
            DropColumn("dbo.Menus", "Parent_Id");
            DropColumn("dbo.Copyright", "Telephone");
            DropColumn("dbo.Admins", "Role_Id");
            RenameTable(name: "dbo.Seo", newName: "Seos");
            RenameTable(name: "dbo.Copyright", newName: "Copyrights");
        }
    }
}
