using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;//added
using Microsoft.Extensions.DependencyInjection;//added
using Microsoft.EntityFrameworkCore;//added

namespace RecipesAssignment1.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app) 
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeName = "Healthier Oatmeal Cookies",
                        Description = "Healthier cookies can be tricky to figure out, and this one was no exception. It went through rounds and rounds of testing. But we're proud to say that what we landed on is a really good COOKIE—not a granola bar that's just shaped like one.",
                        Chef = "Ederson Marques",
                        Ingridients = "1 c. quick-cooking oats, 1/2 c. old-fashioned oats, 1/4 c. whole-wheat flour, 3/4 tsp. baking soda",
                        PrepTime=" 1 hour "

                    },
                     new Recipe
                     {
                         RecipeName = "Taco Veggie Tot Muffins",
                         Description = "These cheesy single-serve tot muffins are hard to resist. Don't forget extra taco sauce for dipping!",
                         Chef = "Ederson Marques",
                         Ingridients = "Cooking spray, 4 large eggs, 1/4 c. whole milk, 2 tbsp. Ortega taco seasoning, (4-oz.) can mild Ortega fire roasted diced green chiles, drained",
                         PrepTime = " 30 min "

                     },
                    new Recipe
                    {
                        RecipeName = "Pineapple Fluff Pie",
                        Description = "Pineapple Fluff Pie tastes like a tropical vacation. The filling is light and airy and takes zero effort (or baking knowledge) to come together.",
                        Chef = "Ederson Marques",
                        Ingridients = "1 1/2 c. graham cracker crumbs, 5 tbsp. melted butter, 1/4 c. granulated sugar , 1/4 tsp. kosher salt",
                        PrepTime = " 3 hours "

                    },
                    new Recipe
                    {
                        RecipeName = "Greek Orzo Salad",
                        Description = "Though it looks a bit like rice, orzo isn't a grain. It's pasta! And like any other pasta, orzo is a great base for a salad.",
                        Chef = "Ederson Marques",
                        Ingridients = "8 oz. orzo, 3 Persian cucumbers, sliced into thin half-moons, 2 c. cherry tomatoes, halved, 1 (15.5-oz.) can chickpeas, drained and rinsed, 1/2 c. pitted kalamata olives, halved",
                        PrepTime = " 36 min "

                    },
                     new Recipe
                     {
                         RecipeName = "Classic BLT",
                         Description = "Here we really elevate the bacon by brushing it with maple syrup and a little cayenne pepper. We also spice up the mayonnaise some chili powder and a paprika to perk it up. ",
                         Chef = "Ederson Marques",
                         Ingridients = "2 tbsp. maple syrup, 2 tbsp. packed brown sugar, Pinch cayenne, 1 lb. thick-cut bacon, 1/4 c. mayonnaise, 1 tsp. chili powder, 1/4 tsp. sweet paprika, 4 slices white bread, lightly toasted, 4 leaves green lettuce, 4 (1/4 thick) slices vine-ripened tomatoes",
                         PrepTime = " 50 min "

                     }        
                );

                context.SaveChanges();

            }

        }
    }
}
