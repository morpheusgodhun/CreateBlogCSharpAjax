using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Concrete
{
    internal class Context : DbContext
    //db context sınıfına ait dizini dahil ettim artık dbset kullanabilirim
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TBVTNM7;database=CoreProjeDB;TrustServerCertificate=True;integrated security=true");
        }
        public DbSet<About>Abouts{ get; set; }
        public DbSet<Contact>Contacts{ get; set; }
        public DbSet<Experience>Experiences{ get; set; }
        public DbSet<Feature>Features{ get; set; }
        public DbSet<Message>Messages{ get; set; }
        public DbSet<Portfolio>Portfolios{ get; set; }
        public DbSet<Service>Services{ get; set; }
        public DbSet<Skill>Skills{ get; set; }
        public DbSet<SocialMedia>SocialMedias{ get; set; }
        public DbSet<Testimonial>Testimonials{ get; set; }
    }
}

