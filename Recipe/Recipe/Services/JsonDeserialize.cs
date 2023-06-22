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
            string json = File.ReadAllText(pathJson);
            var recipes = JsonConvert.DeserializeObject<List<RecipeDetails>>(json)!;
            
            return recipes;
        }
        
    }
}
