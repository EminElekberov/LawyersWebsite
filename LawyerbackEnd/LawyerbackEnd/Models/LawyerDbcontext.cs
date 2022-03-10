using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class LawyerDbcontext : DbContext
    {
        public LawyerDbcontext(DbContextOptions<LawyerDbcontext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Holder> Holders{ get; set; }
        public DbSet<Practise> Practises{ get; set; }
        public DbSet<IndexChoose> IndexChooses{ get; set; }
        public DbSet<Teams> Teams{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().HasData(
            new Slider
            {
                Id = 1,
                Image = "slider1.jpeg",
                Name= "We provide legal",
                Description= "Moto Car"
            },
            new Slider
            {
                Id = 2,
                Image = "slider2.jpeg",
                Name = "We provide legal",
                Description = "Auto Accidents"
            });
        }
    }
}
