using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Livraria.Models;

namespace Livraria.Controllers.Livros
{
    public class LivrosController : Controller
    {
        //
        // GET: /Livros/

        public ActionResult Index()
        {
            var livroRepository = new LivroRepository();
            return View(livroRepository.BuscaTodas());
        }

    }
}
