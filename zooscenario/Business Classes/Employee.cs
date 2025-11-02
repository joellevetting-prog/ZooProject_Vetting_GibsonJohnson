using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class used to represent an employee.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Employee
    {
        /// <summary>
        /// The name of the employee.
        /// </summary>
        public string Name;

        /// <summary>
        /// The employee's identification number.
        /// </summary>
        public int Number;
    }
}