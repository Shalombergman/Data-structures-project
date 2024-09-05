

using DataStructuresProject;
//using Newtonsoft.Json;
using System.Text.Json;

public class Program
{
    static void Main(string[] args)
    {
        List<DefenceTreeNode> defenceTreeNodes = ReadFromJson<List<DefenceTreeNode>>("/Users/shalom_bergman/kodcode2/Data_engineering_course/DataStructuresProject/DataStructuresProject/Json/defenceStrategies.json");  

        static T ReadFromJson<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        foreach (DefenceTreeNode defenceTreeNode in defenceTreeNodes)
        {
            Console.WriteLine(defenceTreeNode.MaxSeverity);
        }
        //Console.WriteLine($"\n{defenceTreeNodes.ToString()}");
        // string jsonString = JsonSerializer.Serialize(destination, new JsonSerializerOptions() { WriteIndented = true});  
        // using (StreamWriter outputFile = new StreamWriter("dataReady.json"))  
        // {  
        //     outputFile.WriteLine(jsonString);  
        // }  

        // using (StreamReader r = new StreamReader())  
        // {  
        //     string json = r.ReadToEnd();  
        //     defenceTreeNodes = JsonSerializer.Deserialize<List<DefenceTreeNode>>(json);  
        // }
    }
}