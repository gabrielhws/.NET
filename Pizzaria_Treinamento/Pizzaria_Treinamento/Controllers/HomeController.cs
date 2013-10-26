using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzaria_Treinamento.Models;

namespace Pizzaria_Treinamento.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var db = new PizzaContext();
            var pizzas = db.Pizza.ToList();
            return View(pizzas);
        }

        //Abre para criar nova pizza [HttpGet] já é implicito
        public ActionResult Create()
        {
            
            return View();
        }

        //Recebe a pizza criada e salva
        [HttpPost]
        public ActionResult Create(PizzaModel pizza)
        {
            if (!ModelState.IsValid)
            {
                return View(pizza);
            }

            var db = new PizzaContext();
            db.Pizza.Add(pizza);
            db.SaveChanges();

            //redireciona e retorn a lista
            return RedirectToAction("Index");
        }

    }
}
