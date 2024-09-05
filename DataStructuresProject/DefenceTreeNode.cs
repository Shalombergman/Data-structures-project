namespace DataStructuresProject;

public class DefenceTreeNode
{
    public  int MinSeverity {get; set;}
    public  int MaxSeverity {get; set;}
    public  List<string> Defenses {get; set;} = new List<string>();
    public  DefenceTreeNode Left {get; set;}
    public  DefenceTreeNode Right {get; set;}

    public DefenceTreeNode(int minSeverity, int maxSeverity ,List<string> defenses)
    {
        MinSeverity = minSeverity;
        MaxSeverity = MaxSeverity;
        Defenses = defenses;
        Left = null;
        Right = null;
    }
}