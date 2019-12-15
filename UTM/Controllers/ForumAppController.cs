﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UTM.Presentation.Controllers
{
    [Authorize]
    public class ForumAppController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PublicForum()
        {
            return View();
        }


        public IActionResult Subjects()
        {
            return View();
        }
    }
}
