using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public static class FactorySample
    {
        public static void Run()
        {
            Func<MyClass> factory;
            for (var level = 1; level < 5; level++)
            {
                Console.WriteLine($"entering level {level}");
                Console.ReadLine();
                var currentLevel = level;
                factory = () =>
                {
                    var result = new MyClass();
                    result.Init(currentLevel);
                    return result;
                };
                Console.WriteLine("using factory twice");
                var mc1 = factory();
                var mc2 = factory();
            }
        }
    }
}
