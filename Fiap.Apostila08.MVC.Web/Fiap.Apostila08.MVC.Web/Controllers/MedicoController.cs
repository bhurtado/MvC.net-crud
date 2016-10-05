using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class MedicoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        // GET: Medico
        public ActionResult Index()
        {
            return View();
        }


        //To register a new medic
        [HttpPost]
        public ActionResult CAdastrar(Medico medico)
        {
            return View();
        }
    }
}