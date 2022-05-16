using System;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    class Program
    {
        public static void Main()
        {
            MyThreadSingleton.Instance.Blah();
            MyThreadSingleton.Instance.Blah();
            MyThreadSingleton.Instance.Blah();
            MyThreadSingleton.Instance.Blah();

            Task.Run(() => MyThreadSingleton.Instance.Blah());
            Console.ReadLine();
        }
    }
}
