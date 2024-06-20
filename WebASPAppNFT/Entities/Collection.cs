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

        public List<int>? NFTIds { get; set; } = null;

        public List<NFTItem>? NFTItems { get; set; } = null;
    }
}
