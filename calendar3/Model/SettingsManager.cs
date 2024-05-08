using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace calendar3.Model
{
    public static class SettingsManager
    {
        public static void SaveSelectedItemsToJson(List<DaySelection> selectedItems, string filePath)
        {
            string json = JsonConvert.SerializeObject(selectedItems);
            File.WriteAllText(filePath, json);
        }

        public static List<DaySelection> LoadSelectedItemsFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<DaySelection>>(json);
            }
            return new List<DaySelection>();
        }
    }
}
