using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebASPAppNFT.Controllers
{
    public class ExploreController : Controller
    {

        private readonly ILogger<ExploreController> _logger;

        public ExploreController(ILogger<ExploreController> logger)
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
