using System;
using Newtonsoft.Json;
using static Recipe.HelperMethods;

namespace Recipe
{
    public class Program 
    {


        public static void Main(string [] args)
        {
        Beginning:
            Console.WriteLine("Co chcesz zrobić?\n");
            Console.WriteLine("1.Dodać przepis");
            Console.WriteLine("2.Wyświetlić przepis");
            Console.WriteLine("3.Wyszukać przepis (nazwa)");
            Console.WriteLine("4.Wyszukać przepis (składnik)");
            Console.WriteLine("5.Usunąć przepis (numery)");
            Console.WriteLine("0.Zamknij program");

            var UserInput = Console.ReadLine();
            int.TryParse(UserInput, out int value);
            Console.Clear();
            switch (value)
            {
                case 1:
                    HelperMethods.AddRecipeToListShowRecipe();
                    Console.WriteLine();
                    
                    goto Beginning;

                    break;
                case 2:
                    
                    HelperMethods.ShowRecipe();
                    Console.WriteLine();
                    
                    goto Beginning;
                    break;
                case 3:
                    HelperMethods.SearchRecipeName();
                    Console.WriteLine();
                    goto Beginning;
                    break;
                case 4:
                    HelperMethods.SearchRecipeIngredient();
                    Console.WriteLine();
                    goto Beginning;
                    break;
                case 0:

                    break;
            }
        }
    }
}