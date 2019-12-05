using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CleanSimpleProject.Core.Entities.Entities;

namespace CleanSimpleProject.EFCore
{
    public class CleanContext : IdentityDbContext<CleanUser>
    {
        private IConfigurationRoot _config;
        public CleanContext(IConfigurationRoot config, DbContextOptions<CleanContext> options)
        : base(options)
        {
            _config = config;
        }

        // public shaffafContext(){}
        public DbSet<StaticPage> StaticPages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<ProjectPic> ProjectPics { get; set; }
        public DbSet<IdeaMain> IdeaMains { get; set; }
        public DbSet<IdeaItem> IdeaItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:CleanContextConnection"]);
        }

    }
}