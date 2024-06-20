using WebASPAppNFT.Entities;

namespace WebASPAppNFT.Models
{
    public class CollectionModel
    {
        private readonly NFTSiteDbContext _context;
        private readonly CategoryModel _categoryModel;
        public CollectionModel(NFTSiteDbContext context)
        {
            _context = context;
            _categoryModel = new CategoryModel(context);
        }

        public IEnumerable<Collection> GetCollections()
        {
            var collections = _context.Collections.ToList();

            foreach (var collection in collections)
            {
                collection.Category = _categoryModel.GetCategoryById(collection.CategoryId);
            }

            return collections;
        }

        public Collection GetCollectionById(int? id) 
        {
            Collection collection = _context.Collections.FirstOrDefault(c => c.Id == id);

            collection.Category = _categoryModel.GetCategoryById(collection.CategoryId);

            return collection;
        }
        
    }
}
