using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UTM.BLL;
using UTM.DLL.Models;

namespace UTM.Presentation.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel<IEnumerable<User>>))]
        public async Task<JsonResult> GetAllUsers()
        {
            return Json(new ResultModel<IEnumerable<User>>
            {
                IsSuccess = true,
                Result = await _userManager.Users.ToListAsync()
            });
        }
    }
}
