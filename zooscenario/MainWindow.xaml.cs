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
            Zoo ComoZoo = new Zoo();

            // Set field values of the zoo.
            ComoZoo.Capacity = 1000;
            ComoZoo.Name = "Como Zoo";
            ComoZoo.LadiesRoom = new Restroom();
            ComoZoo.MensRoom = new Restroom();
            ComoZoo.TicketBooth = new Booth();
            
            // Set field values of the ladies' restroom.
            ComoZoo.LadiesRoom.Capacity = 4;
            ComoZoo.LadiesRoom.Gender = "Female";
            ComoZoo.LadiesRoom.IsOccupied = false;

            // Set field values of the men's restroom.
            ComoZoo.MensRoom.Capacity = 4;
            ComoZoo.MensRoom.Gender = "Male";
            ComoZoo.MensRoom.IsOccupied = true;

            // Set field values of the ticket booth.
            ComoZoo.TicketBooth.ItemCountSold = 236;
            ComoZoo.TicketBooth.ItemPrice = 15.00m;
            ComoZoo.TicketBooth.ItemType = "Ticket";
            ComoZoo.TicketBooth.MoneyBalance = 3640.25m;
            ComoZoo.TicketBooth.Attendant = new Employee();

            // Set field values of the ticket booth attendant.
            ComoZoo.TicketBooth.Attendant.Name = "Sam";
            ComoZoo.TicketBooth.Attendant.Number = 42;
        }

        private void assignment2132Button_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Zoo class.
            Zoo ComoZoo = new Zoo();

            // Set field values of the zoo.
            ComoZoo.Capacity = 1000;
            ComoZoo.Name = "Como Zoo";
            ComoZoo.MensRoom = new Restroom();
            ComoZoo.LadiesRoom = new Restroom();
            ComoZoo.TicketBooth = new Booth();
            ComoZoo.B168 = new BirthingRoom();
            ComoZoo.AnimalSnackMachine = new VendingMachine();

            // Set field values of the ladies' restroom.
            ComoZoo.LadiesRoom.Capacity = 4;
            ComoZoo.LadiesRoom.Gender = "Female";
            ComoZoo.LadiesRoom.IsOccupied = false;

            // Set field values of the men's restroom.
            ComoZoo.MensRoom.Capacity = 4;
            ComoZoo.MensRoom.Gender = "Male";
            ComoZoo.MensRoom.IsOccupied = true;

            // Set filed values for the animal snack machine
            ComoZoo.AnimalSnackMachine.MoneyBalance = 42.75m;

            // Set field values of the birthing room.
            ComoZoo.B168.Temperature = 77.00;

            // Set field values of the ticket booth.
            ComoZoo.TicketBooth.ItemCountSold = 236;
            ComoZoo.TicketBooth.ItemPrice = 15.00m;
            ComoZoo.TicketBooth.ItemType = "Ticket";
            ComoZoo.TicketBooth.MoneyBalance = 3640.25m;
            ComoZoo.TicketBooth.Attendant = new Employee();

            // Set field values of the ticket booth attendant.
            ComoZoo.TicketBooth.Attendant.Name = "Sam";
            ComoZoo.TicketBooth.Attendant.Number = 42;
        }
    }
}