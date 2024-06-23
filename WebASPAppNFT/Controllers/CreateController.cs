using Microsoft.AspNetCore.Mvc;

namespace WebASPAppNFT.Controllers
{
    public class CreateController : Controller
    {
        private readonly ILogger<CreateController> _logger;

        public CreateController(ILogger<CreateController> logger)
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
