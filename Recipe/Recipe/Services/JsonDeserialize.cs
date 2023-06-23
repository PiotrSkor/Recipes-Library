using Newtonsoft.Json;
using Recipe.Path;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Services
{
    public class JsonDeserialize:Paths
    {
        public static List<RecipeDetails> JsonDeserializeMethod() 
        {
            if (!File.Exists(pathJson))
            {
                Console.WriteLine("Brak przepisów do wyświetlenia");
            }
            else
            {
                string json = File.ReadAllText(pathJson);
                var recipes = JsonConvert.DeserializeObject<List<RecipeDetails>>(json)!;
                return recipes;
            }
            return null!;
        }
    }
}
