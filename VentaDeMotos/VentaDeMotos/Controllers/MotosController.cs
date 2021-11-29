using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaDeMotos.Models;
using VentaDeMotos.Repository;

namespace VentaDeMotos.Controllers
{
    public class MotosController : Controller
    {
        // GET: Motos

        ClsMotos clsmoto = new ClsMotos();
        public ActionResult Index()
        {
            var list = clsmoto.Listamoto();
            return View(list);
        }

        public ActionResult COMPRAR(int id)
        {
            MOTO motos = new MOTO();
            motos.ID_MOTO = id;

            clsmoto.Comprar(motos);

            return RedirectToAction("Index");
        }

        public ActionResult INformacion(int Id)
        {
            DATOSMOTOS dtmoto = new DATOSMOTOS();
            dtmoto.ID_DATOSM = Id;
            return View("Informacion");
        }
       
    }
}