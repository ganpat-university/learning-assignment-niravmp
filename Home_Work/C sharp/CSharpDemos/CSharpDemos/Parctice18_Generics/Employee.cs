using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Generics
{
    /// <summary>
    ///     Employee Class
    /// </summary>
    /// <remarks>
    ///     This class is used to demonstrate how generics can package a value type or reference type.
    /// </remarks>
    class Employee
    {
        /// <summary>
        ///     Gets or Sets the ID of the Employee
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        ///     Gets or Sets the Name of the Employee
        /// </summary>
        public string EmployeeName { get; set; }


        /// <summary>
        ///     Customized implemention of the ToString() method.
        ///     This is inherited from the System.Object base class, and overridden over here.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return String.Format("{0} {1}", this.EmployeeID, this.EmployeeName);
        }
    }
}
