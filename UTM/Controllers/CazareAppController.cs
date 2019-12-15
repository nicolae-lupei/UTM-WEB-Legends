using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UTM.Presentation.Controllers
{
    [Authorize]
    public class CazareAppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MyRequests()
        {
            return View();
        }
    }
}
