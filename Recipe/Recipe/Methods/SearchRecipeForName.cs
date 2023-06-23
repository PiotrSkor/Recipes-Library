﻿using Recipe.Interfaces;
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
            Console.WriteLine("Podaj nazwę przepisu: ");
            var UserInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Trwa wyszukiwanie...");
            Thread.Sleep(1000);
            foreach (var item in recipeDetails)
            {
                if (item.RecipeName.Contains(UserInput!))
                {
                    IRecipeLibraryItems.RecipeLibraryItems(recipeDetails);
                }
                else
                {
                    Console.WriteLine($"Brak przepisu o nazwie \"{UserInput}\"");
                    break;
                }
            }
        }
    }
}
