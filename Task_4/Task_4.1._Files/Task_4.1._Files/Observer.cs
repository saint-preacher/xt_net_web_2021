using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace Task_4._1._Files
{
    class Observer
    {
        private FileSystemWatcher fsw;
        private IEnumerable<FileInfo> files;
        private DirectoryInfo di;
        private string backupDirName;
        private List<string> fileNames;

        public Observer(DirectoryInfo di, string backupDirName)
        {
            this.backupDirName = backupDirName;
            this.di = di;
            files = getFiles();
            fileNames = getFileNames(files);

            fsw = new FileSystemWatcher(di.FullName);

            fsw.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastWrite;

            fsw.Changed += new FileSystemEventHandler(OnChanged);

            fsw.Error += new ErrorEventHandler(OnError);

            fsw.InternalBufferSize = 64 * 1024;

            fsw.IncludeSubdirectories = true;

            MakeSnapshot();
        }

        public void Start()
        {
            fsw.EnableRaisingEvents = true;
        }

        public void Stop()
        {
            fsw.EnableRaisingEvents = false;
        }

        public static IEnumerable<FileInfo> getFiles(string backupDirName, DirectoryInfo di)
        {
            string searchPattern = "*.txt";

            var regex = new Regex(@"^" + di.FullName.Replace(@"\", @"\\") + @"\\" + backupDirName.Replace(@".", @"\.") + @".*");
            var result = di.EnumerateFiles(searchPattern, SearchOption.AllDirectories).Where(s => !regex.IsMatch(s.FullName));

            return result;
        }

        private IEnumerable<FileInfo> getFiles()
        {
            return getFiles(backupDirName, di);
        }

        private List<string> getFileNames(IEnumerable<FileInfo> files)
        {
            var temp = new List<string> { };

            foreach (var e in files)
            {
                temp.Add(e.FullName);
            }

            return temp;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {

            System.Timers.Timer t = new System.Timers.Timer();

            try
            {
                fsw.EnableRaisingEvents = false;
                fsw.Changed -= new FileSystemEventHandler(OnChanged);

                t.Interval = 500;
                t.Elapsed += (sender, args) => t_Elapsed(sender, e);
                t.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void t_Elapsed(object sender, FileSystemEventArgs e)
        {
            ((System.Timers.Timer)sender).Stop();
            ServeChange(e);
            fsw.Changed += new FileSystemEventHandler(OnChanged);
            fsw.EnableRaisingEvents = true;

        }
        private void ServeChange(FileSystemEventArgs e)
        {
            var tempFiles = getFiles();
            var tempFileNames = getFileNames(tempFiles);

            if (Regex.IsMatch(e.FullPath, @"^" + di.FullName.Replace(@"\", @"\\") + @"\\" + backupDirName.Replace(@".", @"\.") + @".*"))
            {
                return;
            }

            if (!Directory.Exists(e.FullPath) && !File.Exists(e.FullPath))
            {
                Console.WriteLine("Making snapshot...");
                MakeSnapshot();
                Console.WriteLine("Snapshot taken.");

                files = tempFiles;
                fileNames = tempFileNames;
                return;
            }
            if (File.GetAttributes(e.FullPath).HasFlag(FileAttributes.Directory))
            {
                if (tempFileNames.SequenceEqual(fileNames))
                {
                    Console.WriteLine("Folder \"" + e.FullPath + "\" changed, observong files stay the same.");
                }
                else
                {
                    Console.WriteLine("Making snapshot...");
                    MakeSnapshot();
                    Console.WriteLine("Snapshot taken.");

                    files = tempFiles;
                    fileNames = tempFileNames;
                }
            }
            else
            {
                Console.WriteLine("Making snapshot...");
                MakeSnapshot();
                Console.WriteLine("Snapshot taken.");

                files = tempFiles;
                fileNames = tempFileNames;

            }
            return;
        }
        private void MakeSnapshot()
        {
            string basePath = di.FullName;
            files.ToList().ForEach(s =>
            {
                var filePath = s.FullName;

                var Date = DateTime.Now;

                var Time = Date.ToString("yyyy_MM_dd__HH_mm_ss");

                var baseAndBackup = basePath + "\\" + backupDirName;

                var newFileName = baseAndBackup + "\\" + Time + "\\" + filePath.Substring(basePath.Length + 1);

                try
                {
                    Directory.CreateDirectory(new FileInfo(newFileName).DirectoryName);
                    s.CopyTo(newFileName);
                }
                catch
                {
                }
            });

        }
        private void OnError(object source, ErrorEventArgs e)
        {
            Console.WriteLine("The FileSystemWatcher has detected an error");
            if (e.GetException().GetType() == typeof(InternalBufferOverflowException))
            {
                Console.WriteLine(("The file system watcher experienced an internal buffer overflow: " + e.GetException().Message));
            }
        }
    }
}
