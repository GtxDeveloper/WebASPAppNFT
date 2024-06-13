using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Entities;
using static System.Net.WebRequestMethods;

namespace WebASPAppNFT.Models
{
    public class NFTSiteDbContext : DbContext
    {

        public DbSet<Option> Options { get; set; }

        public DbSet<Navigate> Navigates { get; set; }

        public NFTSiteDbContext(DbContextOptions options) : base(options) 
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FCNTCRS\SQLEXPRESS;Initial Catalog=NFT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");
            optionsBuilder.EnableSensitiveDataLogging(true);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Option[] options = new Option[]
            {
                new Option()
                {
                    Id = 1,
                    Name = "logo",
                    Key = "/",
                    Value = "/images/logo.png",
                    IsSystem = true,
                    Order = 1,
                }
                

            };

            Navigate[] navigates = new Navigate[]
            {
                new Navigate(){Id = 1, Title = "Home", Href = "/", Order = 1, Parent_Id = null},
                new Navigate(){Id = 2, Title = "Explore", Href = "/explore", Order = 2, Parent_Id = null },
                new Navigate(){Id = 3, Title = "Item Details", Href = "/details", Order = 3, Parent_Id = null},
                new Navigate(){Id = 4, Title = "Author", Href = "/author", Order = 4, Parent_Id = null},
                new Navigate(){Id = 5, Title = "Create Yours", Href = "/create", Order = 5, Parent_Id = null}
            };
            modelBuilder.Entity<Option>().HasData(options);
            modelBuilder.Entity<Navigate>().HasData(navigates);
        }
    }
}
