using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class used to represent a zoo.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Zoo
    {
        /// <summary>
        /// The maximum number of guests the zoo can accommodate at a given time.
        /// </summary>
        public int Capacity;

        /// <summary>
        /// The ladies' restroom.
        /// </summary>
        public Restroom LadiesRoom;

        /// <summary>
        /// The men's restroom.
        /// </summary>
        public Restroom MensRoom;

        /// <summary>
        /// The name of the zoo.
        /// </summary>
        public string Name;

        /// <summary>
        /// The ticket booth.
        /// </summary>
        public Booth TicketBooth;
    }
}