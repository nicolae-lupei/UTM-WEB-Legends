using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UTM.Controllers
{
    public class HostelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}