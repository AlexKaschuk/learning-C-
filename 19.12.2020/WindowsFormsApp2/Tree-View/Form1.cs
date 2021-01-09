using System.Drawing;
using System.Windows.Forms;
using Tree_View.Properties;

namespace Tree_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateTree();
        }

        private void CreateTree() {

            TreeNode node = new TreeNode("node1");
            TreeNode node1 = new TreeNode("node2");
            TreeNode node2 = new TreeNode("node3");
            TreeNode node3 = new TreeNode("node4");

            TreeNode node4 = new TreeNode("node4");
            TreeNode node5 = new TreeNode("node5");
            TreeNode node6 = new TreeNode("node6");

            treeView1.Nodes.Add(node);
            treeView1.Nodes.Add(node1);
            treeView1.Nodes.Add(node2);
            node2.Nodes.Add(node3);
            node3.Nodes.Add(node4);
            node3.Nodes.Add(node5);
            node3.Nodes.Add(node6);

            Image[] images = new Image[] { 
            Resources.Close_Folder_icon,
            Resources.imagesOpen
            };

            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.Images.AddRange(images);
            treeView1.ImageList = imageList;
            treeView1.SelectedImageIndex = 1;
            
        }
    }
}
