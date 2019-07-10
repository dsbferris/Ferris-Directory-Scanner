using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace Ferris_Directory_Scanner
{
    public static class XMLHelper
    {
        public static bool Serialize(string FilePath, object obj, Type type)
        {
            if (!Directory.Exists(new FileInfo(FilePath).Directory.ToString())) Directory.CreateDirectory(new FileInfo(FilePath).Directory.ToString());

            XmlSerializer xml = new XmlSerializer(type);
            try
            {
                using (FileStream stream = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite))
                {
                    xml.Serialize(stream, obj);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static object Deserialize(string FilePath, Type type)
        {
            var FI = new FileInfo(FilePath);
            if (FI.Exists && FI.Length != 0)
            {
                XmlSerializer xml = new XmlSerializer(type);
                try
                {
                    using (FileStream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                    {
                        return xml.Deserialize(stream);
                    }
                }
                catch (Exception)
                {
                }
            }
            return null;
        }


        public static List<OwnFile> Load(string FilePath)
        {
            return (List<OwnFile>)Deserialize(FilePath, typeof(List<OwnFile>));
        }

        public static bool Save(string FilePath, List<OwnFile> OwnFiles)
        {
            return Serialize(FilePath, OwnFiles, typeof(List<OwnFile>));
        }
    }
}
