using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Components
{
    public class TopHeaderViewComponent:ViewComponent
    {
        private static NFTSiteDbContext _NFTSiteDbContext;
        private static OptionsModel _optionsModel;

        public TopHeaderViewComponent()
        {
            _NFTSiteDbContext = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _optionsModel = new OptionsModel(_NFTSiteDbContext);
        }
        public IViewComponentResult Invoke()
        {
            return View("TopHeader", _optionsModel.GetOptionByName("logo"));
        }
    }
}
