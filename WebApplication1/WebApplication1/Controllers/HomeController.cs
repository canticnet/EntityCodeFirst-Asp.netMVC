using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ContexteBDD bdd = new ContexteBDD();

        //URL : /HOME/INDEX
        //Test EF basique avec la restitution d'un produit avec un ID produit imposé
        public ActionResult Index()
        {
            Produit monProduit = bdd.Produits.Find(1);
            ViewData["Titre"] = "Test du framework Entity 6";
            if (monProduit == null)
            {

                ViewData["Message"] = "Aucun produit trouvé."; ;

            }

            ViewData["Message"] = monProduit.Titre + " " + monProduit.Fournisseur;

            return View();
        }

        //URL : /HOME/PRODUIT/
        //Test EF avec une recherche à partir d'un ID produit choisi par l'utilisateur
        public ActionResult Produit(int IDProduit)
        {
            Produit monProduit = bdd.Produits.Find(IDProduit);
            ViewData["Titre"] = "Test du framework Entity 6 avec recherche d'un produit";
            if (monProduit == null)
            {

                ViewData["Message"] = "Aucun produit trouvé."; ;

            }

            ViewData["Message"] = monProduit.Titre + " " + monProduit.Fournisseur;

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        
    }
}