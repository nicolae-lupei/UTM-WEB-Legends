using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UTM.Controllers
{
    public class LocatariController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LocatarInfo()
        {
            return View();
        }
    }
}