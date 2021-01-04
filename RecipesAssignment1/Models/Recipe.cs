using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAssignment1.Models
{
    public class Recipe 
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }

        public string Ingridients { get; set; }

        public string Chef { get; set; }
        public string PrepTime { get; set; }
       


    }

}
