using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var authors = new List<Authors>() { 
             new Authors{ Name = "Author 1", Address="missing st."},
             new Authors{ Name = "Author 2", Address="missing st."},
             new Authors{ Name = "Author 3", Address="missing st."},
            };
            return View(authors);
        }
    }
}