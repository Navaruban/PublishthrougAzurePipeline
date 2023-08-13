using Microsoft.AspNetCore.Mvc;

namespace PublishthrougAzurePipeline.Controllers
{
    public class DreamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
