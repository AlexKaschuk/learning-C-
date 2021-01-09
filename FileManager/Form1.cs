using FileManager.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        string Paths;
        string[] directories, files;
        DirectoryInfo copiedDirectory;
        FileInfo copiedfile;

         public Form1()
        {
            InitializeComponent();
            CreateTree();
        }


        private void CreateTree()
        {
            listView1.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Path", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Creation time", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Last access time", 100, HorizontalAlignment.Left);

            directories = Directory.GetLogicalDrives();
            foreach (var item in directories) {
                treeView1.Nodes.Add(item);
                treeView1.Nodes[treeView1.Nodes.Count - 1].Tag = item;
                listView1.Items.Add(item);
            }
            Image[] images = new Image[] {
            Resources.Close_Folder_icon,
            Resources.imagesOpen
            };
            Image[] ListViewImages = new Image[] {
            Resources.Close_Folder_icon,
            Resources.exe,
            Resources.jpeg,
            Resources.txt,
            Resources.sys,
            Resources.dll,
            Resources.ini,
            Resources.img,
            Resources.doc
            };

            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.Images.AddRange(images);
            treeView1.ImageList = imageList;
            treeView1.SelectedImageIndex = 1;

            ImageList ListViewImg = new ImageList();
            ListViewImg.Images.AddRange(ListViewImages);
            ListViewImg.ColorDepth = ColorDepth.Depth32Bit;
            listView1.LargeImageList = ListViewImg;
            listView1.SmallImageList = ListViewImg;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
            directories = Directory.GetDirectories((string)treeView1.SelectedNode.Tag);
            files = Directory.GetFiles((string)treeView1.SelectedNode.Tag);
            listView1.Items.Clear();
            Paths = (string)treeView1.SelectedNode.Tag;
            DrawItems(directories, files);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string singleDirectory = (string)listView1.SelectedItems[0].Tag;
            Paths = (string)listView1.SelectedItems[0].Tag;
            try
            {
                listView1.Items.Clear();
                directories = Directory.GetDirectories(singleDirectory);
                files = Directory.GetFiles(singleDirectory);
                DrawItems(directories, files);

            }
            catch (Exception ex)
            {
                try
                {
                    Process.Start(singleDirectory);
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var info = new DirectoryInfo(Paths);
                info = info.Parent;
                if (info == null) throw new Exception("No parent");
                listView1.Items.Clear();
                directories = Directory.GetDirectories(info.FullName);
                files = Directory.GetFiles(info.FullName);
                Paths = info.FullName;
                DrawItems(directories, files);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listView1.View == View.LargeIcon)
                listView1.View = View.Details;
            else if (listView1.View == View.Details) listView1.View = View.SmallIcon;
            else if (listView1.View == View.SmallIcon) listView1.View = View.List;
            else listView1.View = View.LargeIcon;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Paths + @"\" + listView1.SelectedItems[0].Text;
                FileAttributes attr = File.GetAttributes(str);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                     copiedDirectory = new DirectoryInfo(str); 
                }
                else
                {
                     copiedfile = new FileInfo(str); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (copiedDirectory != null)
                {
                    DirectoryCopy(copiedDirectory.FullName, Paths + @"\" + copiedDirectory.Name, true);
                    copiedDirectory = null;
                }
                if (copiedfile != null)
                {
                    File.Copy(copiedfile.FullName, Paths + @"\" + copiedfile.Name);
                    copiedfile = null;
                }
                listView1.Items.Clear();
                directories = Directory.GetDirectories(Paths);
                files = Directory.GetFiles(Paths);
                DrawItems(directories, files);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destDirName);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Paths + @"\" + listView1.SelectedItems[0].Text;
                FileAttributes attr = File.GetAttributes(str);
                listView1.LabelEdit = true;
                listView1.SelectedItems[0].BeginEdit();
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    copiedDirectory = new DirectoryInfo(str);
                }
                else
                {
                    copiedfile = new FileInfo(str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            ASCIIEncoding AE = new ASCIIEncoding();
            char[] temp = e.Label.ToCharArray();

            for (int x = 0; x < temp.Length; x++)
            {
                byte[] bc = AE.GetBytes(temp[x].ToString());
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Paths + @"\" + listView1.SelectedItems[0].Text;
                FileAttributes attr = File.GetAttributes(str);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    Directory.Delete(str);
                }
                else
                {
                    File.Delete(str);
                }
                listView1.Items.Clear();
                directories = Directory.GetDirectories(Paths);
                files = Directory.GetFiles(Paths);
                DrawItems(directories, files);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawItems(string[] directories, string[] files) {
        foreach (string item in directories)
        {
            var info = new DirectoryInfo(item);
            treeView1.SelectedNode.Nodes.Add(info.Name);
            treeView1.SelectedNode.Nodes[treeView1.SelectedNode.Nodes.Count - 1].Tag = item;
            listView1.Items.Add(info.Name);
            listView1.Items[listView1.Items.Count - 1].Tag = item;
            listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(info.FullName);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(info.CreationTime.ToString());
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(info.LastAccessTime.ToString());
        }

        foreach (string item in files)
        {
            var info = new FileInfo(item);
            listView1.Items.Add(info.Name);
            listView1.Items[listView1.Items.Count - 1].Tag = item;
            if (info.Extension == ".txt") { listView1.Items[listView1.Items.Count - 1].ImageIndex = 2; continue; }
            if (info.Extension == ".jpg" || info.Extension == ".jpeg") { listView1.Items[listView1.Items.Count - 1].ImageIndex = 3; continue; }
            if (info.Extension == ".sys") { listView1.Items[listView1.Items.Count - 1].ImageIndex = 4; continue; }
            if (info.Extension == ".dll") { listView1.Items[listView1.Items.Count - 1].ImageIndex = 5; continue; }
            if (info.Extension == ".ini") { listView1.Items[listView1.Items.Count - 1].ImageIndex = 6; continue; }
            if (info.Extension == ".img" || info.Extension == ".png") { listView1.Items[listView1.Items.Count - 1].ImageIndex = 7; continue; }
            if (info.Extension == ".doc" || info.Extension == ".docx") { listView1.Items[listView1.Items.Count - 1].ImageIndex = 8; continue; }
            else listView1.Items[listView1.Items.Count - 1].ImageIndex = 1;
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(info.FullName);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(info.CreationTime.ToString());
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(info.CreationTime.ToString());
        }
        foreach (TreeNode node in treeView1.SelectedNode.Nodes)
        {
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
        }
    }

    }
}
