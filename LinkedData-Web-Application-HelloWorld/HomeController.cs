using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinkedData_Web_Application_HelloWorld
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            _env = env;
        }

        public ActionResult Index()
        {
            string contentRootPath = _env.ContentRootPath;
            string webRootPath = _env.WebRootPath;

            return Content(contentRootPath + "\n" + webRootPath);
        }
    }
}