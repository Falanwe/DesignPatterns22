using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public class MySingleton
    {
        private static int count;
        private MySingleton()
        {
            count++;
            if (count != 1)
            {
                throw new InvalidOperationException();
            }
        }

        public static MySingleton Instance { get; } = new ();

        public void Blah()
        {
            Console.WriteLine("Blah!");
        }
    }
}
