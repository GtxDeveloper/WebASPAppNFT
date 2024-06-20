using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Components
{
    public class SocialLinksViewComponent : ViewComponent
    {
        private static NFTSiteDbContext _NFTSiteDbContext;
        private static OptionsModel _optionsModel;

        public SocialLinksViewComponent()
        {
            _NFTSiteDbContext = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _optionsModel = new OptionsModel(_NFTSiteDbContext);
        }

        public IViewComponentResult Invoke()
        {
            return View("SocialLinks", _optionsModel.GetOptionsByRelation("socialLink"));
        }
    }
}
