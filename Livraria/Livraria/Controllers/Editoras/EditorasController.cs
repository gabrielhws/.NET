using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Livraria.Models;

namespace Livraria.Controllers.Editoras
{
    public class EditorasController : Controller
    {
        //
        // GET: /Editoras/

        public ActionResult Index()
        {
            var editoraRepository = new EditoraRepository();
            return View(editoraRepository.BuscaTodas());
        }

    }
}
