using Atividade_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade_5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Exercicio 1";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Exercicio 2";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Exercicio 3";

            return View();
        }
        public ActionResult Exercicio4()
        {
            ViewBag.Message = "Exercicio 4";

            return View();
        }
        public ActionResult Exercicio5()
        {
            ViewBag.Message = "Exercicio 5";

            return View();
        }
        public ActionResult Exercicio6()
        {
            ViewBag.Message = "Exercicio 6";

            return View();
        }
        public ActionResult Exercicio7()
        {
            ViewBag.Message = "Exercicio 7";

            return View();
        }
        public ActionResult Exercicio8()        {
            CadastroUsuario user = new CadastroUsuario();
            return View(user);
        }
        [HttpPost]
        public ActionResult exibeCadastro(CadastroUsuario user)
        {            
                return View(user);                    
        }

    }
}