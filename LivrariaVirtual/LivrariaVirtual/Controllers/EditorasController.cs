using LivrariaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivrariaVirtual.Controllers
{
    public class EditorasController : Controller
    {
        //Get Editoras
        public ActionResult Index()
        {
            var editoraRepository = new EditoraRepository();
            return View(editoraRepository.BuscaTodas());
        }
    }
}