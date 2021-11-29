using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaDeMotos.Repository;

namespace VentaDeMotos.Controllers
{
    public class InformacionController : Controller
    {
        // GET: Informacion
        ClsMotos moto = new ClsMotos();
        public ActionResult Informacion()
        {
            var dmoto = moto.Listdatos();
            return View(dmoto);
        }
    }
}
