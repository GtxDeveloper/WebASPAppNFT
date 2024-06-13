using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Components
{
    public class NavBarViewComponent:ViewComponent
    {
        private static NFTSiteDbContext _NFTSiteDbContext;
        private static NavigationsModel _navigationsModel;

        public NavBarViewComponent()
        {
            _NFTSiteDbContext = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _navigationsModel = new NavigationsModel(_NFTSiteDbContext);
        }
        public IViewComponentResult Invoke()
        {
            return View("NavBar", _navigationsModel.GetNavigates());
        }
    }
}
