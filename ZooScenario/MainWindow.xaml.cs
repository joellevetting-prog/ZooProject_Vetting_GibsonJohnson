using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZooScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Performs the tasks outlined in assignment 1.2.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void assignment12Button_Click(object sender, RoutedEventArgs e)
        {
            
            // Create an instance of the Zoo class.
            Zoo comoZoo = new Zoo();

            // Set field values of the zoo.
            comoZoo.Capacity = 1000;
            comoZoo.Name = "Como Zoo";
            comoZoo.LadiesRoom = new Restroom();
            comoZoo.MensRoom = new Restroom();
            comoZoo.TicketBooth = new Booth();

            // Set field values of the ladies' restroom.
            comoZoo.LadiesRoom.Capacity = 4;
            comoZoo.LadiesRoom.Gender = "Female";
            comoZoo.LadiesRoom.IsOccupied = false;

            // Set field values of the men's restroom.
            comoZoo.MensRoom.Capacity = 4;
            comoZoo.MensRoom.Gender = "Male";
            comoZoo.MensRoom.IsOccupied = true;

            // Set field values of the ticket booth.
            comoZoo.TicketBooth.ItemCountSold = 236;
            comoZoo.TicketBooth.ItemPrice = 15.00m;
            comoZoo.TicketBooth.ItemType = "Ticket";
            comoZoo.TicketBooth.MoneyBalance = 3640.25m;
            comoZoo.TicketBooth.Attendant = new Employee();

            // Set field values of the ticket booth attendant.
            comoZoo.TicketBooth.Attendant.Name = "Sam";
            comoZoo.TicketBooth.Attendant.Number = 42;
        }
    }
}