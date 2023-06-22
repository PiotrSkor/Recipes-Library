using Newtonsoft.Json;
using Recipe.Path;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Services
{
    public class JsonSerialize:Paths
    {
        public static void JsonSerialized(object obj)
        {
            var recipeToSerialize = JsonConvert.SerializeObject(obj);
            File.AppendAllText(pathJson, recipeToSerialize);
        }
    }
}
