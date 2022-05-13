using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public class FileLogger : IDisposable, IAsyncDisposable
    {
        private StreamWriter _file;
        private bool disposedValue;

        public FileLogger(string path)
        {

            _file = new StreamWriter(File.OpenWrite(path));
        }

        public void Log(string entry)
        {
            _file.WriteLine(entry);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                _file.Dispose();

                disposedValue = true;
            }
        }

        ~FileLogger()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method²
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public async ValueTask DisposeAsync()
        {
            if (!disposedValue)
            {
                disposedValue = true;
                await _file.DisposeAsync();
                GC.SuppressFinalize(this);
            }
        }
    }
}
