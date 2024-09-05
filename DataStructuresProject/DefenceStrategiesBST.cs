// namespace DataStructuresProject;
//
// public class DefenceStrategiesBST
// {
//     private DefenceTreeNode root;
//
//     public DefenceStrategiesBST()
//     {
//         root = null;
//     }
//     public void Insert(int value)
//     {
//         root = InsertRecursive(root,  value);
//         
//     }
//     private DefenceTreeNode InsertRecursive(DefenceTreeNode node, int value)
//     {
//         if (node == null)
//         {
//             node = new DefenceTreeNode(value);
//             return node;
//         }
//
//         if (value < node.Value)
//         {
//             node.Left = InsertRecursive(node.Left, value);
//         }
//         else
//         {
//             node.Right = InsertRecursive(node.Right, value);
//         }
//         return node;
//     }
//
// }