namespace DataStructuresProject;

public class AVLTree
{
    private AVLTreeNode root;

    public AVLTree()
    {
        root = null;
    }

    public void Insert(int value)
    {
        root = Insert(root,value);
    }

    private AVLTreeNode Insert(AVLTreeNode node, int value)
    {
        if (node == null)
        {
            Console.WriteLine($"Inserting value: {value}");
            return new AVLTreeNode(value);
        }

        if (value < node.value)
        {
            Console.WriteLine($"Going left from node {node.value} to insert {value}");
            node.left = Insert(node.left, value);
            node.Height -= 1;
        }
        else
        {
            Console.WriteLine($"Going right from node {node.value} to insert {value}");
            node.right = Insert(node.right, value);
            node.Height += 1;
        }

        return Balance(node);
    }

    private AVLTreeNode Balance(AVLTreeNode node)
    {
        int balance = GetBalance(node);
        Console.WriteLine($"Balancing node {node.value}, balance factor: {balance}");


        if (balance > 1)
        {
            if (GetBalance(node.left) > 0)
            {
                node.left = RotateLeft(node.left);
            }

            return RotateRight(node);
        }

        if (balance < -1)
        {
            if (GetBalance(node.right) > 0)
            {
                node.right = RotateRight(node.right);
            }

            return RotateLeft(node);
        }
        return node;
    }

    private int GetBalance(AVLTreeNode node)
    {
        if (node == null)
        {
            return 0;
        }
        return  GetBalance(node.left) + GetBalance(node.right);
    }

    public int getHeight(AVLTreeNode node)
    {
        if (node == null)
        {
            return 0;
        }
        return node.Height;
    }

    private AVLTreeNode RotateLeft(AVLTreeNode x)
    {
        Console.WriteLine($"Performing RotateLeft on {x.value}");

        AVLTreeNode y = x.right;
        AVLTreeNode T2 = y.left;
        
        y.left = x;
        x.right = T2;
        UpdateHeight(x);
        UpdateHeight(y);
        return y;
        
        
    }
    private AVLTreeNode RotateRight(AVLTreeNode y)
    {
        Console.WriteLine($"Performing RotateRight on {y.value}");
        AVLTreeNode x = y.left;
        AVLTreeNode T2 = x.right;

        
        x.right = y;
        y.left = T2;

        
        UpdateHeight(y);
        UpdateHeight(x);

        return x;
    }
    private void UpdateHeight(AVLTreeNode node)
    {
        if (node != null)
        {
            node.Height = 1 + Math.Max(getHeight(node.left), getHeight(node.right));
        }
    }
    public int GetRootValue()
    {
        if (root != null)
        {
            return root.value;
        }
        throw new InvalidOperationException("Tree is empty");
    }

    public int GetLeftChildValue()
    {
        if (root != null && root.left != null)
        {
            return root.left.value;
        }
        throw new InvalidOperationException("Left child is null or tree is empty");
    }

    public int GetRightChildValue()
    {
        if (root != null && root.right != null)
        {
            return root.right.value;
        }
        throw new InvalidOperationException("Right child is null or tree is empty");
    }

    public int GetHeight()
    {
        return getHeight(root);
    }

}