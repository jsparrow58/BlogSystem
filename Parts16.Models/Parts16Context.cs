using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parts16.Models.Entities;

namespace Parts16.Models
{
    public class Parts16Context: DbContext
    {
        public Parts16Context():base("parts16")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            builder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AdminPermission> Permissions { get; set; }
        public virtual DbSet<Copyright>  Copyright { get; set; }
        public virtual DbSet<FriendLink>  FriendLinks { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Seo> Seo { get; set; }
        public virtual DbSet<WebMenu> WebMenus { get; set; }

    }
}
