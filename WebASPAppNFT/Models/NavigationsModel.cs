using WebASPAppNFT.Entities;

namespace WebASPAppNFT.Models
{
    public class NavigationsModel
    {
        private readonly NFTSiteDbContext _context;

        public NavigationsModel(NFTSiteDbContext context)
        {
            _context = context;
        }

        public ICollection<Navigate> GetNavigates()
        {
            return _context.Navigates.OrderBy(n => n.Order).ToList();
        }
    }
}
