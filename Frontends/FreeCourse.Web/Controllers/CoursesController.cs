using FreeCourse.Shared.Services;
using FreeCourse.Web.Models.Catalog;
using FreeCourse.Web.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace FreeCourse.Web.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        private readonly ICatalogService _catalogService;
        private ISharedIdentityService _sharedIdentityService;

        public CoursesController(ICatalogService catalogService, ISharedIdentityService sharedIdentityService)
        {
            _catalogService = catalogService;
            _sharedIdentityService = sharedIdentityService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _catalogService.GetAllCourseByUserId(_sharedIdentityService.GetUserId));
        }

        public async Task<IActionResult> Create()
        {
            var categories = await _catalogService.GetAllCategory();
            ViewBag.categoryList = new SelectList(categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateInput courseCreateInput)
        {
            var categories = await _catalogService.GetAllCategory();
            ViewBag.categoryList = new SelectList(categories, "Id", "Name");
            if (!ModelState.IsValid)
                return View();

            courseCreateInput.UserId = _sharedIdentityService.GetUserId;

            await _catalogService.CreateCourse(courseCreateInput);
            return RedirectToAction(nameof(Index));
        }
    }
}
