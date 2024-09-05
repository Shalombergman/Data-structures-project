

using DataStructuresProject;
//using Newtonsoft.Json;
using System.Text.Json;

public class Program
{
    static void Main(string[] args)
    {
        List<DefenceTreeNode> defenceTreeNodes = ReadFromJson<List<DefenceTreeNode>>("/Users/shalom_bergman/kodcode2/Data_engineering_course/DataStructuresProject/DataStructuresProject/Json/defenceStrategiesBalanced.json");  

        static T ReadFromJson<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        foreach (DefenceTreeNode defenceTreeNode in defenceTreeNodes)
        {
            DefenceStrategiesBST.Insert(defenceTreeNode);
            
            
            //Console.WriteLine(defenceTreeNode.MaxSeverity);
        }

        DefenceStrategiesBST.PreOrder(defenceTreeNodes[0]);

        // Console.WriteLine(DefenceStrategiesBST.InsertRecursive(DefenceTreeNode  defenceTreeNodes[0], defenceTreeNodes[0].MinSeverity,
        //     defenceTreeNodes[0].MaxSeverity, defenceTreeNodes[0].Defenses).ToString());
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