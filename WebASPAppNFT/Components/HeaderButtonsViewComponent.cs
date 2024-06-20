using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Components
{
    public class HeaderButtonsViewComponent : ViewComponent
    {
        private static NFTSiteDbContext _NFTSiteDbContext;
        private static NavigationsModel _navigationsModel;

        public HeaderButtonsViewComponent()
        {
            _NFTSiteDbContext = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _navigationsModel = new NavigationsModel(_NFTSiteDbContext);
        }
        public IViewComponentResult Invoke()
        {
            return View("HeaderButtons", _navigationsModel.GetNavigatesByRelation("headerButton"));
        }
    }
}
