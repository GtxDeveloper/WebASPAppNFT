using WebASPAppNFT.Entities;
using WebASPAppNFT.Tools;

namespace WebASPAppNFT.Models
{
    public class NFTItemModel
    {
        private readonly NFTSiteDbContext _context;


        public NFTItemModel(NFTSiteDbContext context)
        {
            _context = context;
        }

        public List<NFTItem> GetNFTItems()
        {
            var items = _context.NFTItems.ToList();

            foreach (var item in items)
            {
                item.Collection = ItemsCollectionsTool.PairCollectionToItem(item, new CollectionModel(_context));
            }

            return items;
        }

        public List<NFTItem> GetNFTItemsByCollectionId(int collectionId)
        {
            var items = _context.NFTItems.Where(i => i.CollectionId == collectionId).ToList();

            foreach (var item in items)
            {
                item.Collection = ItemsCollectionsTool.PairCollectionToItem(item, new CollectionModel(_context));
            }

            return items;
        }

    }
}
