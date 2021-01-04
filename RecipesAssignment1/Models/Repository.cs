using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAssignment1.Models
{
    public class Repository
    {
        public static List<Recipe> recipes = new List<Recipe>();
        public static List<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
        }

        public static void AddRecipe(Recipe r)
        {
            recipes.Add(r);
        }
    }
}
