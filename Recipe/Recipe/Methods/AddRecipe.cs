using Recipe.Path;
using Recipe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Methods
{
    public class AddRecipe :Paths
    {

        public static void AddRecipeMethod()
        {
            var recipe = new RecipeDetails();
            {
                Console.WriteLine("Podaj nazwę przepisu: ");
                recipe.RecipeName = Console.ReadLine()!;

            ValueRecipe:
                Console.WriteLine("Ile składników chcesz dodać?");
                var UserInput = Console.ReadLine();

                StringBuilder stringItem = new StringBuilder();
                StringBuilder stringValue = new StringBuilder();


                if (int.TryParse(UserInput, out int id))
                {
                    for (int i = 0; i < Convert.ToInt32(UserInput); i++)
                    {
                        Console.WriteLine($"Podaj {i + 1} produkt: ");
                        string item = Console.ReadLine()!;
                    IngredientsValue:
                        Console.Write("\tPodaj gramature produktu: ");
                        string value = Console.ReadLine()!;

                        if (int.TryParse(value, out int idd))
                        {

                        }
                        else
                        {
                            Console.WriteLine("\nPodaj prawidłową wartość");
                            goto IngredientsValue;
                        }

                        stringItem.Append(i+1 +"."+ item + " - " + value+" g ");
                    }

                }
                else
                {
                    Console.WriteLine("Podaj prawidłową liczbę");
                    goto ValueRecipe;
                }
                Console.WriteLine("Podaj opis przygotowania potrawy:");
                recipe.RecipeDescription = Console.ReadLine()!;
                recipe.Ingredients = stringItem.ToString();
            }

            Services.JsonSerialize.JsonSerialized(recipe);
        }
    }
}
