using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using appCarrito001.Models;

namespace appCarrito001.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        private CarritoBDEntities ce = new CarritoBDEntities();
        public ActionResult Index()
        {
            return View(ce.Producto.ToList().OrderBy(x=>x.Nombre));
        }
    }
}