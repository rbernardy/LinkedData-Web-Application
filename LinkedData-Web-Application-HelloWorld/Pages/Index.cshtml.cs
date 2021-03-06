﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkedData_Web_Application_HelloWorld.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IHostingEnvironment env)
        {
            _env = env;
        }

        public void OnGet()
        {

        }

        private readonly IHostingEnvironment _env;

        public ActionResult Index()
        {
            string contentRootPath = _env.ContentRootPath;
            string webRootPath = _env.WebRootPath;

            return Content(contentRootPath + "\n" + webRootPath);
        }
    }
}
