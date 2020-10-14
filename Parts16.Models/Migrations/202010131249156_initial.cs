namespace Parts16.Models.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        NickName = c.String(),
                        Photo = c.String(),
                        RoleId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "IX_Email_Unique");
            
            CreateTable(
                "dbo.Copyrights",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Detail = c.String(nullable: false),
                        Telphone = c.String(),
                        Logo = c.String(),
                        Images = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        QQ = c.String(),
                        WeChat = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FriendLinks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Link = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Link = c.String(nullable: false),
                        Icon = c.String(),
                        Parentid = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdminPermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        MenuId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Titile = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Keyworkd = c.String(),
                        Description = c.String(),
                        WebMenuId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WebMenus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Link = c.String(nullable: false),
                        Icon = c.String(),
                        Parentid = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Admins", "IX_Email_Unique");
            DropTable("dbo.WebMenus");
            DropTable("dbo.Seos");
            DropTable("dbo.Roles");
            DropTable("dbo.AdminPermissions");
            DropTable("dbo.Menus");
            DropTable("dbo.FriendLinks");
            DropTable("dbo.Copyrights");
            DropTable("dbo.Admins");
        }
    }
}
