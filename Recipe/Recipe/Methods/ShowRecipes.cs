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
            JsonDeserialize.JsonDeserializeMethod();
            RecipeDetails recipeDetails = new RecipeDetails();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nazwa: "+recipeDetails.RecipeName);
            sb.AppendLine("");
            sb.AppendLine("Opis przygotowania: "+recipeDetails.RecipeDescription);
            sb.AppendLine("Lista składników: "+recipeDetails.Ingredients);
        }
    }
}
