﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfoyYonetimUygulamasi.MVC.Controllers
{
    public class UserPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
