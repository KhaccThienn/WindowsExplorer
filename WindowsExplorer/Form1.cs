using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsExplorer
{
    public partial class frmWindowsExplorer : Form
    {
        // Khai bao bien toan cuc cho thu muc hien tai
        private DirectoryInfo curDir;
        public frmWindowsExplorer()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void frmWindowsExplorer_Load(object sender, EventArgs e)
        {
            this.InitialTreeView();
        }

        private void InitialTreeView()
        {
            TreeNode myComputerNode = new TreeNode("This Computer", 0, 0);
            myComputerNode.Tag = "My Computer";

            trvDir.Nodes.Add(myComputerNode);
            
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode($"{drive.Name} ({drive.VolumeLabel})", 1, 1);
                node.Tag = drive.RootDirectory;
                myComputerNode.Nodes.Add(node);
            }
        }

        private void trvDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // lay node dang duoc chon
            TreeNode selectedNode = trvDir.SelectedNode;

            try
            {
                if (selectedNode.Tag.GetType() == typeof(DirectoryInfo))
                {
                    selectedNode.Nodes.Clear();
;                   DirectoryInfo dir = (DirectoryInfo)selectedNode.Tag;

                    foreach (DirectoryInfo subDir in dir.GetDirectories())
                    {
                        TreeNode dirNode = new TreeNode(subDir.Name, 2, 3);
                        dirNode.Tag = subDir;
                        selectedNode.Nodes.Add(dirNode);
                    }

                    // hien thi ben listview
                    curDir = dir;
                    OpenDirectory();
                }
                // mo rong node
                selectedNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void lstvDir_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                if (lstvDir.SelectedItems[0].Tag.GetType() == typeof(DirectoryInfo))
                {
                    curDir = (DirectoryInfo)lstvDir.SelectedItems[0].Tag;
                    OpenDirectory();
                }
                else
                {
                    FileInfo file = (FileInfo)lstvDir.SelectedItems[0].Tag;
                    System.Diagnostics.Process.Start(file.FullName);
                }
            }
            catch
            {
                MessageBox.Show("Khong mo dc!");
                return;
            }
        }
        private void OpenDirectory()
        {
            // hien thi theo dang chi tiet
            lstvDir.View = View.Details;

            // xóa tất cả items trong listview hiện tại
            lstvDir.Items.Clear();

            // Duyệt qua tất cả các thư mục con của thư mục hiện tại và thêm từng thư mục vào ListView.
            foreach (DirectoryInfo subDir in curDir.GetDirectories())
            {
                ListViewItem lvi = lstvDir.Items.Add(subDir.Name, 0);
                lvi.Tag = subDir;
                lvi.SubItems.Add("");
                lvi.SubItems.Add("Folder");
                lvi.SubItems.Add(subDir.LastWriteTime.ToString());
            }

            // Duyệt qua tất cả các tệp trong thư mục hiện tại và thêm từng tệp vào ListView.
            foreach (FileInfo file in curDir.GetFiles())
            {
                ListViewItem lvi = lstvDir.Items.Add(file.Name, 1);
                lvi.Tag = file;
                lvi.SubItems.Add(file.Length.ToString());
                lvi.SubItems.Add(file.Extension.ToString());
                lvi.SubItems.Add(file.LastWriteTime.ToString());
            }
        }
    }
}
