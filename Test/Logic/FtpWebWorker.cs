using FluentFTP;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Logic
{
    public class FtpWebWorker
    {
        private static readonly string ftpUri = "ftp://feww.gq";
        private static readonly NetworkCredential credential = new NetworkCredential("f0591567", "emxuriveda");

        private static async Task<string[]> GetDirectoriesAndFilesAsync(string email = "")
        {
            string path = string.IsNullOrEmpty(email) ? ftpUri : $"{ftpUri}/{Config.Email}";
            var request = (FtpWebRequest)WebRequest.Create(path);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = credential;
            request.Timeout = 10000;

            try
            {
                using (var response = (FtpWebResponse)await request.GetResponseAsync().ConfigureAwait(false))
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(responseStream))
                        {
                            string result = await reader.ReadToEndAsync().ConfigureAwait(false);

                            return result.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x != "." && x != "..").ToArray();
                        }
                    }
                }
            }
            catch (WebException)
            {
                return Array.Empty<string>();
            }
        }

        public static async Task<StorageFile[]> GetFilesAsync()
        {
            var client = new FtpClient
            {
                Host = ftpUri,
                Credentials = credential
            };

            await client.ConnectAsync().ConfigureAwait(false);

            var listing = await client.GetListingAsync(Config.Email).ConfigureAwait(false);
            return listing.Select(x => new StorageFile
            {
                Name = x.Name,
                Length = x.Size,
                Extension = Path.GetExtension(x.Name),
                Modified = x.Modified.ToString()
            }).ToArray();
        }

        public static async Task UploadFileAsync(string filePath)
        {
            var names = await GetDirectoriesAndFilesAsync().ConfigureAwait(false);
            var email = Config.Email;

            if (!names.Contains(email))
            {
                var request = WebRequest.Create($"{ftpUri}/{email}");
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = credential;

                using (await request.GetResponseAsync().ConfigureAwait(false)) { }
            }

            using (var client = new WebClient())
            {
                client.Credentials = credential;
                try
                {
                    await client.UploadFileTaskAsync($"{ftpUri}/{email}/{Path.GetFileName(filePath)}",
                            WebRequestMethods.Ftp.UploadFile, filePath).ConfigureAwait(false);
                }
                catch (WebException)
                {
                }
            }
        }

        public static async Task UploadFilesAsync(string[] filesPaths)
        {
            var names = await GetDirectoriesAndFilesAsync().ConfigureAwait(false);
            var email = Config.Email;

            if (!names.Contains(email))
            {
                var request = WebRequest.Create($"{ftpUri}/{email}");
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = credential;

                using (await request.GetResponseAsync().ConfigureAwait(false)) { }
            }

            using (var client = new WebClient())
            {
                client.Credentials = credential;
                try
                {
                    for (int i = 0; i < filesPaths.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(filesPaths[i]))
                        {
                            await client.UploadFileTaskAsync($"{ftpUri}/{email}/{Path.GetFileName(filesPaths[i])}",
                                WebRequestMethods.Ftp.UploadFile, filesPaths[i]).ConfigureAwait(false);
                        }
                    }
                }
                catch (WebException)
                {
                }
            }
        }

        public static async Task RemoveFileAsync(string fileName)
        {
            var list = await GetDirectoriesAndFilesAsync(Config.Email).ConfigureAwait(false);

            if (list.Contains(fileName))
            {
                var request = (FtpWebRequest)WebRequest.Create($"{ftpUri}/{Config.Email}/{fileName}");
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = credential;

                using (await request.GetResponseAsync().ConfigureAwait(false)) { }
            }
        }

        public static async void RemoveAllAsync()
        {
            var list = await GetDirectoriesAndFilesAsync(Config.Email).ConfigureAwait(false);

            for (int i = 0; i < list.Length; i++)
            {
                var request = (FtpWebRequest)WebRequest.Create($"{ftpUri}/{Config.Email}/{list[i]}");
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = credential;

                using (await request.GetResponseAsync().ConfigureAwait(false)) { }
            }
        }

        public static async Task<string> DownloadFileAsync(string fileName, string directory = "")
        {
            using (var request = new WebClient())
            {
                request.Credentials = credential;
                try
                {
                    var fileData = await request.DownloadDataTaskAsync($"{ftpUri}/{Config.Email}/{fileName}").ConfigureAwait(false);

                    var pathDirectory = string.IsNullOrEmpty(directory) ? $"{Directory.GetCurrentDirectory()}\\{fileName}" : $"{directory}\\{fileName}";
                    using (var fileStream = File.Create(pathDirectory))
                    {
                        await fileStream.WriteAsync(fileData, 0, fileData.Length);
                        fileStream.Close();
                    }

                    return pathDirectory;
                }
                catch (WebException)
                {
                    return string.Empty;
                }
            }
        }
    }
}