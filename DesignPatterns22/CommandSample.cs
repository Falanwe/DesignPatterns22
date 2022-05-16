using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public static class CommandSample
    {
        private static Action command1;
        private static Action command2;
        private static Action command3;
        private static Action command4;

        public static void Run()
        {
            command1 = () => Console.WriteLine("Blah!");
            command2 = () => Console.WriteLine("Bloh!");
            command3 = () => Console.WriteLine("Blih!");
            command4 = () => Console.WriteLine("Bluh!");


            while (Update())
            {
            }
        }

        private static bool Update()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.A:
                    {
                        Console.WriteLine();
                        command1();
                        break;
                    }
                case ConsoleKey.Z:
                    {
                        Console.WriteLine();
                        command2();
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        Console.WriteLine();
                        command3();
                        break;
                    }
                case ConsoleKey.S:
                    {
                        Console.WriteLine();
                        command4();
                        break;
                    }
                case ConsoleKey.R:
                    {
                        Console.WriteLine();
                        Console.WriteLine("rebinding...");
                        var temp = command1;
                        command1 = command2;
                        command2 = command3;
                        command3 = command4;
                        command4 = temp;
                        break;
                    }
                case ConsoleKey.C:
                    {
                        return false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine();
                        Console.WriteLine("unknown key...");
                        break;
                    }
            }
            return true;
        }
    }
}
