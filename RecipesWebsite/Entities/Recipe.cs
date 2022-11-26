using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesWebsite.Entities
{
	public class Recipe
	{
		public string name { get; set; }
		public string id { get; set; }
		public string description { get; set; }
		public string[] tag { get; set; }
		public string image { get; set; }
		public Ingredient[] ingredient { get; set; }

		public Ingredients[] ingredientGroup { get; set; }
		public Step[] step { get; set; }

		public string notes { get; set; }
		public string forked { get; set; }

			
    }
}
