using Foody.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAcces.Context
{
    public class FoodyContext : DbContext
    {
        //public FoodyContext(DbContextOptions options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer("Server=ALBATROS46;initial catalog=FoodyDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
