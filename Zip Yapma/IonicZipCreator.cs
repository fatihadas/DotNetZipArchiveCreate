using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip_Yapma
{
    public class IonicZipCreator : ArchiveCreator
    {
        private IonicZipCreator() { }
        public IonicZipCreator(String sPath)
        {
            strPath = sPath;
        }
        public override ArchiveObj GetArchieve()
        {
            return new IonicZip(strPath);
        }
    }
}
