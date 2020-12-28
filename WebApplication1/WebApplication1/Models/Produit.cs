using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
 
namespace WebApplication1.Models
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }
        public string Fournisseur { get; set; }
        public double PrixHT { get; set; }

        public double PrixTTC { get; set; }

    }
}