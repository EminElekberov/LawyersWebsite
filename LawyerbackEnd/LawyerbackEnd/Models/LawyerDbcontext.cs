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
        public DbSet<PictureSlider> pictureSliders{ get; set; }
        public DbSet<Practise> Practises{ get; set; }
        public DbSet<IndexChoose> IndexChooses{ get; set; }
        public DbSet<Teams> Teams{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<News> News{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<OurAbout> OurAbouts{ get; set; }
        public DbSet<PageSlider> PageSliders{ get; set; }
        public DbSet<PageContact> PageContacts{ get; set; }
        public DbSet<PracticeSlider> PracticeSliders{ get; set; }
        public DbSet<PracticeAbout> PracticeAbouts{ get; set; }
        public DbSet<AttorneysSlider> AttorneysSliders{ get; set; }
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
