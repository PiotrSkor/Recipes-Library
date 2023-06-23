using Recipe.Interfaces;
using Recipe.Path;
using Recipe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Methods
{
    public class ShowRecipes : Paths, IRecipeLibraryItems
    {
        public static void ShowRecipeMethod()
        {
            if (File.Exists(pathJson))
            {
                List<RecipeDetails> recipeDetails = new List<RecipeDetails>();
                recipeDetails = JsonDeserialize.JsonDeserializeMethod();
                IRecipeLibraryItems.RecipeLibraryItems(recipeDetails);
            }
            else
            {
                Console.WriteLine("Brak przepisów do wyświetlenia");
            }
        }
    }
}
