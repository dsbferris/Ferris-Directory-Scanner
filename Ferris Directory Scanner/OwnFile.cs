using System;
using System.Collections.Generic;
using System.IO;

namespace Ferris_Directory_Scanner
{
    public enum OwnFileSort
    {
        Name,
        Pfad,
        Size
    };

    [Serializable]
    public class OwnFile
    {

        public bool Favourite { get; set; }
        public string Name { get; set; }
        public string Pfad { get; set; }
        public string Size { get; set; }
        public long Length { get; set; }
        

        public static IEnumerable<OwnFile> GetOwnFiles(string[] files)
        {
            foreach (var file in files)
            {
                FileInfo fi = new FileInfo(file);
                yield return CreateOwnFile(fi);
            }
        }

        public static OwnFile CreateOwnFile(FileInfo fi)
        {
            OwnFile f = new OwnFile();
            if (fi.Exists)
            {
                f.Name = fi.Name;
                f.Favourite = false;
                f.Pfad = fi.FullName;
                f.Size = ToReadableBytes(fi.Length);
                f.Length = fi.Length;
            }
            return f;
        }

        public static string ToReadableBytes(long l)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (l >= 1024 && order < sizes.Length - 1)
            {
                order++;
                l = l / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.#}{1}", l, sizes[order]);
        }

        public static List<OwnFile> Sort(List<OwnFile> files, OwnFileSort sorting)
        {
            switch (sorting)
            {
                case OwnFileSort.Name: break;
                case OwnFileSort.Pfad: break;
                case OwnFileSort.Size: break;
            }
            return null;
        }
    }
}
