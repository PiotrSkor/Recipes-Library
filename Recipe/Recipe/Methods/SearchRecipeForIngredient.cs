using Recipe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Methods
{
    public class SearchRecipeForIngredient
    {
        public static void SearchRecipeIngredientMethod()
        {
            List<RecipeDetails> recipeDetails = new List<RecipeDetails>();
            recipeDetails = JsonDeserialize.JsonDeserializeMethod();
            Console.WriteLine("Podaj składnik: ");
            var UserInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Trwa wyszukiwanie...");
            Thread.Sleep(1000);
            if (recipeDetails != null)
            {
                int i = recipeDetails.Count;
                int i2 = 0;
                foreach (var item in recipeDetails)
                {
                    if (item.Ingredients.Contains(UserInput!))
                    {
                        RecipeLibraryItems.RecipeLibraryItemsMethod(item);
                    }
                    else
                    {
                        i2++;
                        if (i == i2)
                        {
                            Console.WriteLine($"Brak przepisu ze składnikiem \"{UserInput}\"");
                        }
                    }
                }
            
            }
        }
    }
}
