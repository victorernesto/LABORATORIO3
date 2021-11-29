using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROYECTOF.Controllers
{
    public class MotosController : Controller
    {
        // GET: Motos
        public ActionResult Index()
        {
            return View();
        }
    }
}
/* public class CajeroAController : Controller
    {
        // GET: CajeroAutomatico

        [HttpGet]
        public ActionResult IndexXL()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Correctohtml()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Errorhtml()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexXL(CajeroAutomatico c)
        {



{


            if (c.monto % 5 == 0)
            {
                return Redirect("Correctohtml");
            }
            else
            {
                return Redirect("Errorhtml");
            }
        }*/