namespace Ferris_Directory_Scanner
{
    partial class ScanControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MBtnScan = new MetroFramework.Controls.MetroButton();
            this.LoadingCircle = new MetroFramework.Controls.MetroProgressSpinner();
            this.MBtnOpenResult = new MetroFramework.Controls.MetroButton();
            this.MBtnAdd = new MetroFramework.Controls.MetroButton();
            this.TVExtensions = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.LVFolders = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MBtnScan);
            this.metroPanel1.Controls.Add(this.LoadingCircle);
            this.metroPanel1.Controls.Add(this.MBtnOpenResult);
            this.metroPanel1.Controls.Add(this.MBtnAdd);
            this.metroPanel1.Controls.Add(this.TVExtensions);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.LVFolders);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(501, 381);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // MBtnScan
            // 
            this.MBtnScan.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.MBtnScan.Location = new System.Drawing.Point(305, 314);
            this.MBtnScan.Name = "MBtnScan";
            this.MBtnScan.Size = new System.Drawing.Size(119, 57);
            this.MBtnScan.TabIndex = 25;
            this.MBtnScan.Text = "Scan";
            this.MBtnScan.UseSelectable = true;
            // 
            // LoadingCircle
            // 
            this.LoadingCircle.EnsureVisible = false;
            this.LoadingCircle.Location = new System.Drawing.Point(430, 314);
            this.LoadingCircle.Maximum = 100;
            this.LoadingCircle.Name = "LoadingCircle";
            this.LoadingCircle.Size = new System.Drawing.Size(58, 58);
            this.LoadingCircle.Speed = 2F;
            this.LoadingCircle.Spinning = false;
            this.LoadingCircle.TabIndex = 24;
            this.LoadingCircle.UseSelectable = true;
            // 
            // MBtnOpenResult
            // 
            this.MBtnOpenResult.Location = new System.Drawing.Point(3, 3);
            this.MBtnOpenResult.Name = "MBtnOpenResult";
            this.MBtnOpenResult.Size = new System.Drawing.Size(75, 23);
            this.MBtnOpenResult.TabIndex = 23;
            this.MBtnOpenResult.Text = "Open Result";
            this.MBtnOpenResult.UseSelectable = true;
            // 
            // MBtnAdd
            // 
            this.MBtnAdd.Location = new System.Drawing.Point(219, 24);
            this.MBtnAdd.Name = "MBtnAdd";
            this.MBtnAdd.Size = new System.Drawing.Size(75, 23);
            this.MBtnAdd.TabIndex = 22;
            this.MBtnAdd.Text = "Add";
            this.MBtnAdd.UseSelectable = true;
            // 
            // TVExtensions
            // 
            this.TVExtensions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TVExtensions.CheckBoxes = true;
            this.TVExtensions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVExtensions.Location = new System.Drawing.Point(305, 50);
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
            this.TVExtensions.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Extensions";
            // 
            // LVFolders
            // 
            this.LVFolders.AllowDrop = true;
            this.LVFolders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LVFolders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVFolders.Location = new System.Drawing.Point(3, 50);
            this.LVFolders.Name = "LVFolders";
            this.LVFolders.Size = new System.Drawing.Size(291, 321);
            this.LVFolders.TabIndex = 19;
            this.LVFolders.UseCompatibleStateImageBehavior = false;
            this.LVFolders.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Folders to scan";
            // 
            // ScanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "ScanControl";
            this.Size = new System.Drawing.Size(508, 389);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton MBtnScan;
        private MetroFramework.Controls.MetroProgressSpinner LoadingCircle;
        private MetroFramework.Controls.MetroButton MBtnOpenResult;
        private MetroFramework.Controls.MetroButton MBtnAdd;
        private System.Windows.Forms.TreeView TVExtensions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView LVFolders;
        private System.Windows.Forms.Label label1;
    }
}
