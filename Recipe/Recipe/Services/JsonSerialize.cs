using Newtonsoft.Json;
using Recipe.Path;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Services
{
    public class JsonSerialize : Paths
    {
        public static void JsonSerialized(object obj)
        {
            if (!File.Exists(pathJson))
            {
                var recipeToSerialize = JsonConvert.SerializeObject(obj);
                File.AppendAllText(pathJson, "[" + recipeToSerialize + "]");
            }
            else
            {
                var recipeToSerialize = JsonConvert.SerializeObject(obj);
                var textFromJson = File.ReadAllText(pathJson);
                textFromJson = textFromJson.TrimEnd(']');
                textFromJson += ",";
                textFromJson += recipeToSerialize + "]";
                File.WriteAllText(pathJson, textFromJson);
            }

        }
    }
}
