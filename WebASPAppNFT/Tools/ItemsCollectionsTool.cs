using WebASPAppNFT.Entities;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Tools
{
    public static class ItemsCollectionsTool
    {
        public static Collection PairCollectionToItem(NFTItem item, CollectionModel collectionModel)
        {
            Collection collection = collectionModel.GetCollectionById_forNFT(item.CollectionId);

            return collection;
        }
    }
}
