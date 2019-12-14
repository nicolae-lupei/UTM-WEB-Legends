using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UTM.BLL;
using UTM.DLL;
using UTM.DLL.Models;

namespace UTM.Presentation.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;

        public RoleController(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
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

        [HttpGet]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel<IEnumerable<Role>>))]
        public async Task<JsonResult> GetAllRoles()
        {
            return Json(new ResultModel<IEnumerable<Role>>
            {
                IsSuccess = true,
                Result = await _roleManager.Roles.ToListAsync()
            });
        }


        [HttpPost]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel))]
        public async Task<JsonResult> AddRoleToUser(Guid userId, string role)
        {
            var response = new ResultModel();
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id.Equals(userId));
            if (user == null) return Json(response);
            var addRoleResponse = await _userManager.AddToRoleAsync(user, role);
            return Json(new ResultModel
            {
                IsSuccess = addRoleResponse.Succeeded
            });
        }
    }
}
