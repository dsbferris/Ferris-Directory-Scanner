namespace Ferris_Directory_Scanner
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("*");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("All Files", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("mp4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("avi");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("mkv");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Video", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("mp3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Audio", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("jpg");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("jpeg");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("png");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("gif");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("bmp");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Images", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("txt");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("pdf");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("docx");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Documents", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("exe");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("msi");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("bat");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Programs", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.LVFolders = new System.Windows.Forms.ListView();
            this.CMSFolders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.TVExtensions = new System.Windows.Forms.TreeView();
            this.CMSext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMIAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SMIAddExtension = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMIDelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SMIDelExt = new System.Windows.Forms.ToolStripMenuItem();
            this.MBtnAdd = new MetroFramework.Controls.MetroButton();
            this.MBtnOpenResult = new MetroFramework.Controls.MetroButton();
            this.LoadingCircle = new MetroFramework.Controls.MetroProgressSpinner();
            this.MBtnScan = new MetroFramework.Controls.MetroButton();
            this.CMSFolders.SuspendLayout();
            this.CMSext.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folders to scan";
            // 
            // LVFolders
            // 
            this.LVFolders.AllowDrop = true;
            this.LVFolders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LVFolders.ContextMenuStrip = this.CMSFolders;
            this.LVFolders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVFolders.Location = new System.Drawing.Point(23, 110);
            this.LVFolders.Name = "LVFolders";
            this.LVFolders.Size = new System.Drawing.Size(291, 321);
            this.LVFolders.TabIndex = 3;
            this.LVFolders.UseCompatibleStateImageBehavior = false;
            this.LVFolders.View = System.Windows.Forms.View.List;
            this.LVFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.LVFolders_DragDrop);
            this.LVFolders.DragEnter += new System.Windows.Forms.DragEventHandler(this.LVFolders_DragEnter);
            this.LVFolders.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LVFolders_KeyUp);
            // 
            // CMSFolders
            // 
            this.CMSFolders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CMSFolders.Name = "CMSext";
            this.CMSFolders.Size = new System.Drawing.Size(108, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extensions";
            // 
            // TVExtensions
            // 
            this.TVExtensions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TVExtensions.CheckBoxes = true;
            this.TVExtensions.ContextMenuStrip = this.CMSext;
            this.TVExtensions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVExtensions.Location = new System.Drawing.Point(325, 110);
            this.TVExtensions.Name = "TVExtensions";
            treeNode1.Name = "NodeAll";
            treeNode1.Text = "*";
            treeNode2.Name = "NodeAll";
            treeNode2.Text = "All Files";
            treeNode3.Name = "Nodemp4";
            treeNode3.Text = "mp4";
            treeNode4.Name = "Nodets";
            treeNode4.Text = "ts";
            treeNode5.Name = "Nodeavi";
            treeNode5.Text = "avi";
            treeNode6.Name = "Nodemkv";
            treeNode6.Text = "mkv";
            treeNode7.Name = "NodeVideo";
            treeNode7.Text = "Video";
            treeNode8.Name = "Nodemp3";
            treeNode8.Text = "mp3";
            treeNode9.Name = "NodeAudio";
            treeNode9.Text = "Audio";
            treeNode10.Name = "Nodejpg";
            treeNode10.Text = "jpg";
            treeNode11.Name = "Nodejpeg";
            treeNode11.Text = "jpeg";
            treeNode12.Name = "Nodepng";
            treeNode12.Text = "png";
            treeNode13.Name = "Nodegif";
            treeNode13.Text = "gif";
            treeNode14.Name = "Nodebmp";
            treeNode14.Text = "bmp";
            treeNode15.Name = "NodeImages";
            treeNode15.Text = "Images";
            treeNode16.Name = "Nodetxt";
            treeNode16.Text = "txt";
            treeNode17.Name = "Nodepdf";
            treeNode17.Text = "pdf";
            treeNode18.Name = "Nodedocx";
            treeNode18.Text = "docx";
            treeNode19.Name = "NodeText";
            treeNode19.Text = "Documents";
            treeNode20.Name = "Nodeexe";
            treeNode20.Text = "exe";
            treeNode21.Name = "NodeMSI";
            treeNode21.Text = "msi";
            treeNode22.Name = "NodeBatch";
            treeNode22.Text = "bat";
            treeNode23.Name = "NodePrograms";
            treeNode23.Text = "Programs";
            this.TVExtensions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7,
            treeNode9,
            treeNode15,
            treeNode19,
            treeNode23});
            this.TVExtensions.Size = new System.Drawing.Size(183, 258);
            this.TVExtensions.TabIndex = 6;
            this.TVExtensions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TVExtensions_AfterCheck);
            // 
            // CMSext
            // 
            this.CMSext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuToolStripMenuItem,
            this.addExtensionToolStripMenuItem});
            this.CMSext.Name = "CMSext";
            this.CMSext.Size = new System.Drawing.Size(108, 48);
            // 
            // addMenuToolStripMenuItem
            // 
            this.addMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMIAddMenu,
            this.SMIAddExtension});
            this.addMenuToolStripMenuItem.Name = "addMenuToolStripMenuItem";
            this.addMenuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addMenuToolStripMenuItem.Text = "Add";
            // 
            // SMIAddMenu
            // 
            this.SMIAddMenu.Name = "SMIAddMenu";
            this.SMIAddMenu.Size = new System.Drawing.Size(137, 22);
            this.SMIAddMenu.Text = "Menu Node";
            // 
            // SMIAddExtension
            // 
            this.SMIAddExtension.Name = "SMIAddExtension";
            this.SMIAddExtension.Size = new System.Drawing.Size(137, 22);
            this.SMIAddExtension.Text = "Extension";
            // 
            // addExtensionToolStripMenuItem
            // 
            this.addExtensionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMIDelMenu,
            this.SMIDelExt});
            this.addExtensionToolStripMenuItem.Name = "addExtensionToolStripMenuItem";
            this.addExtensionToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addExtensionToolStripMenuItem.Text = "Delete";
            // 
            // SMIDelMenu
            // 
            this.SMIDelMenu.Name = "SMIDelMenu";
            this.SMIDelMenu.Size = new System.Drawing.Size(137, 22);
            this.SMIDelMenu.Text = "Menu Node";
            // 
            // SMIDelExt
            // 
            this.SMIDelExt.Name = "SMIDelExt";
            this.SMIDelExt.Size = new System.Drawing.Size(137, 22);
            this.SMIDelExt.Text = "Extension";
            // 
            // MBtnAdd
            // 
            this.MBtnAdd.Location = new System.Drawing.Point(239, 84);
            this.MBtnAdd.Name = "MBtnAdd";
            this.MBtnAdd.Size = new System.Drawing.Size(75, 23);
            this.MBtnAdd.TabIndex = 14;
            this.MBtnAdd.Text = "Add";
            this.MBtnAdd.UseSelectable = true;
            this.MBtnAdd.Click += new System.EventHandler(this.BtnAddFolder_Click);
            // 
            // MBtnOpenResult
            // 
            this.MBtnOpenResult.Location = new System.Drawing.Point(23, 63);
            this.MBtnOpenResult.Name = "MBtnOpenResult";
            this.MBtnOpenResult.Size = new System.Drawing.Size(75, 23);
            this.MBtnOpenResult.TabIndex = 15;
            this.MBtnOpenResult.Text = "Open Result";
            this.MBtnOpenResult.UseSelectable = true;
            this.MBtnOpenResult.Click += new System.EventHandler(this.BtnOpenResult_Click);
            // 
            // LoadingCircle
            // 
            this.LoadingCircle.EnsureVisible = false;
            this.LoadingCircle.Location = new System.Drawing.Point(450, 374);
            this.LoadingCircle.Maximum = 100;
            this.LoadingCircle.Name = "LoadingCircle";
            this.LoadingCircle.Size = new System.Drawing.Size(58, 58);
            this.LoadingCircle.Speed = 2F;
            this.LoadingCircle.Spinning = false;
            this.LoadingCircle.TabIndex = 16;
            this.LoadingCircle.UseSelectable = true;
            // 
            // MBtnScan
            // 
            this.MBtnScan.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.MBtnScan.Location = new System.Drawing.Point(325, 374);
            this.MBtnScan.Name = "MBtnScan";
            this.MBtnScan.Size = new System.Drawing.Size(119, 57);
            this.MBtnScan.TabIndex = 17;
            this.MBtnScan.Text = "Scan";
            this.MBtnScan.UseSelectable = true;
            this.MBtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.MBtnScan);
            this.Controls.Add(this.LoadingCircle);
            this.Controls.Add(this.MBtnOpenResult);
            this.Controls.Add(this.MBtnAdd);
            this.Controls.Add(this.TVExtensions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LVFolders);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Ferris Directory Scanner";
            this.CMSFolders.ResumeLayout(false);
            this.CMSext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LVFolders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView TVExtensions;
        private System.Windows.Forms.ContextMenuStrip CMSext;
        private System.Windows.Forms.ToolStripMenuItem addMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SMIAddMenu;
        private System.Windows.Forms.ToolStripMenuItem SMIAddExtension;
        private System.Windows.Forms.ToolStripMenuItem addExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SMIDelMenu;
        private System.Windows.Forms.ToolStripMenuItem SMIDelExt;
        private System.Windows.Forms.ContextMenuStrip CMSFolders;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MetroFramework.Controls.MetroButton MBtnOpenResult;
        private MetroFramework.Controls.MetroButton MBtnAdd;
        private MetroFramework.Controls.MetroProgressSpinner LoadingCircle;
        private MetroFramework.Controls.MetroButton MBtnScan;
    }
}

