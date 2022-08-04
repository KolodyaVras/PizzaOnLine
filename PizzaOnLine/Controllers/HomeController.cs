using PizzaOnLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaOnLine.Controllers
{
    public class HomeController : Controller
    {
        PizzaContext db = new PizzaContext();

        public ActionResult Index()
        {
            IEnumerable<Pizza> pizzas = db.Pizzas;
            ViewBag.Pizzas = pizzas;

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}