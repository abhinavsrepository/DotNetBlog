using Bloggingweb.Data;
using Bloggingweb.Models.ViewModels; // ✅ Fix typo: VIewModels → ViewModels
using Microsoft.AspNetCore.Mvc;
using Bloggingweb.Models.Domain;

namespace Bloggingweb.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BloggieDbContext bloggieDbContext;

        // ✅ Constructor for dependency injection
        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            bloggieDbContext.Tags.Add(tag);
            bloggieDbContext.SaveChanges();

            return RedirectToAction("Add"); // ✅ Better UX than reloading the same view
        }

        [HttpGet]
        public IActionResult List()
        {
            //usedb Context to reaf the tags
            var tags = bloggieDbContext.Tags.ToList();

            return View(tags);
        }

    }
}
