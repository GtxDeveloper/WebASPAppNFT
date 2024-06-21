using Microsoft.EntityFrameworkCore;
using System.Globalization;
using WebASPAppNFT.Entities;
using static System.Net.WebRequestMethods;

namespace WebASPAppNFT.Models
{
    public class NFTSiteDbContext : DbContext
    {

        public DbSet<Option> Options { get; set; }

        public DbSet<Navigate> Navigates { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Collection> Collections { get; set; }

        public DbSet<NFTItem> NFTItems { get; set; }

        public DbSet<Author> Authors { get; set; }

        public NFTSiteDbContext(DbContextOptions options) : base(options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
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
                },
                new Option()
                {
                    Id = 2,
                    Name = "Instagram",
                    Key = "https://www.instagram.com/",
                    Value = "/images/instagram.png",
                    IsSystem = true,
                    Order = 1,
                    Relation = "socialLink"
                },
                new Option()
                {
                    Id = 3,
                    Name = "FaceBook",
                    Key = "https://uk-ua.facebook.com/",
                    Value = "/images/facebook.png",
                    IsSystem = true,
                    Order = 2,
                    Relation = "socialLink"
                },
                new Option()
                {
                    Id = 4,
                    Name = "TikTok",
                    Key = "https://www.tiktok.com/",
                    Value = "/images/tiktok.png",
                    IsSystem = true,
                    Order = 3,
                    Relation = "socialLink"
                },
                new Option()
                {
                    Id = 5,
                    Name = "Twitter",
                    Key = "https://x.com/?lang=ru",
                    Value = "/images/twitter.png",
                    IsSystem = true,
                    Order = 4,
                    Relation = "socialLink"
                },
                new Option()
                {
                    Id = 6,
                    Name = "sliderItem_1",
                    Key = "",
                    Value = "/images/banner-01.png",
                    IsSystem = true,
                    Order = 1,
                    Relation = "sliderItem"
                },
                new Option()
                {
                    Id = 7,
                    Name = "sliderItem_2",
                    Key = "",
                    Value = "/images/banner-02.png",
                    IsSystem = true,
                    Order = 2,
                    Relation = "sliderItem"
                }



            };

            Navigate[] navigates = new Navigate[]
            {
                new Navigate(){Id = 1, Name = "home", Href = "/", Order = 1, Parent_Id = null , Title = "Home", Relation = "navBar"},
                new Navigate(){Id = 2, Name = "explore", Href = "/explore", Order = 2, Parent_Id = null, Title = "Explore", Relation = "navBar" },
                new Navigate(){Id = 3, Name = "details", Href = "/details", Order = 3, Parent_Id = null, Title = "Item Details", Relation = "navBar"},
                new Navigate(){Id = 4, Name = "author", Href = "/author", Order = 4, Parent_Id = null, Title = "Author", Relation = "navBar"},
                new Navigate(){Id = 5, Name = "create", Href = "/create", Order = 5, Parent_Id = null, Title = "Create Yours", Relation = "navBar"},
                new Navigate(){Id = 6, Name = "watch_videos", Href = "https://www.youtube.com/watch?v=Y9Zw6xOGly0&t=10s&ab_channel=NEFOS", Order = 2, Title = "Watch Our Videos", Relation = "headerButton"},
                new Navigate(){Id = 7, Name = "explore", Href = "/explore", Order = 1, Parent_Id = null, Title = "Explore Top NFTs", Relation = "headerButton"}
            };

            Category[] categories = new Category[]
            {
                new Category {Id = 1, Name = "Blockchain", ImgSrc = "/images/icon-01.png", Slug = "blockchain", Order = 1},
                new Category {Id = 2, Name = "Digital Art", ImgSrc = "/images/icon-02.png", Slug = "digital_art", Order = 2},
                new Category {Id = 3, Name = "Music Art", ImgSrc = "/images/icon-03.png", Slug = "music_art", Order = 3},
                new Category {Id = 4, Name = "Virtual World", ImgSrc = "/images/icon-04.png", Slug = "virtual_world", Order = 4},
                new Category {Id = 5, Name = "Valuable", ImgSrc = "/images/icon-05.png", Slug = "valuable" , Order = 5},
                new Category {Id = 6, Name = "Triple NFT", ImgSrc = "/images/icon-06.png", Slug = "triple_nft" , Order = 6},
            };

            Collection[] collections = new Collection[]
            {
                new Collection {Id = 1, Name = "Mutant Bored Ape Yacht Club", Slug = "mutant_bored_ape_yacht_club", ImgSrc = "/images/collection-01.jpg", CurrentItems = 310, MaxItems = 340, CategoryId = 1 },
                new Collection {Id = 2, Name = "Bored Ape Kennel CLub", Slug = "bored_ape_kennel_club", ImgSrc = "/images/collection-01.jpg", CurrentItems = 324, MaxItems = 324, CategoryId = 2 },
                new Collection {Id = 3, Name = "Genesis Collective Statue", Slug = "genesis_collective_statue", ImgSrc = "/images/collection-01.jpg", CurrentItems = 380, MaxItems = 394, CategoryId = 3 },
                new Collection {Id = 4, Name = "Worldwide Artwork Ground", Slug = "wolrdwide_artwork_ground", ImgSrc = "/images/collection-01.jpg", CurrentItems = 426, MaxItems = 468, CategoryId = 4 }
            };

            NFTItem[] nFTItems = new NFTItem[]
            {
                new NFTItem
                {
                    Id = 1,
                    Name = "Music Art Super Item",
                    CurrentBidInETH = 2.03,
                    CurrentBidInUSD = 8240.50,
                    EndsIn = new TimeSpan(4,8,15,42),
                    DateOfCreating = new DateTime(2022, 6, 24),
                    Slug = "music_art_super_item",
                    CategoryId = 3,
                    ImgSrc = "/images/market-01.jpg",
                    AuthorId = 1,
                }
            };

            Author[] authors = new Author[]
            {
                new Author {Id = 1} 
            };
            modelBuilder.Entity<Author>().HasData(authors);
            modelBuilder.Entity<NFTItem>().HasData(nFTItems);
            modelBuilder.Entity<Option>().HasData(options);
            modelBuilder.Entity<Navigate>().HasData(navigates);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Collection>().HasData(collections);
        }
    }
}
