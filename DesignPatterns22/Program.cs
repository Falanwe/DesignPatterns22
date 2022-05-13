using System;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    class Program
    {
        static async Task MainDisposable(string[] args)
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
                if(task.HasValue)
                {
                    await task.GetValueOrDefault();
                }
            }
        }

        public static void Main()
        {
            Console.ReadLine();
            var lazy = new LazyClass();
            Console.WriteLine("Accessing the property.");
            Console.WriteLine(lazy.ComplicatedProPertyByLazy);
            Console.WriteLine("Accessing the property again.");
            Console.WriteLine(lazy.ComplicatedProPertyByLazy);
        }
    }
}
