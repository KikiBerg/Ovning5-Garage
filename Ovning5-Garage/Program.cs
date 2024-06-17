namespace Ovning5_Garage
{
    internal class Program
    {
        static void Main()
        {
            GarageHandler handler = new GarageHandler();
            UserInterface ui = new UserInterface();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Garage Simulation!");
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3, 4, 5, 6, 0) of your choice:");
                Console.WriteLine("1. List all parked vehicles");
                Console.WriteLine("2. List vehicle types and counts");
                Console.WriteLine("3. Add a vehicle to the garage");
                Console.WriteLine("4. Remove a vehicle from the garage");
                Console.WriteLine("5. Find a vehicle by registration number");
                Console.WriteLine("6. Search for vehicles by properties");
                Console.WriteLine("0. Exit the application");

                char input = ' ';
                try
                {
                    input = Console.ReadLine()![0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                    continue;
                }

                switch(input)
                {
                    case '1':
                        ui.ListAllParkedVehicles();
                        break;
                    case '2':
                        ui.ListVehicleTypesAndCounts();
                        break;
                    case '3':
                        ui.AddVehicle();
                        break;
                    case '4':
                        ui.RemoveVehicle();
                        break;
                    case '5':
                        ui.FindVehicleByRegistrationNumber();
                        break;
                    case '6':
                        ui.SearchVehiclesByProperties();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input (0, 1, 2, 3, 4, 5, 6)");
                        break;
                }

                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }
}
