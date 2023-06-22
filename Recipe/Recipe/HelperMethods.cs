using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Recipe.Path;
using Recipe.Services;

namespace Recipe
{
    class HelperMethods : Paths
    {
        public static void SearchRecipeIngredient()
        {
            Console.WriteLine("Po składniku");
        }

        public static void SearchRecipeName()
        {
            Console.WriteLine("Po nazwie");
        }

        public static void DeleteRecipe()
        {
            var filepath =pathTxt;
            var textInside = File.ReadAllText(filepath);
        }

    }
}
