using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UTM.BLL;
using UTM.DLL;

namespace UTM.Presentation.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel))]
        public async Task<JsonResult> AddNewRole(Role model)
        {
            var result = await _roleManager.CreateAsync(model);
            return Json(new ResultModel
            {
                IsSuccess = result.Succeeded
            });
        }
    }
}
