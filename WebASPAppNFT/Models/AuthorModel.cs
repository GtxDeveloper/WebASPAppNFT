using WebASPAppNFT.Entities;

namespace WebASPAppNFT.Models
{
    public class AuthorModel
    {
        private readonly NFTSiteDbContext _context;

        public AuthorModel(NFTSiteDbContext context)
        {
            _context = context;
        }

        public ICollection<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthorById(int id) 
        {
            return _context.Authors.SingleOrDefault(a = a => a.Id == id);
        }
    }
}
