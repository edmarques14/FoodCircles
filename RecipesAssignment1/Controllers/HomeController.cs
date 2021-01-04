using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipesAssignment1.Models;

namespace RecipesAssignment1.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository repository;
        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }


        public ViewResult Index()
        {
            return View();
        }
       


        public ViewResult ViewRecipe(int recipeId) =>
            View(repository.Recipes
                .FirstOrDefault(p => p.RecipeId == recipeId));


        public ViewResult ReviewRecipe()
        {
            return View();
        }


        public ViewResult ListRecipes() => View(repository.Recipes);
         
        
        

    }
}
