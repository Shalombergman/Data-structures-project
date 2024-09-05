using System.Text.Json;

namespace DataStructuresProject;

public class ThreatsNode
{
    private string ThreatType { get; set; }
    private int Volume { get; set; }
    private int Sophistication  { get; set; }
    private string Target { get; set; }

    public ThreatsNode(string threatType, int volume, int sophistication, string target)
    {
        ThreatType = threatType;
        Volume = volume;
        Sophistication = sophistication;
        Target = target;
    }

    public void attacks()
    {
        List<ThreatsNode> threatsNodes = ReadFromJson<List<ThreatsNode>>("/Users/shalom_bergman/kodcode2/Data_engineering_course/DataStructuresProject/DataStructuresProject/Json/threats.json");  
        static T ReadFromJson<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
        foreach (ThreatsNode threatsNode in threatsNodes)
        {
            //int severity = (threatsNode.Volume * threatsNode.Sophistication) + threatsNode.TargetValue;
          
        }
        DefenceStrategiesBST trt = new();
        foreach (ThreatsNode threatsNode in threatsNodes)
        {
            string targetValue = threatsNode.ToString();
            switch (targetValue)
            {
                case "Web Server":
                    targetValue = "10";
                    break;
                case "Database":
                    targetValue = "15";
                    break;
                case "User Credentials":
                    targetValue = "20";
                    break;
                default:
                    targetValue = "5";
                    break;
            }
            //int severity = int.Parse( th * threatsNode.Sophistication) + int.Parse(threatsNode);
            //trt.Find(severity);
        }

    }
}