namespace WebASPAppNFT.Entities
{
    public class Collection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentItems { get; set; }

        public int MaxItems { get; set; }

        public string ImgSrc { get; set; }

        public string Slug {  get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public List<NFTItem> NFTItems { get; set; } = null;

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
