

using DataStructuresProject;
//using Newtonsoft.Json;
using System.Text.Json;

public class Program
{
    static void Main(string[] args)
    {
        List<DefenceTreeNode> defenceTreeNodes = ReadFromJson<List<DefenceTreeNode>>("/Users/shalom_bergman/kodcode2/Data_engineering_course/DataStructuresProject/DataStructuresProject/Json/defenceStrategiesBalanced.json");  
        //List<ThreatsNode> threatsNodes = ReadFromJson<List<ThreatsNode>>("/Users/shalom_bergman/kodcode2/Data_engineering_course/DataStructuresProject/DataStructuresProject/Json/threats.json");  

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
        
        
        
        
        // foreach (ThreatsNode threatsNode in threatsNodes)
        // {
            //int severity = (threatsNode.Volume * threatsNode.Sophistication) + threatsNode.TargetValue;
            //DefenceStrategiesBST.Insert(threatsNode);
        //}
        List<ThreatsNode> threatsNodes = ReadFromJson<List<ThreatsNode>>("/Users/shalom_bergman/kodcode2/Data_engineering_course/DataStructuresProject/DataStructuresProject/Json/threats.json");          static T ReadThreatFromJson<T>(string jsonFile)
        {
            string jsonthreatString = File.ReadAllText(jsonFile);
            return JsonSerializer.Deserialize<T>(jsonthreatString);
        }
        //DefenceStrategiesBST trt = new();
        // foreach (ThreatsNode threatsNode in threatsNodes)
        // {
        //     string targetValue = threatsNode.ToString();
        //     switch (targetValue)
        //     {
        //         case "Web Server":
        //             targetValue = "10";
        //             break;
        //         case "Database":
        //             targetValue = "15";
        //             break;
        //         case "User Credentials":
        //             targetValue = "20";
        //             break;
        //         default:
        //             targetValue = "5";
        //             break;
        //     }
        //     int severity = int.Parse( th * threatsNode.Sophistication) + int.Parse(threatsNode);
        //     trt.Find(severity);
        // }

        
    }

    // public int GetTargetValue(ThreatsNode threatsNode)
    // {
    //     if (threatsNode.)
    //     {
    //         
    //     }
    // }
    // public int Getseverity(ThreatsNode threatsNode)
    // {
    //     int severity = (threatsNode.volume * threatsNode.sophistication) + threatsNode.targetValue;
    //     return severity;//
    // }
}