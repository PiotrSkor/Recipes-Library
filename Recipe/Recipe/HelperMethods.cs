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
        public JsonSerialize JsonSerialize { get; }

        public HelperMethods(Recipe.Services.JsonSerialize jsonSerialize)
        {
            JsonSerialize = jsonSerialize;
        }

        public static void AddRecipeToListShowRecipe()
        {


            List<string> listOfProductsToTxt = new List<string>();
            List<string> listOfProductsToJson = new List<string>();
            listOfProductsToTxt.Add("****************************************************");
            Console.WriteLine("Podaj nazwę przepisu: ");
            var NameOfRecipe = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------" + NameOfRecipe + "----------");
            listOfProductsToTxt.Add(Convert.ToString(sb)!);
            listOfProductsToJson.Add(Convert.ToString(NameOfRecipe)!);



        ValueRecipe:
            Console.WriteLine("Ile składników chcesz dodać?");
            var UserInput = Console.ReadLine();


            if (int.TryParse(UserInput, out int id))
            {
                for (int i = 0; i < Convert.ToInt32(UserInput); i++)
                {
                    StringBuilder stringItem = new StringBuilder();
                    Console.WriteLine($"Podaj {i + 1} produkt: ");
                    var item = Console.ReadLine();
                    Console.Write("\tPodaj gramature produktu: ");
                    var valueOfProducts = Console.ReadLine();
                    stringItem.Append(item + " - " + valueOfProducts);
                    listOfProductsToJson.Add(Convert.ToString(stringItem)!);
                }

            }
            else
            {
                Console.WriteLine("Podaj prawidłową liczbę");
                goto ValueRecipe;
            }
            listOfProductsToJson.Add("****************************************************");
            listOfProductsToJson.Add("");
            var filepath = pathTxt;

            File.AppendAllLines(filepath, listOfProductsToJson);
            Console.WriteLine("Dodano: ");
            foreach (var items in listOfProductsToJson)
            {
                Console.WriteLine(items);
            }


            Services.JsonSerialize.JsonSerialized(listOfProductsToJson);

            
            
        }


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

        /*JsonConvert.SerializeObject(listOfProducts);*/
       

    }

    

           
}
