﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCControllerDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(name);
        }

    }
}