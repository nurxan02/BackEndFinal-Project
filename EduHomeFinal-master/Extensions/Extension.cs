using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Extencions
{
    public static class Extension
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool CheckFileSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 > kb;
        }

        public async static Task<string> SaveFileAsync(this IFormFile file, string rootpath, string folder)
        {
            string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + Guid.NewGuid() + "_" + file.FileName;
            string filepath = rootpath;
            string fullpath = Path.Combine(filepath, folder, filename);

            using (FileStream fileStream = new FileStream(fullpath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return filename;
        }
    }
}
