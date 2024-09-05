namespace DataStructuresProject;

public class AVLTreeNode
{
    public int value { get; set; }
    public AVLTreeNode left { get; set; }
    public AVLTreeNode right { get; set; }
    public int Height { get; set; }

    public AVLTreeNode(int value)
    {
        this.value = value;
        left = null;
        right = null;
        Height = 0;
    }
}