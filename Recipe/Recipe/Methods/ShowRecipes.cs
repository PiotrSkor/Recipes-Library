using Recipe.Path;
using Recipe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Methods
{
    public class ShowRecipes : Paths
    {
        public static void ShowRecipeMethod()
        {
            List<RecipeDetails> recipeDetails = new List<RecipeDetails>();
            recipeDetails = JsonDeserialize.JsonDeserializeMethod();

            foreach (var item in recipeDetails)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Nazwa: " + item.RecipeName);
                sb.AppendLine("");
                sb.AppendLine("Opis przygotowania: " + item.RecipeDescription);
                sb.AppendLine("Lista składników: " + item.Ingredients);
                Console.WriteLine(sb);
            }

            
        }
    }
}
