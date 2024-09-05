

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
        }
        DefenceStrategiesBST.PreOrder();
    }
    
}