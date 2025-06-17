using Microsoft.AspNetCore.Mvc;

namespace Bloggingweb.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }
    }
}
