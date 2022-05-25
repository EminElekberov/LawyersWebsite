using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models
{
    public class LawyerDbcontext : IdentityDbContext<User>
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
        public DbSet<Faq> Faqs{ get; set; }
        public DbSet<AttorneysSlider> AttorneysSliders{ get; set; }
        public DbSet<Biography> Biographies{ get; set; }
        public DbSet<AttorneyWork> AttorneyWorks{ get; set; }
        public DbSet<AttorneysLogo> AttorneysLogos{ get; set; }
        public DbSet<BlogDetails> BlogDetails{ get; set; }
        public DbSet<BlogHeader> BlogHeaders{ get; set; }
        public DbSet<BlogIndexAbout> BlogIndexAbouts{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<AllContactsAreas> AllContactsAreas{ get; set; }
        public DbSet<Case> Cases{ get; set; }
        public DbSet<Categorys> Categorys{ get; set; }
        public DbSet<Components> Components{ get; set; }
        public DbSet<Packet> Packets{ get; set; }
        public DbSet<PacketToComponents> packetToComponents{ get; set; }
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
            modelBuilder.Entity<PacketToComponents>()
                .HasOne(a => a.packet)
                .WithMany(b => b.packetToComponents)
                .HasForeignKey(a => a.PacketId);

            modelBuilder.Entity<PacketToComponents>()
                .HasOne(a => a.components)
                .WithMany(b => b.PacketToComponents)
                .HasForeignKey(a => a.componentsId);

            modelBuilder.Entity<PacketToComponents>()
               .HasKey(bc => new { bc.PacketId, bc.componentsId });
        }
    }
}
