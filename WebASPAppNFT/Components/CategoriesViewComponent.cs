using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private static NFTSiteDbContext _NFTSiteDbContext;
        private static CategoryModel _categoryModel;

        public CategoriesViewComponent()
        {
            _NFTSiteDbContext = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _categoryModel = new CategoryModel(_NFTSiteDbContext);
        }
        public IViewComponentResult Invoke()
        {
            return View("Categories", _categoryModel.GetCategories());
        }
    }
}
