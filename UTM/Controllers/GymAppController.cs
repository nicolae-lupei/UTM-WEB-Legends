using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UTM.Presentation.Controllers
{
    [Authorize]
    public class GymAppController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyAppointments()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
