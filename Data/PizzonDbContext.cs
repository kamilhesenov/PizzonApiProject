using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{

    //dotnet ef --startup-project.\PizzonApi\PizzonApi.csproj migrations add ProductSchema -p.\Data\Data.csproj
    //dotnet ef --startup-project .\PizzonApi\PizzonApi.csproj database update -p.\Data\Data.csproj
    public class PizzonDbContext: DbContext
    {
        public PizzonDbContext(DbContextOptions<PizzonDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
   

            builder.ApplyConfiguration(new AboutUsConfiguration());
            builder.ApplyConfiguration(new BannerConfiguration());
            builder.ApplyConfiguration(new BreadcrumbConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new AssociateConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new Categoryfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new SettingConfiguration());
            builder.ApplyConfiguration(new SocialLinkConfiguration());
            builder.ApplyConfiguration(new TestimonialConfiguration());
            builder.ApplyConfiguration(new StockConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);

            // Banner/isBanner
            builder.Entity<Banner>().HasData(
                new Banner
                {
                    Id = 2,
                    PhotoUrl = "banner-bg-1.png",
                    IsBanner = true,
                    IsService = false,
                    Header = "Quality Foods",
                    Body = "Healthy Food for healthy body",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AddedBy = "System",
                    ModifiedBy = "System"
                },
                new Banner
                {
                    Id = 3,
                    PhotoUrl = "banner-bg-2.png",
                    IsBanner = true,
                    IsService = false,
                    Header = "Quality Foods",
                    Body = "Healthy Food for healthy body",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AddedBy = "System",
                    ModifiedBy = "System"

                },
                new Banner
                 {
                     Id = 4,
                     PhotoUrl = "banner-bg-3.png",
                     IsBanner = true,
                     IsService = false,
                     Header = "Quality Foods",
                     Body = "Healthy Food for healthy body",
                     AddedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now,
                     AddedBy = "System",
                     ModifiedBy = "System"

                 },
            // Banner/isService
                new Banner
                {
                    Id = 5,
                    PhotoUrl = "order-1.svg",
                    IsBanner = false,
                    IsService = true,
                    Header = "ORDER YOUR FOOD",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
                           "sed do eius-Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
                           "sed do eius-Lorem ipsum dolor sit amet, conse",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AddedBy = "System",
                    ModifiedBy = "System"

                },
                new Banner
                {
                    Id = 6,
                    PhotoUrl = "order-2.svg",
                    IsBanner = false,
                    IsService = true,
                    Header = "DELIVERY OR PICK UP",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
                           "sed do eius-Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
                           "sed do eius-Lorem ipsum dolor sit amet, conse",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AddedBy = "System",
                    ModifiedBy = "System"

                },
                new Banner
                {
                    Id = 7,
                    PhotoUrl = "order-3.svg",
                    IsBanner = false,
                    IsService = true,
                    Header = "DELICIOUS RECEIPE",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
                           "sed do eius-Lorem ipsum dolor sit amet, consectetur adipisicing elit, " +
                           "sed do eius-Lorem ipsum dolor sit amet, conse",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AddedBy = "System",
                    ModifiedBy = "System"

                }
                ); 

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Breadcrumb> Breadcrumbs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Associate> Associates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }

}

