using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Recipe
{


    class HelperMethods
    {
        
 
        public static void AddRecipeToListShowRecipe()
        {

            List<string> listOfProducts = new List<string>();
            listOfProducts.Add("****************************************************");
            Console.WriteLine("Podaj nazwę przepisu: ");
            var NameOfRecipe = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------" + NameOfRecipe + "----------");
            listOfProducts.Add(Convert.ToString(sb));



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
                    listOfProducts.Add(Convert.ToString(stringItem));
                }

            }
            else
            {
                Console.WriteLine("Podaj prawidłową liczbę");
                goto ValueRecipe;
            }
            listOfProducts.Add("****************************************************");
            listOfProducts.Add("");
            var filepath = @"D:\visua\Recipe\Przepisy\Recipe.txt";

            File.AppendAllLines(filepath, listOfProducts);
            Console.WriteLine("Dodano: ");
            foreach (var items in listOfProducts)
            {
                Console.WriteLine(items);
            }

            

            string recipeeeeee = JsonConvert.SerializeObject(listOfProducts);
            File.WriteAllText(@"D:\visua\Recipe\Przepisy\recipeeeeee.json", recipeeeeee);
            



        }

        public static void ShowRecipe()
        {
            var filepath = @"D:\visua\Recipe\Przepisy\Recipe.txt";
            var textInside = File.ReadAllText(filepath);
            Console.WriteLine(textInside);


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
            var filepath = @"D:\visua\Recipe\Przepisy\Recipe.txt";
            var textInside = File.ReadAllText(filepath);

            

        }

        /*JsonConvert.SerializeObject(listOfProducts);*/
       

    }

    

           
}
