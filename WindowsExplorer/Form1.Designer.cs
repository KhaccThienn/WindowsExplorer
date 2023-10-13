namespace WindowsExplorer
{
    partial class frmWindowsExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWindowsExplorer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstvDir = new System.Windows.Forms.ListView();
            this.lstIcons = new System.Windows.Forms.ImageList(this.components);
            this.trvDir = new System.Windows.Forms.TreeView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smallIconList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvDir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstvDir);
            this.splitContainer1.Size = new System.Drawing.Size(1228, 534);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstvDir
            // 
            this.lstvDir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvDir.FullRowSelect = true;
            this.lstvDir.GridLines = true;
            this.lstvDir.HideSelection = false;
            this.lstvDir.Location = new System.Drawing.Point(0, 0);
            this.lstvDir.Name = "lstvDir";
            this.lstvDir.Size = new System.Drawing.Size(882, 534);
            this.lstvDir.SmallImageList = this.smallIconList;
            this.lstvDir.TabIndex = 0;
            this.lstvDir.UseCompatibleStateImageBehavior = false;
            this.lstvDir.View = System.Windows.Forms.View.Details;
            this.lstvDir.ItemActivate += new System.EventHandler(this.lstvDir_ItemActivate);
            // 
            // lstIcons
            // 
            this.lstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstIcons.ImageStream")));
            this.lstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.lstIcons.Images.SetKeyName(0, "mycomputer.ico");
            this.lstIcons.Images.SetKeyName(1, "drive.ico");
            this.lstIcons.Images.SetKeyName(2, "folder_close.ico");
            this.lstIcons.Images.SetKeyName(3, "folder_open.ico");
            this.lstIcons.Images.SetKeyName(4, "document.ico");
            // 
            // trvDir
            // 
            this.trvDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDir.ImageIndex = 0;
            this.trvDir.ImageList = this.lstIcons;
            this.trvDir.Location = new System.Drawing.Point(0, 0);
            this.trvDir.Name = "trvDir";
            this.trvDir.SelectedImageIndex = 0;
            this.trvDir.Size = new System.Drawing.Size(342, 534);
            this.trvDir.TabIndex = 0;
            this.trvDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDir_AfterSelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Modified";
            this.columnHeader4.Width = 230;
            // 
            // smallIconList
            // 
            this.smallIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIconList.ImageStream")));
            this.smallIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIconList.Images.SetKeyName(0, "folder_open.ico");
            this.smallIconList.Images.SetKeyName(1, "document.ico");
            // 
            // frmWindowsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 534);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmWindowsExplorer";
            this.Text = "Windows Explorer";
            this.Load += new System.EventHandler(this.frmWindowsExplorer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstvDir;
        private System.Windows.Forms.TreeView trvDir;
        private System.Windows.Forms.ImageList lstIcons;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList smallIconList;
    }
}

