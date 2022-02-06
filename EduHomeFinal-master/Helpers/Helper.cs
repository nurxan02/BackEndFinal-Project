using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Helpers
{
    public static class Helper
    {
        public static void DeleteFile(string root, string folder, string fileName)
        {
            string oldfulpath = Path.Combine(root, folder, fileName);
            if (System.IO.File.Exists(oldfulpath))
            {
                System.IO.File.Delete(oldfulpath);
            }
        }
    }
}
