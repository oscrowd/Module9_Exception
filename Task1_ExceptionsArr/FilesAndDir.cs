using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    public class FilesAndDir
    {
        public string DirPath;
        //{
        //    get
        //    {
        //        return DirPath;
        //    }
        //    set
        //    {
        //        DirPath = value;
        //    }
        //}

        public Boolean DirExist()
        {
            var di = new DirectoryInfo(DirPath);
            return di.Exists;
        }
        public void DelPathAndDir()
        {
            //path = DirPath;
            var di = new DirectoryInfo(DirPath);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

        }
    }

}
