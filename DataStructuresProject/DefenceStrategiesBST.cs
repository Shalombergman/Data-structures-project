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
    public static void PreOrder(DefenceTreeNode _root = null)
    {
        
        if (_root == null)
        {
            _root = root;
        }

        if (_root == null)
        {
            return;
        }
       
        Console.WriteLine($"[{_root.MinSeverity} - {_root.MaxSeverity}] Defenses:{_root.Defenses[0].ToString()},{_root.Defenses[1].ToString()} ");
        
        if (_root.Left != null)
        {
            PreOrder(_root.Left);
        }

        if (_root.Right != null)
        {
            PreOrder(_root.Right);
        }
            
    }

}