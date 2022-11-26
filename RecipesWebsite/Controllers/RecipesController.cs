using Microsoft.AspNetCore.Mvc;
using RecipesWebsite.Entities;
using RecipesWebsite.Services;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace RecipesWebsite.Controllers
{
    public class RecipesController : Controller
    {

        // /recipes/
        public IActionResult Index()
        {
            //var reader = new StreamReader("Data/recipes.json");
            //var alldata = reader.ReadToEnd();
            //var allrecipes = JsonSerializer.Deserialize<Recipes>(alldata);

            return View(RecipeService.GetAllRecipes());
        }


        // /recipes/about

        public IActionResult About()
        {
            return View();
        }
        // /recipes/blogs
        public IActionResult Blogs()
        {
            return View();
        }

        // /recipes/recipes
        public IActionResult Recipes()
        {
            return View();
        }
        // /recipes/Contactus
        public IActionResult Contactus()
        {
            return View();
        }

    }
}