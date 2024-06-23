using WebASPAppNFT.Entities;

namespace WebASPAppNFT.Models
{
    public class CollectionModel
    {
        private readonly NFTSiteDbContext _context;
        private readonly CategoryModel _categoryModel;
        private readonly AuthorModel _authorModel;
        private readonly NFTItemModel _NFTItemModel;
        private readonly List<Collection> _collections;

        public CollectionModel(NFTSiteDbContext context)
        {
            _context = context;
            _categoryModel = new CategoryModel(context);
            _authorModel = new AuthorModel(context);
            _NFTItemModel = new NFTItemModel(context);
            _collections = _context.Collections.ToList();
        }

        public ICollection<Collection> GetCollections()
        {

            var collections = _collections;

            try
            {
                foreach (var collection in collections)
                {
                    FillCategory(collection);
                    FillAuthor(collection);
                    FillNFTItems(collection);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return collections;

        }

        public Collection GetCollectionById(int? id)
        {
            Collection collection = _collections.FirstOrDefault(c => c.Id == id);

            try
            {
                FillCategory(collection);
                FillAuthor(collection);
                FillNFTItems(collection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    ex.ToString());
            }


            return collection;
        }

        public Collection GetCollectionById_forNFT(int? id)
        {
            Collection collection = _collections.FirstOrDefault(c => c.Id == id);

            try
            {
                FillCategory(collection);
                FillAuthor(collection);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return collection;
        }

        private Category FillCategory(Collection collection)
        {
            return _categoryModel.GetCategoryById(collection.CategoryId);
        }
        private Author FillAuthor(Collection collection)
        {
            return _authorModel.GetAuthorById(collection.AuthorId);
        }
        private List<NFTItem> FillNFTItems(Collection collection)
        {
            return _NFTItemModel.GetNFTItemsByCollectionId(collection.Id);
        }
    }
}
