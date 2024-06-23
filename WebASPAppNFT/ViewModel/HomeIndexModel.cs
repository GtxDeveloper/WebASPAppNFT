using WebASPAppNFT.Entities;

namespace WebASPAppNFT.ViewModel
{
    public class HomeIndexModel
    {
        public List<Collection> Collections { get; set; }

        public List<Category> Categories { get; set; }

        public List<NFTItem> NFTItems { get; set; }
    }
}
