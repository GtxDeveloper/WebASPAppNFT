using Microsoft.AspNetCore.Mvc;

namespace WebASPAppNFT.Controllers
{
    public class DetailsController : Controller
    {
        private readonly ILogger<DetailsController> _logger;

        public DetailsController(ILogger<DetailsController> logger)
        {
            _logger = logger;
        }
        // GET: ExploreController
        public ActionResult Index()
        {
            return View();
        }
    }
}
