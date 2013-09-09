using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestHjemmeside.Models;

namespace TestHjemmeside.Controllers
{
    public class AddressController : Controller
    {
        //
        // GET: /Address/

        public ActionResult Index()
        {
            var liste = new List<Adresse>();
            liste.Add(new Adresse
            {
                Name = "Chalotte",
                Vej = "Århusvej",
            });
            liste.Add(new Adresse {
                Name = "Christian",
                Vej = "Månen",
            });

            return View(liste);
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}
