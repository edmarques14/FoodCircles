using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAssignment1.Models
{
    public class EFRecipeRepository :IRecipeRepository
    {
        private ApplicationDbContext context;
        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Recipe> Recipes => context.Recipes;
        public void SaveProduct(Recipe recipe)
        {
            if (recipe.RecipeId == 0)
            {
                context.Recipes.Add(recipe);
            }
             else
            {
                Recipe recipeEntry = context.Recipes
                    .FirstOrDefault(p => p.RecipeId == recipe.RecipeId);

                if (recipeEntry != null)
                {
                    recipeEntry.RecipeName = recipe.RecipeName;
                    recipeEntry.Description = recipe.Description;
                    recipeEntry.Ingridients = recipe.Ingridients;
                    recipeEntry.Chef = recipe.Chef;
                    recipeEntry.PrepTime = recipe.PrepTime;

                }
            }
            context.SaveChanges();

        }
        public Recipe DeleteRecipe(int recipeID)
        {
            Recipe recipeEntry = context.Recipes
                .FirstOrDefault(p => p.RecipeId == recipeID);

            if (recipeEntry != null)
            {
                context.Recipes.Remove(recipeEntry);
                context.SaveChanges();
            }

            return recipeEntry;
        }
    }
}
