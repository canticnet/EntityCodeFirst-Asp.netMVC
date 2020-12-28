using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApplication1.Models;


namespace WebApplication1.DAL {
	public class ContexteBDD : DbContext

		{
		
		public DbSet<Produit > Produits {
			get;
			set;
		}

protected override void OnModelCreating(DbModelBuilder modelBuilder) {
	
}

}
}