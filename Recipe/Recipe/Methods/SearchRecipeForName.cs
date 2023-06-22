using Recipe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Methods
{
    public class SearchRecipeForName
    {
        public static void SearchRecipeForNameMethod()
        {
            List<RecipeDetails> recipeDetails = new List<RecipeDetails>();
            recipeDetails = JsonDeserialize.JsonDeserializeMethod();
            var UserInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Trwa wyszukiwanie...");
            foreach (var item in recipeDetails)
            {
                if (item.RecipeName.Contains(UserInput!))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("--------------------------");
                    sb.AppendLine("Nazwa: " + item.RecipeName);
                    sb.AppendLine("--------------------------");
                    sb.AppendLine("Opis przygotowania: " + item.RecipeDescription);
                    sb.AppendLine("Lista składników: " + item.Ingredients);
                    sb.AppendLine("--------------------------");
                    Console.WriteLine(sb);
                }
            }
        }
    }
}
