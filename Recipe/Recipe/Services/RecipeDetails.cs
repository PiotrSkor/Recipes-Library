using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Services
{
    public class RecipeDetails
    {
        public string RecipeName { get; set; } = default!;
        public string RecipeDescription { get;set; } = default!;
        public string Ingredients { get; set; } = default!;
        public string IngredientsValue { get; set; } = default!;

    }
}
