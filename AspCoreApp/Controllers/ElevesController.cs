using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspCoreApp.Data;
using AspCoreApp.Models;

namespace AspCoreApp.Controllers
{
    public class ElevesController : Controller
    {
        ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

        public IActionResult Index(string cne)
        {
            List<Eleve> eleves = new List<Eleve>();
            
            if (!String.IsNullOrEmpty(cne))
            {
                var list = client.GetOne(cne);
                Eleve e = new Eleve();
                e.cne = list.cne;
                e.prenom = list.prenom;
                e.nom = list.nom;
                e.email = list.email;
                e.filiere = list.filiere;
                e.tel = list.tel;
                if (e.cne != null)
                {
                    eleves.Add(e);
                }
            }
            else
            {
                var list = client.GetAll();
                foreach (var item in list)
                {
                    Eleve e = new Eleve();
                    e.cne = item.cne;
                    e.prenom = item.prenom;
                    e.nom = item.nom;
                    e.email = item.email;
                    e.filiere = item.filiere;
                    e.tel = item.tel;
                    eleves.Add(e);
                }
            }
            if (eleves.Count == 0)
            {
                var message = "Aucun Eleve n'est trouvé";
                ViewBag.message = message;
                return View();
            }
            else
            {
                return View(eleves);
            }
            
        }

        public ActionResult Details(string cne)
        {
            var list = client.GetOne(cne);
            Eleve e = new Eleve();
            e.cne = list.cne;
            e.prenom = list.prenom;
            e.nom = list.nom;
            e.email = list.email;
            e.filiere = list.filiere;
            e.tel = list.tel;
            return View(e);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Eleve e)
        {
            Eleve E = new Eleve();
            E.cne = e.cne;
            E.prenom = e.prenom;
            E.nom = e.nom;
            E.email = e.email;
            E.filiere = e.filiere;
            E.tel = e.tel;
            client.Insert(E.cne, E.prenom, E.nom, E.email, E.filiere, E.tel);
            return RedirectToAction("Index", "Eleves");
        }

        public ActionResult Delete(string cne)
        {
            int res = client.DeleteEleve(cne);
            if (res > 0)
            {
                return RedirectToAction("Index", "Eleves");
            }
            return View();
        }

        public ActionResult Edit(string cne)
        {
            var list = client.GetOne(cne);
            Eleve e = new Eleve();
            e.cne = (list.cne).Trim();
            e.prenom = (list.prenom).Trim();
            e.nom = (list.nom).Trim();
            e.email = (list.email).Trim();
            e.filiere = (list.filiere).Trim();
            e.tel = (list.tel).Trim();
            return View(e);
        }
        [HttpPost]
        public ActionResult Edit(Eleve e)
        {
            Eleve E = new Eleve();
            E.cne = e.cne;
            E.prenom = e.prenom;
            E.nom = e.nom;
            E.email = e.email;
            E.filiere = e.filiere;
            E.tel = e.tel;
            int res = client.UpdateEleve(E.cne, E.prenom, E.nom, E.email, E.filiere, E.tel);
            if (res > 0)
            {
                return RedirectToAction("Index", "Eleves");
            }
            return View();
        }
    }
}
