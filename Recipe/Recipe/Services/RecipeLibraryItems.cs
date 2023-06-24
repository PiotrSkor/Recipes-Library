using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Services
{
    public class RecipeLibraryItems
    {
        public static void RecipeLibraryItemsMethod(RecipeDetails recipeDetails)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nazwa: " + recipeDetails.RecipeName);
            sb.AppendLine("--------------------------");
            sb.AppendLine("Opis przygotowania: " + recipeDetails.RecipeDescription);
            sb.AppendLine("Lista składników: " + recipeDetails.Ingredients);
            sb.AppendLine("**************************");
            Console.WriteLine(sb);

        }

        public static void RecipeLibraryShowRecipesMethod(List<RecipeDetails> recipeDetails)
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
