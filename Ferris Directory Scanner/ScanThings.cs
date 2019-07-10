using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferris_Directory_Scanner
{
    public static class ScanThings
    {
        
        public static MetroFramework.Forms.MetroForm ProcessCommandLineParameter(string[] args)
        {
            if (args.Length > 1)
            {
                if (args.Length > 0)
                {
                    foreach (var s in args)
                        if (File.Exists(s) && s.EndsWith(".fds"))
                        {
                            return OpenResult(s);
                        }
                }
            }
            return new FormMain();
        }

        public static MetroFramework.Forms.MetroForm OpenResult(string xmlfilepath)
        {
            var OwnFiles = XMLHelper.Load(xmlfilepath);
            if (OwnFiles == null) return null;
            FormListView frmList = new FormListView(OwnFiles);
            return frmList;
        }

        public static MetroFramework.Forms.MetroForm OpenResult(List<OwnFile> OwnFiles)
        {
            if (OwnFiles == null) return null;
            FormListView frmList = new FormListView(OwnFiles);
            return frmList;
        }

        public static List<OwnFile> DeleteNullOwnFile(List<OwnFile> ownFiles)
        {
            foreach (var file in ownFiles)
            {
                if (file.Name == null) ownFiles.Remove(file);
            }
            return ownFiles;
        }

        public static bool ParentExist(string childfolder, List<string> folders)
        {
            foreach (string parentfolder in folders)
            {
                var parentUri = new Uri(parentfolder);
                var childUri = new DirectoryInfo(childfolder).Parent;
                while (childUri != null)
                {
                    if (new Uri(childUri.FullName) == parentUri)
                    {
                        return true;
                    }
                    childUri = childUri.Parent;
                }
            }
            return false;
        }




    }
}
