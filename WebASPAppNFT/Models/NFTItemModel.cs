using WebASPAppNFT.Entities;

namespace WebASPAppNFT.Models
{
    public class NFTItemModel
    {
        private readonly NFTSiteDbContext _context;
        private readonly CategoryModel _categoryModel;
        private readonly CollectionModel _collectionModel;
        private readonly AuthorModel _authorModel;
        public NFTItemModel(NFTSiteDbContext context)
        {
            _context = context;
            _categoryModel = new CategoryModel(context);
            _authorModel = new AuthorModel(context);
            _collectionModel = new CollectionModel(context);
        }

        public ICollection<NFTItem> GetNFTItems()
        {
            var items = _context.NFTItems.ToList();

            foreach (var item in items)
            {
                item.Author = _authorModel.GetAuthorById(item.AuthorId);
                if (item.CollectionId != null)
                {
                    item.Collection = _collectionModel.GetCollectionById(item.CollectionId);
                }
                item.Category = _categoryModel.GetCategoryById(item.CategoryId);

            }

            return items;
        }
    }
}
