using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    public class LazyClass
    {
        private int? _complicatedProperty;
        public int ComplicatedProperty
        {
            get
            {
                if (!_complicatedProperty.HasValue)
                {
                    lock (this)
                    {
                        if (!_complicatedProperty.HasValue)
                        {
                            _complicatedProperty = ComputeComplicatedThing();
                        }
                    }
                }
                return _complicatedProperty.GetValueOrDefault();
            }
        }

        private readonly Lazy<int> _complicatedPropertyByLazy;
        public int ComplicatedProPertyByLazy => _complicatedPropertyByLazy.Value;

        public LazyClass()
        {
            _complicatedPropertyByLazy = new Lazy<int>(ComputeComplicatedThing);
        }

        public int ComputeComplicatedThing()
        {
            Thread.Sleep(5000);
            return 42;
        }
    }
}
