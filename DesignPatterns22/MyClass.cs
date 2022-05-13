using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns22
{
    /// <summary>
    /// An excellent class
    /// </summary>
    class MyClass
    {       
        /// <summary>
        /// The private float
        /// </summary>        
        private float _somePrivate;

        /// <summary>
        /// A magnificent property
        /// </summary>
        public int SomeProperty { get; set; }

        /// <summary>
        /// A sublime constructor
        /// </summary>
        public MyClass()
        {
        }

        /// <summary>
        /// Do something
        /// </summary>
        /// <param name="someArgument">Specifies how you do the thing</param>
        /// <returns>The right string</returns>
        public string SomeMethod(bool someArgument)
        {
            SomePrivateMethod('c');
            return "";
        }

        /// <summary>
        /// I don't care anymore...
        /// </summary>
        /// <param name="c">the character c</param>
        private void SomePrivateMethod(char c)
        {
        }
    }
}
