using System;
using Newtonsoft.Json;
using Recipe.Methods;
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
            Console.WriteLine("5.Usunąć przepis (nazwa)");
            Console.WriteLine("0.Zamknij program");

            var UserInput = Console.ReadLine();
            int.TryParse(UserInput, out int value);
            Console.Clear();
            switch (value)
            {
                case 1:
                    AddRecipe.AddRecipeMethod();
                    Console.WriteLine();
                    goto Beginning;
                case 2:
                    ShowRecipes.ShowRecipeMethod();
                    Console.WriteLine();
                    goto Beginning;
                case 3:
                    SearchRecipeForName.SearchRecipeForNameMethod();
                    Console.WriteLine();
                    goto Beginning;
                case 4:
                    SearchRecipeForIngredient.SearchRecipeIngredientMethod();
                    Console.WriteLine();
                    goto Beginning;
                    case 5:
                    DeleteRecipeForName.DeleteRecipeForNameMethod();
                    Console.WriteLine("");
                    goto Beginning;
                case 0:
                    break;
            }
        }
    }
}