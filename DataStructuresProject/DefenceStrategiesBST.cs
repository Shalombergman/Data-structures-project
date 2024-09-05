namespace DataStructuresProject;

public class DefenceStrategiesBST
{
    private static DefenceTreeNode root;
    

    public DefenceStrategiesBST()
    {
        root = null;
       
    }
    public static void Insert(DefenceTreeNode node)
    {
        root = InsertRecursive(root,node.MinSeverity,node.MaxSeverity,node.Defenses);
        
    }
    private static DefenceTreeNode InsertRecursive(DefenceTreeNode node, int minSeverity, int maxSeverity,List<string>defenses)
    {
        if (node == null)
        {
            node = new DefenceTreeNode(minSeverity,maxSeverity,defenses);
            return node;
        }

        if (minSeverity < node.MinSeverity)
        {
            node.Left = InsertRecursive(node.Left, minSeverity, maxSeverity, defenses);
        }
        else
        {
            node.Right = InsertRecursive(node.Right, minSeverity, maxSeverity, defenses);
        }
        return node;
    }
    //סריקה תכילית הדפסה קודם של השורש ובכך אני יכול לשחזר את העץ ואז סריקה של תת עץ שמאלי ואז תת עץ ימני
    public static void PreOrder(DefenceTreeNode _root)
    {
        
        if (_root == null)
        {
            return;
        }
        else
        {
            root = _root;
        }
        

        Console.WriteLine($"[{root.MinSeverity} - {root.MaxSeverity}] Defenses:{root.Defenses[0].ToString()},{root.Defenses[1].ToString()} ");
        PreOrder(root.Left) ;
        PreOrder(root.Right);
    }

}