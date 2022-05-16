using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public class MyLazySingleton
    {
        private static int _count;
        private static readonly Lazy<MyLazySingleton> _instance = new(() =>
        {
            var result = new MyLazySingleton();
            result.Init();
            return result;
        }, true);

        private MyLazySingleton()
        {
            _count++;
            if (_count != 1)
            {
                throw new InvalidOperationException();
            }
        }

        private void Init()
        {
        }

        public static MyLazySingleton Instance => _instance.Value;
    }
}
