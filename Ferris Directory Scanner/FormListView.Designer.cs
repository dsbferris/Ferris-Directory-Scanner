namespace Ferris_Directory_Scanner
{
    partial class FormListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListView));
            this.LVFiles = new System.Windows.Forms.ListView();
            this.CMSFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openExplorerHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IListStar = new System.Windows.Forms.ImageList(this.components);
            this.MBtnSave = new MetroFramework.Controls.MetroButton();
            this.MToggleFavourite = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MTbSearch = new MetroFramework.Controls.MetroTextBox();
            this.LblSize = new MetroFramework.Controls.MetroLabel();
            this.CMSFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVFiles
            // 
            this.LVFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVFiles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LVFiles.ContextMenuStrip = this.CMSFiles;
            this.LVFiles.FullRowSelect = true;
            this.LVFiles.GridLines = true;
            this.LVFiles.LargeImageList = this.IListStar;
            this.LVFiles.Location = new System.Drawing.Point(23, 92);
            this.LVFiles.Name = "LVFiles";
            this.LVFiles.Size = new System.Drawing.Size(667, 314);
            this.LVFiles.SmallImageList = this.IListStar;
            this.LVFiles.StateImageList = this.IListStar;
            this.LVFiles.TabIndex = 0;
            this.LVFiles.UseCompatibleStateImageBehavior = false;
            this.LVFiles.View = System.Windows.Forms.View.Details;
            this.LVFiles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LVFiles_ColumnClick);
            this.LVFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LVFiles_KeyUp);
            this.LVFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LVFiles_MouseDoubleClick);
            // 
            // CMSFiles
            // 
            this.CMSFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExplorerHereToolStripMenuItem});
            this.CMSFiles.Name = "CMSFiles";
            this.CMSFiles.Size = new System.Drawing.Size(175, 26);
            // 
            // openExplorerHereToolStripMenuItem
            // 
            this.openExplorerHereToolStripMenuItem.Name = "openExplorerHereToolStripMenuItem";
            this.openExplorerHereToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openExplorerHereToolStripMenuItem.Text = "Open Explorer here";
            this.openExplorerHereToolStripMenuItem.Click += new System.EventHandler(this.LVopenExplorerHereToolStripMenuItem_Click);
            // 
            // IListStar
            // 
            this.IListStar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IListStar.ImageStream")));
            this.IListStar.TransparentColor = System.Drawing.Color.Transparent;
            this.IListStar.Images.SetKeyName(0, "if_star_172558.png");
            this.IListStar.Images.SetKeyName(1, "if_star_299040.png");
            // 
            // MBtnSave
            // 
            this.MBtnSave.Location = new System.Drawing.Point(23, 63);
            this.MBtnSave.Name = "MBtnSave";
            this.MBtnSave.Size = new System.Drawing.Size(75, 23);
            this.MBtnSave.TabIndex = 23;
            this.MBtnSave.Text = "Save";
            this.MBtnSave.UseSelectable = true;
            this.MBtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MToggleFavourite
            // 
            this.MToggleFavourite.AutoSize = true;
            this.MToggleFavourite.DisplayStatus = false;
            this.MToggleFavourite.Location = new System.Drawing.Point(208, 66);
            this.MToggleFavourite.Name = "MToggleFavourite";
            this.MToggleFavourite.Size = new System.Drawing.Size(50, 17);
            this.MToggleFavourite.TabIndex = 25;
            this.MToggleFavourite.Text = "Aus";
            this.MToggleFavourite.UseSelectable = true;
            this.MToggleFavourite.CheckedChanged += new System.EventHandler(this.MToggleFavourite_CheckedChangedAsync);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(104, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Only Favourites";
            // 
            // MTbSearch
            // 
            this.MTbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.MTbSearch.CustomButton.Image = null;
            this.MTbSearch.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.MTbSearch.CustomButton.Name = "";
            this.MTbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MTbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTbSearch.CustomButton.TabIndex = 1;
            this.MTbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTbSearch.CustomButton.UseSelectable = true;
            this.MTbSearch.CustomButton.Visible = false;
            this.MTbSearch.Lines = new string[0];
            this.MTbSearch.Location = new System.Drawing.Point(438, 60);
            this.MTbSearch.MaxLength = 32767;
            this.MTbSearch.Name = "MTbSearch";
            this.MTbSearch.PasswordChar = '\0';
            this.MTbSearch.PromptText = "Search for...";
            this.MTbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTbSearch.SelectedText = "";
            this.MTbSearch.SelectionLength = 0;
            this.MTbSearch.SelectionStart = 0;
            this.MTbSearch.ShortcutsEnabled = true;
            this.MTbSearch.ShowClearButton = true;
            this.MTbSearch.Size = new System.Drawing.Size(252, 23);
            this.MTbSearch.TabIndex = 28;
            this.MTbSearch.UseSelectable = true;
            this.MTbSearch.WaterMark = "Search for...";
            this.MTbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MTbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Location = new System.Drawing.Point(296, 64);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(66, 19);
            this.LblSize.TabIndex = 29;
            this.LblSize.Text = "Total Size:";
            // 
            // FormListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(709, 426);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.MTbSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MToggleFavourite);
            this.Controls.Add(this.MBtnSave);
            this.Controls.Add(this.LVFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListView";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Ferris Directory Scanner";
            this.Shown += new System.EventHandler(this.FormListView_Shown);
            this.CMSFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVFiles;
        private System.Windows.Forms.ImageList IListStar;
        private System.Windows.Forms.ContextMenuStrip CMSFiles;
        private System.Windows.Forms.ToolStripMenuItem openExplorerHereToolStripMenuItem;
        private MetroFramework.Controls.MetroButton MBtnSave;
        private MetroFramework.Controls.MetroToggle MToggleFavourite;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox MTbSearch;
        private MetroFramework.Controls.MetroLabel LblSize;
    }
}