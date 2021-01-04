using Microsoft.AspNetCore.Mvc;// conected to Controller
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesAssignment1.Models;

namespace RecipesAssignment1.Controllers
{
    public class CrudController : Controller
    {
        private IRecipeRepository repository;
        public CrudController(IRecipeRepository repo)
        {
            repository = repo;
        }

      public ViewResult Index() => View(repository.Recipes);
        [HttpGet]
        public ViewResult AddNewRecipe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewRecipe(Recipe recipe)
        {
            repository.SaveProduct(recipe);
            TempData["message"] = $"{recipe.RecipeName} has been saved!";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int recipeid)
        {
            Recipe deletedProduct = repository.DeleteRecipe(recipeid);

            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.RecipeName} was deleted!";
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Edit(int recipeId) =>
           View(repository.Recipes
               .FirstOrDefault(p => p.RecipeId == recipeId));

        [HttpPost]
        public IActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(recipe);
                TempData["message"] = $"{recipe.RecipeName} has been saved!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }
    }
}
