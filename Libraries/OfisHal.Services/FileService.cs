using OfisHal.Core;
using System;
using System.IO;
using System.Web;
using System.Web.Routing;

namespace OfisHal.Services
{
    public enum FileSection
    {
        Reports,
        InvoiceTemplates,
        Documents
    }

    public interface IFileService
    {
        bool DeleteFile(string fileName, FileSection section);

        byte[] GetFileContent(string fileName, FileSection section);

        string UploadFile(HttpPostedFileBase postedFile, FileSection section, bool overwrite = false);

        string GetFilePath(string fileName, FileSection section);
    }

    public class FileService : IFileService
    {
        private readonly string _basePath;
        private readonly string _clientPath;

        public FileService(HttpServerUtilityBase server/*, ITenantService tenantService*/)
        {
            //_clientPath = Convert.ToString(tenantService.GetCurrentTenant()?.Id);
            _basePath = server.MapPath(Constants.BaseDocumentPath);
        }

        public string UploadFile(HttpPostedFileBase postedFile, FileSection section, bool overwrite = false)
        {
            if (postedFile?.ContentLength <= 0)
                throw new ArgumentNullException(nameof(postedFile));

            var fi = new FileInfo(postedFile.FileName);

            var newFileName = string.Concat(fi.Name.Replace(fi.Extension, string.Empty).ToSlug(), fi.Extension);
            var fullPath = GetFilePath(newFileName, section);

            if (File.Exists(fullPath))
            {
                if (overwrite)
                    DeleteFile(newFileName, section);
                else
                {
                    var i = 1;

                    while (File.Exists(fullPath))
                    {
                        newFileName = string.Concat(fi.Name.Replace(fi.Extension, string.Empty).ToSlug(), '_', i, fi.Extension);
                        i++;
                    }
                }
            }

            postedFile.SaveAs(Path.Combine(fullPath, newFileName));

            return newFileName;
        }

        public bool DeleteFile(string fileName, FileSection section)
        {
            fileName = GetFilePath(fileName, section);

            if (!File.Exists(fileName))
                return false;

            File.Delete(fileName);
            return true;
        }

        public byte[] GetFileContent(string fileName, FileSection section)
        {
            fileName = GetFilePath(fileName, section);

            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            return File.ReadAllBytes(fileName);
        }

        public string GetFilePath(string fileName,FileSection section)
        {
            var filePath = Path.Combine(_basePath, section.ToString(), _clientPath, fileName);

            if (!File.Exists(filePath))
                filePath = Path.Combine(_basePath, section.ToString(), "_default", fileName);

            return filePath;
        }
    }
}
