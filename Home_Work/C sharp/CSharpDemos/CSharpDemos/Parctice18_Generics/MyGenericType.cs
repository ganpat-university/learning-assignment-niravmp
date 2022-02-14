using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Generics
{
    /// <summary>
    ///     My Generic Type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyGenericType<T>
    {

        /// <summary>
        ///     Gets or Sets the Value of the Generic Type
        /// </summary>
        public T Value { get; set; }


        /// <summary>
        ///     Displays the information of the object packaged in the Value Property of the Generic Class
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("Type: {0}", this.Value.GetType());
            Console.WriteLine("Value: {0}", this.Value.ToString());
            Console.WriteLine();
        }
    }
}
