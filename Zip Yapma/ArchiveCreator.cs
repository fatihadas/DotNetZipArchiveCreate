using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip_Yapma
{
    public abstract class ArchiveCreator
    {
        internal String strPath;
        public abstract ArchiveObj GetArchieve();
    }
}
