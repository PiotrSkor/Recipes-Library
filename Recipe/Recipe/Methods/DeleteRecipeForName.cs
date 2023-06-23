using Newtonsoft.Json;
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
    public class DeleteRecipeForName : Paths, IRecipeLibraryItems
    {
        public static void DeleteRecipeForNameMethod()
        {
            
            List<RecipeDetails> recipeDetails = new List<RecipeDetails>();
            recipeDetails = JsonDeserialize.JsonDeserializeMethod();
            Console.WriteLine("Podaj nazwę przepisu do usunięcia: ");
            var UserInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Trwa wyszukiwanie...");
            Thread.Sleep(1000);
            int i = recipeDetails.Count;
            int i2 = 0;
            foreach (var item in recipeDetails)
            {
                if (item.RecipeName.Contains(UserInput!))
                {
                    recipeDetails.RemoveAll(item => item.RecipeName.Contains(UserInput!));
                    Console.WriteLine("Przepis został usunięty");
                    break;
                    
                }
                else
                {
                    i2++;   
                    if (i==i2)
                    {
                        Console.WriteLine($"Brak przepisu o nazwie \"{UserInput}\" do usunięcia");
                    }
                }

            }

            

            File.WriteAllText(pathJson, string.Empty);
            var recipeToSerialize = JsonConvert.SerializeObject(recipeDetails);
            File.WriteAllText(pathJson, recipeToSerialize);


        }
    }
}
