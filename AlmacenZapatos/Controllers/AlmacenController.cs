using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AlmacenZapatos.Controllers
{
    public class AlmacenController : Controller
    {
        // GET: Almacen
        public ActionResult Index()
        {
            return View();
        }

        //Catalogo de los productos
        [HttpGet]
        public ActionResult Catalogo()
        {
            List<Inventario> Inv;
            using (var context = new InventarioZapatosEntities())
            {
                Inv = (from zpts in context.Inventario select zpts).ToList();
            }
            return View(Inv);
        }


        //Detalles de un modelo
       [HttpGet]
       public ActionResult Detalles (int Id)
        {
            Inventario Inv;
            using (var context = new InventarioZapatosEntities())
            {
                Inv = (from zpts in context.Inventario where zpts.Id == Id select zpts).FirstOrDefault();
            }
            return View(Inv);
        }
       

        //Creacion de un nuevo Modelo
        [HttpGet]
        public ActionResult NuevoZapato()
        {
            return View("NuevoZapato");
        }

        [HttpPost]
        public ActionResult NuevoZapato(Inventario Inv)
        {
            using (var context = new InventarioZapatosEntities())
            {
                context.Inventario.Add(Inv);
                context.SaveChanges();
            }
            return RedirectToAction("Catalogo", "Almacen");
        }

        //Actualizacion de un Modelo
        [HttpGet]
        public ActionResult Actualizar (int Id)
        {
            Inventario Inv;
            using (var context = new InventarioZapatosEntities())
            {
                Inv = (from zpts in context.Inventario where zpts.Id == Id select zpts).FirstOrDefault();
            }
            return View(Inv);
        }


        [HttpPost]
        public ActionResult Actualizar (Inventario Inv)
        {
            using (var contexto = new InventarioZapatosEntities())
            {
                contexto.Entry(Inv).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
            return RedirectToAction("Catalogo", "Almacen");
        }


        //Eliminacion de un modelo
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            Inventario Inv;
            using (var context = new InventarioZapatosEntities())
            {
                Inv = (from zapatos in context.Inventario where zapatos.Id == id select zapatos).FirstOrDefault();
            }
            return View(Inv);
        }


        [HttpPost]
        public ActionResult Eliminar(Inventario Zap)
        {
            Inventario ZapatoEliminar;
            using (var context = new InventarioZapatosEntities())
            {
                ZapatoEliminar = (from zpts in context.Inventario where zpts.Id == zpts.Id select zpts).FirstOrDefault();
                context.Inventario.Remove(ZapatoEliminar);
                context.SaveChanges();
            }
            return RedirectToAction("Catalogo", "Almacen");
        }



    }
}