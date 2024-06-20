using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Components
{
    public class CollectionsViewComponent : ViewComponent
    {
        private readonly NFTSiteDbContext _context;
        private readonly CollectionModel _collectionModel;

        public CollectionsViewComponent()
        {
            _context = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _collectionModel = new CollectionModel(_context);
        }

        public IViewComponentResult Invoke()
        {
            return View("Collections", _collectionModel.GetCollections());
        }

    }
}
