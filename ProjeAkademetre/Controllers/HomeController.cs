using ClosedXML.Excel;
using ProjeAkademetre.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeAkademetre.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string firstName, string surName, string adres, string mail)
        {

            return Content("Hello" + firstName + ":)");
        }
    }
}