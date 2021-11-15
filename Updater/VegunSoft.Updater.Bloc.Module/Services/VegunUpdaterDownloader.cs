using System;
using System.Collections;
using System.IO;
using System.Net;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using VegunSoft.App.Repository.Business.Cfg;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;

namespace VegunSoft.Layer.UcService.Provider.Services.App
{
    public class VegunUpdaterDownloader : IVegunUpdaterDownloader
    {
        public string ServerFolderName { get; set; } = "data_update";

        public string HostAddress { get; set; }

        public string TempDir { get; set; }

        private static IIocService _dbIoc;
        protected static IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));

        private static IRepositorySystemConfig _repositorySystemConfig;
        protected static IRepositorySystemConfig RepositorySystemConfig => _repositorySystemConfig ?? (_repositorySystemConfig = DbIoc.GetInstance<IRepositorySystemConfig>());

        public IVegunUpdaterDownloader Init()
        {
            return this;
        }

        public void UpdateUpdater(string localFolderPath, string serverFileName, bool isAsync)
        {

            string zipLocalPath = Path.Combine(Environment.CurrentDirectory, serverFileName);
            LoadUpdateInfo();
            if (CheckForInternetConnection())
            {
                DownloadUpdater(localFolderPath, ServerFolderName, serverFileName, zipLocalPath);
            }

        }

        public long GetFileSize(string url)
        {
            long result = 0;

            WebRequest req = WebRequest.Create(url);
            req.Method = "HEAD";
            using (WebResponse resp = req.GetResponse())
            {
                if (long.TryParse(resp.Headers.Get("Content-Length"), out long contentLength))
                {
                    result = contentLength;
                }
            }

            return result;
        }

        private void DownloadUpdater(string updaterLocalFolder, string serverFolderName, string updaterServerFileName, string zipLocalPath)
        {
            string address = this.HostAddress + $"/{serverFolderName }/{updaterServerFileName}";
            string fileName = Path.GetTempPath() + this.TempDir + $"\\{updaterServerFileName}";
            this.CreateTempDirectory();
            var remoteSize = GetFileSize(address);
            new WebClient().DownloadFile(address, fileName);
            if (File.Exists(fileName))
            {
                var fi = new FileInfo(fileName);
                var localSize = fi.Length;
                if(localSize == remoteSize)
                {
                    this.CopyFiles();
                    this.ExtractZipFile(updaterServerFileName, updaterLocalFolder);
                    if (File.Exists(zipLocalPath)) File.Delete(zipLocalPath);
                }
                else
                {
                    if (File.Exists(zipLocalPath)) File.Delete(zipLocalPath);
                }
            }
          
           
        }

        private void CreateTempDirectory()
        {
            string path = Path.GetTempPath() + this.TempDir;
            if (Directory.Exists(path))
                return;
            Directory.CreateDirectory(path);
        }

        private void CopyFiles()
        {
            string currentDirectory = Environment.CurrentDirectory;
            foreach (string file in Directory.GetFiles(Path.GetTempPath() + this.TempDir))
            {
                string fileName = Path.GetFileName(file);
                string destFileName = currentDirectory + "\\" + fileName;
                try
                {
                    File.Copy(file, destFileName, true);
                }
                catch(System.IO.IOException ex)
                {

                }
               
            }
        }

        private void LoadUpdateInfo()
        {
            TempDir = "VegunSoft_Temp" + DateTime.Now.ToString("HH_mm_ss");

            HostAddress = "http://" + RepositorySystemConfig.UpdateHost;

        }

        public bool CheckForInternetConnection()
        {

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    using (webClient.OpenRead(HostAddress))
                        return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void ExtractZipFile(string archiveFilenameIn, string outFolder)
        {
            string rootFolderName = Path.GetDirectoryName(outFolder);

            ZipFile zipFile = null;
            try
            {
                zipFile = new ZipFile(File.OpenRead(archiveFilenameIn));
                IEnumerator enumerator = zipFile.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        ZipEntry current = (ZipEntry)enumerator.Current;
                        if (current.IsFile)
                        {
                            string name = current.Name;
                            byte[] buffer = new byte[4096];
                            Stream inputStream = zipFile.GetInputStream(current);
                            string path = Path.Combine(outFolder, name);
                            string directoryName = Path.GetDirectoryName(path);
                            if (directoryName != null)
                            {
                                if (!directoryName.EndsWith(rootFolderName))
                                {
                                    if (directoryName.Length > 0) Directory.CreateDirectory(directoryName);
                                    if (!File.Exists(path))
                                    {
                                        using (FileStream fileStream = File.Create(path)) StreamUtils.Copy(inputStream, fileStream, buffer);
                                    }
                                    else
                                    {
                                        using (FileStream fileStream = new FileStream(path, FileMode.Create)) StreamUtils.Copy(inputStream, fileStream, buffer);
                                    }
                                }
                            }


                        }
                    }
                }
                finally
                {
                    IDisposable disposable = enumerator as IDisposable;
                    if (disposable != null)
                        disposable.Dispose();
                }
            }
            finally
            {
                if (zipFile != null)
                {
                    zipFile.IsStreamOwner = true;
                    zipFile.Close();
                }
            }
        }
    }
}
