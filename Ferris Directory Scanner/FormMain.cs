using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using static Ferris_Directory_Scanner.ScanThings;

namespace Ferris_Directory_Scanner
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {

        private bool ScanStarted = false;
        private CancellationTokenSource cts = new CancellationTokenSource();


        public FormMain()
        {
            InitializeComponent();

        }
        

        private void BtnOpenResult_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                DefaultExt = "*.fds",
                Filter = "Ferris Directory Scan Files (*.fds)|*.fds"
            };

            var dr = ofd.ShowDialog();
            if (dr == DialogResult.OK && ofd.CheckFileExists && ofd.FileName != null && ofd.FileName.Length != 0)
            {
                var listform = OpenResult(ofd.FileName);
                listform.Show();
                this.Close();
            }
        }


        #region ListView
        
        private Task AddToLV(string[] dirs)
        {
            if (dirs != null && dirs.Length != 0)
            {
                return Task.Run(() =>
                {
                    foreach (string dir in dirs)
                    {
                        if (File.GetAttributes(dir).HasFlag(FileAttributes.Directory))
                        {
                            ListViewItem lvi = new ListViewItem()
                            {
                                Text = dir,
                            };

                            MethodInvoker LVUpdate = delegate
                            {
                                LVFolders.Items.Add(lvi);
                                //folders.Add(dir);
                            };
                            try
                            {
                                Invoke(LVUpdate);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                });

            }
            else return null;
        }

        private string[] OpenFolderDialog()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Multiselect = true
            };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok) return dialog.FileNames.ToArray();
            else return null;
        }
        
        private async void LVFolders_DragDrop(object sender, DragEventArgs e)
        {
            var dirs = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (dirs.Length == 0 || dirs == null) return;
            await AddToLV(dirs);
        }

        private void LVFolders_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop));
                if (path.Length == 1)
                {
                    if (File.GetAttributes(path[0]).HasFlag(FileAttributes.Directory))
                        effects = DragDropEffects.Copy;
                }
                else
                {
                    effects = DragDropEffects.Copy;
                }
                e.Effect = effects;
            }
        }

        private async void LVFolders_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != LVFolders) return;

            if (e.Control && e.KeyCode == Keys.V)
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData.GetDataPresent(DataFormats.FileDrop))
                {
                    var clipboard = (string[])iData.GetData(DataFormats.FileDrop);
                    if (clipboard.Length == 0 || clipboard == null) return;
                    await AddToLV(clipboard);
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem lvi in LVFolders.SelectedItems)
                {
                    lvi.Remove();
                    //folders.Remove(lvi.Text);
                }
            }
        }

        private async void BtnAddFolder_Click(object sender, EventArgs e)
        {
            string[] selection = OpenFolderDialog();
            if (selection != null) await AddToLV(selection);
        }

        private async void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] selection = OpenFolderDialog();
            if (selection != null) await AddToLV(selection);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in LVFolders.SelectedItems)
            {
                LVFolders.Items.Remove(lvi);
            }
        }


        #endregion


        #region TreeView
        
        private void TVExtensions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        // Updates all child tree nodes recursively.
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private string[] GetSelectedExtensions()
        {
            List<string> exts = new List<string>();
            foreach (TreeNode parentnode in TVExtensions.Nodes)
            {
                foreach (TreeNode childnode in parentnode.Nodes)
                {
                    if (childnode.Checked) exts.Add('.' + childnode.Text.ToLower());
                }
            }
            if (exts.Contains(".*")) return null;
            return exts.ToArray();
        }


        #endregion



        #region Scan

        private async void BtnScan_Click(object sender, EventArgs e)
        {
            await Scan();
        }

        private async Task Scan()
        {
            if (!ScanStarted)
            {
                //Get Extensions
                string[] exts = GetSelectedExtensions();

                //Get Folders
                var folders = GetLVFolders().ToList();
                folders.Distinct();
                foreach (string s in folders)
                {
                    if (ParentExist(s, folders))
                    {
                        LVFolders.Items.Remove(new ListViewItem(s));
                        folders.Remove(s);
                    }
                }

                if (folders.Count == 0)
                {
                    MessageBox.Show("Nothing to scan bro");
                    return;
                }
                
                //if (exts.Length == 0) return;

                MBtnScan.Text = "Stop";
                ScanStarted = true;

                LoadingCircle.Spinning = true;
                LoadingCircle.Value = 30;

                //var files = await Task.Factory.StartNew(() => CustomSearcher.Oldscan(folders.ToArray(), exts));
                var files = await Task.Factory.StartNew(() => FerrisSearchEngine.ScanDirectories(folders.ToArray(), exts, cts));
                if (files != null)
                {
                    var OwnFiles = DeleteNullOwnFile(await Task.Factory.StartNew(() => OwnFile.GetOwnFiles(files).ToList()));

                    if (OwnFiles != null)
                    {
                        var listform = OpenResult(OwnFiles);
                        listform.Show();
                        this.Close();
                    }
                    
                }

            }
            else
            {
                cts.Cancel();
                MessageBox.Show("Operation Canceled");
            }
            
            ScanStarted = false;
            MBtnScan.Text = "Scan";
            LoadingCircle.Spinning = false;
            LoadingCircle.Value = 0;
        }

        public IEnumerable<string> GetLVFolders()
        {
            foreach (ListViewItem lvi in LVFolders.Items)
            {
                yield return lvi.Text;
            }
        }


        #endregion


    }

}
