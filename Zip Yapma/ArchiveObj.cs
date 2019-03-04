using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip_Yapma
{
    public abstract class ArchiveObj
    {
        internal String strPath;
        internal List<String> lError;
        internal List<String> lFiles;
        public String[] ErrorList
        {
            get
            {
                return lError.ToArray();
            }
        }
        public ArchiveObj()
        {
            lFiles = new List<string>();
            lError = new List<string>();
        }
        public Boolean AddFile(String strFile)
        {
            lFiles.Add(strFile);
            return true;
        }
        public abstract int SaveArchive();
    }
}
