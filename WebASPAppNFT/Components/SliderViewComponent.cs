using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebASPAppNFT.Models;

namespace WebASPAppNFT.Components
{
    public class SliderViewComponent : ViewComponent
    {
        private static NFTSiteDbContext _NFTSiteDbContext;
        private static OptionsModel _optionsModel;

        public SliderViewComponent()
        {
            _NFTSiteDbContext = new NFTSiteDbContext(new DbContextOptions<NFTSiteDbContext>());
            _optionsModel = new OptionsModel(_NFTSiteDbContext);
        }

        public IViewComponentResult Invoke()
        {
            var options = _optionsModel.GetOptionsByRelation("sliderItem");

            return View("Slider", options );
        }
    }
}
