namespace DataStructuresProject;

public class DefenceTreeNode
{
   
    public  int MinSeverity {get; set;}
    public  int MaxSeverity {get; set;}
    public  List<string> Defenses {get; set;} = new List<string>();
    public  DefenceTreeNode Left {get; set;}
    public  DefenceTreeNode Right {get; set;}
    //public Dictionary<string, int,string,int,string,List<string>> Children { get; set; } = new Dictionary<string, DefenceTreeNode>();
    // public DefenceTreeNode(Dictionary<DefenceTreeNode, DefenceTreeNode> dict)
    // {
    //     
    // }

    public DefenceTreeNode(int minSeverity, int maxSeverity ,List<string> defenses)
    {
        MinSeverity = minSeverity;
        MaxSeverity = MaxSeverity;
        Defenses = defenses;
        Left = null;
        Right = null;
    }
}