using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Induvidual_Task
{
    #region Classes
    class Searcher
    {
        private string pattern;
        private string directoryPath;
        private DirectoryInfo directory;
        private ManualResetEvent resetEvent;
        private ManualResetEvent startEvent;
        CancellationTokenSource cancelTokenSource;
        private long storageMemory;

        public string Pattern
        {
            get { return pattern; }
            set
            {
                if (Status == Status.Completed
                    || Status == Status.NotStarted
                    || Status == Status.Stopped)
                    pattern = value;
                else
                    throw new InvalidInputSearcherException();
            }
        }
        public string DirectoryPath
        {
            get { return directoryPath; }
            set
            {
                if (Status == Status.Completed
                    || Status == Status.NotStarted
                    || Status == Status.Stopped)
                    directoryPath = value;
                else
                    throw new InvalidInputSearcherException();
            }
        }
        public DirectoryInfo Directory
        {
            get { return directory; }
            set
            {
                if (Status == Status.Completed
                    || Status == Status.NotStarted
                    || Status == Status.Stopped)
                    directory = value;
                else
                    throw new InvalidInputSearcherException();
            }
        }
        public Status Status { get; private set; }
        public List<FileInfo> FilesFound { get; private set; }
        public double Progress { get; private set; }

        public delegate void CompletedHandle(object sender, CompletedEventArgs e);
        public delegate void SearchProgressHandle(object sender, SearchProgressEventArgs e);
        public delegate void FileFoundHandle(object sender, FileFoundEventArgs e);

        public event CompletedHandle Completed;
        public event SearchProgressHandle SearchProgress;
        public event FileFoundHandle FileFound;
        private Searcher()
        {
            Status = Status.NotStarted;
            resetEvent = new ManualResetEvent(true);
            startEvent = new ManualResetEvent(false);
        }

        public Searcher(string pattern, string directoryPath) : this()
        {
            Pattern = pattern;
            DirectoryPath = directoryPath;
        }

        public Searcher(string pattern, DirectoryInfo directory) : this()
        {
            Pattern = pattern;
            Directory = directory;
            DirectoryPath = Directory.FullName;
        }

        private Task GetMemoryAsync()
        {
            return Task.Run(() =>
           {
               MemoryConverter.GetMemoryOfDirectory(Directory, ref storageMemory);
               startEvent.Set();
           });
        }

        public Task Start()
        {
            if (Status == Status.Completed
                    || Status == Status.NotStarted
                    || Status == Status.Stopped)
            {
                Progress = 0;
                long total = 0;
                FilesFound = new List<FileInfo>();
                cancelTokenSource = new CancellationTokenSource();
                Directory = new DirectoryInfo(DirectoryPath);
                startEvent.Reset();
                GetMemoryAsync();
                Status = Status.Working;
                return Task.Run(() => { CheckDirectory(Directory, ref total); });
            }
            throw new InvalidStartSearcherExeption();
        }

        public void Resume()
        {
            if (Status == Status.Paused)
            {
                resetEvent.Set();
                Status = Status.Working;
            }
        }

        public void Pause()
        {
            if (Status == Status.Working)
            {
                resetEvent.Reset();
                Status = Status.Paused;
            }
        }

        public void Stop()
        {
            if (Status == Status.Working)
                cancelTokenSource.Cancel();
        }

        private void CheckDirectory(DirectoryInfo dir, ref long total)
        {
            try
            {
                startEvent.WaitOne();
                FileInfo[] files = dir.GetFiles();
                foreach (var file in files)
                {
                    if (file.Extension == ".txt")
                    {
                        total += file.Length;
                        if (storageMemory <= total)
                        {
                            Complete(Status.Completed);
                            return;
                        }
                        else if (cancelTokenSource.Token.IsCancellationRequested)
                        {
                            Complete(Status.Stopped);
                            return;
                        }
                        resetEvent.WaitOne();
                        Progress = ((double)total / storageMemory) * 100;
                        SearchProgress?.Invoke(this, new SearchProgressEventArgs(Progress));
                        Task.Run(() => { CheckFile(file); });
                    }
                }
                foreach (var d in dir.GetDirectories())
                {
                    CheckDirectory(d, ref total);
                }
            }
            catch { }
        }

        private void CheckFile(FileInfo file)
        {
            try
            {
                using (StreamReader streamReader = file.OpenText())
                {
                    string text = streamReader.ReadToEnd();
                    if (text.Contains(Pattern))
                    {
                        FileFound?.Invoke(this, new FileFoundEventArgs(file));
                        FilesFound.Add(file);
                    }
                }
            }
            catch { }
        }

        private void Complete(Status status)
        {
            if (Status != Status.Stopped && Status != Status.Completed)
            {
                Status = status;
                Progress = 100;
                SearchProgress?.Invoke(this, new SearchProgressEventArgs(Progress));
                Completed?.Invoke(this, new CompletedEventArgs(Status));
            }
        }
    }
    #endregion

    #region Enums
    public enum Status
    {
        NotStarted,
        Working,
        Stopped,
        Paused,
        Completed
    }
    #endregion

    #region EventArgs
    public class CompletedEventArgs : EventArgs
    {
        public Status Status { get; private set; }

        public CompletedEventArgs(Status status)
        {
            Status = status;
        }
    }
    public class SearchProgressEventArgs : EventArgs
    {
        public double Progress { get; private set; }

        public SearchProgressEventArgs(double progress)
        {
            Progress = progress;
        }
    }
    public class FileFoundEventArgs : EventArgs
    {
        public FileInfo File { get; private set; }

        public FileFoundEventArgs(FileInfo file)
        {
            File = file;
        }
    }
    #endregion

    #region Exceptions
    public class SearcherException : Exception
    {

    }
    public class InvalidInputSearcherException : SearcherException
    {

    }
    public class InvalidStartSearcherExeption : SearcherException
    {

    }
    #endregion
}
