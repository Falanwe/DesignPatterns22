using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public static class DisposableSample
    {
        public static async Task RunAsync()
        {
            // await using var logger = new FileLogger("log.txt");

            FileLogger logger = null;
            try
            {
                logger = new FileLogger("log.txt");
                logger.Log("Hello World!");
                logger.Log("I'm writing in the log.");
            }
            finally
            {
                ValueTask? task = logger?.DisposeAsync();
                if (task.HasValue)
                {
                    await task.GetValueOrDefault();
                }
            }
        }        
    }
}
