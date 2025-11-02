using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class used to represent a ticket booth.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Booth
    {
        /// <summary>
        /// The booth attendant.
        /// </summary>
        public Employee Attendant;

        /// <summary>
        /// The number of items sold.
        /// </summary>
        public int ItemCountSold;

        /// <summary>
        /// The price of an individual item for sale.
        /// </summary>
        public decimal ItemPrice;

        /// <summary>
        /// The type of item for sale.
        /// </summary>
        public string ItemType;

        /// <summary>
        /// The amount of money currently in the ticket booth.
        /// </summary>
        public decimal MoneyBalance;
    }
}