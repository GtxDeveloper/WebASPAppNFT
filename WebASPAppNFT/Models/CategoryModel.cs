using WebASPAppNFT.Entities;

namespace WebASPAppNFT.Models
{
    public class CategoryModel
    {
        private readonly NFTSiteDbContext _context;

        public CategoryModel(NFTSiteDbContext context)
        {
            _context = context;
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        
        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
