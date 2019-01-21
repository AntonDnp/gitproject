using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        DataContext dc = new DataContext();
        // GET: Home
        public ActionResult Index()
        {

            ViewBag.Data = dc.Tables.Select(c=>c.Name);
                //   Comment 1
                 //  Hello new branch
               // barnch master
            return View();
        }
    }
}