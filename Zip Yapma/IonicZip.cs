using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip_Yapma
{
    class IonicZip : ArchiveObj
    {
        private IonicZip() { }
        public IonicZip(String sPath)
        {
            strPath = sPath;
        }
        public override int SaveArchive()
        {
            ZipFile zip = new ZipFile();
            foreach (String strFile in lFiles)
                zip.AddFile(strFile);
            zip.Save(strPath);
            return 1;
        }
    }
}
