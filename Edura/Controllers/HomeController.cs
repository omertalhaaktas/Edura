using Edura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edura.Controllers
{
    public class HomeController : Controller
    {
        EduraContext _context = new EduraContext();



        // GET: Home
        public ActionResult Index()
        {
            var products = _context.
                Products.
                Where(i=>i.isApproved==true && i.isHome==true)
                .ToList();


            return View(products);
        }
    }
}