using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferris_Directory_Scanner
{
    public partial class FormListView : MetroFramework.Forms.MetroForm
    {
        public List<OwnFile> OwnFiles;
        private Timer SearchTimer = new Timer();

        public FormListView(List<OwnFile> files)
        {
            InitializeComponent();
            
            OwnFiles = files;
            SearchTimer.Interval = SetTimerTime(OwnFiles.Count);
            SearchTimer.Tick += SearchTimer_Tick;
        }
        
        #region UI

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormListView_Shown(object sender, EventArgs e)
        {
            LVFiles.Columns.Add("Favourite");
            LVFiles.Columns.Add("Name");
            LVFiles.Columns.Add("Größe");
            LVFiles.Columns.Add("Pfad");

            if (OwnFiles != null) await FillLV();
        }


        #endregion

        #region ListView

        private Task FillLV()
        {
            LVFiles.Items.Clear();
            long totalsize = 0;
            string filter = MTbSearch.Text;
            if (filter == "") filter = null;
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (OwnFile file in filter == null ? OwnFiles : OwnFiles.Where(x => x.Name.ToLower().Contains(filter.ToLower())).ToList())
            {

                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(file.Name);
                lvi.SubItems.Add(file.Size);
                lvi.SubItems[1].Tag = file.Length;
                lvi.SubItems.Add(file.Pfad);
                if (file.Favourite) lvi.ImageIndex = 1;
                else lvi.ImageIndex = 0;
                if (MToggleFavourite.Checked) if (!file.Favourite) continue;
                items.Add(lvi);

                totalsize += file.Length;
            }
            LVFiles.BeginUpdate();
            LVFiles.Items.AddRange(items.ToArray());
            LVFiles.EndUpdate();

            LVFiles.Columns[0].Width = -2;
            LVFiles.Columns[0].TextAlign = HorizontalAlignment.Left;
            LVFiles.Columns[1].Width = -1;
            LVFiles.Columns[2].Width = -1;
            LVFiles.Columns[2].TextAlign = HorizontalAlignment.Right;
            LVFiles.Columns[3].Width = -1;

            UpdateSize(totalsize);


            return Task.CompletedTask;
        }

        private void UpdateSize(long size)
        {
            LblSize.Text = $"Total Size: {OwnFile.ToReadableBytes(size)}";
        }

        private void LVFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                foreach (ListViewItem lvi in LVFiles.Items)
                {
                    lvi.Selected = true;
                }
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                System.Collections.Specialized.StringCollection FileCollection = new System.Collections.Specialized.StringCollection();
                foreach (ListViewItem lvi in LVFiles.SelectedItems)
                {
                    FileCollection.Add(lvi.SubItems[3].Text);
                }
                Clipboard.SetFileDropList(FileCollection);
            }
        }
        
        private void LVFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = LVFiles.FocusedItem;
            if (item == null) return;
            if (item.ImageIndex == 0) item.ImageIndex = 1;
            else item.ImageIndex = 0;
            foreach (var ownfile in OwnFiles)
            {
                if (ownfile.Pfad == item.SubItems[3].Text)
                {
                    if (item.ImageIndex == 1) ownfile.Favourite = true;
                    else ownfile.Favourite = false;
                }
            }
        }

        private void LVopenExplorerHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = LVFiles.FocusedItem;
            FileInfo fi = new FileInfo(lvi.SubItems[3].Text);
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", fi.DirectoryName);
            }
            catch (Exception)
            {
                MessageBox.Show("Error while opening explorer");
            }
        }

        private void LVFiles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1: //Name

                case 2: //Größe

                case 3: //Pfad

                default: return;
            }
        }

        #endregion

        #region Buttons

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                DefaultExt = "*.fds",
                Filter = "Ferris Directory Scan files (*.fds)|*.fds"
            };

            var dr = sfd.ShowDialog();
            if (dr == DialogResult.OK && sfd.CheckPathExists && sfd.FileName != null && sfd.FileName.Length != 0)
            {
                XMLHelper.Save(sfd.FileName, OwnFiles);
            }
        }

        #endregion

        #region Search

        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            await FillLV();
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTimer.Stop();
            SearchTimer.Start();
        }

        private int SetTimerTime(int amount)
        {
            //Set time for certain amounts of List<OwnFile>.Count
            //Ex:   1 = 1ms
            //      
            //      100.000 = 300ms
            //Maybe look for typing speed.

            //For not that many items, instant
            if (amount <= 1000) return 1;
            return 500;
        }

        #endregion

        
        private async void MToggleFavourite_CheckedChangedAsync(object sender, EventArgs e)
        {
            await FillLV();
        }
        
    }
}