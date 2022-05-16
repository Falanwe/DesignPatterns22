using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public class MyThreadSingleton
    {
        [ThreadStatic]
        private static int count;
        private MyThreadSingleton()
        {
            count++;
            if (count != 1)
            {
                throw new InvalidOperationException();
            }
        }

        [ThreadStatic]
        private static MyThreadSingleton _instance;
        public static MyThreadSingleton Instance
        {
            get
            {
                {
                    if (_instance == null)
                    {
                        _instance = new();
                    }
                    return _instance;
                }
            }
        }

        public void Blah()
        {
            Console.WriteLine("Blah!");
        }
    }
}
