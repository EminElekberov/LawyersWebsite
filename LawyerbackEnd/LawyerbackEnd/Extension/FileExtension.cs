using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Extension
{
    public static class FileExtension
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType == "image/jpeg" ||
               file.ContentType == "image/jpg" ||
               file.ContentType == "image/gif" ||
               file.ContentType == "image/png" ||
               file.ContentType == "image/svg" ||//svg formatinda iconlar ucun
               file.ContentType == "image/jfif";
        }
        public static bool isCv(this IFormFile file)
        {
            return file.ContentType == "application/pdf" ||
                file.ContentType == "application/doc" ||
                file.ContentType == "application/docx" ||
                file.ContentType == "application/pptx";
        }
        public async static Task<string> Savepicture(this IFormFile file,string root ,string folder)
        {
            string path = Path.Combine(root, folder);
            string fileNamee = Path.Combine(Guid.NewGuid().ToString() + Path.GetFileName(file.FileName));
            string result = Path.Combine(path, fileNamee);
            using (FileStream fileStream=new FileStream(result,FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileNamee;
        }
        public static void DeleteImage(string root,string folder,string fileName)
        {
            string path = Path.Combine(root, folder, fileName);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
