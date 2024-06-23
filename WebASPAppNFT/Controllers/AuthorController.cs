using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebASPAppNFT.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(ILogger<AuthorController> logger)
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
