using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNIPIM.Models;

namespace UNIPIM.Controllers
{
    public class HomeController : Controller
    {
        public Tarefas imus = new Tarefas();

        public ActionResult Index()
        {
            var lista = imus.Consultar();
            return View(lista);
        }


        public ActionResult Cadastrar()
        {


            return View();
        }

        public ActionResult Create(Tarefas aluno)
        {
            if (ModelState.IsValid)
            {
                imus.Cadastrar(aluno);

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {

            imus.Deletar(id);
            return View();
        }


    }
}