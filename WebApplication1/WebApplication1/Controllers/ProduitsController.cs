using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebserviceCatalogueCDiscount.DAL;
using WebserviceCatalogueCDiscount.Models;

namespace WebserviceCatalogueCDiscount.Controllers
{
    public class ProduitsController : ApiController
    {
   
        private BddCDiscount bdd = new BddCDiscount();


        //GET api/Produits
        public IEnumerable<Produit> GetProduits()
        {
            return bdd.Produits;
        }

        //GET api/Produits/5
        public IHttpActionResult GetProduits(int id)
        {
           
            Produit monProduit = bdd.Produits.Find(id);
            if (monProduit == null)
            {

                return NotFound();

            }
            return Ok(monProduit);
        }

        //GET api/Produits/Cognac&ChaussuresHomme&J.BRADFORD
        public IHttpActionResult GetProduits(string titre, string theme, string fournisseur)
        {
                 var mesproduits = (from MesProduits in bdd.Produits
                             where MesProduits.Titre == titre || MesProduits.Theme == theme || MesProduits.Fournisseur == fournisseur
                             orderby MesProduits.Titre
                                    select MesProduits).ToList();


            if (mesproduits == null)
            {
                return NotFound();
            }
            
            return Ok(mesproduits);
        }

    }
}
