// using System;
//
// using System.Text.Json;
// using Newtonsoft.Json;
// namespace DataStructuresProject;
//
// public class ReadAndParseJsonFileWithNewtonsoftJson
// {
//     private readonly string _sampleJsonFilePath;
//     
//     public ReadAndParseJsonFileWithNewtonsoftJson(string sampleJsonFilePath)
//     {
//         _sampleJsonFilePath = sampleJsonFilePath;
//     }
//     public List<DefenceTreeNode> UseUserDefinedObjectWithNewtonsoftJson()
//     {
//         using StreamReader reader = new(_sampleJsonFilePath);
//         var json = reader.ReadToEnd();
//         List<DefenceTreeNode> defenceTreeNodes = JsonConvert.DeserializeObject<List<DefenceTreeNode>>(json);
//         return defenceTreeNodes;
//         
//     }
//     
// }