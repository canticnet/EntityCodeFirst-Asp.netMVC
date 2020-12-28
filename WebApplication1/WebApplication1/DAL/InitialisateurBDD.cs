using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
 
namespace WebApplication1.DAL
{
    public class InitialisateurBDD : System.Data.Entity.DropCreateDatabaseAlways<ContexteBDD>
    {
        protected override void Seed(ContexteBDD context)
        {
            var Produits = new List<Produit>
                {
                new Produit{Titre="ChaussuresA",Description="Cool",PrixHT=15.1, Fournisseur="Nike"},
                new Produit{Titre="ChaussuresB",Description="Détendu",PrixHT=17.9, Fournisseur="Burton"},
                new Produit{Titre="ChaussuresC",Description="Sportswear",PrixHT=21.3, Fournisseur="Nike"},
                new Produit{Titre="ChaussuresD",Description="Sérieux",PrixHT=25.2, Fournisseur="LondonShoes"},
                new Produit{Titre="ChaussuresE",Description="Classique",PrixHT=27.5, Fournisseur="Italo"},
                new Produit{Titre="ChaussuresF",Description="Outdoor",PrixHT=29.2, Fournisseur="Reebook"},
                new Produit{Titre="ChaussuresH",Description="Détendu",PrixHT=31.3, Fournisseur="Puma"},
                };
            Produits.ForEach(s => context.Produits.Add(s));
            context.SaveChanges();
        }
    }
}