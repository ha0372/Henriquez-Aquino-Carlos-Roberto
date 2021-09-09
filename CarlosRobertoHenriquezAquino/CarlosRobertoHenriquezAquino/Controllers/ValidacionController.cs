using CarlosRobertoHenriquezAquino.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarlosRobertoHenriquezAquino.Controllers
{
    public class ValidacionController : Controller
    {
        // GET: Validacion
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Mensaje(ValidacionViewModel val)
        {
            if (!ModelState.IsValid)
            {
                return View("Retiro", val);
            }

            return Redirect("Index");
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Retiro()
        {
            return View();
        }


    }
}