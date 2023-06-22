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
        public static void JsonDeserializeMethod() 
        {
            string json = File.ReadAllText(pathJson);
            RecipeDetails recipe = new RecipeDetails();
            recipe = JsonConvert.DeserializeObject<RecipeDetails>(json)!;
        }
        
    }
}
