using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebASPAppNFT.Models;
using WebASPAppNFT.ViewModel;

namespace WebASPAppNFT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NFTSiteDbContext _context;
        private readonly CategoryModel _categoryModel;
        private readonly CollectionModel _collectionModel;
        private HomeIndexModel _indexModel = new HomeIndexModel();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _categoryModel = new CategoryModel(_context);
            _collectionModel = new CollectionModel(_context);
        }

        public IActionResult Index()
        {
            _indexModel.Collections = _collectionModel.GetCollections().ToList();
            _indexModel.Categories = _categoryModel.GetCategories().ToList();

            return View(_indexModel);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
