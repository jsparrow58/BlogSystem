using System.Data.Entity.Migrations;
using Parts16.Models.Entities;

namespace Parts16.Models.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Parts16.Models.Parts16Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Parts16.Models.Parts16Context context)
        {
            if(!context.Roles.Any())
            {
                context.Roles.AddOrUpdate(new Role { Title = "超级管理员" }, new Role { Title = "普通管理员" });
                context.SaveChanges();
            }
        }
    }
}
