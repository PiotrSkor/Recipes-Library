using Recipe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Interfaces
{
    public interface IRecipeLibraryItems
    {
        public static void RecipeLibraryItems(List<RecipeDetails> recipeDetails)
        {
            foreach (var item in recipeDetails)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Nazwa: " + item.RecipeName);
                sb.AppendLine("--------------------------");
                sb.AppendLine("Opis przygotowania: " + item.RecipeDescription);
                sb.AppendLine("Lista składników: " + item.Ingredients);
                sb.AppendLine("**************************");
                Console.WriteLine(sb);
            }
        }
    }
}
