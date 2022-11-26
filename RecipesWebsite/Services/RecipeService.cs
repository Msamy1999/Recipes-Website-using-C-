using RecipesWebsite.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RecipesWebsite.Services
{
    public class RecipeService
    {
        public static IEnumerable<Recipe> GetAllRecipes()
        {
            var reader = new StreamReader("Data/recipes.json");
            var alldata = reader.ReadToEnd();
            var allrecipes = JsonSerializer.Deserialize<Recipes>(alldata);

            return allrecipes.recipe;

        }

    }
}
