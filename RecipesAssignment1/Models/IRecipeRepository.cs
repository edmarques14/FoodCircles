using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAssignment1.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
        void SaveProduct(Recipe recipe);
        Recipe DeleteRecipe(int recipeID);

    }
}
